<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="InternetExercise2.index_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Source Page</h1>
            <br />
            <br />
            Item1&nbsp;to&nbsp;send:&nbsp;<asp:TextBox runat="server" placeholder="Click the button to send" ID="txtItem1" />
            <br />
            <br />
            Item2&nbsp;to&nbsp;send:&nbsp;<asp:TextBox runat="server" placeholder="Click the button to send" ID="txtItem2" />
            <br />
            <br />
            Item3&nbsp;to&nbsp;send:&nbsp;<asp:TextBox runat="server" placeholder="Click the button to send" ID="txtItem3" />
            <br />
            <br />
            Item4&nbsp;to&nbsp;send:&nbsp;<asp:TextBox runat="server" placeholder="Click the button to send" ID="txtItem4" />
            <br />
            <br />
            Item5&nbsp;to&nbsp;send:&nbsp;<asp:TextBox runat="server" placeholder="Click the button to send" ID="txtItem5" />
            <br />
            <br />
            <asp:Button runat="server" ID="btnUsingQueryString" Text="Using Query String" OnClick="btnUsingQueryString_OnClick" />
            <br />
            <br />
            <asp:Button runat="server" ID="btnUsingSessionState" Text="Using Session State" OnClick="btnUsingSessionState_OnClick" />
            <br />
            <br />
            <asp:Button runat="server" ID="btnUsingPreviousPage" Text="Using PreviousPage" OnClick="btnUsingPreviousPage_OnClick" />
            <br />
            <br />
            <asp:Button runat="server" ID="btnUsingCookie" Text="Using Cookie" OnClick="btnUsingCookie_OnClick" />
            <br />
            <br />
            <asp:Button runat="server" ID="btnUsingViewState" Text="Using ViewState" OnClick="btnUsingViewState_OnClick" />
        </div>
    </form>
</body>
</html>
