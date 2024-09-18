using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Product
    {
        private string _name;
        private double _price;
        private double _discount;

        public void setName(string name)
        {
            _name = name;
        }

        public string getName()
        {
            return _name;
        }

        public void setPrice(double price)
        {
            _price = price;
        }

        public double getPrice()
        {
            return _price;
        }

        public void setDiscount(double discount)
        {
            _discount = discount;
        }

        public double getDiscount()
        {
            return _discount;
        }

        public Product(string name, int price, float discount)
        {
            _name = name;
            _price = price;
            _discount = discount;
        }

        public Product(string name, int price)
        {
            _name = name;
            _price = price;
            _discount = 0;
        }

        private double getImportTax()
        {
            return _price * 0.1;
        }

        public void display()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Price: " + _price);
            Console.WriteLine("Discount: " + _discount);
            Console.WriteLine("Import Tax: " + getImportTax());
        }
        
    }
}
