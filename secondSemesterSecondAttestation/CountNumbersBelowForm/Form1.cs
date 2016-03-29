using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeLibrary;

namespace CountNumbersBelowForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
        }

        int maxTreeSize = 30;
        BinaryTree binaryTree;

        private void generateBtn_Click(object sender, EventArgs e)
        {
            GenerateTree();
            DrawTree(binaryTree);
            GatherAndCountBelow();
            GatherAndFindMax();
        }

        private void GenerateTree()
        {
            Random random = new Random();
            binaryTree = new BinaryTree();
            for (int i = 0; i <= maxTreeSize; i++)
            {
                binaryTree.Add(random.Next(100));
            }
        }

        private void DrawTree(BinaryTree source)
        {
            List<KeyValuePair<int, float[]>> drawingData = source.Draw(this.Width);

            Graphics graphics = mainPanel.CreateGraphics();
            graphics.Clear(this.BackColor);
            Pen linePen = new Pen(Color.Black);
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new
                SolidBrush(Color.White);
            SolidBrush circleBrush = new
                SolidBrush(Color.Purple);
            int xParallaxNumberCenter = 15;
            int yParallaxNumberCenter = 10;
            int circleDiameter = 30;
            int yParallaxCircle = 5;
            int xParallaxCircle = 5;
            foreach (KeyValuePair<int, float[]> node in drawingData)  //draw lines first to hide it under circles
            {
                graphics.DrawLine(linePen, node.Value[2] + xParallaxNumberCenter, node.Value[3] + yParallaxNumberCenter, node.Value[0] + xParallaxNumberCenter, node.Value[1] + yParallaxNumberCenter);
            }
            foreach (KeyValuePair<int, float[]> ex in drawingData)
            {
                graphics.DrawEllipse(linePen, ex.Value[0], ex.Value[1] - yParallaxCircle, circleDiameter, circleDiameter);
                graphics.FillEllipse(circleBrush, ex.Value[0], ex.Value[1] - yParallaxCircle, circleDiameter, circleDiameter);
                graphics.DrawString(ex.Key.ToString(), drawFont, drawBrush, ex.Value[0], ex.Value[1]);
            }
        }

        private void mainForm_Size_Changed(object sender, EventArgs e)
        {
            mainPanel.Width = this.Width;
            mainPanel.Height = this.Height;
            mainPanel.Update();
            maxTreeSize = this.Width / 45;
            if (binaryTree != null)
            DrawTree(binaryTree);
        }

        private void inputXNumeric_ValueChanged(object sender, EventArgs e)
        {
            GatherAndCountBelow();
        }

        private void inputKNumeric_ValueChanged(object sender, EventArgs e)
        {
            GatherAndCountBelow();
        }

        private void GatherAndCountBelow()
        {
            int k = (int)inputKNumeric.Value;
            double x = (double)inputXNumeric.Value;
            if (binaryTree != null) countBeloxResultLabel.Text = binaryTree.CountBelow(k, x).ToString();
        }

        private void inputLevelNumeric_ValueChanged(object sender, EventArgs e)
        {
            GatherAndFindMax();
        }

        private void GatherAndFindMax()
        {
            if (binaryTree != null)
            {
                int max = binaryTree.FindMaxOnLevel((int)inputLevelNumeric.Value);
                if (max != -1)
                    maxResultLabel.Text = max.ToString();
                else maxResultLabel.ResetText();
            }
        }
    }
}
