using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_TylerStanley
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuote = new AddQuote();
            addNewQuote.Show();
            
        }

        private void searchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes addNewSearch = new SearchQuotes();
            addNewSearch.Show();
        }
    }
}
