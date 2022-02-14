using Autofac;
using Module2HW5.Configs;

namespace Module2HW5
{
    internal class Program
    {
        private static void Main()
        {
            var config = new Config();
            var container = config.RegisterTypes();
            var start = container.Resolve<Starter>();
            start.Run();
        }
    }
}
