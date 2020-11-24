using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WorkerService1
{
    /// <summary>
    /// Entry class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry Point
        /// </summary>
        /// <param name="args">Commandline arguments</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Create hostbuilder.
        /// </summary>
        /// <param name="args">Commandline arguments</param>
        /// <returns><see cref="IHostBuilder"/></returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<Worker>();
            });
        }
    }
}
