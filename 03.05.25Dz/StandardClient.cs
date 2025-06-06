﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._25Dz
{
    public class StandardClient : IClientCafe, IPrintable
    {
        private const double HourlyRate = 100;
        public string FullName { get; set; }
        public int HoursCount { get; set; }

        public double TotalCost()
        {
            return HoursCount * HourlyRate;
        }

        public void Print()
        {
            Console.WriteLine($"ФИО: {FullName}, Часы: {HoursCount}, Стоимость: {TotalCost()}");
        }
    }
}
