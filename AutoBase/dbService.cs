using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace AutoBase
{
    public class DBService
    {
        private static ISessionFactory mySessionFactory;
        public static ISessionFactory Factory
        {
            get
            {
                if (mySessionFactory == null)
                {
                    GetFactory();

                }
                return mySessionFactory;
            }
        }
        private static void GetFactory()
        {
            var myConfig = new Configuration();
            myConfig.Configure();
            mySessionFactory = myConfig.BuildSessionFactory();
        }
    }
}
