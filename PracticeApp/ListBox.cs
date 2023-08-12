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

        private void Locationtxt_MouseDown(object sender, MouseEventArgs e)
        {
            Locationtxt.SelectAll();
            Locationtxt.DoDragDrop(Locationtxt.Text, DragDropEffects.All);
        }

        private void LocationListBox_DragEnter(object sender, DragEventArgs e)
        {
            if(LocationListBox.SelectedIndex==-1)
            {
                e.Effect = DragDropEffects.Move;
                LocationListBox.Items.Add(e.Data.GetData(DataFormats.Text));
                Locationtxt.Clear();
                Locationtxt.Focus();
            }
            else
            {
                LocationListBox.SelectedIndex = -1;
            }
            
        }

        private void LocationListBox_MouseDown(object sender, MouseEventArgs e)
        {
            LocationListBox.DoDragDrop(LocationListBox.Text, DragDropEffects.All);
        }

        private void Locationtxt_DragEnter(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.Copy;
            //Locationtxt.Text= e.Data.GetData(DataFormats.Text).ToString();

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string draggedText = e.Data.GetData(DataFormats.Text) as string;
                if (draggedText != null)
                {
                    Locationtxt.Text = draggedText;
                }
            }
        }
    }
}
