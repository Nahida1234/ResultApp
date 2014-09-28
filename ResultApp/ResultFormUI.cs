using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultApp
{
    public partial class Form1 : Form
    {
        Result aResult = new Result();
        public Form1()
        {
            InitializeComponent();
        }

        private double average = 0;
        private void showButton_Click(object sender, EventArgs e)
        {
            aResult._physics = Convert.ToDouble(physicsTextBox.Text);
            aResult._chemistry = Convert.ToDouble(chemistryTextBox.Text);
            aResult._math = Convert.ToDouble(mathTextBox.Text);

            double average = aResult.Average(aResult._physics, aResult._chemistry, aResult._math);
            averageTextBox.Text = average.ToString();

            gradeTextBox.Text=aResult.Grade(average);

        }

    

    }
}
