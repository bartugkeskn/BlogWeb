<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SertifikaEkle.aspx.cs" Inherits="BlogWeb.SertifikaEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="SERTIFIKA"></asp:Label>
            <asp:TextBox ID="txtSertifika" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="EKLE" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>