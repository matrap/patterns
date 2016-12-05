using System.Collections.Generic;

namespace Composite
{
    public class CompositePrinter : IPrinter
    {
        private List<IPrinter> _children;

        public CompositePrinter()
        {
            _children = new List<IPrinter>();
        }
             
        public void Print()
        {
            foreach(IPrinter leaf in _children)
            {
                leaf.Print();
            }
        }

        public void Add(IPrinter leaf)
        {
            _children.Add(leaf);
        }

        public void Remove(IPrinter leaf)
        {
            _children.Remove(leaf);
        }

        public IEnumerable<IPrinter> GetChild()
        {
            return _children;
        }
    }
}
