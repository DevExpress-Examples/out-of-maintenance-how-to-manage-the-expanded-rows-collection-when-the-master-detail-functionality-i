Imports System.ComponentModel

Namespace DxExample
	Public Class Category
		Public Property ID() As Integer
		Public Property CategoryName() As String
		Public Property Description() As String
		Public Property Products() As BindingList(Of Product)
	End Class
End Namespace
