using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class MainMenuForm : Form
    {
        private string cusID;
        public MainMenuForm(string cusID)
        {
            InitializeComponent();
            //var x;
            this.cusID = cusID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            airwaybill airwayfrm = new airwaybill(cusID);
        }
    }
}
