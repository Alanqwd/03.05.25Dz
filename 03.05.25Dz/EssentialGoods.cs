using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._25Dz
{
    public class EssentialGoods : ITaxable, IPrintable
    {  



        public static string ClassName => "Предметы первой необходимости";

        public string ProductName { get; set; }

        public double Price { get; set; }



        public double AddTax()
        {
            return Price * 1.005; 
        }

        public void Print()

        {
            Console.WriteLine($"{ClassName}: Товар: {ProductName}, Цена без налога: {Price}, Цена с налогом: {AddTax()}");
        }


    }
}
