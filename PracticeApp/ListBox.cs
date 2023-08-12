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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void Locationtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveLocationBtn_Click(object sender, EventArgs e)
        {
            LocationListBox.Items.Add(Locationtxt.Text);
            Locationtxt.Clear();
            Locationtxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(LocationListBox.SelectedIndex==-1)
            {
                MessageBox.Show("Please Select Item");
            }

            //while(LocationListBox.SelectedItems.Count!=0)
            //{
            //    LocationListBox.Items.Remove(LocationListBox.SelectedItem);
            //}

            while (LocationListBox.SelectedItems.Count != 0)
            {
                LocationListBox.Items.Remove(LocationListBox.SelectedItems[0]);
            }
        }

        private void MoveItemBtn_Click(object sender, EventArgs e)
        {
            if(LocationListBox.SelectedIndex==-1)
            {
                MessageBox.Show("Please Select Item");
            }
            else
            {
                if(LocationListBox.SelectedItems.Count>1)
                {
                    while(LocationListBox.SelectedItems.Count!=0)
                    {
                        secondListBox.Items.Add(LocationListBox.SelectedItems[0]);
                        LocationListBox.Items.Remove(LocationListBox.SelectedItems[0]);
                    }

                }else
                {
                    secondListBox.Items.Add(LocationListBox.SelectedItem);
                    LocationListBox.Items.Remove(LocationListBox.SelectedItem);
                }
              
            }
        }
    }
}
