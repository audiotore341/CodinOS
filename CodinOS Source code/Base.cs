// Basiclly the base of the operating system or the "core" if you will.

using System;
using System.Threading;

namespace OS
{
    public class Base
    {
        static Commands cmd = new Commands();
        public void run(string input)
        {
            Console.Clear();
            Console.WriteLine("Copyright (C) CodinOS OS 2022 1.1");
            Console.WriteLine("Type 'help' to get a list of commands.");
            while (true)
            {
                Console.Write("[<O>]: ");
                string command_type = Console.ReadLine();
                if (command_type == "help")
                {
                    Commands.help();
                }
                else if (command_type == "system_shutdown")
                {
                    Console.Clear();
                    Commands.system_shutdown();
                }
                else if (command_type == "system_reboot")
                {
                    Commands.system_reboot();
                }
                else if (command_type == "")
                {
                    // Do nothing.
                }
                else
                {
                    Console.WriteLine("Invaild command, type 'help' to get a list of commands!");
                }

            }
        }
    }
}