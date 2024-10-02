using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            HoleWitz();

            while (true) 
            {
                Console.Write("Nächsten Witz holen? j/n  ");
                string eingabe = Console.ReadLine().ToLower();
                if (eingabe.Equals("j"))
                {
                    Console.WriteLine();
                    Console.WriteLine(HoleWitz());
                    Console.WriteLine();
                }
                else
                {
                    break;    
                }
            }
          
        }

        static string HoleWitz()
        {
            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");

            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                string jsonResponse = new StreamReader(responseStream).ReadToEnd();
               
                JArray array = JArray.Parse(jsonResponse);
                
                return array[0]["text"].ToString();
            }

            return string.Empty;
        }
    }
}