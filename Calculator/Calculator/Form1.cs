﻿using System;
using System.Globalization;
using System.Windows.Forms;
using Calculator.OneArgument;
using Calculator.TwoArguments;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                string firstValueText = textBox1.Text;
                double firstValue = Convert.ToDouble(firstValueText);
                string secondValueText = textBox2.Text;
                double secondValue = Convert.ToDouble(secondValueText);
                string calculatorName = ((Button) sender).Name;
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(calculatorName);
                double result = calculator.Calculate(firstValue, secondValue);
                label1.Text = Convert.ToString(result, CultureInfo.CurrentCulture);
            }
            catch (Exception exc)
            {
                label1.Text = exc.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string calculatorName = ((Button)sender).Name;
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(calculatorName);
            double result = calculator.Calculate(firstValue);
            label1.Text = Convert.ToString(result, CultureInfo.CurrentCulture);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}