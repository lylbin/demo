using Microsoft.Extensions.DependencyInjection;
using Xunit;
using System.Linq;

namespace ScrutorDemo
{
    public class ScrutorTest
    {
        [Fact]
        public void Register_All_Singleton_Test()
        {
            var collection = new ServiceCollection();

            collection.Scan(scan => scan.FromAssemblyOf<ISingletonDependency>()
                .AddClasses(x => x.AssignableTo<ISingletonDependency>())
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            var provider = collection.BuildServiceProvider();

            var instances = provider.GetServices<ISingletonDependency>();

            Assert.Equal(2, instances.Count());

            var instance = provider.GetRequiredService<ISingletonDependency>();

            Assert.Equal(2, instance.GetInt());
        }

        [Fact]
        public void Register_All_Transient_Test()
        {
            var collection = new ServiceCollection();

            collection.Scan(scan => scan.FromAssemblyOf<ITransientDependency>()
                .AddClasses(x => x.AssignableTo<ITransientDependency>())
                .AsImplementedInterfaces()
                .WithTransientLifetime()
                .AddClasses(x => x.AssignableTo<ISingletonDependency>())
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            var provider = collection.BuildServiceProvider();
            var td = provider.GetRequiredService<ITransientDependency>();

            Assert.Equal("two", td.GetName());

            var sd = provider.GetRequiredService<ISingletonDependency>();
            Assert.Equal(2, sd.GetInt());
        }
    }
}
