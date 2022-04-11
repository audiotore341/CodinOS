using System;
using System.Threading;
/* NOTE: This os is still in testing beta! please put some Idea's in the issues tab
 * of the github, who know's you may get your idea in the program! */


namespace OS
{
    public class filex
    {
        public static void fileX()
        {
            while (true)
            { 
            // For the downloads area.
            string download_place1 = "";
            string download_place2 = "";
            string download_place3 = "";
            string download_place4 = "";
            string download_place5 = "";
            string download_place6 = "";
            string download_place7 = "";
            string download_place8 = "";
            string download_place9 = "";
            string download_place10 = "";
            Console.WriteLine("==============");
            Console.WriteLine("|1.) Downloads|");
            Console.WriteLine("|2.) Documents|");
            Console.WriteLine("|3.) About    |");
            Console.WriteLine("===============");
            string fileX_select = Console.ReadLine();
                if (fileX_select == "1")
                {


                    Console.WriteLine("====================================================");
                    Console.WriteLine("| " + download_place1 + " " + download_place2 + "|");
                    Console.WriteLine("| " + download_place3 + " " + download_place4 + "|");
                    Console.WriteLine("| " + download_place5 + " " + download_place6 + "|");
                    Console.WriteLine("| " + download_place7 + " " + download_place8 + "|");
                    Console.WriteLine("| " + download_place9 + " " + download_place10 + "|");
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Press any key to go back.");
                    Console.ReadKey();




                }
                else if (fileX_select == "2")
                {
                    string doc_place1 = "";
                    string doc_place2 = "";
                    string doc_place3 = "";
                    string doc_place4 = "";
                    string doc_place5 = "";
                    string doc_place6 = "";
                    string doc_place7 = "";
                    string doc_place8 = "";
                    string doc_place9 = "";
                    string doc_place10 = "";

                    Console.WriteLine("====================================================");
                    Console.WriteLine("| " + doc_place1 + " " + doc_place2 + "|");
                    Console.WriteLine("| " + doc_place3 + " " + doc_place4 + "|");
                    Console.WriteLine("| " + doc_place5 + " " + doc_place6 + "|");
                    Console.WriteLine("| " + doc_place7 + " " + doc_place8 + "|");
                    Console.WriteLine("| " + doc_place9 + " " + doc_place10 + "|");
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Press any key to go back.");
                    Console.ReadKey();

                }

                else if (fileX_select == "3")
                {
                    Console.WriteLine("                      about page.");
                    Console.WriteLine("========================================================");
                    Console.WriteLine("fileX is CodinOS's file!");
                    Console.WriteLine("This feature is still in beta, and I would love it if");
                    Console.WriteLine("you put some ideas in the issues tab of the github page!");
                    Console.WriteLine("========================================================");
                    Console.WriteLine("Press any key to go back.");
                    Console.ReadKey();
                }

            }
            
        }
    }
}