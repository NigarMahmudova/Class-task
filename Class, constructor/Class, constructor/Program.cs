using System;

namespace Class__constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrayin uzunlugunu daxil edin...");
            int length = Convert.ToInt32(Console.ReadLine());
            Notebook[] notebooks = new Notebook[length];

            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.WriteLine("Mehsulun brendi:");
                string brand = Console.ReadLine();

                Console.WriteLine("Mehsulun modeli:");
                string model = Console.ReadLine();

                double price;
                do
                {
                    Console.WriteLine("Mehsulun qiymeti:");
                    price = Convert.ToDouble(Console.ReadLine());

                } while (price<0);

                Notebook notebook = new Notebook(brand,model,price);
                notebooks[i] = notebook;
            }
            
            foreach (var item in notebooks)
            {
                Console.WriteLine(item.ShowInfo());
                
            }

            var avarageOfPrices = Avg(notebooks);
            Console.WriteLine("Mehsullarin qiymetlerinin ededi ortasi:" + avarageOfPrices);
           
        }
        static double Avg(Notebook[] notebooks)
        {
            double sum = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                sum += notebooks[i].Price;
            }
            double avg = sum / notebooks.Length;
            return avg;
        }
    }
}
