namespace WorkTime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start_Label = new System.Windows.Forms.Label();
            this.End_Label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.Gym_Label = new System.Windows.Forms.Label();
            this.Button_Time = new System.Windows.Forms.Button();
            this.Lunch_Label = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.TotalTime_Label = new System.Windows.Forms.Label();
            this.TimeBank_Label = new System.Windows.Forms.Label();
            this.TotalTime_TextBox = new System.Windows.Forms.TextBox();
            this.TimeBank_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start_Label
            // 
            this.Start_Label.AutoSize = true;
            this.Start_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Start_Label.Location = new System.Drawing.Point(56, 19);
            this.Start_Label.Name = "Start_Label";
            this.Start_Label.Size = new System.Drawing.Size(43, 19);
            this.Start_Label.TabIndex = 0;
            this.Start_Label.Text = "Start";
            // 
            // End_Label
            // 
            this.End_Label.AutoSize = true;
            this.End_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.End_Label.Location = new System.Drawing.Point(134, 19);
            this.End_Label.Name = "End_Label";
            this.End_Label.Size = new System.Drawing.Size(35, 19);
            this.End_Label.TabIndex = 1;
            this.End_Label.Text = "End";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Commons", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(67, 27);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 2, 2, 7, 15, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Commons", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Location = new System.Drawing.Point(115, 41);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(67, 27);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2020, 2, 2, 16, 45, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker3.Location = new System.Drawing.Point(115, 76);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(67, 27);
            this.dateTimePicker3.TabIndex = 4;
            this.dateTimePicker3.Value = new System.DateTime(2020, 2, 2, 0, 0, 0, 0);
            // 
            // Gym_Label
            // 
            this.Gym_Label.AutoSize = true;
            this.Gym_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Gym_Label.Location = new System.Drawing.Point(56, 81);
            this.Gym_Label.Name = "Gym_Label";
            this.Gym_Label.Size = new System.Drawing.Size(40, 19);
            this.Gym_Label.TabIndex = 5;
            this.Gym_Label.Text = "Gym";
            // 
            // Button_Time
            // 
            this.Button_Time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Time.Location = new System.Drawing.Point(77, 159);
            this.Button_Time.Name = "Button_Time";
            this.Button_Time.Size = new System.Drawing.Size(75, 30);
            this.Button_Time.TabIndex = 6;
            this.Button_Time.Text = "Time";
            this.Button_Time.UseVisualStyleBackColor = true;
            this.Button_Time.Click += new System.EventHandler(this.Button_Time_Click);
            // 
            // Lunch_Label
            // 
            this.Lunch_Label.AutoSize = true;
            this.Lunch_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Lunch_Label.Location = new System.Drawing.Point(56, 116);
            this.Lunch_Label.Name = "Lunch_Label";
            this.Lunch_Label.Size = new System.Drawing.Size(50, 19);
            this.Lunch_Label.TabIndex = 7;
            this.Lunch_Label.Text = "Lunch";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker4.Location = new System.Drawing.Point(115, 111);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(67, 27);
            this.dateTimePicker4.TabIndex = 8;
            this.dateTimePicker4.Value = new System.DateTime(2020, 2, 2, 0, 45, 0, 0);
            // 
            // TotalTime_Label
            // 
            this.TotalTime_Label.AutoSize = true;
            this.TotalTime_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.TotalTime_Label.Location = new System.Drawing.Point(38, 210);
            this.TotalTime_Label.Name = "TotalTime_Label";
            this.TotalTime_Label.Size = new System.Drawing.Size(80, 19);
            this.TotalTime_Label.TabIndex = 9;
            this.TotalTime_Label.Text = "Total Time";
            // 
            // TimeBank_Label
            // 
            this.TimeBank_Label.AutoSize = true;
            this.TimeBank_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.TimeBank_Label.Location = new System.Drawing.Point(38, 246);
            this.TimeBank_Label.Name = "TimeBank_Label";
            this.TimeBank_Label.Size = new System.Drawing.Size(80, 19);
            this.TimeBank_Label.TabIndex = 10;
            this.TimeBank_Label.Text = "Time Bank";
            // 
            // TotalTime_TextBox
            // 
            this.TotalTime_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTime_TextBox.Location = new System.Drawing.Point(124, 206);
            this.TotalTime_TextBox.Name = "TotalTime_TextBox";
            this.TotalTime_TextBox.Size = new System.Drawing.Size(67, 27);
            this.TotalTime_TextBox.TabIndex = 11;
            this.TotalTime_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeBank_TextBox
            // 
            this.TimeBank_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.TimeBank_TextBox.Location = new System.Drawing.Point(124, 241);
            this.TimeBank_TextBox.Name = "TimeBank_TextBox";
            this.TimeBank_TextBox.Size = new System.Drawing.Size(67, 27);
            this.TimeBank_TextBox.TabIndex = 12;
            this.TimeBank_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.Button_Time;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 306);
            this.Controls.Add(this.TimeBank_TextBox);
            this.Controls.Add(this.TotalTime_TextBox);
            this.Controls.Add(this.TimeBank_Label);
            this.Controls.Add(this.TotalTime_Label);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.Lunch_Label);
            this.Controls.Add(this.Button_Time);
            this.Controls.Add(this.Gym_Label);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.End_Label);
            this.Controls.Add(this.Start_Label);
            this.Font = new System.Drawing.Font("Commons", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "WorkTime";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Start_Label;
        private System.Windows.Forms.Label End_Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label Gym_Label;
        private System.Windows.Forms.Button Button_Time;
        private System.Windows.Forms.Label Lunch_Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label TotalTime_Label;
        private System.Windows.Forms.Label TimeBank_Label;
        private System.Windows.Forms.TextBox TotalTime_TextBox;
        private System.Windows.Forms.TextBox TimeBank_TextBox;
    }
}

