﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HobiGuncelle.aspx.cs" Inherits="BlogWeb.HobiGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="HOBI"></asp:Label>
            <asp:TextBox ID="txtHobi" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="KAYDET" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>

</asp:Content>