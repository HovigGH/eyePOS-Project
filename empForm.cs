﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class empForm : Form
    {
        public empForm()
        {
            InitializeComponent();
        }

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			// add options for admin and user designation

			EmpForm1 menu = new EmpForm1();
			this.Hide();
			menu.ShowDialog();
			this.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtPassword.Clear();
			txtUserName.Clear();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
