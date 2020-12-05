using System;
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
    public partial class LinkForm : Form
    {
        public string URL;
        public LinkForm()
        {
            InitializeComponent();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            if (urlTB.Text.Length > 0)
            {
                if (urlTB.Text.Contains("https://youtu.be/"))
                {
                    if (urlTB.Text.Replace("https://youtu.be/", "").Length > 0)
                    {
                        URL = urlTB.Text.Replace("https://youtu.be/", "");
                    }
                    else
                    {
                        MessageBox.Show("Nem írtál be az url után semmit"); return;
                    }
                        
                }
                else
                {
                    MessageBox.Show("Ez nem Tiny YouTube link");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nem írtál be semmit");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
