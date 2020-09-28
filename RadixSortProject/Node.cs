using System;
using System.Collections.Generic;
using System.Text;

namespace RadixSortProject
{
    class Node
    {
        public int info;
        public Node link;
        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}
