using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._25Dz
{
    public class LuxuryGoods : ITaxable, IPrintable
    {
        public static string ClassName => "Предметы роскоши";

        public string ProductName { get; set; }

        public double Price { get; set; }

        public double AddTax()
        {
            return Price * 1.20; 
        }

        public void Print()
        {
            Console.WriteLine($"{ClassName}: Товар: {ProductName}, Цена без налога: {Price}, Цена с налогом: {AddTax()}");
        }
    }
}
