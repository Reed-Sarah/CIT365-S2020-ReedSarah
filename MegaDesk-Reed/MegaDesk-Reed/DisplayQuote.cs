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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string CustomerName, string deskWidth, string deskDepth, string deskDrawers, string deskMaterial, string shipDays)
        {
            InitializeComponent();

           custName.Text = CustomerName;


            width.Text = deskWidth;
            depth.Text = deskDepth;
            drawers.Text = deskDrawers;
            Material.Text = deskMaterial;
            rush.Text = shipDays;
            cost.Text = "$600";


        }

        

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Close();
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cost_Click(object sender, EventArgs e)
        {

        }

        private void rush_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Material_Click(object sender, EventArgs e)
        {

        }

        private void drawers_Click(object sender, EventArgs e)
        {

        }

        private void depth_Click(object sender, EventArgs e)
        {

        }

        private void width_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void custName_Click(object sender, EventArgs e)
        {

        }
    }
}
