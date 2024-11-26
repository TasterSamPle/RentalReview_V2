namespace RentalReview_V2
{
    partial class Van_Screen
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Whe = new TextBox();
            Wei = new TextBox();
            Hei = new TextBox();
            Reg = new TextBox();
            Add = new Button();
            Select = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(208, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Registration Number";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(208, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Height";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(208, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(73, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Weight (KG)";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(208, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(73, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = "Wheels";
            // 
            // Whe
            // 
            Whe.Location = new Point(276, 145);
            Whe.Name = "Whe";
            Whe.Size = new Size(100, 23);
            Whe.TabIndex = 8;
            // 
            // Wei
            // 
            Wei.Location = new Point(276, 193);
            Wei.Name = "Wei";
            Wei.Size = new Size(100, 23);
            Wei.TabIndex = 7;
            // 
            // Hei
            // 
            Hei.Location = new Point(276, 245);
            Hei.Name = "Hei";
            Hei.Size = new Size(100, 23);
            Hei.TabIndex = 6;
            // 
            // Reg
            // 
            Reg.Location = new Point(276, 89);
            Reg.Name = "Reg";
            Reg.Size = new Size(100, 23);
            Reg.TabIndex = 5;
            // 
            // Add
            // 
            Add.Location = new Point(267, 294);
            Add.Name = "Add";
            Add.Size = new Size(90, 42);
            Add.TabIndex = 9;
            Add.Text = "Add to database";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // Select
            // 
            Select.FormattingEnabled = true;
            Select.Items.AddRange(new object[] { "VanA", "VanB", "VanC" });
            Select.Location = new Point(255, 31);
            Select.Name = "Select";
            Select.Size = new Size(121, 23);
            Select.TabIndex = 10;
            Select.Text = "Add new Van";
            // 
            // Van_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 380);
            Controls.Add(Select);
            Controls.Add(Add);
            Controls.Add(Whe);
            Controls.Add(Wei);
            Controls.Add(Hei);
            Controls.Add(Reg);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Van_Screen";
            Text = "Rental Reviewing system-Van";
            Load += Van_Screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox Whe;
        private TextBox Wei;
        private TextBox Hei;
        private TextBox Reg;
        private Button Add;
        private ComboBox Select;
    }
}