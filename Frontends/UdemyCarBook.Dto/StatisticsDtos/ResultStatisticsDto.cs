using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int CarCount { get; set; }
        public int LocationCount { get; set; }
        public int AuthorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgPriceForDaily { get; set; }
        public decimal avgRentPriceForWeekly { get; set; }
        public decimal avgRentPriceForMonthly { get; set; }
        public int carCountByTransmissionIsAuto { get; set; }
        public int carCountByKmSmallerThen1000 { get; set; }
        public int carCountByFuelGasolineOrDiesel { get; set; }
        public int carCountByFuelElectric { get; set; }
        public string carBrandAndModelByRentPriceDailyMax { get; set; }
        public string carBrandAndModelByRentPriceDailyMin { get; set; }
        public string brandNameByMaxCar { get; set; }
        public string blogTitleByMaxBlogComment { get; set; }
    }
}
