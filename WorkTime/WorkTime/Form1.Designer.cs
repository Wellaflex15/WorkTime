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
            this.SuspendLayout();
            // 
            // Start_Label
            // 
            this.Start_Label.AutoSize = true;
            this.Start_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Start_Label.Location = new System.Drawing.Point(37, 9);
            this.Start_Label.Name = "Start_Label";
            this.Start_Label.Size = new System.Drawing.Size(43, 19);
            this.Start_Label.TabIndex = 0;
            this.Start_Label.Text = "Start";
            // 
            // End_Label
            // 
            this.End_Label.AutoSize = true;
            this.End_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.End_Label.Location = new System.Drawing.Point(115, 9);
            this.End_Label.Name = "End_Label";
            this.End_Label.Size = new System.Drawing.Size(35, 19);
            this.End_Label.TabIndex = 1;
            this.End_Label.Text = "End";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(67, 29);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 2, 2, 8, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(96, 31);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(67, 29);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2020, 2, 2, 16, 30, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(96, 66);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(67, 29);
            this.dateTimePicker3.TabIndex = 4;
            this.dateTimePicker3.Value = new System.DateTime(2020, 2, 2, 0, 0, 0, 0);
            // 
            // Gym_Label
            // 
            this.Gym_Label.AutoSize = true;
            this.Gym_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Gym_Label.Location = new System.Drawing.Point(37, 71);
            this.Gym_Label.Name = "Gym_Label";
            this.Gym_Label.Size = new System.Drawing.Size(40, 19);
            this.Gym_Label.TabIndex = 5;
            this.Gym_Label.Text = "Gym";
            // 
            // Button_Time
            // 
            this.Button_Time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Time.Location = new System.Drawing.Point(58, 136);
            this.Button_Time.Name = "Button_Time";
            this.Button_Time.Size = new System.Drawing.Size(75, 30);
            this.Button_Time.TabIndex = 6;
            this.Button_Time.Text = "Time";
            this.Button_Time.UseVisualStyleBackColor = true;
            // 
            // Lunch_Label
            // 
            this.Lunch_Label.AutoSize = true;
            this.Lunch_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Lunch_Label.Location = new System.Drawing.Point(37, 106);
            this.Lunch_Label.Name = "Lunch_Label";
            this.Lunch_Label.Size = new System.Drawing.Size(50, 19);
            this.Lunch_Label.TabIndex = 7;
            this.Lunch_Label.Text = "Lunch";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(96, 101);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(67, 29);
            this.dateTimePicker4.TabIndex = 8;
            this.dateTimePicker4.Value = new System.DateTime(2020, 2, 2, 1, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 242);
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
    }
}

