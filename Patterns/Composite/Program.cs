using CompositePattern;
using System;
using System.Collections;

namespace CompositeExample
{
    class MainApp
    {
        static void Main()
        {
            Component root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));
            Component comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);
            root.Add(new Leaf("Leaf C"));
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            root.Display(1);
            Console.Read();
        }
    }
}

