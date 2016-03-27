using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLibrary
{
    public class BinaryTree
    {
        private BinaryTreeNode head;
        private int levels;

        public int levelsCount { get
            {
                return levels;
            } }

        public bool empty { get
            {
                return head == null;
            }
        }

        public BinaryTree()
        {

        }

        public void Add(int value)
        {
            BinaryTreeNode newNode = new BinaryTreeNode(value);
            if (empty)
            {
                head = newNode;
                levels = 1;
            }
            else
            {
                if (levels < head.AddNextNode(value)) levels++;
            }
        }

        public List<KeyValuePair<int, float[]>> Draw()    //returns list of pairs value-coordinates
        {
            if (head != null) return head.DrawNode();
            else return null;
        }
    }
}
