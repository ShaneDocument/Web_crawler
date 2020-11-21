using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotherHappy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosing +=new FormClosingEventHandler(this.Form2_Closing);
        }
        int Mode = 0;
        int Page = 1;
        private void Form2_Closing(object sender,FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
            Mode = 0;
            pictureBox1.Visible = false;
            label1.Visible = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mode = 3;
            pictureBox1.Image = MotherHappy.Properties.Resources._3_1;
            pictureBox1.Visible = true;
            label1.Text = button3.Text;
            label1.Visible = true;
            Page = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mode = 1;
            pictureBox1.Image = MotherHappy.Properties.Resources._1_1;
            pictureBox1.Visible = true;
            label1.Text = button1.Text;
            label1.Visible = true;
            Page = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mode = 2;
            pictureBox1.Image = MotherHappy.Properties.Resources._2_1;
            pictureBox1.Visible = true;
            label1.Text = button2.Text;
            label1.Visible = true;
            Page = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Page>1)
            Page--;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Page++;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                switch (Mode)
                {

                    case 1:
                        switch (Page)
                        {
                            case 1:
                                pictureBox1.Image = MotherHappy.Properties.Resources._1_1;

                                break;
                            case 2:
                                pictureBox1.Image = MotherHappy.Properties.Resources._1_2;
                                break;
                            case 3:
                                pictureBox1.Image = MotherHappy.Properties.Resources._1_3;
                                break;
                            case 4:
                                pictureBox1.Image = MotherHappy.Properties.Resources._1_4;
                                break;
                            case 5:
                                pictureBox1.Image = MotherHappy.Properties.Resources._1_5;
                                break;
                        }
                        if (Page > 5)
                            Page = 5;
                        break;
                    case 2:
                        switch (Page)
                        {
                            case 1:
                                pictureBox1.Image = MotherHappy.Properties.Resources._2_1;
                                break;
                            case 2:
                                pictureBox1.Image = MotherHappy.Properties.Resources._2_2;
                                break;
                        }
                        if (Page > 2)
                            Page = 2;
                        break;
                    case 3:
                        switch (Page)
                        {
                            case 1:
                                pictureBox1.Image = MotherHappy.Properties.Resources._3_1;

                                break;
                            case 2:
                                pictureBox1.Image = MotherHappy.Properties.Resources._3_2;
                                break;
                        }
                        if (Page > 2)
                            Page = 2;
                        break;

                }
            }
            catch
            {

            }
        }
    }
}
