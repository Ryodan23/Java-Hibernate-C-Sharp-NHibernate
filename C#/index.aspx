<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Examen.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.1.min.js" integrity="sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ=" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="index" runat="server">
        <div>
            <div style="height: 110px; text-align: center;" class="mt-4 p-4 text-black rounded">
                <h2>Examen Final</h2>
                <p>Hibernate</p>
                <br />
                <asp:Button ID="btnPrestamos" class="btn bg-info" runat="server" Text="Prestamos" />
                <asp:Button ID="btnDevoluciones" class="btn bg-info" runat="server" Text="Devoluciones" />
                <asp:Button ID="btnLibros" class="btn bg-info" runat="server" Text="Libros" />
                <asp:Button ID="btnClientes" class="btn bg-info" runat="server" Text="Clientes" />
            </div>
        </div>
    </form>
    <script src="main.js"></script>
</body>
</html>
