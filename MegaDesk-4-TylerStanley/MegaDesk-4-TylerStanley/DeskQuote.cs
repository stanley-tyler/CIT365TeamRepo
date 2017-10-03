using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_TylerStanley
{
    class DeskQuote : Desk
    {
        public int deskQuote { get; set; }
        public DateTime quoteDate { get; set;}
        
        public int BASEPRICE = 200;
        private int BASESIZE = 1000;
        private int DRAWERCOST = 50;
        

     public int[,] GetRushOrder()
        {
            int rows = 3;
            int columns = 3;
            int[,] grid = new int[rows, columns];
            int count = 0;
 
            try
            {
                string[] array = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\RushOrderPrices.txt");
                for (int i = 0; i != rows; i++)
                {
                    for (int j = 0; j != columns; j++)
                    {
                        grid[i, j] += int.Parse(array[count]);
                        count++;
                    }
                }
                return grid;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
