namespace Life_Planner
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
            this.work_button = new System.Windows.Forms.Button();
            this.drink_button = new System.Windows.Forms.Button();
            this.fluids_meter_label = new System.Windows.Forms.Label();
            this.time_till_break_label = new System.Windows.Forms.Label();
            this.drink_input_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.elapsed_time_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // work_button
            // 
            this.work_button.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.work_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.work_button.Location = new System.Drawing.Point(39, 38);
            this.work_button.Name = "work_button";
            this.work_button.Size = new System.Drawing.Size(136, 47);
            this.work_button.TabIndex = 0;
            this.work_button.Text = "work";
            this.work_button.UseVisualStyleBackColor = true;
            this.work_button.Click += new System.EventHandler(this.work_button_Click);
            // 
            // drink_button
            // 
            this.drink_button.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.drink_button.Location = new System.Drawing.Point(39, 113);
            this.drink_button.Name = "drink_button";
            this.drink_button.Size = new System.Drawing.Size(136, 59);
            this.drink_button.TabIndex = 1;
            this.drink_button.Text = "drink!";
            this.drink_button.UseVisualStyleBackColor = true;
            this.drink_button.Click += new System.EventHandler(this.drink_button_Click);
            // 
            // fluids_meter_label
            // 
            this.fluids_meter_label.AutoSize = true;
            this.fluids_meter_label.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.fluids_meter_label.Location = new System.Drawing.Point(27, 189);
            this.fluids_meter_label.Name = "fluids_meter_label";
            this.fluids_meter_label.Size = new System.Drawing.Size(420, 72);
            this.fluids_meter_label.TabIndex = 2;
            this.fluids_meter_label.Text = "0 / 9 cups drunk";
            this.fluids_meter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_till_break_label
            // 
            this.time_till_break_label.AutoSize = true;
            this.time_till_break_label.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.time_till_break_label.Location = new System.Drawing.Point(185, 39);
            this.time_till_break_label.Name = "time_till_break_label";
            this.time_till_break_label.Size = new System.Drawing.Size(268, 46);
            this.time_till_break_label.TabIndex = 3;
            this.time_till_break_label.Text = "0:00h until break";
            // 
            // drink_input_textBox
            // 
            this.drink_input_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(191)))));
            this.drink_input_textBox.Font = new System.Drawing.Font("Segoe UI", 29F);
            this.drink_input_textBox.Location = new System.Drawing.Point(193, 113);
            this.drink_input_textBox.Name = "drink_input_textBox";
            this.drink_input_textBox.Size = new System.Drawing.Size(99, 59);
            this.drink_input_textBox.TabIndex = 4;
            this.drink_input_textBox.Text = "0";
            this.drink_input_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 29F);
            this.label3.Location = new System.Drawing.Point(298, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "cups";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elapsed_time_backgroundWorker
            // 

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(162)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(489, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drink_input_textBox);
            this.Controls.Add(this.time_till_break_label);
            this.Controls.Add(this.fluids_meter_label);
            this.Controls.Add(this.drink_button);
            this.Controls.Add(this.work_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button work_button;
        private System.Windows.Forms.Button drink_button;
        private System.Windows.Forms.Label fluids_meter_label;
        private System.Windows.Forms.Label time_till_break_label;
        private System.Windows.Forms.TextBox drink_input_textBox;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker elapsed_time_backgroundWorker;
    }
}

