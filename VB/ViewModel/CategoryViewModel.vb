Imports DevExpress.Mvvm.POCO
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace DxExample
	Public Class CategoryViewModel
		Public Sub New()
			ExpandedEntitiesCollection = New ObservableCollection(Of Object)()
		End Sub

        Private _categories As BindingList(Of Category)
        Public Property ExpandedEntitiesCollection() As ObservableCollection(Of Object)
        Public ReadOnly Property ExpandedEntitiesCount() As Integer
            Get
                Return ExpandedEntitiesCollection.Count
            End Get
        End Property


        Public Property Categories() As BindingList(Of Category)
            Get
                If _categories Is Nothing Then
     _categories = DataHelper.GetData()
                End If
                Return _categories
            End Get
            Set(ByVal value As BindingList(Of Category))
    _categories = value
            End Set
        End Property

		Public Sub Update(ByVal entityID As Object)
			UpdateDataBindings()
			UpdateCommands(entityID)
		End Sub

		Public Sub UpdateDataBindings()
			Me.RaisePropertyChanged(Function(x) x.ExpandedEntitiesCount)
		End Sub

		Public Sub UpdateCommands(ByVal categoryID As Object)
            Me.RaiseCanExecuteChanged(Sub(x) x.CollapseEntity(categoryID))
            Me.RaiseCanExecuteChanged(Sub(x) x.DeleteEntity(categoryID))
            Me.RaiseCanExecuteChanged(Sub(x) x.ExpandEntity(categoryID))
		End Sub

		Public Sub DeleteEntity(ByVal categoryID As Object)
			CollapseEntity(categoryID)
			Categories.Remove(FindEntity(categoryID))
			Update(categoryID)
		End Sub

		Public Sub ExpandEntity(ByVal categoryID As Object)
			ExpandedEntitiesCollection.Add(categoryID)
			Update(categoryID)
		End Sub

		Public Sub CollapseEntity(ByVal categoryID As Object)
			ExpandedEntitiesCollection.Remove(categoryID)
			Update(categoryID)
		End Sub

		Public Function CanDeleteEntity(ByVal categoryID As Object) As Boolean
			Return EntityExists(categoryID)
		End Function

		Public Function CanCollapseEntity(ByVal categoryID As Object) As Boolean
			Return EntityExists(categoryID) AndAlso ExpandedEntitiesCollection.Contains(categoryID)
		End Function

		Public Function CanExpandEntity(ByVal categoryID As Object) As Boolean
			Return EntityExists(categoryID) AndAlso Not ExpandedEntitiesCollection.Contains(categoryID)
		End Function

		Private Function EntityExists(ByVal categoryID As Object) As Boolean
			Return FindEntity(categoryID) IsNot Nothing
		End Function

		Private Function FindEntity(ByVal categoryID As Object) As Category
			Return Categories.FirstOrDefault(Function(entity) entity.ID = Convert.ToInt32(categoryID))
		End Function
	End Class
End Namespace
