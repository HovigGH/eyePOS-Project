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
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

		private void custButton_Click(object sender, EventArgs e)
		{
			WelcomeCust welcome = new WelcomeCust();

			this.Hide();
			welcome.ShowDialog();
			this.Show();

		}

		private void empButton_Click(object sender, EventArgs e)
		{
			empForm empLogin = new empForm();

			this.Hide();
			empLogin.ShowDialog();
			this.Show();

		}
	}
}
