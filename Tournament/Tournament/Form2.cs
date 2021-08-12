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

                label1.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;

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
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
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

                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Red;

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
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
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
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
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
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
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
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;

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
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
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
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;


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

                label1.Location = new Point(455, 95);
                label2.Location = new Point(359, 204);
                label3.Location = new Point(359, 280);
                label4.Location = new Point(455, 400);
                label5.Location = new Point(455, 557);
                label6.Location = new Point(953, 95);
                label7.Location = new Point(1058, 204);
                label8.Location = new Point(1058, 280);
                label9.Location = new Point(953, 400);
                label10.Location = new Point(1058, 509);
                label11.Location = new Point(1058, 585);

                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
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

                label1.Location = new Point(475, 86);
                label2.Location = new Point(362, 197);
                label3.Location = new Point(362, 276);
                label4.Location = new Point(475, 401);
                label5.Location = new Point(362, 512);
                label6.Location = new Point(362, 590);
                label7.Location = new Point(974, 85);
                label8.Location = new Point(1062, 197);
                label9.Location = new Point(1062, 276);
                label10.Location = new Point(974, 401);
                label11.Location = new Point(1062, 512);
                label12.Location = new Point(1062, 590);

                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
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

                label1.Location = new Point(457, 96);
                label2.Location = new Point(358, 204);
                label3.Location = new Point(358, 282);
                label4.Location = new Point(358, 360);
                label5.Location = new Point(358, 435);
                label6.Location = new Point(358, 515);
                label7.Location = new Point(358, 593);
                label8.Location = new Point(959, 96);
                label9.Location = new Point(1050, 204);
                label10.Location = new Point(1050, 282);
                label11.Location = new Point(959, 407);
                label12.Location = new Point(1050, 515);
                label13.Location = new Point(1050, 593);


                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
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

                label1.Location = new Point(436, 86);
                label2.Location = new Point(350, 198);
                label3.Location = new Point(350, 277);
                label4.Location = new Point(350, 360);
                label5.Location = new Point(350, 437);
                label6.Location = new Point(350, 516);
                label7.Location = new Point(350, 596);
                label8.Location = new Point(964, 86);
                label9.Location = new Point(1057, 198);
                label10.Location = new Point(1057, 277);
                label11.Location = new Point(1057, 360);
                label12.Location = new Point(1057, 437);
                label13.Location = new Point(1057, 519);
                label14.Location = new Point(1057, 596);

                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;

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

                label1.Location = new Point(471, 119);
                label2.Location = new Point(390, 225);
                label3.Location = new Point(390, 300);
                label4.Location = new Point(390, 374);
                label5.Location = new Point(390, 448);
                label6.Location = new Point(390, 521);
                label7.Location = new Point(390, 597);
                label8.Location = new Point(1066, 77);
                label9.Location = new Point(1066, 149);
                label10.Location = new Point(1066, 225);
                label11.Location = new Point(1066, 300);
                label12.Location = new Point(1066, 374);
                label13.Location = new Point(1066, 448);
                label14.Location = new Point(1066, 521);
                label15.Location = new Point(1066, 597);


                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(12))
            {

                pictureBox1.Image = Properties.Resources._16;

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
                label16.Visible = true;

                label1.Location = new Point(358, 87);
                label2.Location = new Point(358, 161);
                label3.Location = new Point(358, 233);
                label4.Location = new Point(358, 306);
                label5.Location = new Point(358, 379);
                label6.Location = new Point(358, 599);
                label7.Location = new Point(358, 526);
                label8.Location = new Point(358, 599);
                label9.Location = new Point(1066, 87);
                label10.Location = new Point(1066, 161);
                label11.Location = new Point(1066, 233);
                label12.Location = new Point(1066, 306);
                label13.Location = new Point(1066, 379);
                label14.Location = new Point(1066, 452);
                label15.Location = new Point(1066, 526);
                label16.Location = new Point(1066, 599);

                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(13))
            {

                pictureBox1.Image = Properties.Resources._17;

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
                label16.Visible = true;
                label17.Visible = true;

                label1.Location = new Point(430, 113);
                label2.Location = new Point(430, 185);
                label3.Location = new Point(430, 255);
                label4.Location = new Point(430, 324);
                label5.Location = new Point(430, 395);
                label6.Location = new Point(430, 465);
                label7.Location = new Point(430, 535);
                label8.Location = new Point(332, 576);
                label9.Location = new Point(332, 631);
                label10.Location = new Point(1076, 113);
                label11.Location = new Point(1076, 183);
                label12.Location = new Point(1076, 253);
                label13.Location = new Point(1076, 324);
                label14.Location = new Point(1076, 395);
                label15.Location = new Point(1076, 465);
                label16.Location = new Point(1076, 535);
                label17.Location = new Point(1076, 605);

                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(14))
            {

                pictureBox1.Image = Properties.Resources._18;

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
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;

                label1.Location = new Point(423, 121);
                label2.Location = new Point(423, 186);
                label3.Location = new Point(423, 254);
                label4.Location = new Point(423, 318);
                label5.Location = new Point(423, 385);
                label6.Location = new Point(423, 451);
                label7.Location = new Point(423, 518);
                label8.Location = new Point(340, 568);
                label9.Location = new Point(340, 597);
                label10.Location = new Point(1027, 121);
                label11.Location = new Point(1027, 186);
                label12.Location = new Point(1027, 254);
                label13.Location = new Point(1027, 318);
                label14.Location = new Point(1027, 385);
                label15.Location = new Point(1027, 451);
                label16.Location = new Point(1027, 518);
                label17.Location = new Point(1106, 568);
                label18.Location = new Point(1106, 597);

                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(15))
            {

                pictureBox1.Image = Properties.Resources._19;

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
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;

                label1.Location = new Point(417, 124);
                label2.Location = new Point(417, 189);
                label3.Location = new Point(417, 256);
                label4.Location = new Point(417, 323);
                label5.Location = new Point(417, 389);
                label6.Location = new Point(417, 456);
                label7.Location = new Point(417, 522);
                label8.Location = new Point(340, 577);
                label9.Location = new Point(340, 604);
                label10.Location = new Point(1017, 124);
                label11.Location = new Point(1017, 189);
                label12.Location = new Point(1017, 256);
                label13.Location = new Point(1017, 323);
                label14.Location = new Point(1017, 389);
                label15.Location = new Point(1017, 456);
                label16.Location = new Point(1017, 508);
                label17.Location = new Point(1100, 537);
                label18.Location = new Point(1100, 577);
                label19.Location = new Point(1100, 604);


                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(16))
            {

                pictureBox1.Image = Properties.Resources._20;

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
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;

                label1.Location = new Point(419, 127);
                label2.Location = new Point(419, 195);
                label3.Location = new Point(419, 262);
                label4.Location = new Point(419, 330);
                label5.Location = new Point(419, 397);
                label6.Location = new Point(419, 468);
                label7.Location = new Point(340, 520);
                label8.Location = new Point(340, 547);
                label9.Location = new Point(340, 588);
                label10.Location = new Point(340, 617);
                label11.Location = new Point(1018, 127);
                label12.Location = new Point(1018, 195);
                label13.Location = new Point(1018, 262);
                label14.Location = new Point(1018, 330);
                label15.Location = new Point(1018, 397);
                label16.Location = new Point(1018, 468);
                label17.Location = new Point(1100, 520);
                label18.Location = new Point(1100, 547);
                label19.Location = new Point(1100, 588);
                label20.Location = new Point(1100, 617);

                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(17))
            {

                pictureBox1.Image = Properties.Resources._21;

                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(18))
            {

                pictureBox1.Image = Properties.Resources._22;

                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(19))
            {

                pictureBox1.Image = Properties.Resources._23;

                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(20))
            {

                pictureBox1.Image = Properties.Resources._24;

                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(21))
            {

                pictureBox1.Image = Properties.Resources._25;

                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(22))
            {

                pictureBox1.Image = Properties.Resources._26;

                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(23))
            {

                pictureBox1.Image = Properties.Resources._27;

                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(24))
            {

                pictureBox1.Image = Properties.Resources._28;

                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(25))
            {

                pictureBox1.Image = Properties.Resources._29;

                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(26))
            {

                pictureBox1.Image = Properties.Resources._30;

                label31.Visible = false;
                label32.Visible = false;
            }

            if (comboBox1.SelectedIndex.Equals(27))
            {

                pictureBox1.Image = Properties.Resources._31;

                label32.Visible = false;
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

            if (comboBox1.SelectedIndex.Equals(7))
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
                label11.Text = (string)items[10];

            }

            if (comboBox1.SelectedIndex.Equals(8))
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
                label11.Text = (string)items[10];
                label12.Text = (string)items[11];

            }


            if (comboBox1.SelectedIndex.Equals(9))
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
                label11.Text = (string)items[10];
                label12.Text = (string)items[11];
                label13.Text = (string)items[12];

            }

            if (comboBox1.SelectedIndex.Equals(10))
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
                label11.Text = (string)items[10];
                label12.Text = (string)items[11];
                label13.Text = (string)items[12];
                label14.Text = (string)items[13];

            }

            if (comboBox1.SelectedIndex.Equals(11))
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
                label11.Text = (string)items[10];
                label12.Text = (string)items[11];
                label13.Text = (string)items[12];
                label14.Text = (string)items[13];
                label15.Text = (string)items[14];

            }


            if (comboBox1.SelectedIndex.Equals(12))
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
                label11.Text = (string)items[10];
                label12.Text = (string)items[11];
                label13.Text = (string)items[12];
                label14.Text = (string)items[13];
                label15.Text = (string)items[14];
                label16.Text = (string)items[15];

            }


            if (comboBox1.SelectedIndex.Equals(13))
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
                label11.Text = (string)items[10];
                label12.Text = (string)items[11];
                label13.Text = (string)items[12];
                label14.Text = (string)items[13];
                label15.Text = (string)items[14];
                label16.Text = (string)items[15];
                label17.Text = (string)items[16];

            }

            if (comboBox1.SelectedIndex.Equals(14))
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
                label11.Text = (string)items[10];
                label12.Text = (string)items[11];
                label13.Text = (string)items[12];
                label14.Text = (string)items[13];
                label15.Text = (string)items[14];
                label16.Text = (string)items[15];
                label17.Text = (string)items[16];
                label18.Text = (string)items[17];

            }

            if (comboBox1.SelectedIndex.Equals(15))
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
                label11.Text = (string)items[10];
                label12.Text = (string)items[11];
                label13.Text = (string)items[12];
                label14.Text = (string)items[13];
                label15.Text = (string)items[14];
                label16.Text = (string)items[15];
                label17.Text = (string)items[16];
                label18.Text = (string)items[17];
                label19.Text = (string)items[18];

            }

            if (comboBox1.SelectedIndex.Equals(16))
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
                label11.Text = (string)items[10];
                label12.Text = (string)items[11];
                label13.Text = (string)items[12];
                label14.Text = (string)items[13];
                label15.Text = (string)items[14];
                label16.Text = (string)items[15];
                label17.Text = (string)items[16];
                label18.Text = (string)items[17];
                label19.Text = (string)items[18];
                label20.Text = (string)items[19];

            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}