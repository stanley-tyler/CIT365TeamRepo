﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk_3_TylerStanley
{
    class DeskQuote : Desk
    {
        public int deskQuote { get; set; }
        public DateTime quoteDate { get; set;}

        public int BASEPRICE = 200;
        private int BASESIZE = 1000;
        private int DRAWERCOST = 50;
        

     public int calcPriceQuote()
        {

        
            return 0; ;
        }

    }
}
