using Autofac;

namespace MovieReview.Infra.CrossCutting.IoC
{
    public class ModuleIoc : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIoc.Load(builder);
        }
    }
}
