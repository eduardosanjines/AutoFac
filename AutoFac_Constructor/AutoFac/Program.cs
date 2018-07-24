using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AutoFac
{
    public class Program
    {
        public static IContainer Container { get;private set; }

        static void Main(string[] args)
        {
            Configure();
            Load();
            Console.ReadKey();

        }
            public static void Configure()
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<BMWAutoService>().SingleInstance();
                builder.RegisterType<FordAutoService>().SingleInstance();
                builder.RegisterType<HondaAutoService>().SingleInstance();
                Container = builder.Build();

            }

        public static void Load() {

            using (var scope = Container.BeginLifetimeScope()) {
                
                var bmw = scope.Resolve<BMWAutoService>();
                var honda = scope.Resolve<HondaAutoService>();
                var ford = scope.Resolve<FordAutoService>();

                AutoServiceCallerImp servi = new AutoServiceCallerImp(bmw, honda, ford);
                servi.CallAutoService();
            }
        }
    }
}
