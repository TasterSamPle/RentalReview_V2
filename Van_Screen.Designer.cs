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
            Whe_Add = new TextBox();
            Wei_Add = new TextBox();
            Hei_Add = new TextBox();
            Reg_Add = new TextBox();
            Add = new Button();
            Select_Add = new ComboBox();
            Check = new ComboBox();
            Output = new PictureBox();
            Check_Button = new Button();
            Select_Edit = new ComboBox();
            button1 = new Button();
            Whe_Edit = new TextBox();
            Wei_Edit = new TextBox();
            Hei_Edit = new TextBox();
            Reg_Edit = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            Remove = new Button();
            ((System.ComponentModel.ISupportInitialize)Output).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(199, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Registration Number";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(199, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Height";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(199, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(73, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Weight (KG)";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(199, 121);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(73, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = "Wheels";
            // 
            // Whe_Add
            // 
            Whe_Add.Location = new Point(267, 148);
            Whe_Add.Name = "Whe_Add";
            Whe_Add.Size = new Size(100, 23);
            Whe_Add.TabIndex = 8;
            // 
            // Wei_Add
            // 
            Wei_Add.Location = new Point(267, 196);
            Wei_Add.Name = "Wei_Add";
            Wei_Add.Size = new Size(100, 23);
            Wei_Add.TabIndex = 7;
            // 
            // Hei_Add
            // 
            Hei_Add.Location = new Point(267, 248);
            Hei_Add.Name = "Hei_Add";
            Hei_Add.Size = new Size(100, 23);
            Hei_Add.TabIndex = 6;
            // 
            // Reg_Add
            // 
            Reg_Add.Location = new Point(267, 92);
            Reg_Add.Name = "Reg_Add";
            Reg_Add.Size = new Size(100, 23);
            Reg_Add.TabIndex = 5;
            // 
            // Add
            // 
            Add.Location = new Point(258, 297);
            Add.Name = "Add";
            Add.Size = new Size(90, 42);
            Add.TabIndex = 9;
            Add.Text = "Add to database";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // Select_Add
            // 
            Select_Add.FormattingEnabled = true;
            Select_Add.Items.AddRange(new object[] { "VanA", "VanB", "VanC" });
            Select_Add.Location = new Point(246, 34);
            Select_Add.Name = "Select_Add";
            Select_Add.Size = new Size(121, 23);
            Select_Add.TabIndex = 10;
            Select_Add.Text = "Add new Van";
            // 
            // Check
            // 
            Check.FormattingEnabled = true;
            Check.Items.AddRange(new object[] { "VanA", "VanB", "VanC" });
            Check.Location = new Point(25, 47);
            Check.Name = "Check";
            Check.Size = new Size(121, 23);
            Check.TabIndex = 11;
            Check.Text = "Check details";
            Check.SelectedIndexChanged += Check_SelectedIndexChanged;
            // 
            // Output
            // 
            Output.Location = new Point(25, 228);
            Output.Name = "Output";
            Output.Size = new Size(145, 111);
            Output.TabIndex = 12;
            Output.TabStop = false;
            // 
            // Check_Button
            // 
            Check_Button.Location = new Point(37, 113);
            Check_Button.Name = "Check_Button";
            Check_Button.Size = new Size(90, 42);
            Check_Button.TabIndex = 13;
            Check_Button.Text = "Check details";
            Check_Button.UseVisualStyleBackColor = true;
            // 
            // Select_Edit
            // 
            Select_Edit.FormattingEnabled = true;
            Select_Edit.Items.AddRange(new object[] { "VanA", "VanB", "VanC" });
            Select_Edit.Location = new Point(486, 34);
            Select_Edit.Name = "Select_Edit";
            Select_Edit.Size = new Size(121, 23);
            Select_Edit.TabIndex = 23;
            Select_Edit.Text = "Edit a Vans Details";
            // 
            // button1
            // 
            button1.Location = new Point(439, 297);
            button1.Name = "button1";
            button1.Size = new Size(90, 42);
            button1.TabIndex = 22;
            button1.Text = "Add to database";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Whe_Edit
            // 
            Whe_Edit.Location = new Point(507, 148);
            Whe_Edit.Name = "Whe_Edit";
            Whe_Edit.Size = new Size(100, 23);
            Whe_Edit.TabIndex = 21;
            // 
            // Wei_Edit
            // 
            Wei_Edit.Location = new Point(507, 196);
            Wei_Edit.Name = "Wei_Edit";
            Wei_Edit.Size = new Size(100, 23);
            Wei_Edit.TabIndex = 20;
            // 
            // Hei_Edit
            // 
            Hei_Edit.Location = new Point(507, 248);
            Hei_Edit.Name = "Hei_Edit";
            Hei_Edit.Size = new Size(100, 23);
            Hei_Edit.TabIndex = 19;
            // 
            // Reg_Edit
            // 
            Reg_Edit.Location = new Point(507, 92);
            Reg_Edit.Name = "Reg_Edit";
            Reg_Edit.Size = new Size(100, 23);
            Reg_Edit.TabIndex = 18;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(439, 121);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(73, 23);
            textBox9.TabIndex = 17;
            textBox9.Text = "Wheels";
            // 
            // textBox10
            // 
            textBox10.Enabled = false;
            textBox10.Location = new Point(439, 167);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(73, 23);
            textBox10.TabIndex = 16;
            textBox10.Text = "Weight (KG)";
            // 
            // textBox11
            // 
            textBox11.Enabled = false;
            textBox11.Location = new Point(439, 221);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(73, 23);
            textBox11.TabIndex = 15;
            textBox11.Text = "Height";
            // 
            // textBox12
            // 
            textBox12.Enabled = false;
            textBox12.Location = new Point(439, 63);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(123, 23);
            textBox12.TabIndex = 14;
            textBox12.Text = "Registration Number";
            // 
            // Remove
            // 
            Remove.Location = new Point(546, 297);
            Remove.Name = "Remove";
            Remove.Size = new Size(90, 42);
            Remove.TabIndex = 24;
            Remove.Text = "Remove Selected";
            Remove.UseVisualStyleBackColor = true;
            // 
            // Van_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 380);
            Controls.Add(Remove);
            Controls.Add(Select_Edit);
            Controls.Add(button1);
            Controls.Add(Whe_Edit);
            Controls.Add(Wei_Edit);
            Controls.Add(Hei_Edit);
            Controls.Add(Reg_Edit);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(textBox11);
            Controls.Add(textBox12);
            Controls.Add(Check_Button);
            Controls.Add(Output);
            Controls.Add(Check);
            Controls.Add(Select_Add);
            Controls.Add(Add);
            Controls.Add(Whe_Add);
            Controls.Add(Wei_Add);
            Controls.Add(Hei_Add);
            Controls.Add(Reg_Add);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Van_Screen";
            Text = "Rental Reviewing system-Van";
            Load += Van_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)Output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox Whe_Add;
        private TextBox Wei_Add;
        private TextBox Hei_Add;
        private TextBox Reg_Add;
        private Button Add;
        private ComboBox Select_Add;
        private ComboBox Check;
        private PictureBox Output;
        private Button Check_Button;
        private ComboBox Select_Edit;
        private Button button1;
        private TextBox Whe_Edit;
        private TextBox Wei_Edit;
        private TextBox Hei_Edit;
        private TextBox Reg_Edit;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button Remove;
    }
}