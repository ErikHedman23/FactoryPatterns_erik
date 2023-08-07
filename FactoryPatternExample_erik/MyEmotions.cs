using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample_erik
{
    public class MyEmotions : AbstractExample
    {
        public override void WhatIsYourEmotion()
        {
            Console.WriteLine("sadness");
        }
        public override void MyCurrentEmotion()
        {
            base.MyCurrentEmotion();
        }
    }
}
