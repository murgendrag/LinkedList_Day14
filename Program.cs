using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
    class Program
    {
        static void  Main (string[] args)
        {
            Linkedlist1 linkedlist = new Linkedlist1();

            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(70);
            linkedlist.Display();
            linkedlist.InsertAtParticularPosition(1, 12);
        }
    }
}

