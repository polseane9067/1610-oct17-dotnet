﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="entryform.aspx.cs" Inherits="MonsterWeb.Client.entryform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="MonsterName">Name</asp:Label>
            <asp:TextBox runat="server" ID="MonsterName_Text"></asp:TextBox>

            <asp:Label runat="server" ID="MonsterGender">Gender</asp:Label>
            <asp:DropDownList runat="server" ID="MonsterGender_List"></asp:DropDownList>

            <asp:Button runat="server" ID="MonsterSubmit" OnClick="MonsterSubmit_Click" Text="Submit"/>
        </div>
    </form>
</body>
</html>
