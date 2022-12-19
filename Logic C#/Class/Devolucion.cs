using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Class
{
    public class Devolucion
    {
        public virtual int idDevolucion { get; set; }
        public virtual string fecha { get; set; }
        public virtual int idCliente { get; set; }
        public virtual int idlibro { get; set; }
    }
}
