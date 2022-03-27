using System;
using System.Threading;

/* This is where all the command functionality is. To add a command, make a function with the command name.
 * then on the base.cs add a if statement for when the user types the command name */

namespace OS
{
    class Commands
    {
        public static Bootloader reboot = new Bootloader();
        static Base bs = new Base(); // Used for system reboot, shutdown commands.
        public static void help()
        {
            Console.WriteLine("List of commands: 'help', system_shutdown, system_reboot");
        }

        public static void system_shutdown()
        {
            
            Console.Write("Are you sure? [yes/no]: ");
            string shutdown = Console.ReadLine();
            if (shutdown == "yes")
            {
                Console.Clear();
                Console.WriteLine("Shutting down...");
                Thread.Sleep(1000);
                Environment.Exit(0); // Closes the program.
            }
            else
            {
                Console.WriteLine("Canceling...");
                bs.run(null);

                
            }
        }
        public static void system_reboot()
        {
            Console.Write("Are you sure? [yes/no]: ");
            string reboot = Console.ReadLine();
            if (reboot == "yes")
            {
                Bootloader.Main(null);

            }
            else
            {
                Console.WriteLine("Canceling...");
                bs.run(null);
            }
        }



    }
}