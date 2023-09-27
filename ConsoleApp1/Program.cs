using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleUI
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Debug("Developer: Tutorial was run");
            log.Info("Maintenance: water pump turned on");
            log.Warn("Maintenance: the water pump is getting hot");
            log.Error("Developer: we tried to divide by zero again");
            log.Fatal("This is a fatal error in the process");



            Console.ReadLine();
        }
    }
}
