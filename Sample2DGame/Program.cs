using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2DGame
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
#if !DEBUG
            try
            {
#endif
            using (var game = new Sample2DGame())
                game.Run();
#if !DEBUG
            }
            catch (Exception e)
            {
                DebugPrinter.print(e.ToString());
            }
#endif
        }
    }
}
