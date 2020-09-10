<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reserva2.aspx.cs" Inherits="TutuCanchas_GP1.Reserva2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvReservas" runat="server" OnRowCommand="gvReservas_RowCommand" OnSelectedIndexChanged="gvReservas_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" HeaderText="Borrar" Text="Borrar" CommandName="Borrar" />
        </Columns>
    </asp:GridView>
</asp:Content>
