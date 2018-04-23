Imports System.ComponentModel

Namespace DxExample

	Public NotInheritable Class DataHelper

		Private Sub New()
		End Sub

		Public Shared Function GetData() As BindingList(Of Category)
			Dim categoryBindingList As New BindingList(Of Category)()
			InitData(categoryBindingList)
			Return categoryBindingList
		End Function

		Private Shared Sub InitData(ByVal categoryBindingList As BindingList(Of Category))
			categoryBindingList.Add(New Category() With {
				.ID = 1, .CategoryName = "Beverages", .Description = "Soft drinks, coffees, teas, beers, and ales", .Products = New BindingList(Of Product) From {
					New Product() With {.ProductName = "Guaraná Fantástica", .CategoryID = 1, .UnitPrice = 4.5D}
				}
			})
			categoryBindingList.Add(New Category() With {
				.ID = 2, .CategoryName = "Condiments", .Description = "Sweet and savory sauces, relishes, spreads, and seasonings", .Products = New BindingList(Of Product) From {
					New Product() With {.ProductName = "Sir Corey's Scones", .CategoryID = 2, .UnitPrice = 110},
					New Product() With {.ProductName = "Sir Joes's Scones", .CategoryID = 2, .UnitPrice = 231.23D},
					New Product() With {.ProductName = "Amanda's Scones", .CategoryID = 2, .UnitPrice = 31.23D}
				}
			})
			categoryBindingList.Add(New Category() With {
				.ID = 3, .CategoryName = "Confections", .Description = "Desserts, candies, and sweet breads", .Products = New BindingList(Of Product) From {
					New Product() With {.ProductName = "Sir Rodney's Scones", .CategoryID = 3, .UnitPrice = 10},
					New Product() With {.ProductName = "Gumbär Gummibärchen", .CategoryID = 3, .UnitPrice = 31.23D},
					New Product() With {.ProductName = "NuNuCa Nuß-Nougat-Creme", .CategoryID = 3, .UnitPrice = 14},
					New Product() With {.ProductName = "Gumbär", .CategoryID = 3, .UnitPrice = 331.23D},
					New Product() With {.ProductName = "Gummibärchen", .CategoryID = 3, .UnitPrice = 321.23D}
				}
			})
			categoryBindingList.Add(New Category() With {
				.ID = 4, .CategoryName = "Dairy Products", .Description = "Cheeses", .Products = New BindingList(Of Product) From {
					New Product() With {.ProductName = "Gorgonzola Telino", .CategoryID = 4, .UnitPrice = 12.5D},
					New Product() With {.ProductName = "Gorgonzola", .CategoryID = 4, .UnitPrice = 112.5D},
					New Product() With {.ProductName = "Telino", .CategoryID = 4, .UnitPrice = 122.5D}
				}
			})
			categoryBindingList.Add(New Category() With {
				.ID = 5, .CategoryName = "Grains/Cereals", .Description = "Breads, crackers, pasta, and cereal", .Products = New BindingList(Of Product) From {
					New Product() With {.ProductName = "Tunnbröd", .CategoryID = 5, .UnitPrice = 9},
					New Product() With {.ProductName = "Gustaf's Knäckebröd", .CategoryID = 5, .UnitPrice = 21},
					New Product() With {.ProductName = "Knäckebröd", .CategoryID = 5, .UnitPrice = 221}
				}
			})
			categoryBindingList.Add(New Category() With {
				.ID = 6, .CategoryName = "Meat/Poultry", .Description = "Prepared meats", .Products = New BindingList(Of Product) From {
					New Product() With {.ProductName = "Thüringer Rostbratwurst", .CategoryID = 6, .UnitPrice = 123.79D},
					New Product() With {.ProductName = "Thüringer", .CategoryID = 6, .UnitPrice = 223.79D},
					New Product() With {.ProductName = "Rostbratwurst", .CategoryID = 6, .UnitPrice = 133.79D}
				}
			})
			categoryBindingList.Add(New Category() With {
				.ID = 7, .CategoryName = "Produce", .Description = "Dried fruit and bean curd", .Products = New BindingList(Of Product) From {
					New Product() With {.ProductName = "Rössle Sauerkraut", .CategoryID = 7, .UnitPrice = 45.6D},
					New Product() With {.ProductName = "Rössle", .CategoryID = 7, .UnitPrice = 55.6D},
					New Product() With {.ProductName = "Sauerkraut", .CategoryID = 7, .UnitPrice = 35.6D}
				}
			})
			categoryBindingList.Add(New Category() With {
				.ID = 8, .CategoryName = "Seafood", .Description = "Seaweed and fish", .Products = New BindingList(Of Product) From {
					New Product() With {.ProductName = "Nord-Ost Matjeshering", .CategoryID = 8, .UnitPrice = 25.89D},
					New Product() With {.ProductName = "Nord-Ost", .CategoryID = 8, .UnitPrice = 23.89D},
					New Product() With {.ProductName = "Nord Matjeshering", .CategoryID = 8, .UnitPrice = 29.89D}
				}
			})
		End Sub
	End Class
End Namespace
