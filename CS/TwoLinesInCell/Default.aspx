<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TwoLinesInCell._Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <dxwgv:GridViewDataTextColumn Caption="Subject / From" Name="colSubFrom" VisibleIndex="0">
                    <DataItemTemplate>
                        <dxe:ASPxLabel ID="ASPxLabel1" runat="server" Text='<%# Eval("Subject") %>' Font-Bold="True">
                        </dxe:ASPxLabel>
                        <br />
                        <dxe:ASPxLabel ID="ASPxLabel2" runat="server" Text='<%# Eval("From") %>' Font-Size="Smaller" ForeColor="Gray">
                        </dxe:ASPxLabel>
                    </DataItemTemplate>
                </dxwgv:GridViewDataTextColumn>
            </Columns>
        </dxwgv:ASPxGridView>
    </div>
    </form>
</body>
</html>
