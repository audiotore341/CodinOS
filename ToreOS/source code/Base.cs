using System;
using System.Threading;

/* This is the base os for functionality, pretty much the core
 * of the operating system! */

namespace OS
{
    class Base
    {
        Commands cmd_func = new Commands();
        public void run()
        {
            Console.WriteLine("Copyright (c) ToreOS 1.0 2022");
            Console.WriteLine("Type 'help' to get a list of commands!");

            bool running = true;
            while (running == true)
            {
                Console.Write("[<Z>]:");
                string input = Console.ReadLine();

                if (input == "help")
                {
                    cmd_func.Help();
                }

                if (input == "system_shutdown")
                {
                    Console.Clear();
                    cmd_func.system_shutdown();
                    break;
                }

                if (input == "system_reboot")
                {
                    Console.Clear();
                    cmd_func.system_reboot();
                }

                if (input == "system_about")
                {
                    cmd_func.system_about();
                }

                if (input == "open_notepad")
                {
                    cmd_func.open_notepad();
                }
                
            }
            
        }
    }
}