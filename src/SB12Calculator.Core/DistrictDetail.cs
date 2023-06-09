﻿namespace SB12Calculator.Core
{
    public class DistrictDetail
    {
        public string DistrictId { get; set; }
        public string DistrictName { get; set;}
        public List<DistrictRateDetail> Rates { get; set; }
    }

    public class DistrictRateDetail
    {
        public int Year { get; set; }
        //Compressed M&O rate for 2018, MCR for 2019+
        public decimal MaximumCompressedRate { get; set; }
        public decimal ActualMORate { get; set; }
    }
}