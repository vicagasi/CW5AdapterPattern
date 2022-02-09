using System;

namespace CW5AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BearFactory.Grizzly grizzly = new BearFactory.Grizzly();
            BearFactory.TeddyBear teddy = new BearFactory.TeddyBear();
            BearFactory.BearAdapter adaptedTed = new BearFactory.BearAdapter(grizzly);

            grizzly.maul();
            grizzly.hibernate();

            teddy.hug();

            adaptedTed.hug();
        }
    }
}
