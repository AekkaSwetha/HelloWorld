using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Repository
{
    public class ConsoleRepository : IRepository
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
