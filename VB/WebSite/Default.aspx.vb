Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Linq

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub cbCars_ItemRequestedByValue(ByVal source As Object, ByVal e As DevExpress.Web.ASPxEditors.ListEditItemRequestedByValueEventArgs)
		If e.Value IsNot Nothing AndAlso TypeOf e.Value Is Integer Then
			Dim data = MyDataSource.GetData(cbLocation.Text)
			Dim query = _
				From r In data _
				Where r.Value = CInt(Fix(e.Value)) _
				Select r
			cbCars.DataSource = query
			cbCars.DataBind()
		End If
	End Sub
	Protected Sub cbCars_ItemsRequestedByFilterCondition(ByVal source As Object, ByVal e As DevExpress.Web.ASPxEditors.ListEditItemsRequestedByFilterConditionEventArgs)
		Dim data = MyDataSource.GetData(cbLocation.Text)
		Dim query = _
			From r In data _
			Where r.Text.StartsWith(e.Filter) _
			Select r
		cbCars.DataSource = query.Skip(e.BeginIndex).Take(e.EndIndex - e.BeginIndex + 1)
		cbCars.DataBind()
	End Sub
End Class
Public NotInheritable Class MyDataSource
	Public Class MyDataSourceItem
		Private privateValue As Integer
		Public Property Value() As Integer
			Get
				Return privateValue
			End Get
			Set(ByVal value As Integer)
				privateValue = value
			End Set
		End Property
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
	End Class
	Private Sub New()
	End Sub
	Public Shared Function GetData(ByVal location As String) As IQueryable(Of MyDataSourceItem)
		Dim ds As New List(Of MyDataSourceItem)()
		For i As Integer = 0 To 99
			ds.Add(New MyDataSourceItem() With {.Text = String.Format("Car#{0} for {1}", i, location), .Value = i})
		Next i
		Return ds.AsQueryable()
	End Function
End Class