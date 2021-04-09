using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainsProject.Application
{
    public class NameClass
    {
        static private string name;
        public void setName(string newName)
        {
            name = newName;
        }
        public string getName()
        {
            return name;
        }
    }
}
