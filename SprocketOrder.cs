using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrtizP5
{
    public class SprocketOrder
    {
        public List<Sprocket> Items { get; private set; }
        public string CustomerName { get; set; }
        public Address Address { get; set; }
        public decimal TotalPrice { get; private set; }

        public SprocketOrder()
        {
            Items = new List<Sprocket>();
        }

        public SprocketOrder(string customerName, Address address, List<Sprocket> items) : this()
        {
            CustomerName = customerName;
            Address = address;
            Items = items;
            CalculateTotalPrice();
        }

        public void AddItem(Sprocket sprocket)
        {
            Items.Add(sprocket);
            CalculateTotalPrice();
        }

        public void RemoveItem(Sprocket sprocket)
        {
            Items.Remove(sprocket);
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = Items.Sum(item => item.Price);
        }

        public override string ToString()
        {
            string addressString = Address != null ? $"Ship to: {Address}" : "Local Pickup";
            return $"{CustomerName}: {Items.Count} items, Total Price: ${TotalPrice}\n{addressString}";
        }
    }

}
