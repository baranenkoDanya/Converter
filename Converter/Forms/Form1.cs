﻿using System;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            //comboBox1.SelectedIndex = 2;
            //comboBox2.SelectedIndex = 0;
            Input.Text = Output.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Input.Text.ToString().Contains("-"))
                {
                    string temp = "";
                    if (!Input.Text.Contains("."))
                    {
                        temp = Instruments.IntChoice(Convert.ToInt32(comboBox1.SelectedItem),
                            Convert.ToInt32(comboBox2.SelectedItem), Input.Text);
                    }
                    else if (Input.Text[0].ToString() == "0" & Input.Text[1].ToString() == ".")
                    {
                        temp = Instruments.FractChoice(Convert.ToInt32(comboBox1.SelectedItem),
                            Convert.ToInt32(comboBox2.SelectedItem), Input.Text);
                    }
                    else if (Input.Text[0].ToString() != "0" & Input.Text.Contains("."))
                    {
                        temp = MixedSolution.MixedInput(Convert.ToInt32(comboBox1.SelectedItem),
                            Convert.ToInt32(comboBox2.SelectedItem), Input.Text);
                    }
                    Output.Text = temp;
                    label4.Text = "Output base " + comboBox2.SelectedItem.ToString() + " value:";
                }
                else
                {
                    MessageBox.Show("You can only use positive values");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            label3.Text += "Input base " + comboBox1.SelectedItem.ToString() + " value:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var temp = Input.Text;
            Input.Text = Output.Text;
            Output.Text = temp;
            var tmp = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            comboBox2.SelectedIndex = tmp;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }
    }
}
