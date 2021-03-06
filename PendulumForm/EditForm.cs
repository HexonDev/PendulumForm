﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendulumForm
{
    public partial class EditForm : Form
    {
        public TimeSpan length;
        public EditForm()
        {
            InitializeComponent();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Biztosan szeretnéd szerkesztenini a jelenlegi diszkográfiai adatot?",
                "Szerkesztés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    length = TimeSpan.Parse(lengthTB.Text);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception exception)
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
