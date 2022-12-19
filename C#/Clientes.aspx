<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Examen.Clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Clientes</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.1.min.js" integrity="sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ=" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="clientes" runat="server">
        <div>
            <div style="height: 10px; text-align: center;" class="mt-1 p-1 text-white rounded">
                <asp:Button ID="btnPrestamos" class="btn bg-info" runat="server" Text="Prestamos" />
                <asp:Button ID="btnDevoluciones" class="btn bg-info" runat="server" Text="Devoluciones" />
                <asp:Button ID="btnLibros" class="btn bg-info" runat="server" Text="Libros" />
                <asp:Button ID="btnClientes" class="btn bg-info" runat="server" Text="Clientes" />
            </div>

            <div style="height: 110px; text-align: center;" class="mt-4 p-4 text-black rounded">
                <h2>Examen Final</h2>
                <p>Hibernate</p>
            </div>

            <div style="height: 220px; text-align: center;" class="mt-2 p-2 bg-secondary text-white rounded">
                <h1>Mantemientos</h1>
                <p id="pEstado">Clientes</p>

                <asp:Label runat="server" ID="labelID" style="display: none;" Text="ID:"></asp:Label>
                <asp:DropDownList ID="DropIDCliente" style="display: none;" runat="server"></asp:DropDownList>
                <asp:Label runat="server" ID="labelNombre" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="tboxNombreCliente" runat="server" Enabled="False"></asp:TextBox>
                <asp:Label runat="server" ID="labelApellido" Text="Apellido:"></asp:Label>
                <asp:TextBox ID="tboxApellidoCliente" runat="server" Enabled="False"></asp:TextBox>

                <hr />
                <h4>Lista de Clientes</h4>
                <br />
            </div>

            <div>
                <div style="height: 230px; text-align: center;" class=" bg text-white rounded">
                    <asp:GridView ID="tablaClientes" class="table table-bordered" runat="server"></asp:GridView>
                    <hr />
                    <!-- Principal -->
                    <asp:Button class="btn bg-success" ID="btnAgregarCliente" runat="server" Text="Agregar"></asp:Button>
                    <asp:Button class="btn bg-warning" ID="btnActualizarCliente" runat="server" Text="Actualizar"></asp:Button>
                    <asp:Button class="btn bg-danger" ID="btnEliminarCliente" runat="server" Text="Eliminar"></asp:Button>

                    <!-- Agregar -->
                    <asp:Button class="btn bg-success" Style="display: none;" ID="btnConfirmaAgregarCliente" runat="server" Text="Agregar"></asp:Button>
                    <asp:Button class="btn bg-danger" Style="display: none;" ID="btnCancelaAgregarCliente" runat="server" Text="Cancelar"></asp:Button>

                    <!-- Editar -->
                    <asp:Button class="btn bg-warning" Style="display: none;" ID="btnConfirmaEditarCliente" runat="server" Text="Actualizar"></asp:Button>
                    <asp:Button class="btn bg-danger" Style="display: none;" ID="btnCancelaEditarCliente" runat="server" Text="Cancelar"></asp:Button>

                    <!-- Eliminar -->
                    <asp:Button class="btn bg-danger" Style="display: none;" ID="btnConfirmaEliminarCliente" runat="server" Text="Eliminar"></asp:Button>
                    <asp:Button class="btn bg-danger" Style="display: none;" ID="btnCancelaEliminarCliente" runat="server" Text="Cancelar"></asp:Button>
                </div>
            </div>
        </div>
    </form>
    <script src="main.js"></script>
</body>
</html>

