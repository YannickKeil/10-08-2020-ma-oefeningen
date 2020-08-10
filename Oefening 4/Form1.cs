using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbVoornamen.SelectedValue.ToString());
            txtVoornaam.Show();
            txtAchternaam.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<User> users = new BindingList<User>();
            cbVoornamen.DisplayMember = "Voornaam";
            cbVoornamen.ValueMember = "Achternaam";

            users.Add(new User("Ken", "Fields"));
            users.Add(new User("Yannick", "Keil"));
            users.Add(new User("Koen", "Dejans"));
            users.Add(new User("Jonas", "Van Mullem"));
            users.Add(new User("Benjamin", "Vandevelde"));

            cbVoornamen.DataSource = users;
            
        }
    }
}
