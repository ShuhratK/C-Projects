using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Composite
{
    public abstract class Component
    {
        public string name;

        public abstract string getName();
    }

    public class Leaf:Component
    {
        public Leaf(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }
    }

    public class Composite:Component
    {
        public List<Component> children = new List<Component>();

        public void add(Component child)
        {
            children.Add(child);
        }

        public void add(Component[] childs)
        {
            foreach (var child in childs)
            {
                children.Add(child);
            }
            
        }

        public void remove(Component child)
        {
            children.Remove(child);
        }
        /*
        public Composite(string name)
        {
            this.name = name;
        }
        */
        public override string getName()
        {
            string output = "";
            
            foreach (Component item in children)
                {
                output += " " + item.getName();
            }
            return output;
        }
    }
}
