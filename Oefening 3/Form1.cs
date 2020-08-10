using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<string> naamLijst = new List<string>();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbLijst.Items.Clear();
            foreach (var item in naamLijst)
            {
                if (item.ToLower().Contains(txtSearchText.Text.ToLower()))
                {
                    lbLijst.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            naamLijst.Add("An");
            naamLijst.Add("Bart");
            naamLijst.Add("Cedric");
            naamLijst.Add("Dieter");
            naamLijst.Add("Evert");
            naamLijst.Add("filip");
            naamLijst.Add("Gert");
            naamLijst.Add("Henk");
            foreach (var item in naamLijst)
            {
                lbLijst.Items.Add(item);
            }
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            lbLijst.Items.Clear();
            foreach (var item in naamLijst)
            {
                if (item.ToLower().Contains(txtSearchText.Text.ToLower()))
                {
                    lbLijst.Items.Add(item);
                }
            }
        }
    }
}
