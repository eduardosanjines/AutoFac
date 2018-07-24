using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacExample
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            Configure();

            Dividir(10, 0);
            Console.ReadKey();
        }


        public static void Configure() {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacModule());
            builder.RegisterType<CalculadoraController>().SingleInstance();
            Container = builder.Build();
        }

        public static void Dividir(int num1, int num2)
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var res = scope.Resolve<CalculadoraController>().Div(num1, num2);
                Console.WriteLine(res);
            }
        }



    }
    
}
