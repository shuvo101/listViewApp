using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ListViewItem information = new ListViewItem(nameTextBox.Text);

            information.SubItems.Add(emailTextBox.Text);
            information.SubItems.Add(ageTextBox.Text);

            listView1.Items.Add(information);

            nameTextBox.Text = "";
            emailTextBox.Text = "";
            ageTextBox.Text = "";
        }

    }
}
