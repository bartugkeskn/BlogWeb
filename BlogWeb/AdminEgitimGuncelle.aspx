<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimGuncelle.aspx.cs" Inherits="BlogWeb.AdminEgitimGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="BAŞLIK"></asp:Label>
            <asp:TextBox ID="txtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="ALT BAŞLIK"></asp:Label>
            <asp:TextBox ID="txtAltBaslik" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="AÇIKLAMA"></asp:Label>
            <asp:TextBox ID="txtAciklama" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="GENEL NOT ORTALAMASI"></asp:Label>
            <asp:TextBox ID="txtGenelNot" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="TARİH"></asp:Label>
            <asp:TextBox ID="txtTarih" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="KAYDET" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>

</asp:Content>
