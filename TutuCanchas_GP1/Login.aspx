<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TutuCanchas_GP1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <link href="~/css/Site.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="img/pelotita.png" type="image/png" sizes="32x32">
    <link rel="icon" href="img/pelotita.png" type="image/png" sizes="32x32">

    <title>Tutu Canchas - Iniciar Sesión</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">

                <br />
                <div class="row">
                    <div class="col-md-4">
                    </div>
                    <div class="col-md-4 text-center">
                        <img align="center" alt="Logo" src="img/logo.jpg" width="100%" />
                        <br />
                    </div>
                    <div class="col-md-4">
                    </div>
                </div>
                <br />
                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <h3>Iniciar Sesión</h3>
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <label for="txUsuario">Usuario (Email)</label>
                        <asp:TextBox ID="txUsuario" runat="server" class="form-control"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-4">
                    </div>
                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <label for="txContraseña">Contraseña</label>
                        <asp:TextBox ID="txContraseña" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>
                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-sm-4 text-center">
                        <asp:Button ID="btIniciar" runat="server" Text="Iniciar Sesión" class="btn btn-primary btn-lg" OnClick="btIniciarSesion_Click" />
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>
                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-sm-4 text-center">
                        <asp:Label ID="lbMsg" runat="server"></asp:Label>
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>
            </div>


        </div>
    </form>
</body>
</html>
