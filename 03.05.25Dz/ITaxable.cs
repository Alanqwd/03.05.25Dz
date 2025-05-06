using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._25Dz
{



    public interface ITaxable
    {
        string ProductName { get; set; }
        double Price { get; set; }

        double AddTax();

        static string ClassName => "Налоговые товары";
    }
}
