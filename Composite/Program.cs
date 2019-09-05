using Composite.BL;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure 

            //Elemento raiz
            CompositeElement root =
              new CompositeElement("Picture");

            //Nivel 1
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));
            root.Add(new PrimitiveElement("Purple Triangle"));
            // Create a branch
            //Nivel 2
            CompositeElement comp =
              new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            //level 3
            CompositeElement lvl3 = new CompositeElement("Two Triangle");
            lvl3.Add(new PrimitiveElement("Coral Triangle"));
            lvl3.Add(new PrimitiveElement("Cyan Triangle"));
            comp.Add(lvl3);

            // Add and remove a PrimitiveElement

            PrimitiveElement pe =
              new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }
}
