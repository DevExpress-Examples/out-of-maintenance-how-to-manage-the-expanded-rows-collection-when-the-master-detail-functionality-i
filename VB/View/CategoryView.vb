Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.ObjectModel
Imports System.Collections.Specialized

Namespace DxExample
	Partial Public Class CategoryView
		Inherits UserControl

		Public Sub New()
			InitializeComponent()

			mvvmContext1.ViewModelType = GetType(CategoryViewModel)
			Dim fluentAPI = mvvmContext1.OfType(Of CategoryViewModel)()

			Dim expandedMasterRowsManager As New ExpandedMasterRowsManager(categoryGridView)

			fluentAPI.SetBinding(gridControl1, Function(grid) grid.DataSource, Function(x) x.Categories)

			fluentAPI.SetBinding(expandedMasterRowsManager, Function(x) x.ExpandedMasterRowsCollection, Function(y) y.ExpandedEntitiesCollection)
			fluentAPI.SetBinding(countLabelControl, Function(x) x.Text, Function(y) y.ExpandedEntitiesCount)

            fluentAPI.WithEvent(Of CustomMasterRowEventArgs)(categoryGridView, "MasterRowExpanded").EventToCommand(Sub(x) x.Update(Nothing), Function(ea) expandedMasterRowsManager.GetCategoryID(ea.RowHandle))
            fluentAPI.WithEvent(Of CustomMasterRowEventArgs)(categoryGridView, "MasterRowCollapsed").EventToCommand(Sub(x) x.Update(Nothing), Function(ea) expandedMasterRowsManager.GetCategoryID(ea.RowHandle))
            fluentAPI.WithEvent(categoryGridView, "DataSourceChanged").EventToCommand(Sub(x) x.UpdateDataBindings())

            fluentAPI.WithEvent(categoryIdEdit, "EditValueChanged").EventToCommand(Sub(x) x.UpdateCommands(GetCategoryIDFromEditor()))

            fluentAPI.BindCommand(buttonExpand, Sub(x) x.ExpandEntity(Nothing), Function(x) GetCategoryIDFromEditor())
            fluentAPI.BindCommand(buttonCollapse, Sub(x) x.CollapseEntity(Nothing), Function(x) GetCategoryIDFromEditor())
            fluentAPI.BindCommand(buttonDelete, Sub(x) x.DeleteEntity(Nothing), Function(x) GetCategoryIDFromEditor())
		End Sub

		Private Function GetCategoryIDFromEditor() As Integer
			Return Convert.ToInt32(categoryIdEdit.EditValue)
		End Function

		Private Class ExpandedMasterRowsManager
			Implements IDisposable

			Public Sub New(ByVal _view As GridView)
				view = _view
				SubscribeViewEvents(True)
			End Sub

			Private view As GridView
			Private _expandedMasterRowsCollection As ObservableCollection(Of Object)
			Private ReadOnly Property viewIsNull() As Boolean
				Get
					Return view Is Nothing
				End Get
			End Property
			Private Property lockExpandedMasterRowsCollectionChanged() As Boolean
			Private lockMasterRowExpanded As Boolean = False

			Public Property ExpandedMasterRowsCollection() As ObservableCollection(Of Object)
				Get
					Return _expandedMasterRowsCollection
				End Get
				Set(ByVal value As ObservableCollection(Of Object))
					If _expandedMasterRowsCollection Is value Then
						Return
					End If
					SubscribeCollectionChangedEvent(False)
					_expandedMasterRowsCollection = value
					SubscribeCollectionChangedEvent(True)
				End Set
			End Property

			Private Sub SubscribeCollectionChangedEvent(ByVal subscribe As Boolean)
				If _expandedMasterRowsCollection Is Nothing Then
					Return
				End If
				If subscribe Then
					AddHandler _expandedMasterRowsCollection.CollectionChanged, AddressOf ExpandedMasterRowsCollectionChanged
				Else
					RemoveHandler _expandedMasterRowsCollection.CollectionChanged, AddressOf ExpandedMasterRowsCollectionChanged
				End If
			End Sub

			Private Sub SubscribeViewEvents(ByVal subscribe As Boolean)
				If viewIsNull Then
					Return
				End If
				If subscribe Then
					AddHandler view.Disposed, AddressOf view_Disposed
					AddHandler view.MasterRowExpanded, AddressOf view_MasterRowExpanded
					AddHandler view.MasterRowCollapsed, AddressOf view_MasterRowCollapsed
					AddHandler view.DataSourceChanged, AddressOf view_DataSourceChanged
				Else
					RemoveHandler view.Disposed, AddressOf view_Disposed
					RemoveHandler view.MasterRowExpanded, AddressOf view_MasterRowExpanded
					RemoveHandler view.MasterRowCollapsed, AddressOf view_MasterRowCollapsed
					RemoveHandler view.DataSourceChanged, AddressOf view_DataSourceChanged
					view = Nothing
				End If
			End Sub

			Private Sub view_DataSourceChanged(ByVal sender As Object, ByVal e As EventArgs)
				lockExpandedMasterRowsCollectionChanged = True
				_expandedMasterRowsCollection.Clear()
				lockExpandedMasterRowsCollectionChanged = False
			End Sub

			Private Sub view_Disposed(ByVal sender As Object, ByVal e As EventArgs)
				SubscribeViewEvents(False)
			End Sub

			Private Sub view_MasterRowCollapsed(ByVal sender As Object, ByVal e As CustomMasterRowEventArgs)
				MasterRowExpanded(False, GetCategoryID(e.RowHandle))
			End Sub

			Private Sub view_MasterRowExpanded(ByVal sender As Object, ByVal e As CustomMasterRowEventArgs)
				MasterRowExpanded(True, GetCategoryID(e.RowHandle))
			End Sub

			Public Function GetCategoryID(ByVal rowHandle As Integer) As Integer
				Return (TryCast(view.GetRow(rowHandle), Category)).ID
			End Function

			Private Sub MasterRowExpanded(ByVal expanded As Boolean, ByVal categoryID As Integer)
				If lockMasterRowExpanded Then
					Return
				End If
				lockExpandedMasterRowsCollectionChanged = True
				If expanded Then
					_expandedMasterRowsCollection.Add(categoryID)
				Else
					_expandedMasterRowsCollection.Remove(categoryID)
				End If
				lockExpandedMasterRowsCollectionChanged = False
			End Sub

			Private Sub ExpandedMasterRowsCollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
				If lockExpandedMasterRowsCollectionChanged OrElse viewIsNull Then
					Return
				End If
				lockMasterRowExpanded = True
				Select Case e.Action
					Case NotifyCollectionChangedAction.Add
						For Each categoryID As Integer In e.NewItems
							ExpandMasterRow(categoryID)
						Next categoryID
					Case NotifyCollectionChangedAction.Remove
						For Each categoryID As Integer In e.OldItems
							CollapseMasterRow(categoryID)
						Next categoryID
					Case NotifyCollectionChangedAction.Reset
						CollapseAllMasterRows()
				End Select
				lockMasterRowExpanded = False
			End Sub

			Private Sub ExpandMasterRow(ByVal categoryID As Integer)
				view.ExpandMasterRow(GetRowHandle(categoryID))
			End Sub

			Private Sub CollapseMasterRow(ByVal categoryID As Integer)
				view.CollapseMasterRow(GetRowHandle(categoryID))
			End Sub

			Private Sub CollapseAllMasterRows()
				view.CollapseAllDetails()
			End Sub

			Private Function GetRowHandle(ByVal categoryID As Integer) As Integer
				Return view.LocateByValue("ID", categoryID, Nothing)
			End Function

			Public Sub Dispose() Implements IDisposable.Dispose
				SubscribeViewEvents(False)
				SubscribeCollectionChangedEvent(False)
			End Sub
		End Class
	End Class
End Namespace
