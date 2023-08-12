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
    public partial class UpDownListItem : Form
    {
        public UpDownListItem()
        {
            InitializeComponent();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if (locationList.SelectedIndex == -1)
                MessageBox.Show("Please Select a item ","Error", MessageBoxButtons.OK);

            int newIndex = locationList.SelectedIndex - 1;

            if (newIndex < 0 || newIndex >= locationList.Items.Count)
                return;

            object selected = locationList.SelectedItem;
            locationList.Items.Remove(selected);
            locationList.Items.Insert(newIndex, selected);

            locationList.SetSelected(newIndex, true);
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            var date = DOB.Value;
            if (locationList.SelectedIndex == -1)
                MessageBox.Show("Please Select a item ", "Error", MessageBoxButtons.OK);

            int newIndex = locationList.SelectedIndex + 1;

            if (newIndex < 0 || newIndex >= locationList.Items.Count)
                return;

            object selected = locationList.SelectedItem;
            locationList.Items.Remove(selected);
            locationList.Items.Insert(newIndex, selected);

            locationList.SetSelected(newIndex, true);
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back || e.KeyCode==Keys.Delete) {
                DOB.CustomFormat = "";   
            }
        }
    }
}
