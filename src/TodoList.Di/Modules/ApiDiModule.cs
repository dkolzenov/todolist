namespace TodoList.Di.Modules
{
    using System.Reflection;

    using Autofac;

    using Module = Autofac.Module;

    public class ApiDiModule : Module
    {
        private const string ServiceName = "TodoList.Services";

        private const string DataName = "TodoList.Data";

        protected override void Load(ContainerBuilder builder)
        {
            var assemblies = AppDomain.CurrentDomain
                .GetAssemblies()
                .OrderByDescending(a => a.FullName)
                .ToArray();

            ServicesRegister(ref builder, assemblies);
            RepositoriesRegister(ref builder, assemblies);
        }

        private static void ServicesRegister(
            ref ContainerBuilder builder,
            Assembly[] assemblies)
        {
            var servicesAssembly = assemblies.FirstOrDefault(
                t => t.FullName!
                    .ToLower()
                    .Contains(ServiceName.ToLower()));

            builder.RegisterAssemblyTypes(servicesAssembly!)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();
        }

        private static void RepositoriesRegister(
            ref ContainerBuilder builder,
            Assembly[] assemblies)
        {
            var dataAssembly = assemblies.FirstOrDefault(
                t => t.FullName!
                    .ToLower()
                    .Contains(DataName.ToLower()));

            builder.RegisterAssemblyTypes(dataAssembly!)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();
        }
    }
}
