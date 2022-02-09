using System;
using System.Collections.Generic;
using System.Text;

namespace CW5AdapterPattern
{
    class BearFactory
    {
        abstract public class Bear{
            abstract public void maul();
            abstract public void hibernate();
        }

        abstract public class ToyBear
        {
            abstract public void hug();
        }

        public class Grizzly : Bear
        {
            override public void maul()
            {
                Console.WriteLine("The customer was mauled by the bear");
            }
            override public void hibernate()
            {
                Console.WriteLine("The customer is bored because the bear hibernating");
            }
        }

        public class TeddyBear : ToyBear
        {
            override public void hug()
            {
                Console.WriteLine("The customer hugs the teddy bear!");
            }
        }

        public class BearAdapter
        {
            private readonly Grizzly grizzly;
            public BearAdapter(Grizzly grizzly)
            {
                this.grizzly = grizzly;
            }

            public void hug()
            {
                this.grizzly.maul();
            }
        }
    }
}
