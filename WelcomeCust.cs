using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class WelcomeCust : Form
    {
        public WelcomeCust()
        {
            InitializeComponent();
        }

		private void startScanning()
		{
			CustForm1 scanning = new CustForm1();

			this.Hide();

			scanning.ShowDialog();
			this.Close();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			//go to new cust menu
			startScanning();

		}

		private void btnExist_Click(object sender, EventArgs e)
		{
			//do old cust things
			startScanning();

		}
	}
}
