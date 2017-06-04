using AlimexDAL.Model;
using Autofac;
using System;

namespace AlimexDAL
{
    public class RegisterComponent : Module
    {
        #region Protected Methods

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(cxt =>
            {
                return new AppDbContext(new DbParameter().getParam());
            })
            .AsSelf().InstancePerLifetimeScope();
        }

          

        #endregion Protected Methods
    }
}
