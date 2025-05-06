using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._25Dz
{
    public interface IClientCafe
    {
        string FullName { get; set; }
        int HoursCount { get; set; }
        double TotalCost();

        static double HourlyRate => 100;
    }
}
