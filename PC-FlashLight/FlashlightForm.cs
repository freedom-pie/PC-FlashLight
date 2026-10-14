using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PC_FlashLight
{
    public partial class FlashlightForm : Form
    {
        public FlashlightForm(Color lightColor)
        {
            InitializeComponent();
            this.BackColor = lightColor;
        }



        private void FlashlightForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
