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

namespace Renamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtDirectory.Text == string.Empty)
                MessageBox.Show("You must provide a directory!");
            else if (txtOldFilename.Text == string.Empty)
                MessageBox.Show("You must provide an old filename!");
            else if (txtNewFilename.Text == string.Empty)
                MessageBox.Show("You must provide an new filename!");
            else
                foreach (string f in Directory.GetFiles(txtDirectory.Text))
                    if (f.Substring(f.LastIndexOf('\\') + 1).Contains(txtOldFilename.Text))
                        File.Move(f, f.Replace(txtOldFilename.Text, txtNewFilename.Text));
        }
    }
}
