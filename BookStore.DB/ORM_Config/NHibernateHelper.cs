using System;
using System.Collections.Generic;
using System.Text;
using BookStore.DB.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace BookStore.DB.ORM_Config
{
    class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(@"Server=DESKTOP-NB3LN5U;Database=Book_Store;Trusted_Connection=True;").ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<User>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true)).BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
