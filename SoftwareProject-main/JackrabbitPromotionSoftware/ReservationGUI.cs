using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JackrabbitPromotionSoftware
{
    public partial class ReservationGUI : Form
    {
        public ReservationGUI()
        {
            InitializeComponent();
        }

        private Customer CurrentCustomer = new Customer("John", "Smith", "543-234-4333","John_dumb");
        private DateTime resTime;
        private int partySize;

        //Buttons to add
        //Create reservation
        //Show current reservations on the screen
        //View Profile

        public void createRez()
        {
 
            resTime = dateTimePicker3.Value;
            partySize = ((int)numericUpDown1.Value);
            CurrentCustomer.resList[0] = new Reservation(CurrentCustomer, resTime, partySize);
            Console.WriteLine("Here");
        }
        public void deleteRez()
        {
            CurrentCustomer.resList[0] = null;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReservationGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createRez();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //View Reservation
        private void label3_Click(object sender, EventArgs e)
        {
            if(CurrentCustomer.resList[0] != null)
            {


            }

        }
        public void DrawString()
        {
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            string drawString = "Sample Text";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 150.0F;
            float y = 50.0F;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }

    }
}
