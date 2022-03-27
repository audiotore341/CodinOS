/* This is currently a beta version of CodinOS.
 * CodinOS is not an actual OS. It's just a os simulator, and
 * made for programmers who want to get an picture of what it's like
 * to make a actual programing language. */

// This is the bootloader, and setup for new users

using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

namespace OS
{
    public class Bootloader
    {
        public static Base bn = new Base();
        public static void Main(string[] args)
        {
            // Fake loading screen.
            Console.WriteLine("Booting CodinOS.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Booting CodinOS..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Booting CodinOS...");
            Thread.Sleep(1000);
            Console.Clear();

            // host os checker.
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Console.WriteLine("Sorry, but your platforum is not compatible!");
            }
            else
            {
                if (File.Exists(@"user/username.data") && File.Exists(@"user/password.data"))
                {
                    // Reads the user's username
                    using (StreamReader read_username = new StreamReader(@"user/username.data"))
                    {
                        string read_username1;
                        read_username1 = read_username.ReadLine();
                        while (true)
                        {
                            Console.WriteLine("username: " + read_username1);
                            Console.Write("password: ");
                            string verify_password = Console.ReadLine();
                            // Reads the password.
                            using (StreamReader read_password = new StreamReader(@"user/password.data"))
                            {
                                string read_password1;
                                read_password1 = read_password.ReadLine();
                                if (verify_password == read_password1)
                                {
                                    bn.run(null);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect username or password, please try again!");
                                }
                            
                            }
                        }
                    }
                    
                        
                    
                }
                else
                {
                    Console.Write("Would you like to have a user and pass? [yes/no]: ");
                    string user = Console.ReadLine();
                    if (user == "yes")
                    {
                        Console.Write("Enter a username: ");
                        string username = Console.ReadLine();
                        using (StreamWriter write_username = new StreamWriter(@"user\username.data"))
                        {
                            write_username.WriteLine(username);
                        }
                        Console.Write("Enter a password: ");
                        string password = Console.ReadLine();
                        using (StreamWriter write_password = new StreamWriter(@"user\password.data"))
                        {
                            write_password.WriteLine(password);
                        }
                        Console.WriteLine("Done!");
                        bn.run(null);
                        


                    }
                }
            }
        }
    }
}