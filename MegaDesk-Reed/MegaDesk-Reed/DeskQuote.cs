using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Reed
{
    class DeskQuote
    {
        public const int PRICEPERDRAWER = 50;
        public const int BASEPRICE = 200;
        public string custName { get; set; }
        public string rush { get; set; }
        public string date { get; set; }

        int calculateShip(string rush, int SurfaceArea)
        {
            int shipCost = 0;
            if (rush == "3 day")
            {
                if (SurfaceArea < 1000)
                    shipCost = 60;
                else if (SurfaceArea > 1000 && SurfaceArea < 2000)
                    shipCost = 70;
                else if (SurfaceArea > 2000)
                    shipCost = 80;
            }
            else if (rush == "5 day")
            {
                if (SurfaceArea < 1000)
                    shipCost = 40;
                else if (SurfaceArea > 1000 && SurfaceArea < 2000)
                    shipCost = 50;
                else if (SurfaceArea > 2000)
                    shipCost = 60;
            }
            else if (rush == "7 day")
            {
                if (SurfaceArea < 1000)
                    shipCost = 30;
                else if (SurfaceArea > 1000 && SurfaceArea < 2000)
                    shipCost = 35;
                else if (SurfaceArea > 2000)
                    shipCost = 40;
            }
            else
            {
                shipCost = 0;
            }
            return shipCost;
        }
        double CalculateCost(int SurfaceArea)
        {
            int bigDeskCost = 0;
            if (SurfaceArea > 1000)
            {
                bigDeskCost = SurfaceArea - 1000;
            }
            else
            {
                bigDeskCost = 0;
            }
            double cost = BASEPRICE + bigDeskCost; // + (PRICEPERDRAWER * desk.drawers) + MaterialPrice
            return cost;
        }
    }
}

