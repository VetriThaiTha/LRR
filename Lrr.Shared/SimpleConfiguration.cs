﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lrr.Shared
{
    public class SimpleConfiguration : Configuration, IConfiguration, ISimpleConfiguration
    {
        public SimpleConfiguration() : base()
        {
            StartingValueMultiple = 1.5;
        }
        public double StartingValueMultiple { get; set; }

        public override double GetStartingValueMultiple(int regValue)
        {
            return StartingValueMultiple;
        }
    }
    public abstract class Configuration : IConfiguration
    {
        public Configuration()
        {
            StampChargePercentage = 0.07;
            RegistrationChargePercentage = 0.01;
            AuctionDuration = 3;
            
            

            /* Give up Ratios*/
            GiveUpProvBuyerIncentiveRatio = 0.2;
            GiveUpSellerIncentiveRatio = 0.6;
            Brokerage = 0.02;

            /* Match price Ratios*/
            MatchBidderIncentiveRatio = 0.1;
            MatchSellerIncentiveRatio= 0.6;
        }

        public double StampChargePercentage { get; set; }
        public double RegistrationChargePercentage { get; set; }

        public int AuctionDuration { get; set; }
        
        

        public double GiveUpProvBuyerIncentiveRatio { get; set; }
        public double GiveUpSellerIncentiveRatio { get; set; }
        public double Brokerage { get; set; }

        public double MatchSellerIncentiveRatio { get; set; }
        public double MatchBidderIncentiveRatio { get; set; }

        public abstract double GetStartingValueMultiple(int regValue);
        
    }
}
