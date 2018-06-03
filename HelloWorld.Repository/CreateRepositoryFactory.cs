using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Repository
{
    public class CreateRepositoryFactory : CreateAbstractRepositoryFactory
    {
        public override IRepository CreateRepository(string type)
        {
            switch (type)
            {
                case "Console": return new ConsoleRepository();
                case "Database": return new DBRepository();
                default: throw new Exception("Repository is Not created successfully"); 

            }
        }
    }
}
