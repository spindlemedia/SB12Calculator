﻿namespace SB12Calculator.Core
{
    public class CalculationResult
    {
        public List<CalculationResultDetail> Details { get; set; }
        public decimal CalculatedCeiling { get; set; }
    }

    public class CalculationResultDetail
    {
        public int Year { get; set; }
        public decimal StartingAmount { get; set; }
        public decimal AdditionalImprovement { get; set; }
        public int TaxableValue { get; set; }
        public decimal Reduction { get; set; }
        public decimal RunningTotal => Math.Max(StartingAmount + AdditionalImprovement - Reduction, 0);

        public string CalculationText { get; set; }
    }
}
