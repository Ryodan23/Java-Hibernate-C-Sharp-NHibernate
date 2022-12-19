using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using System.Collections;

namespace Logic.Class
{
    public class DevolucionDB
    {
        private ISessionFactory sessionFactory;
        private ISession session;

        public DevolucionDB()
        {
            Configuration config = new Configuration();
            config.AddAssembly("Logic");
            sessionFactory = config.BuildSessionFactory();
            session = sessionFactory.OpenSession();
        }

        [Obsolete]
        public bool creaDevolucion(int idDevolucion, String fecha, int idCliente, int idlibro)
        {
            try
            {
                using (session.BeginTransaction())
                {
                    Devolucion devolucion = new Devolucion
                    {
                        idDevolucion = idDevolucion,
                        fecha = fecha,
                        idCliente = idCliente,
                        idlibro = idlibro
                    };
                    session.Save(devolucion);
                    session.Transaction.Commit();
                }

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
