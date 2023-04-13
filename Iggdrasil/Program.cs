using System;

namespace Iggdrasil
{
    class Program
    {
        static void Main(string[] args)
        {
            Derevo tree = new Derevo();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);

            bool result = tree.Search(3);
            
        }
    }
}
