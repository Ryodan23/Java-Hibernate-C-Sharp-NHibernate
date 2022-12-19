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
    public class PrestamoDB
    {
        private ISessionFactory sessionFactory;
        private ISession session;

        public PrestamoDB()
        {
            Configuration config = new Configuration();
            config.AddAssembly("Logic");
            sessionFactory = config.BuildSessionFactory();
            session = sessionFactory.OpenSession();
        }

        [Obsolete]
        public bool creaPrestamo(int idPrestamo, String fecha, int idCliente, int idlibro)
        {
            try
            {
                using (session.BeginTransaction())
                {
                    Prestamo prestamo = new Prestamo
                    {
                        idPrestamo = idPrestamo,
                        fecha = fecha,
                        idCliente = idCliente,
                        idlibro = idlibro

                    };
                    session.Save(prestamo);
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
