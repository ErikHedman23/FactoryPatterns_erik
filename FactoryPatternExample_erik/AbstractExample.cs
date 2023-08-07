using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample_erik
{
    public abstract class AbstractExample
    {
        public string emotion = "happy";
        public bool areYouHappy { get; set; }
        public abstract void WhatIsYourEmotion();
        public virtual void MyCurrentEmotion()
        {
            Console.WriteLine("I am always happy!");
        }
    }
}
