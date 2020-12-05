using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendulumForm
{
    static class Error
    {
        public static void Show(Exception e)
        {
            DialogResult result = MessageBox.Show($"Hiba a futás közben! {Environment.NewLine} {e.Message} {Environment.NewLine} A program bezárul",
                "Hiba",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }
    }
}
