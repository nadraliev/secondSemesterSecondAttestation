using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLibrary
{
    class BinaryTreeNode
    {
        protected int value { get; }

        protected BinaryTreeNode right { get; set; }
        protected BinaryTreeNode left { get; set; }

        int yParallax = 60;
        int xParallax = 20;

        public BinaryTreeNode(int value)
        {
            this.value = value;
        }

        public int AddNextNode(int value)   //returns number of levels in visited branch
        {
            int numberOfLevels = 1;
            if (value < this.value)
            {
                if (left == null)
                {
                    left = new BinaryTreeNode(value);
                    numberOfLevels++;
                }
                else numberOfLevels += left.AddNextNode(value);
            } else if (value > this.value)
            {
                if (right == null)
                {
                    right = new BinaryTreeNode(value);
                    numberOfLevels++;
                }
                else numberOfLevels += right.AddNextNode(value);
            }
            return numberOfLevels;
        }

        public List<KeyValuePair<int, float[]>> DrawNode(int width)
        {
            List<KeyValuePair<int, float[]>> result = new List<KeyValuePair<int, float[]>>();
            float[] coordiantes = new float[4]; //x, y, xParent, yParent
            coordiantes[0] = width/2;
            coordiantes[1] = yParallax;
            coordiantes[2] = width/2;
            coordiantes[3] = yParallax;
            result.Add(new KeyValuePair<int, float[]>(value, coordiantes));
            if (left != null)
            {
                result.AddRange(left.DrawLeftNode(coordiantes));
            }
            if (right != null)
            {
                result.AddRange(right.DrawRigthNode(coordiantes));
            }
            return result;
        }


        public List<KeyValuePair<int, float[]>> DrawLeftNode(float[] parentCoordinates) //calculates x negative parallax by number of rigth children 
        {
            List<KeyValuePair<int, float[]>> result = new List<KeyValuePair<int, float[]>>();
            float[] coordiantes = new float[4];
            coordiantes[0] = parentCoordinates[0] - xParallax - (right == null ? 0 : (right.ChildrenCount()+1) * xParallax);     //x 
            coordiantes[1] = parentCoordinates[1] + yParallax;                                                                   //y
            coordiantes[2] = parentCoordinates[0];                                                                               //parent x
            coordiantes[3] = parentCoordinates[1];                                                                               //parent y
            result.Add(new KeyValuePair<int, float[]>(value, coordiantes));
            if (left != null)
            {
                result.AddRange(left.DrawLeftNode(coordiantes));
            }
            if (right != null)
            {
                result.AddRange(right.DrawRigthNode(coordiantes));
            }
            return result;
        }

        public List<KeyValuePair<int, float[]>> DrawRigthNode(float[] parentCoordinates)    //calculates x positive parallax by number of left children 
        {
            List<KeyValuePair<int, float[]>> result = new List<KeyValuePair<int, float[]>>();
            float[] coordiantes = new float[4];
            coordiantes[0] = parentCoordinates[0] + xParallax + (left==null?0:(left.ChildrenCount() + 1) * xParallax);
            coordiantes[1] = parentCoordinates[1] + yParallax;
            coordiantes[2] = parentCoordinates[0];
            coordiantes[3] = parentCoordinates[1];
            result.Add(new KeyValuePair<int, float[]>(value, coordiantes));
            if (left != null)
            {
                result.AddRange(left.DrawLeftNode(coordiantes));
            }
            if (right != null)
            {
                result.AddRange(right.DrawRigthNode(coordiantes));
            }
            return result;
        }

        public int ChildrenCount()
        {
            int result = 0;
            if (left != null) result += 1 + left.ChildrenCount();
            if (right != null) result += 1 + right.ChildrenCount();
            return result;
        }

        public int CountBelowKLessX(int k, double x, int callerLevel)
        {
            int result = 0;
            if (++callerLevel > k && value < x) result++;
            if (left != null) result += left.CountBelowKLessX(k, x, callerLevel);
            if (right != null) result += right.CountBelowKLessX(k, x, callerLevel);
            return result;
        }

        public int FindMaxOnLevel(int level, int callerLevel, int currMax)
        {
            int result = currMax;
            if (++callerLevel == level)
            {
                if (result < value) result = value;
                return result;
            } else
            {
                if (left != null)
                {
                    int leftMax = left.FindMaxOnLevel(level, callerLevel, result);
                    if (leftMax > result) result = leftMax;
                }
                if (right != null)
                {
                    int rightMax = right.FindMaxOnLevel(level, callerLevel, result);
                    if (rightMax > result) result = rightMax;
                }
            }
            return result;
        }
    }
}
