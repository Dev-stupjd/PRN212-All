using System.Diagnostics;
using System.Xml.Linq;

namespace Demo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input First Product: ");
            Product pd1 = Input();
            Console.WriteLine("============================= ");
            Console.WriteLine("Input Second Product: ");
            Product pd2 = Input();
            Console.WriteLine("============================= ");
            Console.WriteLine();
            Console.WriteLine("Display Product: ");
            Console.WriteLine("First product: ");
            pd1.display();
            Console.WriteLine();
            Console.WriteLine("Second product: ");
            pd2.display();

        }


        public static Product Input()
        {
            Console.Write("Input name: ");
            var name = Console.ReadLine();
            while (true)
            {
                try
                {                   
                    Console.Write("Input price: ");
                    var price = int.Parse(Console.ReadLine());
                    if (price < 0) throw new Exception("Price must be greater than 0");
                    Console.Write("Want this have discount? (y/n): ");
                    var isDiscount = Console.ReadLine();
                    if (isDiscount == "y" || isDiscount == "Y")
                    {
                        Console.Write("Input discount: ");
                        var discount = float.Parse(Console.ReadLine());
                        if (name != null)
                        {
                            if (discount > 0)
                            {
                                return new Product(name, price, discount);
                            }
                            else throw new Exception("Discount must be greater than 0");
                        }
                    } else return new Product(name, price);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Discount must be a number");
                }
            }
        }
    }
}


