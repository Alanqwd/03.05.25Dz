using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._25Dz
{
    public class KilometersToMilesConverter : IConverter, IPrintable
    {
        public string FromScale { get; } = "Километры";
        public string ToScale { get; }  = "Мили"; 

        public double Convert(double kilometers)
        {
            return kilometers * 0.621371; 
        }

        public void Print()
        {
            Console.WriteLine($"Конвертация из: {FromScale} в: {ToScale}");
        }
    }
}
