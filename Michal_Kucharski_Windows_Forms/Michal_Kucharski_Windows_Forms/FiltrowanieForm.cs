using System;
using System.Windows.Forms;

namespace Michal_Kucharski_Windows_Forms
{
    public partial class FilrtowanieForm : Form
    {
        public int UstawionyFiltrPredkosci { get; set; }

        public FilrtowanieForm()
        {
            InitializeComponent();
        }

        private void btnFiltruj_Click(object sender, EventArgs e)
        {
            UstawionyFiltrPredkosci = int.Parse(txtFiltrowanaPredkosc.Text);
            DialogResult = DialogResult.OK;
        }
    }
}