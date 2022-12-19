<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prestamos.aspx.cs" Inherits="Examen.Prestamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prestamos</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.1.min.js" integrity="sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ=" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="prestamos" runat="server">
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

            <div style="height: 250px; text-align: center;" class="mt-2 p-2 bg-secondary text-white rounded">
                <h1>Generar Prestamo</h1>

                <asp:Label runat="server" ID="labelIDClientePresta" Text="ID_Cliente:"></asp:Label>
                <asp:TextBox ID="tboxIDClientePresta" runat="server"></asp:TextBox>
                <asp:Label runat="server" ID="labelIDLibroPrestao" Text="ID_Libro:"></asp:Label>
                <asp:TextBox ID="tboxIDLibroPresta" runat="server"></asp:TextBox>
                <hr />

                <asp:Button class="btn bg-info" ID="btnGenerarPresta" runat="server" OnClick="btnGenerarPresta_Click" Text="Generar"></asp:Button>

                <hr />
                <h4>Lista de Prestamos</h4>
                <br />
            </div>

            <div>
                <div style="height: 230px; text-align: center;" class=" bg text-white rounded">
                    <asp:GridView ID="tablaPrestamos" class="table table-bordered" runat="server"></asp:GridView>
                    <hr />
                </div>
            </div>
        </div>
    </form>
    <script src="main.js"></script>
</body>
</html>
