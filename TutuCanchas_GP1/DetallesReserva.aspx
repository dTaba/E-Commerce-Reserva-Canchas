<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetallesReserva.aspx.cs" Inherits="TutuCanchas_GP1.DetallesReserva" %>

<asp:content id="Content1" contentplaceholderid="head" runat="server">
</asp:content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="server">
        <div class="container" style="text-align: center">
            <h3>Datos de reserva: </h3>
            <div id="divFecha">
                <asp:Label ID="lblFecha" runat="server" Text="Fecha: "></asp:Label>
                <asp:Label ID="lblFechaa" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div id="divHorario">
                <asp:Label ID="lblHorario" runat="server" Text="Horario: "></asp:Label>
                <asp:Label ID="lblHorarioo" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div id="divDireccion">
                <asp:Label ID="lblDireccion" runat="server" Text="Direccion: "></asp:Label>
                <asp:Label ID="lblDireccionn" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div id="divTipo">
                <asp:Label ID="lblTipo" runat="server" Text="Tipo: "></asp:Label>
                <asp:Label ID="lblTipoo" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div id="divPrecio">
                <asp:Label ID="lblPrecio" runat="server" Text="Precio: "></asp:Label>
                <asp:Label ID="lblPrecioo" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div id="divConfirmar">
                <asp:Button ID="btConfirmar" runat="server" class="btn btn-primary btn-lg" Text="Confirmar" OnClick="btConfirmar_Click" />
            </div>

            <br />

        </div>
</asp:content>
