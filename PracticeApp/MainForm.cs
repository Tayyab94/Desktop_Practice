using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addSibjectBtn_Click(object sender, EventArgs e)
        {
            bool itemExists = false;
            foreach (var item in subjectComboBox.Items)
            {
                if(item.Equals(addsubjecttxt.Text))
                {
                    itemExists = true;
                    break; // Exit the loop since we found a match

                }
            }
            if (itemExists)
            {
                MessageBox.Show("Item Already Exist", "Information", MessageBoxButtons.OK);
            }
            else
            {
                subjectComboBox.Items.Add(addsubjecttxt.Text);

                addsubjecttxt.Clear();
                addsubjecttxt.Focus();
            }

        }

        private void removeSelectedItem_Click(object sender, EventArgs e)
        {
            subjectComboBox.Items.Remove(subjectComboBox.SelectedItem);
            MessageBox.Show("item Removed Successfully", "Information", MessageBoxButtons.OK);
        }
    }
}
