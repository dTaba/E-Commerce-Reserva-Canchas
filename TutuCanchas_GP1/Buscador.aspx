<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Buscador.aspx.cs" Inherits="TutuCanchas_GP1.Buscador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="container">

        <div class="row">

            <div class="col-md-12">

                <h3>Buscador</h3>

                <asp:Label ID="Label1" runat="server" Text="Horario"></asp:Label>
                <asp:DropDownList ID="ddHorario" runat="server" class="custom-select d-block w-100" Width="100%"></asp:DropDownList>

                <br />
                <asp:Label ID="Label2" runat="server" Text="Tipo de Cancha"></asp:Label>
                <asp:DropDownList ID="ddTipoCancha" runat="server" class="custom-select d-block w-100" Width="100%"></asp:DropDownList>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_9CF8B6_CanchasConnectionString %>" SelectCommand="SELECT * FROM [CanchasTipos]"></asp:SqlDataSource>

                <br />
                <asp:Label ID="Label3" runat="server" Text="Precio Maximo"></asp:Label>
                <asp:TextBox ID="txPrecio" runat="server" class="form-control" TextMode="Number">5000</asp:TextBox>

                <br />
                <asp:Label ID="Label4" runat="server" Text="Zonas"></asp:Label>
                <asp:DropDownList ID="ddZonas" runat="server" class="custom-select d-block w-100" Width="100%"></asp:DropDownList>

                <br />
                Fecha(Formato : yyyy-MM-dd )<br />
                <asp:TextBox ID="txFecha" runat="server"></asp:TextBox>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DB_9CF8B6_CanchasConnectionString %>" SelectCommand="SELECT * FROM [ClubesZonas]"></asp:SqlDataSource>

            </div>
        </div>
        <div class="row">

            <div class="col-md-12 text-right">
                <br />
                <asp:Button ID="btBuscar" runat="server" Text="Buscar" class="btn btn-primary btn-lg" OnClick="btBuscar_Click" OnInit="btBuscar_Init" />
                <br />
                <br />
                <asp:GridView ID="gvCanchas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvCanchas_SelectedIndexChanged" OnRowCommand="gvCanchas_RowCommand" AutoGenerateColumns="False">
                    
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" Text="Reservar" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DB_9CF8B6_CanchasConnectionString %>" SelectCommand="SELECT        Clubes.Nombre AS Club, Canchas.Nombre AS Cancha, CanchasHorarios.HoraDesde AS Desde, CanchasHorarios.HoraHasta AS Hasta, CanchasHorarios.Precio, Clubes.Direccion, CanchasTipos.Nombre AS Tipo, 
                         Clubes.Zona
FROM            Canchas RIGHT OUTER JOIN
                         CanchasHorarios ON Canchas.Id = CanchasHorarios.IdCancha LEFT OUTER JOIN
                         Clubes ON Canchas.IdClub = Clubes.Id LEFT OUTER JOIN
                         CanchasTipos ON Canchas.IdCanchasTipos = CanchasTipos.Id
GROUP BY Clubes.Nombre, Canchas.Nombre, CanchasHorarios.HoraDesde, CanchasHorarios.HoraHasta, CanchasHorarios.Precio, Clubes.Direccion, CanchasTipos.Nombre, Clubes.Zona
ORDER BY CanchasHorarios.Precio"></asp:SqlDataSource>
            </div>

            <asp:Label ID="lbMsg" runat="server"></asp:Label>
        </div>
    </div>

</asp:Content>
