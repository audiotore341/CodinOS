// Basiclly the base of the operating system or the "core" if you will.

using System;
using System.Threading;

namespace OS
{
    public class Base
    {
        static Commands cmd = new Commands(); // Functionality to all the commands!
        public void run(string input)
        {
            Console.Clear();
            Console.WriteLine("Copyright (C) CodinOS OS 2022 1.2");
            Console.WriteLine("Type 'help' to get a list of commands.");
            while (true)
            {
                Console.Write("[C:/]: ");
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
                else if (command_type == "open_notepad")
                {
                    Commands.open_notepad();
                }
                // Just a joke command.
                else if (command_type == "I hate audiotore.")
                {
                    Console.WriteLine("ratio + cope + nobody asked");
                }
                else if (command_type == "open_fileX")
                {
                    Commands.open_fileX();
                }
                else
                {
                    Console.WriteLine("Invaild command, type 'help' to get a list of commands!");
                }

            }
        }
    }
}