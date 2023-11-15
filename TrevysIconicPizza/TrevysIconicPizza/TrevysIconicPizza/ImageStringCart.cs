using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class ImageStringCart
    {
        public string Order { get; set; }
        public Image Image { get; set; }
        public ImageStringCart(string order, Image image) 
        { 
            Order = order;
            Image = image;
        }
        public string ToString()
        {
            return Order;
        }
    }
}
