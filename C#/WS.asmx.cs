using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Examen
{
    /// <summary>
    /// Summary description for WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {
        DBDataContext conn = new DBDataContext();
        WSJAVA.WSJAVAClient wsJava = new WSJAVA.WSJAVAClient();

        //Crea Cliente
        [WebMethod]
        public bool creaCliente(String nombre, String apellido)
        {
            try
            {
                wsJava.creaUsuario(nombre, apellido);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Edita Cliente
        [WebMethod]
        public bool editaCliente(int idUser, String NameEdit, String LastEdit)
        {
            try
            {
                wsJava.editaUser(idUser, NameEdit, LastEdit);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Elimina Cliente
        [WebMethod]
        public bool eliminaCliente(int idCliente)
        {
            try
            {
                wsJava.eliminaUser(idCliente);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Lista Cliente
        [WebMethod]
        public List<ListaClienteResult> MostrarClientes()
        {
            return conn.ListaCliente().ToList();
        }


        //Crea Libro
        [WebMethod]
        public bool creaLibro(String nombreLibro, String autorLibro, String annoLibro)
        {
            try
            {
                wsJava.creaLibro(nombreLibro, autorLibro, annoLibro);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Edita Libro
        [WebMethod]
        public bool editaLibro(int idLibro, String NameEditLibro, String autorEditLibro, String annoEditLibro, int estadoEditLibro)
        {
            try
            {
                wsJava.editaLibro(idLibro, NameEditLibro, autorEditLibro, annoEditLibro, estadoEditLibro);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Elimina Libro
        [WebMethod]
        public bool eliminaLibro(int idLibro)
        {
            try
            {
                wsJava.eliminaLibro(idLibro);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Lista Libro
        [WebMethod]
        public List<ListaLibroResult> MostrarLibro()
        {
            return conn.ListaLibro().ToList();
        }


        //Lista Prestamos
        [WebMethod]
        public List<ListaPrestamosResult> MostrarPrestamos()
        {
            return conn.ListaPrestamos().ToList();
        }

        //Lista Devoluciones
        [WebMethod]
        public List<ListaDevolucionesResult> MostrarDevoluciones()
        {
            return conn.ListaDevoluciones().ToList();
        }
    }
}
