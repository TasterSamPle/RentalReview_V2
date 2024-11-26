namespace RentalReview_V2
{
    partial class Main_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Car_Button = new Button();
            Van_Button = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Car_Button
            // 
            Car_Button.Location = new Point(75, 145);
            Car_Button.Name = "Car_Button";
            Car_Button.Size = new Size(97, 34);
            Car_Button.TabIndex = 0;
            Car_Button.Text = "Cars";
            Car_Button.UseVisualStyleBackColor = true;
            Car_Button.Click += Car_Button_Click;
            // 
            // Van_Button
            // 
            Van_Button.Location = new Point(344, 145);
            Van_Button.Name = "Van_Button";
            Van_Button.Size = new Size(82, 34);
            Van_Button.TabIndex = 1;
            Van_Button.Text = "Vans";
            Van_Button.UseVisualStyleBackColor = true;
            Van_Button.Click += Van_Button_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.HideSelection = false;
            textBox1.Location = new Point(57, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Would you like to look at the cars or the vans in the system at the moment?";
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 275);
            Controls.Add(textBox1);
            Controls.Add(Van_Button);
            Controls.Add(Car_Button);
            Name = "Main_Menu";
            Text = "Rental Reviewing system-Main";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Car_Button;
        private Button Van_Button;
        private TextBox textBox1;
        private EventHandler textBox1_TextChanged;
    }
}