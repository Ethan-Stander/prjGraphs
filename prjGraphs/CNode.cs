using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGraphs
{
    public class CNode<T>
    {
        public int id; 
        public LinkedList<CNode<T>> children = new LinkedList<CNode<T>>();
        T data;

        public CNode(int id, T data)
        {
            this.id = id;
            this.data = data;
        }
    }
}
