using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_3_TylerStanley
{
    public partial class AddQuote : Form
    {
        
        int width = 0;
        int depth = 0;
        int drawers = 0; //number of desk drawers
        int price = 0;
        int materialCost = 0;
        int[,] rushOrderArray = new int[3,3];
        int rushCost = 0;
        int squareFeet;
        string material;
        string customerName;
        string rushOrder;
        string[] lines = new string[7];
        DeskVariable cDesk = new DeskVariable();
        List<DesktopMaterial> dMaterial = new List<DesktopMaterial>();
        DeskQuote test = new DeskQuote();
        

        public AddQuote()
        {
            InitializeComponent();
            dMaterial.Add(DesktopMaterial.Oak);
            dMaterial.Add(DesktopMaterial.Laminate);
            dMaterial.Add(DesktopMaterial.Pine);
            dMaterial.Add(DesktopMaterial.Rosewood);
            dMaterial.Add(DesktopMaterial.Veneer);
            materialTextBox.DataSource = dMaterial;

        }

        //parses the users input data
        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                rushOrderArray = test.GetRushOrder();
                cDesk.Width = int.Parse(widthTextBox.Text);
                cDesk.Depth = int.Parse(depthTextBox.Text);
                squareFeet = cDesk.Width * cDesk.Depth;
                cDesk.NumDrawers = int.Parse(numDrawersTextBox.Text);
                width = int.Parse(widthTextBox.Text);
                depth = int.Parse(depthTextBox.Text);
                drawers = int.Parse(numDrawersTextBox.Text);
                material = materialTextBox.Text;
                customerName = customerNameTextBox.Text;
                rushOrder = rushOrderOptionTextBox.Text;

                switch (rushOrder)
                {
                    case "3 day":
                        if (squareFeet < 1000)
                        {
                            rushCost = rushOrderArray[0, 0];
                        }
                        else if(squareFeet >= 1000 && squareFeet < 2000 )
                        {
                            rushCost = rushOrderArray[0, 1];
                        }
                        else if (squareFeet > 2000)
                        {
                            rushCost = rushOrderArray[0, 2];
                        }
                        break;
                    case "5 day":
                        if (squareFeet < 1000)
                        {
                            rushCost = rushOrderArray[1, 0];
                        }
                        else if (squareFeet >= 1000 && squareFeet < 2000)
                        {
                            rushCost = rushOrderArray[1, 1];
                        }
                        else if (squareFeet > 2000)
                        {
                            rushCost = rushOrderArray[1, 2];
                        }
                        break;
                    case "7 day":
                        if (squareFeet < 1000)
                        {
                            rushCost = rushOrderArray[2, 0];
                        }
                        else if (squareFeet >= 1000 && squareFeet < 2000)
                        {
                            rushCost = rushOrderArray[2, 1];
                        }
                        else if (squareFeet > 2000)
                        {
                            rushCost = rushOrderArray[2, 2];
                        }
                        break;
                    default:
                        break;
                }


                price = ((200 + (cDesk.Width * cDesk.Depth) + (50 * drawers)) + (int)dMaterial[0]) + rushCost;
                string priceString = price.ToString();
                lines[4] = widthTextBox.Text;
                lines[1] = depthTextBox.Text;
                lines[2] = numDrawersTextBox.Text;
                lines[3] = materialTextBox.Text;
                lines[5] = rushOrderOptionTextBox.Text;
                lines[6] = priceString;
                lines[0] = customerNameTextBox.Text;


                string csv = JsonConvert.SerializeObject(lines, Formatting.Indented);
                //string.Format("{0},{1},{2},{3},{4},{5},{6}\n", lines[0], lines[1], lines[2], lines[3], lines[4], lines[5], lines[6]);

                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Quotes.json", csv);
            }
            catch(Exception)
            {
                throw;
            }
            

    }

        private void ValidateWidthInput(object sender, CancelEventArgs e)
        {
            int w;            
            if (int.TryParse(widthTextBox.Text, out w))
            {
                if (w > 96 || w < 24)
                {
                    widthTextBox.Text = "";
                    MessageBox.Show("Please enter a value between 24 and 96 inches");
                    widthTextBox.Focus();
                }
            }           
        }

        private void ValidateNumofDrawers(object sender, CancelEventArgs e)
        {

        }

        private void ValidateName(object sender, CancelEventArgs e)
        {

        }

        private void ValidateDepthInput(object sender, KeyPressEventArgs e)
        {
            int d;
            if (int.TryParse(depthTextBox.Text, out d))
            {
                if (d > 48 || d < 12)
                {
                 
                    
                }
                
            }
        }
    }
}
