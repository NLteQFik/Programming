using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR8
{
    internal class CargoCompany
    {
        private List<Tariff>? ListTariffs = new List<Tariff>();

        public void AddTarrif(Tariff tariff) => ListTariffs.Add(tariff);

        public string FindMinimalTariff()
        {
            return ListTariffs.Min().Name;
        }
    }
}