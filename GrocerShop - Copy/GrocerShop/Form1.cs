using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrocerShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startpos = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 3;
            myprogressbar.Value = startpos;
            if(myprogressbar.Value == 99 )
            {
                myprogressbar.Value = 0;
                timer1.Stop();
                Loginform log = new Loginform();
                log.Show();
                this.Hide();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

       
    }
}
