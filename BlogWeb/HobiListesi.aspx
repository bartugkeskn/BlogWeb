﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HobiListesi.aspx.cs" Inherits="BlogWeb.HobiListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form id="Form1" runat="server">
     <table class="table table-bordered">
         <tr>
             <th>ID</th>
             <th>YETENEK</th>
         </tr>
         <tbody>
             <asp:Repeater ID="Repeater1" runat="server">
                 <itemtemplate>
                     <tr>
                         <th><%# Eval("ID") %></th>
                         <th><%# Eval("HOBI") %></th>
                         <td>
                             <asp:HyperLink NavigateUrl='<%# "HobiSil.aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                             <asp:HyperLink NavigateUrl='<%# "HobiGuncelle.aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                         </td>
                     </tr>
                 </itemtemplate>
             </asp:Repeater>
         </tbody>
     </table>

     <asp:HyperLink NavigateUrl="~/HobiEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">YENİ HOBİ EKLE</asp:HyperLink>
 </form>

</asp:Content>
