<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Libros.aspx.cs" Inherits="Examen.Libros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Libros</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.1.min.js" integrity="sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ=" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="libros" runat="server">
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
                <p id="pEstado">Libros</p>

                <asp:Label runat="server" ID="labelID" Style="display: none;" Text="ID:"></asp:Label>
                <asp:DropDownList ID="DropIDLibro" Style="display: none;" runat="server"></asp:DropDownList>
                <asp:Label runat="server" ID="labelNombre" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="tboxNombreLibro" runat="server" Enabled="False"></asp:TextBox>
                <asp:Label runat="server" ID="labelAutor" Text="Autor:"></asp:Label>
                <asp:TextBox ID="tboxAutorLibro" runat="server" Enabled="False"></asp:TextBox>
                <asp:Label runat="server" ID="labelanno" Text="Año:"></asp:Label>
                <asp:TextBox ID="tboxannoLibro" runat="server" Enabled="False"></asp:TextBox>
                <asp:Label runat="server" ID="labelEstado" Text="Estado:"></asp:Label>
                <asp:TextBox ID="tboxEstadoLibro" runat="server" Enabled="False"></asp:TextBox>

                <hr />
                <h4>Lista de Libros</h4>
                <br />
            </div>

            <div>
                <div style="height: 230px; text-align: center;" class=" bg text-white rounded">
                    <asp:GridView ID="tablaLibros" class="table table-bordered" runat="server"></asp:GridView>
                    <hr />
                    <!-- Principal -->
                    <asp:Button class="btn bg-success" ID="btnAgregarLibro" runat="server" Text="Agregar"></asp:Button>
                    <asp:Button class="btn bg-warning" ID="btnActualizarLibro" runat="server" Text="Actualizar"></asp:Button>
                    <asp:Button class="btn bg-danger" ID="btnEliminarLibro" runat="server" Text="Eliminar"></asp:Button>

                    <!-- Agregar -->
                    <asp:Button class="btn bg-success" Style="display: none;" ID="btnConfirmaAgregarLibro" runat="server" Text="Agregar"></asp:Button>
                    <asp:Button class="btn bg-danger" Style="display: none;" ID="btnCancelaAgregarLibro" runat="server" Text="Cancelar"></asp:Button>

                    <!-- Editar -->
                    <asp:Button class="btn bg-warning" Style="display: none;" ID="btnConfirmaEditarLibro" runat="server" Text="Actualizar"></asp:Button>
                    <asp:Button class="btn bg-danger" Style="display: none;" ID="btnCancelaEditarLibro" runat="server" Text="Cancelar"></asp:Button>

                    <!-- Eliminar -->
                    <asp:Button class="btn bg-danger" Style="display: none;" ID="btnConfirmaEliminarLibro" runat="server" Text="Eliminar"></asp:Button>
                    <asp:Button class="btn bg-danger" Style="display: none;" ID="btnCancelaEliminarLibro" runat="server" Text="Cancelar"></asp:Button>
                </div>
            </div>
        </div>
    </form>
    <script src="main.js"></script>
</body>
</html>
