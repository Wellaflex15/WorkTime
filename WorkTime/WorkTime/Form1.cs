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

            //End Time Picker
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm"; //Only hours and minutes
            dateTimePicker2.ShowUpDown = true;

            //Gym Time Picker
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "HH:mm"; //Only hours and minutes
            dateTimePicker3.ShowUpDown = true;

            //Gym Time Picker
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "HH:mm"; //Only hours and minutes
            dateTimePicker3.ShowUpDown = true;

            //Lunch Time Picker
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "HH:mm"; //Only hours and minutes
            dateTimePicker4.ShowUpDown = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
