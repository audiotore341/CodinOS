using System;
using System.Threading;

/* This is where all the command functionality is. To add a command, make a function with the command name.
 * then on the base.cs add a if statement for when the user types the command name. Also add it to the help command list!*/

namespace OS
{
    class Commands
    {
        // Classes.
        filex filep = new filex();
        public static Bootloader reboot = new Bootloader(); // Used for rebooting mainly.
        static Base bs = new Base(); // Used for system reboot.
        public static void help()
        {
            Console.WriteLine("List of commands: 'help', system_shutdown, system_reboot, open_notepad, open_fileX");
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

        public static void open_notepad()
        {
            Console.Write("Document name: ");
            string doc_name = Console.ReadLine();
            Console.WriteLine(".txt (basic text doc) .py (python coding) .cs (C# coding) .bat (Batch coding)");
            Console.Write("Document type: ");
            string doc_type = Console.ReadLine();        
            using (StreamWriter write_doc = new StreamWriter(@doc_name + doc_type))
            {
                while (true)
                {
                    Console.Write("Type something: ");
                    string type = Console.ReadLine();
                    write_doc.WriteLine(type);
                }

            }
        }

        public static void open_fileX()
        {
            filex.fileX();
        }



    }
}