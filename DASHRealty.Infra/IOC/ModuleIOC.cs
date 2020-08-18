using Autofac;

namespace DASHRealty.Infra.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder) => ConfigurationIOC.Load(builder);
    }
}
