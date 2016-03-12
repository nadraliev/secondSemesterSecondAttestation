using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentLibrary;

namespace EquipmentShopQueryForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            method();
        }

        List<WallPanel> wallPanels;

        public void method()
        {
            int[] ex = new int[5] { 1, 4, 9, -1, 24 };
            var query =
                from num in ex
                where num > 2
                orderby num descending
                select num;
            List<int> ex2 = query.ToList<int>();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int count = random.Next(100);
            wallPanels = new List<WallPanel>();
            for (int i = 0; i < count; i++)
            {
                wallPanels.Add(new WallPanel(random.Next(100), random.Next(100), random.Next(1000), random.Next(1000)));
                generatedDataGrid.Rows.Add(new string[5] { wallPanels.Last<WallPanel>().width.ToString(), wallPanels.Last<WallPanel>().length.ToString(),
                    wallPanels.Last<WallPanel>().price.ToString(), wallPanels.Last<WallPanel>().quantity.ToString(),  (wallPanels.Last<WallPanel>().width*wallPanels.Last<WallPanel>().length*wallPanels.Last<WallPanel>().quantity).ToString()});
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            int minArea = (int)minAreaNumeric.Value;
            var query =
                from panel in wallPanels
                where panel.length * panel.width * panel.quantity >= minArea
                orderby panel.price ascending
                select panel;
            List<WallPanel> sortedWallPanels = query.ToList<WallPanel>();
            foreach (WallPanel wallpanel in sortedWallPanels)
            {
                sortedDataGrid.Rows.Add(new string[5] { wallpanel.width.ToString(), wallpanel.length.ToString(), wallpanel.price.ToString(), wallpanel.quantity.ToString(), (wallpanel.width* wallpanel.length* wallpanel.quantity).ToString() });
            }
        }
    }
}
