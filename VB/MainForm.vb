Namespace DxExample
    Partial Public Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            Dim categoryView As CategoryView = New CategoryView With {.Dock = DockStyle.Fill, .Parent = Me}
        End Sub
    End Class
End Namespace
