using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample_erik
{
    public class AndriodPhone : IMobilePhone
    {
        public void Call()
        {
            Console.WriteLine("Call with an Android phone");
        }

        public void Text()
        {
            Console.WriteLine("Texting with an Android phone");
        }
    }
}
