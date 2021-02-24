using System;
using System.Collections.Generic;
namespace danskebanktask
{
    public interface Imunicipalities
    {
        string Name { get; set; }
        public List<Daily> dailyTax { get; set; }
        public List<Weekly> weeklyTax { get; set; }
        public List<Monthly> monthlyTax { get; set; }
        public List<Yearly> yearlyTax { get; set; }
    }
}
