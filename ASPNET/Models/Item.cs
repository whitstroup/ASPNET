using System;
namespace ASPNET.Models
{
    public class Item
    {
        public Item()
        {
        }

        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
