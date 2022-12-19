using Logic.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen
{
    public partial class Prestamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WS_Reference.WSSoapClient ws = new WS_Reference.WSSoapClient();
            tablaPrestamos.DataSource = ws.MostrarPrestamos();
            tablaPrestamos.DataBind();
        }

        [Obsolete]
        protected void btnGenerarPresta_Click(object sender, EventArgs e)
        {
            try
            {
                Random Random = new Random();
                DateTime Now = DateTime.Now;
                int numRandom = Random.Next(1, 1000);
                String fecha = Now.ToString();
                int IDClientePresta = Int32.Parse(tboxIDClientePresta.Text);
                int IDLibroPresta = Int32.Parse(tboxIDLibroPresta.Text);

                PrestamoDB prestamo = new PrestamoDB();
                prestamo.creaPrestamo(numRandom, fecha, IDClientePresta, IDLibroPresta);

                tboxIDClientePresta.Text = "";
                tboxIDLibroPresta.Text = "";

                WS_Reference.WSSoapClient ws = new WS_Reference.WSSoapClient();
                tablaPrestamos.DataSource = ws.MostrarPrestamos();
                tablaPrestamos.DataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}