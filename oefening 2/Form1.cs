using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbLijst.SelectedItem.ToString());
            cbLijst.Items.RemoveAt(cbLijst.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLijst.Items.Add("Martijn");
            cbLijst.Items.Add("Benjamin");
            cbLijst.Items.Add("Koen");
            cbLijst.Items.Add("Antal");
            cbLijst.Items.Add("Yannick");
            cbLijst.Items.Add("Latha");
            cbLijst.Items.Add("Jonas");
            cbLijst.Items.Add("Machiel");
        }
    }
}
