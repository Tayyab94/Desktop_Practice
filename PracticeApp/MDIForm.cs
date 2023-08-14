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
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

       private int NoOfFile = 0;
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile newFile= new NewFile();
            newFile.MdiParent= this;
            NoOfFile++;
            newFile.Text = "File " + NoOfFile;
            newFile.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
