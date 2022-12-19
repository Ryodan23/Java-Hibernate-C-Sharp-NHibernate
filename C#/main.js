$(document).ready(function () {

    //Redireccionamiento

    //Prestamos
    $('#btnPrestamos').click(function (e) {
        e.preventDefault();

        window.location.href = "Prestamos.aspx";
    });

    //Devoluciones
    $('#btnDevoluciones').click(function (e) {
        e.preventDefault();

        window.location.href = "Devoluciones.aspx";
    });

    //Libros
    $('#btnLibros').click(function (e) {
        e.preventDefault();

        window.location.href = "Libros.aspx";
    });

    //Clientes
    $('#btnClientes').click(function (e) {
        e.preventDefault();

        window.location.href = "Clientes.aspx";
    });

    //Llenar Dropdown Cliente
    $.ajax({
        url: "WS.asmx/MostrarClientes",
        type: "POST",
        dataType: "xml",
        success: function (respuesta) {
            //console.log(respuesta);

            $(respuesta).find('ListaClienteResult').each(function () {
                var idCliente = $(this).find('idCliente').text();
                $('#DropIDCliente').append(`<option>${idCliente}</option>`);
            });
        }
    });

    //Llenar Dropdown Libro
    $.ajax({
        url: "WS.asmx/MostrarLibro",
        type: "POST",
        dataType: "xml",
        success: function (respuesta) {
            //console.log(respuesta);

            $(respuesta).find('ListaLibroResult').each(function () {
                var idLibro = $(this).find('idLibro').text();
                $('#DropIDLibro').append(`<option>${idLibro}</option>`);
            });
        }
    });

    //Agrega Cliente
    $('#btnAgregarCliente').click(function (e) {
        e.preventDefault();
        $('#pEstado').text("Agregar Cliente");

        //Oculta Botones
        $('#btnAgregarCliente').hide();
        $('#btnEliminarCliente').hide();
        $('#btnActualizarCliente').hide();

        //Activa Textboxs
        $('#tboxNombreCliente').attr("disabled", false);
        $('#tboxApellidoCliente').attr("disabled", false);

        //Muestra Botones
        $('#btnConfirmaAgregarCliente').show();
        $('#btnCancelaAgregarCliente').show();

        //Confirmar Agregar
        $('#btnConfirmaAgregarCliente').click(function (e) {
            e.preventDefault();

            //Variables
            var nombre = $('#tboxNombreCliente').val();
            var apellido = $('#tboxApellidoCliente').val();

            if (nombre.length || apellido.length) {

                $.ajax({
                    url: "WS.asmx/creaCliente",
                    type: "POST",
                    data: {
                        nombre: nombre,
                        apellido: apellido
                    },
                    success: function (respuesta) {
                        // console.log(respuesta);

                        Swal.fire("Exito", "Se agrego el cliente correctamente", "success");

                        setTimeout(function () {
                            location.reload();
                        }, 2000)
                    }
                });
            } else {
                Swal.fire("Adventencia", "Los datos no pueden estar vacíos", "warning");
                return;
            }
        });

        //Cancela Accion
        $('#btnCancelaAgregarCliente').click(function (e) {
            e.preventDefault();

            location.reload();
        });
    });

    //Actualiza Clietne
    $('#btnActualizarCliente').click(function (e) {
        e.preventDefault();
        $('#pEstado').text("Actualizar Cliente");

        //Oculta Botones y Textbox
        $('#btnAgregarCliente').hide();
        $('#btnEliminarCliente').hide();
        $('#btnActualizarCliente').hide();

        //Muestra Drop
        $('#labelID').show();
        $('#DropIDCliente').show();

        //Activa Textboxs
        $('#tboxNombreCliente').attr("disabled", false);
        $('#tboxApellidoCliente').attr("disabled", false);

        //Muestra Botones
        $('#btnConfirmaEditarCliente').show();
        $('#btnCancelaEditarCliente').show();

        //Confirmar Actualizacion
        $('#btnConfirmaEditarCliente').click(function (e) {
            e.preventDefault();

            //Variables
            var idUser = $('#DropIDCliente').val();
            var NameEdit = $('#tboxNombreCliente').val();
            var LastEdit = $('#tboxApellidoCliente').val();

            if (NameEdit != "" || LastEdit != "") {

                $.ajax({
                    url: "WS.asmx/editaCliente",
                    type: "POST",
                    data: {
                        idUser: idUser,
                        NameEdit: NameEdit,
                        LastEdit: LastEdit
                    },
                    success: function (respuesta) {
                        //console.log(respuesta);

                        Swal.fire("Exito", "Se actualizo el cliente correctamente", "success");

                        setTimeout(function () {
                            location.reload();
                        }, 2000);
                    }
                });
            } else {
                Swal.fire("Adventencia", "Los datos no pueden estar vacíos", "warning");
                return;
            }
        });

        //Cancela Accion
        $('#btnCancelaEditarCliente').click(function (e) {
            e.preventDefault();

            location.reload();
        });
    });

    //Eliminar Cliente
    $('#btnEliminarCliente').click(function (e) {
        e.preventDefault();
        $('#pEstado').text("Eliminar Cliente");

        //Oculta Botones
        $('#btnAgregarCliente').hide();
        $('#btnEliminarCliente').hide();
        $('#btnActualizarCliente').hide();

        //Oculta Labels y Textboxs
        $('#labelNombre').hide();
        $('#labelApellido').hide();
        $('#tboxNombreCliente').hide();
        $('#tboxApellidoCliente').hide();

        //Muestra Drop
        $('#labelID').show();
        $('#DropIDCliente').show();

        //Muestra Botones
        $('#btnConfirmaEliminarCliente').show();
        $('#btnCancelaEliminarCliente').show();

        //Confirmar Eliminacion
        $('#btnConfirmaEliminarCliente').click(function (e) {
            e.preventDefault();

            //Variables
            var idCliente = $('#DropIDCliente').val();

            $.ajax({
                url: "WS.asmx/eliminaCliente",
                type: "POST",
                data: {
                    idCliente: idCliente
                },
                success: function (respuesta) {
                    //console.log(respuesta);

                    Swal.fire("Exito", "Se elimino el cliente correctamente", "success");

                    setTimeout(function () {
                        location.reload();
                    }, 2000);
                }
            });

        });

        //Cancela Accion
        $('#btnCancelaEliminarCliente').click(function (e) {
            e.preventDefault();

            location.reload();
        });
    });


    //Agrega Libro
    $('#btnAgregarLibro').click(function (e) {
        e.preventDefault();
        $('#pEstado').text("Agregar Libro");

        //Oculta Botones
        $('#btnAgregarLibro').hide();
        $('#btnEliminarLibro').hide();
        $('#btnActualizarLibro').hide();

        //Oculta Estado
        $('#labelEstado').hide();
        $('#tboxEstadoLibro').hide();

        //Activa Textboxs
        $('#tboxNombreLibro').attr("disabled", false);
        $('#tboxAutorLibro').attr("disabled", false);
        $('#tboxannoLibro').attr("disabled", false);

        //Muestra Botones
        $('#btnConfirmaAgregarLibro').show();
        $('#btnCancelaAgregarLibro').show();

        //Confirmar Agregar
        $('#btnConfirmaAgregarLibro').click(function (e) {
            e.preventDefault();

            //Variables
            var nombreLibro = $('#tboxNombreLibro').val();
            var autorLibro = $('#tboxAutorLibro').val();
            var annoLibro = $('#tboxannoLibro').val();

            if (nombreLibro.length || autorLibro.length || annoLibro.length) {

                $.ajax({
                    url: "WS.asmx/creaLibro",
                    type: "POST",
                    data: {
                        nombreLibro: nombreLibro,
                        autorLibro: autorLibro,
                        annoLibro: annoLibro

                    },
                    success: function (respuesta) {
                        // console.log(respuesta);

                        Swal.fire("Exito", "Se agrego el libro correctamente", "success");

                        setTimeout(function () {
                            location.reload();
                        }, 2000)
                    }
                });
            } else {
                Swal.fire("Adventencia", "Los datos no pueden estar vacíos", "warning");
                return;
            }
        });

        //Cancela Accion
        $('#btnCancelaAgregarLibro').click(function (e) {
            e.preventDefault();

            location.reload();
        });
    });

    //Actualiza Libro
    $('#btnActualizarLibro').click(function (e) {
        e.preventDefault();
        $('#pEstado').text("Actualizar Libro");

        //Oculta Botones y Textbox
        $('#btnAgregarLibro').hide();
        $('#btnEliminarLibro').hide();
        $('#btnActualizarLibro').hide();

        //Muestra Drop
        $('#labelID').show();
        $('#DropIDLibro').show();

        //Activa Textboxs
        $('#tboxNombreLibro').attr("disabled", false);
        $('#tboxAutorLibro').attr("disabled", false);
        $('#tboxannoLibro').attr("disabled", false);
        $('#tboxEstadoLibro').attr("disabled", false);

        //Muestra Botones
        $('#btnConfirmaEditarLibro').show();
        $('#btnCancelaEditarLibro').show();

        //Confirmar Actualizacion
        $('#btnConfirmaEditarLibro').click(function (e) {
            e.preventDefault();

            //Variables
            var idLibro = $('#DropIDLibro').val();
            var NameEditLibro = $('#tboxNombreLibro').val();
            var autorEditLibro = $('#tboxAutorLibro').val();
            var annoEditLibro = $('#tboxannoLibro').val();
            var estadoEditLibro = parseInt($('#tboxEstadoLibro').val());

            if (NameEditLibro != "" || autorEditLibro != "" || annoEditLibro != "" || estadoEditLibro != "") {

                $.ajax({
                    url: "WS.asmx/editaLibro",
                    type: "POST",
                    data: {
                        idLibro: idLibro,
                        NameEditLibro: NameEditLibro,
                        autorEditLibro: autorEditLibro,
                        annoEditLibro: annoEditLibro,
                        estadoEditLibro: estadoEditLibro
                    },
                    success: function (respuesta) {
                        //console.log(respuesta);

                        Swal.fire("Exito", "Se actualizo el libro correctamente", "success");

                        setTimeout(function () {
                            location.reload();
                        }, 2000);
                    }
                });
            } else {
                Swal.fire("Adventencia", "Los datos no pueden estar vacíos", "warning");
                return;
            }
        });

        //Cancela Accion
        $('#btnCancelaEditarLibro').click(function (e) {
            e.preventDefault();

            location.reload();
        });
    });

    //Eliminar Libro
    $('#btnEliminarLibro').click(function (e) {
        e.preventDefault();
        $('#pEstado').text("Eliminar Libro");

        //Oculta Botones
        $('#btnAgregarLibro').hide();
        $('#btnEliminarLibro').hide();
        $('#btnActualizarLibro').hide();

        //Oculta Labels y Textboxs
        $('#labelNombre').hide();
        $('#labelAutor').hide();
        $('#labelanno').hide();
        $('#labelEstado').hide();
        $('#tboxNombreLibro').hide();
        $('#tboxAutorLibro').hide();
        $('#tboxannoLibro').hide();
        $('#tboxEstadoLibro').hide();

        //Muestra Drop
        $('#labelID').show();
        $('#DropIDLibro').show();

        //Muestra Botones
        $('#btnConfirmaEliminarLibro').show();
        $('#btnCancelaEliminarLibro').show();

        //Confirmar Eliminacion
        $('#btnConfirmaEliminarLibro').click(function (e) {
            e.preventDefault();

            //Variables
            var idLibro = $('#DropIDLibro').val();

            $.ajax({
                url: "WS.asmx/eliminaLibro",
                type: "POST",
                data: {
                    idLibro: idLibro
                },
                success: function (respuesta) {
                    console.log(respuesta);

                    Swal.fire("Exito", "Se elimino el libro correctamente", "success");

                    setTimeout(function () {
                        location.reload();
                    }, 2000);
                }
            });

        });

        //Cancela Accion
        $('#btnCancelaEliminarLibro').click(function (e) {
            e.preventDefault();

            location.reload();
        });
    });

})