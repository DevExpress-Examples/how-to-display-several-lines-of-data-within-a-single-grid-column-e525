Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Namespace TwoLinesInCell
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.DataSource = GetDataTable()
			ASPxGridView1.DataBind()
		End Sub

		Private Function GetDataTable() As Object
			Dim table As New DataTable()
			table.Columns.Add("Subject")
			table.Columns.Add("From")
			table.Rows.Add("Your order", "John Doe")
			table.Rows.Add("Canadian pharmacy", "Miss Piggy")
			Return table
		End Function

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace
