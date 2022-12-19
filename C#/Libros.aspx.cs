using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen
{
    public partial class Libros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WS_Reference.WSSoapClient ws = new WS_Reference.WSSoapClient();
            tablaLibros.DataSource = ws.MostrarLibro();
            tablaLibros.DataBind();
        }
    }
}