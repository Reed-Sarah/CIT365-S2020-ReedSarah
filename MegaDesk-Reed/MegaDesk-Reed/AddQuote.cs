using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MegaDesk_Reed
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
           
            
            
        }





        private void depthValidation(object sender, EventArgs e)
        {
            if (depth.Value < Desk.MINDEPTH || depth.Value > Desk.MAXDEPTH)
            {
                depth.Text = String.Empty;
                invalid f = new invalid();
                f.Show(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk((int)width.Value, (int)depth.Value, (int)drawer.Value);
           

            DisplayQuote display = new DisplayQuote(UserName.Text, width.Text, depth.Text, drawer.Text, material.Text, rush.Text);
            display.ShowDialog();

            try
            {
               // DeskQuote.CalculateCost();
            }

            catch
            {
                const string message =
       "An error occured please re-enter values";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption);
            }

           
            Close();
        }

        private void widthValidation(object sender, CancelEventArgs e)
        {
            if ((width.Value < Desk.MINWIDTH || width.Value > Desk.MAXWIDTH) && !(Char.IsDigit((char) width.Value)))
            {
                width.Text = String.Empty;
                invalid f = new invalid();
                f.Show(this);
            }
        }

        private void drawerValidation(object sender, EventArgs e)
        {
            if (drawer.Value > Desk.MAXDRAWERS)
            {
                drawer.Text = String.Empty;
                invalid f = new invalid();
                f.Show(this);
            }
        }
    }
}