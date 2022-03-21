using System;
using System.Threading;

/* This is for the bootloader 
 * Please be carefull on what code you make! */

namespace OS
{
    public class Bootloader
    {
        static Base running = new Base();
        static void Main(string[] args)
        {          
            Console.WriteLine("Booting ToreOS 1.0.");
            Thread.Sleep(1000);
            Console.WriteLine("Booting ToreOS 1.0..");
            Thread.Sleep(1000);
            Console.WriteLine("Booting ToreOS 1.0...");
            Console.WriteLine("OS has successfully booted!");
            Thread.Sleep(1000);
            if (File.Exists("username.data") & File.Exists("password.data"))
            {
                running.run();
            }
            else
            {             
                Console.Write("Enter a username: ");
                string register_username = Console.ReadLine();
                using (StreamWriter write_username = new StreamWriter(@"username.data"))
                {
                    write_username.WriteLine(register_username);
                }
                Console.Write("Enter a password: ");
                string register_password = Console.ReadLine();
                using (StreamWriter write_password = new StreamWriter(@"password.data"))
                {
                    write_password.WriteLine(register_password);
                }
                Console.WriteLine("username, and password has been created!");
                Thread.Sleep(1000);
                running.run();
                

            }
            
           
            
            
            
        }

        public void reboot_101()
        {
            Console.WriteLine("Rebooting ToreOS...");
            Thread.Sleep(3000);
            Console.WriteLine("OS has successfully rebooted!");
            Thread.Sleep(1000);
            running.run();
        }
    }
}