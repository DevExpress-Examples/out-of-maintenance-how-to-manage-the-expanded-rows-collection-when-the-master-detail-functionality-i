Namespace DxExample
	Partial Public Class CategoryView
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.productGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.categoryGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.mvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.buttonDelete = New DevExpress.XtraEditors.SimpleButton()
			Me.categoryIdEdit = New DevExpress.XtraEditors.TextEdit()
			Me.buttonCollapse = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonExpand = New DevExpress.XtraEditors.SimpleButton()
			Me.countLabelControl = New DevExpress.XtraEditors.LabelControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.dataSourceRowIndexItem = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			DirectCast(Me.productGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.categoryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.mvvmContext1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			DirectCast(Me.categoryIdEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dataSourceRowIndexItem, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' productGridView
			' 
			Me.productGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductName, Me.colUnitPrice, Me.colCategoryID})
			Me.productGridView.GridControl = Me.gridControl1
			Me.productGridView.Name = "productGridView"
			' 
			' colProductName
			' 
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 0
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 1
			' 
			' colCategoryID
			' 
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 2
			' 
			' gridControl1
			' 
			gridLevelNode1.LevelTemplate = Me.productGridView
			gridLevelNode1.RelationName = "Products"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(12, 141)
			Me.gridControl1.MainView = Me.categoryGridView
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(664, 428)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.categoryGridView, Me.productGridView})
			' 
			' categoryGridView
			' 
			Me.categoryGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colCategoryName, Me.colDescription})
			Me.categoryGridView.GridControl = Me.gridControl1
			Me.categoryGridView.Name = "categoryGridView"
			' 
			' colID
			' 
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 2
			' 
			' mvvmContext1
			' 
			Me.mvvmContext1.ContainerControl = Me
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.buttonDelete)
			Me.layoutControl1.Controls.Add(Me.categoryIdEdit)
			Me.layoutControl1.Controls.Add(Me.buttonCollapse)
			Me.layoutControl1.Controls.Add(Me.buttonExpand)
			Me.layoutControl1.Controls.Add(Me.countLabelControl)
			Me.layoutControl1.Controls.Add(Me.gridControl1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(688, 581)
			Me.layoutControl1.TabIndex = 1
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' buttonDelete
			' 
			Me.buttonDelete.Location = New System.Drawing.Point(519, 43)
			Me.buttonDelete.Name = "buttonDelete"
			Me.buttonDelete.Size = New System.Drawing.Size(145, 22)
			Me.buttonDelete.StyleController = Me.layoutControl1
			Me.buttonDelete.TabIndex = 7
			Me.buttonDelete.Text = "DeleteMasterRow"
			' 
			' entityIdEdit
			' 
			Me.categoryIdEdit.EditValue = "1"
			Me.categoryIdEdit.Location = New System.Drawing.Point(85, 43)
			Me.categoryIdEdit.Name = "entityIdEdit"
			Me.categoryIdEdit.Properties.Mask.EditMask = "n0"
			Me.categoryIdEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.categoryIdEdit.Size = New System.Drawing.Size(142, 20)
			Me.categoryIdEdit.StyleController = Me.layoutControl1
			Me.categoryIdEdit.TabIndex = 6
			' 
			' buttonCollapse
			' 
			Me.buttonCollapse.Location = New System.Drawing.Point(370, 43)
			Me.buttonCollapse.Name = "buttonCollapse"
			Me.buttonCollapse.Size = New System.Drawing.Size(145, 22)
			Me.buttonCollapse.StyleController = Me.layoutControl1
			Me.buttonCollapse.TabIndex = 5
			Me.buttonCollapse.Text = "CollapseMasterRow"
			' 
			' buttonExpand
			' 
			Me.buttonExpand.Location = New System.Drawing.Point(231, 43)
			Me.buttonExpand.Name = "buttonExpand"
			Me.buttonExpand.Size = New System.Drawing.Size(135, 22)
			Me.buttonExpand.StyleController = Me.layoutControl1
			Me.buttonExpand.TabIndex = 4
			Me.buttonExpand.Text = "ExpandMasterRow"
			' 
			' countLabelControl
			' 
			Me.countLabelControl.Location = New System.Drawing.Point(145, 112)
			Me.countLabelControl.Name = "countLabelControl"
			Me.countLabelControl.Size = New System.Drawing.Size(63, 13)
			Me.countLabelControl.StyleController = Me.layoutControl1
			Me.countLabelControl.TabIndex = 3
			Me.countLabelControl.Text = "labelControl1"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.layoutControlItem1, Me.layoutControlGroup3})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(688, 581)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 69)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(668, 60)
			Me.layoutControlGroup2.Text = "Info"
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.countLabelControl
			Me.layoutControlItem2.CustomizationFormText = "Expanded details count:"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(644, 17)
			Me.layoutControlItem2.Text = "Expanded details count:"
			Me.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(116, 13)
			Me.layoutControlItem2.TextToControlDistance = 5
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.gridControl1
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 129)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(668, 432)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.dataSourceRowIndexItem, Me.layoutControlItem4, Me.layoutControlItem3, Me.layoutControlItem5})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Size = New System.Drawing.Size(668, 69)
			Me.layoutControlGroup3.Text = "Commands"
			' 
			' dataSourceRowIndexItem
			' 
			Me.dataSourceRowIndexItem.Control = Me.categoryIdEdit
			Me.dataSourceRowIndexItem.Location = New System.Drawing.Point(0, 0)
			Me.dataSourceRowIndexItem.Name = "dataSourceRowIndexItem"
			Me.dataSourceRowIndexItem.Size = New System.Drawing.Size(207, 26)
			Me.dataSourceRowIndexItem.Text = "CategoryID"
			Me.dataSourceRowIndexItem.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
			Me.dataSourceRowIndexItem.TextSize = New System.Drawing.Size(56, 13)
			Me.dataSourceRowIndexItem.TextToControlDistance = 5
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.buttonCollapse
			Me.layoutControlItem4.Location = New System.Drawing.Point(346, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(149, 26)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.buttonExpand
			Me.layoutControlItem3.Location = New System.Drawing.Point(207, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(139, 26)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.buttonDelete
			Me.layoutControlItem5.Location = New System.Drawing.Point(495, 0)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(149, 26)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextVisible = False
			' 
			' CategoryView
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "CategoryView"
			Me.Size = New System.Drawing.Size(688, 581)
			DirectCast(Me.productGridView, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.categoryGridView, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.mvvmContext1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			DirectCast(Me.categoryIdEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dataSourceRowIndexItem, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private categoryGridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
		Private productGridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private mvvmContext1 As DevExpress.Utils.MVVM.MVVMContext
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private countLabelControl As DevExpress.XtraEditors.LabelControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private buttonExpand As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private buttonCollapse As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private categoryIdEdit As DevExpress.XtraEditors.TextEdit
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private dataSourceRowIndexItem As DevExpress.XtraLayout.LayoutControlItem
		Private buttonDelete As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace
