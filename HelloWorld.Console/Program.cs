using HelloWorld.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Console
{
    public class Program
    {

        /// <summary>
        /// Write a ‘Hello World’ program.
        /// a.The program has 1 current business requirement – write “Hello World” to the
        ///         console/screen.
        /// b.The program should have an API that is separated from the program logic to eventually
        /// support mobile applications, web applications, or console applications, or windows
        /// services.
        /// c.The program should support future enhancements for writing to a database, console
        /// application, etc.
        /// i.Use common design patterns(inheritance, e.g.) to account for these future
        /// concerns.
        /// ii.Use configuration files or another industry-standard mechanism for determining
        /// where to write the information to.

        /// Write unit tests to support the API.
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome \n");
             MainAsync();
            System.Console.WriteLine("Press Enter to exit...");
            System.Console.ReadLine();
        }
        public static async Task MainAsync()
        {
            //Get the configuration setting to determine where to write to. 
            //By Default set it to Console. but Also have option to set it to DB Repo. 
            var DisplayTo = ConfigurationSettings.AppSettings["WriteTo_Location"];
            string message = "";
            //Call API to get the text to display to Conosle. 
            HttpClient client = new HttpClient();
            string path = "http://localhost:57867/api/HelloWorld"; // "http://localhost:56823/api/HelloWorld"; 
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
               message = await response.Content.ReadAsStringAsync();
            }

            CreateRepositoryFactory repo = new CreateRepositoryFactory(); 
            IRepository repository = repo.CreateRepository(DisplayTo);//new ConsoleRepository();
            repository.Write(message);

            
        }

    }
}
