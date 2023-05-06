using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace HD_SDI_WinApp
{
    public partial class Home : Form
    {
     
        public Home()
        {
            this.InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            
          
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
