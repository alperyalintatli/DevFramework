using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHibernate
{
   public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _session;
        public virtual ISessionFactory SessionFactory { get { return _session ?? (_session = InitializeFactory()); } }

        protected abstract ISessionFactory InitializeFactory();
      
        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
