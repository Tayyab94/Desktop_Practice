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
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ListViewItem data = new ListViewItem("1");
            data.SubItems.Add("Tayyab");
            data.SubItems.Add("tayya@gmail.com");
            UserlistView.Items.Add(data);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(UserlistView.SelectedItems.Count > 0) {
                var s = UserlistView.SelectedItems[0].SubItems[1].Text;
                MessageBox.Show($"Value: {s}");
                UserlistView.Items.Remove(UserlistView.SelectedItems[0]);
            }
        }
    }
}
