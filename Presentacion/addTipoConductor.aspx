<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addTipoConductor.aspx.cs" Inherits="Presentacion.addTipoConductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>

    <title></title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">Concesionario</a>
    </nav>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="addTipoVehiculos.aspx">Registro Tipo Vehiculos</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="addVehiculos.aspx">Registro Vehiculos</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="addTipoConductor.aspx">Registro Tipo Conductor<span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="addConductor.aspx">Registro Conductor</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="addContrato.aspx">Contrato</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="addRuta.aspx">Ruta</a>
                    </li>
                </ul>
            </div>
        </nav>
    <div class="container">
    <br />
        <h1>Registro Tipo Conductor</h1>
    <br />
        <form id="form" runat="server">
            <div class="form-group">
                <label for="txtId">Id</label>
                <asp:TextBox ID="txtId" runat="server" class="form-control"></asp:TextBox>     
            </div>
            <div class="form-group">
                <label for="txtNomTipo">Nombre</label>
                <asp:TextBox ID="txtNomTipo" runat="server" class="form-control" ></asp:TextBox>
            </div>
            <div class="form-row">
                <div class="col-8">
                    <asp:Button id="btnAdd" runat="server" class="btn btn-primary" Text="Agregar" OnClick="btnAdd_Click"/>
                </div>
                <div class="col-4 text-right">
                    <asp:Button id="btnUpdate" runat="server" class="btn btn-primary" Text="Modificar" OnClick="btnUpdate_Click"/>
                    <asp:Button id="btnList" runat="server" class="btn btn-primary" Text="Listar" OnClick="btnList_Click"/>
                    <asp:Button id="btnDelete" runat="server" class="btn btn-danger" Text="Eliminar" OnClick="btnDelete_Click"/>
                </div>
            </div>
            <br />
            <div class="form-row">
                <asp:label ID="lblMensaje" runat="server" ForeColor="Blue" EnableViewState="false"></asp:label>
            </div>
            <br />
            <table class="table">
                <tr>
                    <th>
                        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="Id" />
                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                            </Columns>
                        </asp:GridView>
                    </th>
                </tr>
           </table>
        </form>
    </div>

    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

</body>
</html>
