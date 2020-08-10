using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_08_2020_ma_oefeningen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            lbLijst.Items.Add(txtInput.Text);

            if (lbLijst.Items.Count >= 5)
            {
                txtInput.Enabled = false;
                btnToevoegen.Enabled = false;
            }
            else
            {
                txtInput.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnToevoegen_Click(sender, e);
            }
        }
    }
}
