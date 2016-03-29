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

        public List<KeyValuePair<int, float[]>> Draw(int width)    //returns list of pairs value-coordinates
        {
            if (head != null) return head.DrawNode(width);
            else return null;
        }

        public int CountBelow(int k, double x)
        {
            if (k >= levels) return 0;
            else if (head != null) return head.CountBelowKLessX(k, x, 0);
            else return 0;
        }

        public int FindMaxOnLevel(int level)
        {
            if (level > levels) return -1;
            else if (head != null) return head.FindMaxOnLevel(level, 0, 0);
            else return -1;
        }
    }
}
