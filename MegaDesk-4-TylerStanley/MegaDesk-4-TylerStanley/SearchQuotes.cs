using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_TylerStanley
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchedQuote.Text = "";
            string[] quoteFile = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Quotes.txt");
            string material;
            string[] splitString;
            material = materialSearchBox.Text;

            //foreach (var line in strLines)
            //{
            //    if (line.Split(',')[1].Equals(material))
            //    {
            //        searchedQuote.Text = line.Split(',')[2];
            //    }
            //}
            for (int i = 0; i < quoteFile.Length; i++)
            {
                if (quoteFile[i].Contains(material))
                {
                    splitString = quoteFile[i].Split(',');
                    for (int j = 0; j < splitString.Length; j++)
                    {
                        searchedQuote.Text += splitString[j] + "\n";
                    }
                }

            }

        }
    }
}
