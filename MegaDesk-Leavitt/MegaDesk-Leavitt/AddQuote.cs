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
    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            //surfaceMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void AddQuote_Shown(object sender, EventArgs e)
        {
            date_actual.Text = DateTime.Now.ToString("d MMMM yyyy");
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            
        }

        private void addQuote_formClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
