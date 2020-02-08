using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Leavitt
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void button_addNewQuote(object sender, EventArgs e)
        {
            var addQuote = new AddQuote(this);
            addQuote.Show();
            this.Hide();
        }

        private void button_viewQuotes(object sender, EventArgs e)
        {
            var viewQuote = new ViewAllQuotes(this);
            viewQuote.Show();
            this.Hide();
        }

        private void button_searchQuote(object sender, EventArgs e)
        {
            var searchQuote = new SearchQuotes(this);
            searchQuote.Show();
            this.Hide();
        }

        private void button_exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
