using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample_erik
{
    public class GooglePhone : IMobilePhone
    {
        public void Call()
        {
            Console.WriteLine("Making a call with a Googlephone");
        }

        public void Text()
        {
            Console.WriteLine("Making a text with a Google phone");
        }
    }
}
