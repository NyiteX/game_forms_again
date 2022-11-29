using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void figuri_Button_Click(object sender, EventArgs e)
        {
            
        }
        private void Test(object sender, EventArgs e) { MessageBox.Show("ALO"); }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            figuri_Button.Click += Test;
        }
    }
}
