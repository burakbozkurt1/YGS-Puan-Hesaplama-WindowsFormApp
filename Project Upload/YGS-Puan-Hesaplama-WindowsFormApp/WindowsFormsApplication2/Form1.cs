using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sinavCombobox.SelectedIndex == 0)
                {
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = true; label10.Visible = true; label11.Visible = true; label12.Visible = true;
                    label13.Visible = true;
                    matematikDogruTextField.Visible = true; matematikYanlisTextField.Visible = true;
                    fenDogruTextField.Visible = true; fenYanlisTextField.Visible = true;
                    turkceDogruTextField.Visible = true; turkceYanlisTextField.Visible = true;
                    sosyalDogruTextField.Visible = true; sosyalYanlisTextField.Visible = true;
                }
                if (sinavCombobox.SelectedIndex == 1)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label4.Visible = true;
                    label7.Visible = true;
                    txtMF4Fen1.Visible = true; txtMF4fen2.Visible = true;
                    txtMF4mat1.Visible = true; txtMF4mat2.Visible = true;

                }
                if (sinavCombobox.SelectedIndex == 2)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label4.Visible = true;
                    label7.Visible = true;
                    txtMF4Fen1.Visible = true; txtMF4fen2.Visible = true;
                    txtMF4mat1.Visible = true; txtMF4mat2.Visible = true;

                }
                if (sinavCombobox.SelectedIndex == 3)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label4.Visible = true;
                    label7.Visible = true;
                    txtMF4Fen1.Visible = true; txtMF4fen2.Visible = true;
                    txtMF4mat1.Visible = true; txtMF4mat2.Visible = true;

                }
                if (sinavCombobox.SelectedIndex == 4)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label4.Visible = true;
                    label7.Visible = true;
                    txtMF4Fen1.Visible = true; txtMF4fen2.Visible = true;
                    txtMF4mat1.Visible = true; txtMF4mat2.Visible = true;

                }
            }
            catch
            {
                MessageBox.Show("Something went wrong! Please be sure about entered and integer numbers!");
            }
            

        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sinavCombobox.SelectedIndex == 0)
                {
                    /*   //----------------------------------------------------------------------------------------------------------
                       // YGS PUAN HESAPLAMASI Ham YGS/LYS Kısa Yol Puan Hesaplama Formülü (Taban Puanı + Her 1 Netin Puan Değeri)
                       //----------------------------------------------------------------------------------------------------------

                       let turkceNet = (Double(turkceDogru.text!))!-(Double(turkceYanlis.text!)! / 4)
                       let sosyalNet = (Double(sosyalDogru.text!))!-(Double(sosyalYanlis.text!)! / 4)
                       let matematikNet = (Double(matematikDogru.text!))!-(Double(matematikYanlis.text!)! / 4)
                       let fenNet = (Double(fenDogru.text!))!-(Double(fenYanlis.text!)! / 4)

                       let YGS1 = 98.416 + (turkceNet * 1.995) + (sosyalNet * 1.173) + (matematikNet * 3.773) + (fenNet * 3.099)
                       let YGS2 = 98.430 + (turkceNet * 1.977) + (sosyalNet * 1.162) + (matematikNet * 2.804) + (fenNet * 4.095)
                       let YGS3 = 96.367 + (turkceNet * 3.861) + (sosyalNet * 3.404) + (matematikNet * 1.826) + (fenNet * 1.000)
                       let YGS4 = 96.344 + (turkceNet * 2.848) + (sosyalNet * 4.465) + (matematikNet * 1.796) + (fenNet * 0.983)
                       let YGS5 = 97.010 + (turkceNet * 3.606) + (sosyalNet * 2.321) + (matematikNet * 3.072) + (fenNet * 1.022)
                       let YGS6 = 97.764 + (turkceNet * 3.295) + (sosyalNet * 1.177) + (matematikNet * 3.510) + (fenNet * 2.074) */

                    double turkceNet = (Convert.ToDouble(turkceDogruTextField.Text)) - (Convert.ToDouble(turkceYanlisTextField.Text) / 4);
                    double sosyalNet = (Convert.ToDouble(sosyalDogruTextField.Text)) - (Convert.ToDouble(sosyalYanlisTextField.Text) / 4);
                    double fenNet = (Convert.ToDouble(fenDogruTextField.Text)) - (Convert.ToDouble(fenYanlisTextField.Text) / 4);
                    double matematikNet = (Convert.ToDouble(matematikDogruTextField.Text)) - (Convert.ToDouble(matematikYanlisTextField.Text) / 4);

                    double YGS1 = 98.416 + (turkceNet * 1.995) + (sosyalNet * 1.173) + (matematikNet * 3.773) + (fenNet * 3.099);
                    double YGS2 = 98.430 + (turkceNet * 1.977) + (sosyalNet * 1.162) + (matematikNet * 2.804) + (fenNet * 4.095);
                    double YGS3 = 96.367 + (turkceNet * 3.861) + (sosyalNet * 3.404) + (matematikNet * 1.826) + (fenNet * 1.000);
                    double YGS4 = 96.344 + (turkceNet * 2.848) + (sosyalNet * 4.465) + (matematikNet * 1.796) + (fenNet * 0.983);
                    double YGS5 = 97.010 + (turkceNet * 3.606) + (sosyalNet * 2.321) + (matematikNet * 3.072) + (fenNet * 1.022);
                    double YGS6 = 97.764 + (turkceNet * 3.295) + (sosyalNet * 1.177) + (matematikNet * 3.510) + (fenNet * 2.074);

                    string YGS1Text = Convert.ToString(YGS1);
                    string YGS2Text = Convert.ToString(YGS2);
                    string YGS3Text = Convert.ToString(YGS3);
                    string YGS4Text = Convert.ToString(YGS4);
                    string YGS5Text = Convert.ToString(YGS5);
                    string YGS6Text = Convert.ToString(YGS6);

                    YGS1SonucLabel.Text = YGS1Text;
                    YGS2SonucLabel.Text = YGS2Text;
                    YGS3SonucLabel.Text = YGS3Text;
                    YGS4SonucLabel.Text = YGS4Text;
                    YGS5SonucLabel.Text = YGS5Text;
                    YGS6SonucLabel.Text = YGS6Text;


                }

                if (sinavCombobox.SelectedIndex == 1)
                {
                    double matNet = (Convert.ToDouble(txtMF4mat1.Text)) - (Convert.ToDouble(txtMF4mat2.Text) / 4);
                    double fenNet = (Convert.ToDouble(txtMF4Fen1.Text)) - (Convert.ToDouble(txtMF4fen2.Text) / 4);

                    string MF4Sonuc = Convert.ToString(166.275 + (matNet * 4.387) + (fenNet * 3.477));

                    label6.Visible = true;
                    label14.Visible = true;

                    label14.Text = MF4Sonuc;

                }

                if (sinavCombobox.SelectedIndex == 2)
                {
                    double matNet = (Convert.ToDouble(txtMF4mat1.Text)) - (Convert.ToDouble(txtMF4mat2.Text) / 4);
                    double fenNet = (Convert.ToDouble(txtMF4Fen1.Text)) - (Convert.ToDouble(txtMF4fen2.Text) / 4);

                    string MF4Sonuc = Convert.ToString(166.275 + (matNet * 3.387) + (fenNet * 6.477));

                    label6.Visible = true;
                    label14.Visible = true;

                    label14.Text = MF4Sonuc;

                }

                if (sinavCombobox.SelectedIndex == 3)
                {
                    double matNet = (Convert.ToDouble(txtMF4mat1.Text)) - (Convert.ToDouble(txtMF4mat2.Text) / 4);
                    double fenNet = (Convert.ToDouble(txtMF4Fen1.Text)) - (Convert.ToDouble(txtMF4fen2.Text) / 4);

                    string MF4Sonuc = Convert.ToString(166.275 + (matNet * 7.387) + (fenNet * 2.477));

                    label6.Visible = true;
                    label14.Visible = true;

                    label14.Text = MF4Sonuc;

                }

                if (sinavCombobox.SelectedIndex == 4)
                {
                    double matNet = (Convert.ToDouble(txtMF4mat1.Text)) - (Convert.ToDouble(txtMF4mat2.Text) / 4);
                    double fenNet = (Convert.ToDouble(txtMF4Fen1.Text)) - (Convert.ToDouble(txtMF4fen2.Text) / 4);

                    string MF4Sonuc = Convert.ToString(166.275 + (matNet * 2.387) + (fenNet * 4.477));

                    label6.Visible = true;
                    label14.Visible = true;

                    label14.Text = MF4Sonuc;

                }
            } catch
            {
                MessageBox.Show("Something went wrong! Please be sure about entered and integer numbers!");
            } 

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            YGS1SonucLabel.Text = "";
            YGS2SonucLabel.Text = "";
            YGS3SonucLabel.Text = "";
            YGS4SonucLabel.Text = "";
            YGS5SonucLabel.Text = "";
            YGS6SonucLabel.Text = "";
            txtMF4mat1.Text = "";
            txtMF4mat2.Text = "";
            txtMF4Fen1.Text = "";
            txtMF4fen2.Text = "";

            matematikDogruTextField.Text = ""; matematikYanlisTextField.Text = "";
            fenDogruTextField.Text = ""; fenYanlisTextField.Text = "";
            sosyalDogruTextField.Text = ""; sosyalYanlisTextField.Text = "";
            turkceDogruTextField.Text = ""; turkceYanlisTextField.Text = ""; 

        }
    }
    }

