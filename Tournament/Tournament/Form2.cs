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
using System.Drawing.Printing;

namespace Tournament
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            
            if (comboBox1.SelectedIndex.Equals(0))
            {

                pictureBox1.Image = Properties.Resources._4;
                label1.Location = new Point(487, 119);
                label2.Location = new Point(487, 442);
                label3.Location = new Point(818, 119);
                label4.Location = new Point(818, 442);

                //label1.ForeColor = Color.Red;
               //label3.ForeColor = Color.Red;

                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(1))
            {

                pictureBox1.Image = Properties.Resources._5;

                label5.Visible = true;

                label1.Location = new Point(529, 167);
                label2.Location = new Point(438, 403);
                label3.Location = new Point(442, 560);
                label4.Location = new Point(832, 166);
                label5.Location = new Point(833, 482);

                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(2))
            {

                pictureBox1.Image = Properties.Resources._6;

                label5.Visible = true;
                label6.Visible = true;

                label1.Location = new Point(542, 166);
                label2.Location = new Point(442, 398);
                label3.Location = new Point(442, 551);
                label4.Location = new Point(875, 166);
                label5.Location = new Point(963, 398);
                label6.Location = new Point(963, 551);

                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(3))
            {

                pictureBox1.Image = Properties.Resources._7;

                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;

                label1.Location = new Point(530, 166);
                label2.Location = new Point(442, 398);
                label3.Location = new Point(442, 551);
                label4.Location = new Point(972, 93);
                label5.Location = new Point(972, 245);
                label6.Location = new Point(972, 398);
                label7.Location = new Point(972, 551);

                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(4))
            {

                pictureBox1.Image = Properties.Resources._8;

                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

                label1.Location = new Point(433, 91);
                label2.Location = new Point(433, 245);
                label3.Location = new Point(433, 398);
                label4.Location = new Point(433, 551);
                label5.Location = new Point(951, 93);
                label6.Location = new Point(951, 245);
                label7.Location = new Point(951, 398);
                label8.Location = new Point(951, 551);


                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;

            }

            if (comboBox1.SelectedIndex.Equals(5))
            {

                pictureBox1.Image = Properties.Resources._9;

                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;

                label1.Location = new Point(468, 86);
                label2.Location = new Point(371, 196);
                label3.Location = new Point(371, 272);
                label4.Location = new Point(468, 395);
                label5.Location = new Point(468, 549);
                label6.Location = new Point(982, 86);
                label7.Location = new Point(982, 241);
                label8.Location = new Point(982, 395);
                label9.Location = new Point(982, 549);


                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(6))
            {

                pictureBox1.Image = Properties.Resources._10;

                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;

                label1.Location = new Point(437, 95);
                label2.Location = new Point(359, 204);
                label3.Location = new Point(359, 281);
                label4.Location = new Point(437, 400);
                label5.Location = new Point(437, 557);
                label6.Location = new Point(972, 95);
                label7.Location = new Point(1078, 204);
                label8.Location = new Point(1078, 280);
                label9.Location = new Point(972, 400);
                label10.Location = new Point(972, 557);

                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;


            }

            if (comboBox1.SelectedIndex.Equals(7))
            {

                pictureBox1.Image = Properties.Resources._11;

                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;

                label1.Location = new Point(456, 389);
                label2.Location = new Point(454, 543);
                label3.Location = new Point(1056, 268);
                label4.Location = new Point(1055, 498);
                label5.Location = new Point(367, 268);
                label6.Location = new Point(953, 389);
                label7.Location = new Point(951, 81);
                label8.Location = new Point(367, 191);
                label9.Location = new Point(457, 81);
                label10.Location = new Point(1055, 191);
                label11.Location = new Point(1055, 577);

                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(8))
            {

                pictureBox1.Image = Properties.Resources._12;

                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;

                label1.Location = new Point(495, 389);
                label2.Location = new Point(387, 577);
                label3.Location = new Point(1062, 265);
                label4.Location = new Point(1066, 499);
                label5.Location = new Point(385, 264);
                label6.Location = new Point(970, 389);
                label7.Location = new Point(973, 74);
                label8.Location = new Point(386, 186);
                label9.Location = new Point(495, 75);
                label10.Location = new Point(1064, 187);
                label11.Location = new Point(1063, 577);
                label12.Location = new Point(387, 499);

                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(9))
            {

                pictureBox1.Image = Properties.Resources._13;

                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;

                label1.Location = new Point(369, 349);
                label2.Location = new Point(370, 581);
                label3.Location = new Point(1050, 271);
                label4.Location = new Point(1050, 502);
                label5.Location = new Point(370, 270);
                label6.Location = new Point(959, 394);
                label7.Location = new Point(959, 84);
                label8.Location = new Point(371, 192);
                label9.Location = new Point(467, 83);
                label10.Location = new Point(1050, 192);
                label11.Location = new Point(1050, 581);
                label12.Location = new Point(371, 502);
                label13.Location = new Point(370, 426);


                label14.Visible = false;
                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(10))
            {

                pictureBox1.Image = Properties.Resources._14;

                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;

                label1.Location = new Point(347, 345);
                label2.Location = new Point(346, 585);
                label3.Location = new Point(1060, 267);
                label4.Location = new Point(1059, 507);
                label5.Location = new Point(347, 267);
                label6.Location = new Point(1059, 346);
                label7.Location = new Point(973, 73);
                label8.Location = new Point(346, 186);
                label9.Location = new Point(433, 74);
                label10.Location = new Point(1059, 187);
                label11.Location = new Point(1061, 584);
                label12.Location = new Point(347, 505);
                label13.Location = new Point(344, 426);
                label14.Location = new Point(1061, 426);

                label15.Visible = false;
                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;

            }

            if (comboBox1.SelectedIndex.Equals(11))
            {

                pictureBox1.Image = Properties.Resources._15;

                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;

                label1.Location = new Point(426, 374);
                label2.Location = new Point(426, 595);
                label3.Location = new Point(1066, 299);
                label4.Location = new Point(1066, 523);
                label5.Location = new Point(426, 299);
                label6.Location = new Point(1066, 374);
                label7.Location = new Point(1066, 148);
                label8.Location = new Point(426, 225);
                label9.Location = new Point(507, 119);
                label10.Location = new Point(1066, 225);
                label11.Location = new Point(1066, 595);
                label12.Location = new Point(426, 523);
                label13.Location = new Point(426, 447);
                label14.Location = new Point(1066, 446);
                label15.Location = new Point(1066, 75);


                //label16.Visible = false;
                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(12))
            {

                pictureBox1.Image = Properties.Resources._16;

                //label17.Visible = false;
                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(13))
            {

                pictureBox1.Image = Properties.Resources._17;

                //label18.Visible = false;
                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(14))
            {

                pictureBox1.Image = Properties.Resources._18;

                //label19.Visible = false;
                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(15))
            {

                pictureBox1.Image = Properties.Resources._19;

                //label20.Visible = false;
                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(16))
            {

                pictureBox1.Image = Properties.Resources._20;

                //label21.Visible = false;
                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(17))
            {

                pictureBox1.Image = Properties.Resources._21;

                //label22.Visible = false;
                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(18))
            {

                pictureBox1.Image = Properties.Resources._22;

                //label23.Visible = false;
                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(19))
            {

                pictureBox1.Image = Properties.Resources._23;

                //label24.Visible = false;
                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(20))
            {

                pictureBox1.Image = Properties.Resources._24;

                //label25.Visible = false;
                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(21))
            {

                pictureBox1.Image = Properties.Resources._25;

                //label26.Visible = false;
                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(22))
            {

                pictureBox1.Image = Properties.Resources._26;

                //label27.Visible = false;
                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(23))
            {

                pictureBox1.Image = Properties.Resources._27;

                //label28.Visible = false;
                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(24))
            {

                pictureBox1.Image = Properties.Resources._28;

                //label29.Visible = false;
                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(25))
            {

                pictureBox1.Image = Properties.Resources._29;

                //label30.Visible = false;
                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(26))
            {

                pictureBox1.Image = Properties.Resources._30;

                //label31.Visible = false;
                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(27))
            {

                pictureBox1.Image = Properties.Resources._31;

                //label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(28))
            {

                pictureBox1.Image = Properties.Resources._32;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

           OpenFileDialog f = new OpenFileDialog();

                        
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                var allLines = File.ReadAllLines(f.FileName);
                for (var i = 0; i < allLines.Length; i++)
                {
                    listBox1.Items.Add(allLines[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //randomizina saraša jo viduje

            ListBox.ObjectCollection list = listBox1.Items;
            Random rng = new Random();
            int n = list.Count;
            //begin updating
            listBox1.BeginUpdate();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            listBox1.EndUpdate();
            listBox1.Invalidate();

            //suskirsto i vietas

            if (comboBox1.SelectedIndex.Equals(0))
            {
                ListBox.ObjectCollection items = listBox1.Items;
                label1.Text = (string)items[0];
                label2.Text = (string)items[1];
                label3.Text = (string)items[2];
                label4.Text = (string)items[3];

            }

            if (comboBox1.SelectedIndex.Equals(1))
            {
                ListBox.ObjectCollection items = listBox1.Items;
                label1.Text = (string)items[0];
                label2.Text = (string)items[1];
                label3.Text = (string)items[2];
                label4.Text = (string)items[3];
                label5.Text = (string)items[4];

            }

            if (comboBox1.SelectedIndex.Equals(2))
            {
                ListBox.ObjectCollection items = listBox1.Items;
                label1.Text = (string)items[0];
                label2.Text = (string)items[1];
                label3.Text = (string)items[2];
                label4.Text = (string)items[3];
                label5.Text = (string)items[4];
                label6.Text = (string)items[5];

            }

            if (comboBox1.SelectedIndex.Equals(3))
            {
                ListBox.ObjectCollection items = listBox1.Items;
                label1.Text = (string)items[0];
                label2.Text = (string)items[1];
                label3.Text = (string)items[2];
                label4.Text = (string)items[3];
                label5.Text = (string)items[4];
                label6.Text = (string)items[5];
                label7.Text = (string)items[6];

            }


            if (comboBox1.SelectedIndex.Equals(4))
            {
                ListBox.ObjectCollection items = listBox1.Items;
                label1.Text = (string)items[0];
                label2.Text = (string)items[1];
                label3.Text = (string)items[2];
                label4.Text = (string)items[3];
                label5.Text = (string)items[4];
                label6.Text = (string)items[5];
                label7.Text = (string)items[6];
                label8.Text = (string)items[7];

            }


            if (comboBox1.SelectedIndex.Equals(5))
            {
                ListBox.ObjectCollection items = listBox1.Items;
                label1.Text = (string)items[0];
                label2.Text = (string)items[1];
                label3.Text = (string)items[2];
                label4.Text = (string)items[3];
                label5.Text = (string)items[4];
                label6.Text = (string)items[5];
                label7.Text = (string)items[6];
                label8.Text = (string)items[7];
                label9.Text = (string)items[8];

            }


            if (comboBox1.SelectedIndex.Equals(6))
            {
                ListBox.ObjectCollection items = listBox1.Items;
                label1.Text = (string)items[0];
                label2.Text = (string)items[1];
                label3.Text = (string)items[2];
                label4.Text = (string)items[3];
                label5.Text = (string)items[4];
                label6.Text = (string)items[5];
                label7.Text = (string)items[6];
                label8.Text = (string)items[7];
                label9.Text = (string)items[8];
                label10.Text = (string)items[9];

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}