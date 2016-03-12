using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentLibrary
{
    public class WallPanel
    {

        public int width { get; set; }
        public int length { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }


        public WallPanel(int width, int length, int price, int quantity)
        {
            this.width = width;
            this.length = length;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
