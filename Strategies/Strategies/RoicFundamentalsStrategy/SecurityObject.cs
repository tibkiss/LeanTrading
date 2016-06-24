﻿using System;

namespace Strategies.ROICFundamentalsStrategy
{
    public class SecurityObject
    {
        // Fields

        // ACTIVATE THESE
        //private ROIC _roic;
        //private EnterpriseValue _enterprisevalue;
        //private InvestedCapital _investedcapital;

        // DEACTIVATE THESE

        // Properties
        public string Ticker { get; set; }

        public decimal HoldingsWeight { get; set; } = 0.0m;

        // ACTIVATE THESE

        //public ROIC ROIC
        //{
        //    get { return _roic; }
        //    set
        //    {
        //        _roic = value;
        //    }
        //}

        //public EnterpriseValue EnterpriseValue
        //{
        //    get { return _enterprisevalue; }
        //    set
        //    {
        //        _enterprisevalue = value;
        //    }
        //}

        //public InvestedCapital InvestedCapital
        //{
        //    get { return _investedcapital; }
        //    set
        //    {
        //        _investedcapital = value;
        //    }
        //}

        // DEACTIVATE THESE

        public double Roic { get; set; }

        public double EnterpriseValue { get; set; }

        public double InvestedCapital { get; set; }

        public bool IsOvervalued { get; set; }

        // Methods
        public void DetermineValue(double polyA, double polyB, double polyC)
        {
            var varX = Roic;
            var varY = polyA * Math.Pow(varX, 2) + polyB * varX + polyC;
            var actualY = EnterpriseValue / InvestedCapital;

            IsOvervalued = actualY >= varY;
        }
    }
}