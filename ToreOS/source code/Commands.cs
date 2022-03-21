using System;
using System.Threading;

// Command functionality for the os!

namespace OS
{
    public class Commands
    {
        static Bootloader boot = new Bootloader();
        public void Help()
        {
            Console.WriteLine("[system_shutdown, system_reboot, system_about, open_notepad, open_bios");
        }

        public void system_shutdown()
        {
            Console.WriteLine("Shutting down...");
            Thread.Sleep(3000);
            Console.WriteLine("OS Has shutted down!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
        }

        public void system_reboot()
        {
            Console.WriteLine("rebooting...");
            Thread.Sleep(3000);
            boot.reboot_101();
        }

        public void system_about()
        {
            Console.WriteLine("ToreOS copyright (c) 2022 1.0");
            Console.WriteLine("ToreOS is about a terminal os that gives the programmer an ");
            Console.WriteLine("picture of what it's like to write an actual operating system.");
        }

        // Notepad configuration.
        public void open_notepad()
        {
            

            Console.WriteLine("Torepad 1.1");
            Console.WriteLine("At the moment of Torepad 1.0, you can only write 2 lines!");
            Console.Write("[give your document a name:");
            string dock_name = Console.ReadLine();
            Console.WriteLine("You can pick any format you want, however if your confused on what format you need, here is a list of formats:");
            Console.WriteLine("Pick a format: .txt (regular text document) .py (for python coding) .cs (for C# Coding)");
            Console.WriteLine("WARNING: Make sure whatever you type starts with a dot, otherwise this wouldn't work.");
            Console.Write("[format]: ");
            string dock_format = Console.ReadLine();
            Console.Write("How many lines do you want [max 1-5]: ");
            string line_write = Console.ReadLine();
            if (line_write == "1");
            { 
                Console.WriteLine("Doc has been successfully created!");
                using (StreamWriter sw = new StreamWriter(@dock_name + dock_format))
                {
                    Console.Write("Type what you want in the text document: ");
                    string line1 = Console.ReadLine();
                    sw.WriteLine(line1);
                    Console.WriteLine("Doc has been successfully created!");
                    Console.WriteLine("Check your files to see your new created doc!");
                }
            }
            if (line_write == "2")
            {
                Console.WriteLine("Doc has been successfully created!");
                using (StreamWriter sw = new StreamWriter(@dock_name + dock_format))
                {
                    Console.Write("Type what you want in the text document: ");
                    string line1 = Console.ReadLine();
                    Console.Write("Type what you want in the text document: ");
                    string line2 = Console.ReadLine();
                    sw.WriteLine(line1);
                    sw.WriteLine(line2);
                    Console.WriteLine("Doc has been successfully created!");
                    Console.WriteLine("Check your files to see your new created doc!");
                }
            }
            if (line_write == "3")
            {
                Console.WriteLine("Doc has been successfully created!");
                using (StreamWriter sw = new StreamWriter(@dock_name + dock_format))
                {
                    Console.Write("Type what you want in the text document: ");
                    string line1 = Console.ReadLine();
                    string line2 = Console.ReadLine();
                    string line3 = Console.ReadLine();
                    sw.WriteLine(line1);
                    sw.WriteLine(line2);
                    sw.WriteLine(line3);
                    Console.WriteLine("Doc has been successfully created!");
                    Console.WriteLine("Check your files to see your new created doc!");
                }
            }
            if (line_write == "4")
            {
                Console.WriteLine("Doc has been successfully created!");
                using (StreamWriter sw = new StreamWriter(@dock_name + dock_format))
                {
                    Console.Write("Type what you want in the text document: ");
                    string line1 = Console.ReadLine();
                    string line2 = Console.ReadLine();
                    string line3 = Console.ReadLine();
                    string line4 = Console.ReadLine();
                    sw.WriteLine(line1);
                    sw.WriteLine(line2);
                    sw.WriteLine(line3);
                    sw.WriteLine(line4);
                    Console.WriteLine("Doc has been successfully created!");
                    Console.WriteLine("Check your files to see your new created doc!");
                }
            }
            if (line_write == "5")
            {
                Console.WriteLine("Doc has been successfully created!");
                using (StreamWriter sw = new StreamWriter(@dock_name + dock_format))
                {
                    Console.Write("Type what you want in the text document: ");
                    string line1 = Console.ReadLine();
                    string line2 = Console.ReadLine();
                    string line3 = Console.ReadLine();
                    string line4 = Console.ReadLine();
                    string line5 = Console.ReadLine();
                    sw.WriteLine(line1);
                    sw.WriteLine(line2);
                    sw.WriteLine(line3);
                    sw.WriteLine(line4);
                    sw.WriteLine(line5);
                    Console.WriteLine("Doc has been successfully created!");
                    Console.WriteLine("Check your files to see your new created doc!");
                }
            }
            




        }

        public void open_bios()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("|       OS: Windows        |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|                          |");
            Console.WriteLine("===========================");
            Console.WriteLine("[1. Change your computer name]");
        }
    }
}