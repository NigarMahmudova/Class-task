using System;

namespace Academy_tasks_6
{
    class Human
    {
        public string Name;
        public string Surname;
        public int Age;
        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.Name = "Nigar";
            human1.Surname = "Mahmudova";
            human1.Age = 23;
            Console.WriteLine(human1.GetFullName());

            Student student1 = new Student
            {
                FullName = "Nigar Mahmudova",
                GroupNo = "P231",
                Point = 100
            };

            Console.WriteLine(student1.IsGraduated());

            Product[] products = new Product[3];
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Mehsulun adini daxil edin...");
                string name = Console.ReadLine();

                Console.WriteLine("Mehsulun qiymetini daxil edin...");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Endirim faizini daxil edin...");
                int discountPercant = Convert.ToInt32(Console.ReadLine());

                Product product = new Product(name, price, discountPercant);
                products[i] = product;
            }
            foreach (var item in products)
            {
                Console.WriteLine(item.Name+ " " +item.Price);
            }
        }
       
        static bool HasName(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            if (!Char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length ; i++)
            {
                if (!Char.IsLower(str[i]))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
