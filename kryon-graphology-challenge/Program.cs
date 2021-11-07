﻿using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using kryongraphologychallenge.Helpers;
using Newtonsoft.Json.Linq;

namespace kryon_graphology_challenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //   /$$   /$$                                        
            //  | $$  /$$/                                        
            //  | $$ /$$/   /$$$$$$  /$$   /$$  /$$$$$$  /$$$$$$$ 
            //  | $$$$$/   /$$__  $$| $$  | $$ /$$__  $$| $$__  $$
            //  | $$  $$  | $$  \__/| $$  | $$| $$  \ $$| $$  \ $$
            //  | $$\  $$ | $$      | $$  | $$| $$  | $$| $$  | $$
            //  | $$ \  $$| $$      |  $$$$$$$|  $$$$$$/| $$  | $$
            //  |__/  \__/|__/       \____  $$ \______/ |__/  |__/
            //                       /$$  | $$                    
            //                      |  $$$$$$/                    
            //                       \______/                     

            // TODO: STAGE 1 - read and understand what this code is suppose to do //
            string[] paths = { "demo-image-1.jpeg", "demo-image-2.jpeg", "demo-image-3.jpeg", "demo-image-4.jpeg", "demo-image-5.jpeg" };

            foreach (string path in paths) {
                Console.WriteLine("\nReading challenge file " + path + "...\n");
                var process = HandwritingAnalyzer.ReadHandwrittenText("./Image-files/" + path);
                process.Wait();
                JToken result = process.Result;
                // TODO: STAGE 2 - fixed the code so it prints the wanted results //
                // WANT TO ANALYZE HUGE AMOUNTS OF TEXT 
                // AND UTILIZE IT TO PARTICIPATE THE NEXT
                // INDUSTRIAL REVOLUTION? 
                Console.WriteLine(result.ToString());
            }

            // TODO: STAGE 3 - find the connections between the outputs above //
            Console.WriteLine("\nCan you find the connection between the outputs above?");

            Console.WriteLine("\nAll these people were leaders, that grounded/expanded US/Russian Empire in 18 century");

            // TODO: STAGE 4 - submit your answers, repo and CV, and join us for a cup of coffee //
            Console.WriteLine("\nSend us your solution with the github repo and your CV to challenge@kryonsystems.com and wait for our call!\n");
            Console.ReadLine();
        }
    }
}
