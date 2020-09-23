using BLL.BLEntities;
using DAL.Interfaces;
using DAL.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    class ServiceModule : NinjectModule
    {
        private List<BLProduct> connection;
        public ServiceModule(List<BLProduct> con)
        {
            connection = con;
        }
        public override void Load()
        {
            Bind<IWork>().To<DBWork>().WithConstructorArgument(connection);
        }
    }
}
