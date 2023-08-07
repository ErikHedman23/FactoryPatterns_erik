using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample_erik
{
    public class ApplePhone : IMobilePhone //follows the contract of being able to call and text
    {
        public void Call()
        {
            Console.WriteLine("Making a call with and IPhone.");
        }

        public void Text()
        {
            Console.WriteLine("Making a text");
        }
    }
}
