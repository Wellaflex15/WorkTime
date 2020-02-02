using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //Start Time Picker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm"; //Only hours and minutes
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.TabIndex = 1;

            //End Time Picker
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm"; //Only hours and minutes
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.TabIndex = 2;

            //Gym Time Picker
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "HH:mm"; //Only hours and minutes
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.TabIndex = 3;

            //Lunch Time Picker
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "HH:mm"; //Only hours and minutes
            dateTimePicker4.ShowUpDown = true;
            dateTimePicker4.TabIndex = 4;

            //Time Button
            Button_Time.TabIndex = 5;

            //Total Time Box
            TotalTime_TextBox.TabIndex = 6;

            //Time Bank Box
            TimeBank_TextBox.TabIndex = 7;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_Time_Click(object sender, EventArgs e)
        {
            CalculateTotalWorkTime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CalculateTotalWorkTime();
            }

            MessageBox.Show($"{e.KeyCode}");
        }

        public void CalculateTotalWorkTime()
        {
            Time totalWorkTime = new Time(dateTimePicker1.Value, dateTimePicker2.Value);
            TotalTime_TextBox.Text = totalWorkTime.CalculateWorkTime().ToString();
        }
    }
}
