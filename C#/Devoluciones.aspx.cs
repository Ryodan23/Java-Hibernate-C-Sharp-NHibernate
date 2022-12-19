using Logic.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen
{
    public partial class Devoluciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WS_Reference.WSSoapClient ws = new WS_Reference.WSSoapClient();
            tablaDevoluciones.DataSource = ws.MostrarDevoluciones();
            tablaDevoluciones.DataBind();
        }

        [Obsolete]
        protected void btnGenerarDevo_Click(object sender, EventArgs e)
        {
            try
            {
                Random Random = new Random();
                DateTime Now = DateTime.Now;
                int numRandom = Random.Next(1, 1000);
                String fecha = Now.ToString();
                int IDClienteDevo = Int32.Parse(tboxIDClienteDevo.Text);
                int IDLibroDevo = Int32.Parse(tboxIDLibroDevo.Text);

                DevolucionDB devolucion = new DevolucionDB();
                devolucion.creaDevolucion(numRandom, fecha, IDClienteDevo, IDLibroDevo);
                tboxIDClienteDevo.Text = "";
                tboxIDLibroDevo.Text = "";

                WS_Reference.WSSoapClient ws = new WS_Reference.WSSoapClient();
                tablaDevoluciones.DataSource = ws.MostrarDevoluciones();
                tablaDevoluciones.DataBind();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}