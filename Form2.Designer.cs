namespace RentalReview_V2
{
    partial class Car
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
            Remove = new Button();
            Select_Edit = new ComboBox();
            Add_Edit = new Button();
            Whe_Edit = new TextBox();
            Wei_Edit = new TextBox();
            Hei_Edit = new TextBox();
            Reg_Edit = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            Check_Button = new Button();
            Output = new PictureBox();
            Check = new ComboBox();
            Select_Add = new ComboBox();
            Add = new Button();
            Whe_Add = new TextBox();
            Wei_Add = new TextBox();
            Hei_Add = new TextBox();
            Reg_Add = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Output).BeginInit();
            SuspendLayout();
            // 
            // Remove
            // 
            Remove.Location = new Point(581, 309);
            Remove.Name = "Remove";
            Remove.Size = new Size(90, 42);
            Remove.TabIndex = 48;
            Remove.Text = "Remove Selected";
            Remove.UseVisualStyleBackColor = true;
            // 
            // Select_Edit
            // 
            Select_Edit.FormattingEnabled = true;
            Select_Edit.Items.AddRange(new object[] { "CarA", "CarB", "CarC" });
            Select_Edit.Location = new Point(509, 46);
            Select_Edit.Name = "Select_Edit";
            Select_Edit.Size = new Size(121, 23);
            Select_Edit.TabIndex = 47;
            Select_Edit.Text = "Edit a Cars Details";
            // 
            // Add_Edit
            // 
            Add_Edit.Location = new Point(462, 309);
            Add_Edit.Name = "Add_Edit";
            Add_Edit.Size = new Size(90, 42);
            Add_Edit.TabIndex = 46;
            Add_Edit.Text = "Add to database";
            Add_Edit.UseVisualStyleBackColor = true;
            // 
            // Whe_Edit
            // 
            Whe_Edit.Location = new Point(530, 160);
            Whe_Edit.Name = "Whe_Edit";
            Whe_Edit.Size = new Size(100, 23);
            Whe_Edit.TabIndex = 45;
            // 
            // Wei_Edit
            // 
            Wei_Edit.Location = new Point(530, 208);
            Wei_Edit.Name = "Wei_Edit";
            Wei_Edit.Size = new Size(100, 23);
            Wei_Edit.TabIndex = 44;
            // 
            // Hei_Edit
            // 
            Hei_Edit.Location = new Point(530, 260);
            Hei_Edit.Name = "Hei_Edit";
            Hei_Edit.Size = new Size(100, 23);
            Hei_Edit.TabIndex = 43;
            // 
            // Reg_Edit
            // 
            Reg_Edit.Location = new Point(530, 104);
            Reg_Edit.Name = "Reg_Edit";
            Reg_Edit.Size = new Size(100, 23);
            Reg_Edit.TabIndex = 42;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(462, 133);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(73, 23);
            textBox9.TabIndex = 41;
            textBox9.Text = "Wheels";
            // 
            // textBox10
            // 
            textBox10.Enabled = false;
            textBox10.Location = new Point(462, 179);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(73, 23);
            textBox10.TabIndex = 40;
            textBox10.Text = "Weight (KG)";
            // 
            // textBox11
            // 
            textBox11.Enabled = false;
            textBox11.Location = new Point(462, 233);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(73, 23);
            textBox11.TabIndex = 39;
            textBox11.Text = "Height";
            // 
            // textBox12
            // 
            textBox12.Enabled = false;
            textBox12.Location = new Point(462, 75);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(123, 23);
            textBox12.TabIndex = 38;
            textBox12.Text = "Registration Number";
            // 
            // Check_Button
            // 
            Check_Button.Location = new Point(60, 125);
            Check_Button.Name = "Check_Button";
            Check_Button.Size = new Size(90, 42);
            Check_Button.TabIndex = 37;
            Check_Button.Text = "Check details";
            Check_Button.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            Output.Location = new Point(48, 240);
            Output.Name = "Output";
            Output.Size = new Size(145, 111);
            Output.TabIndex = 36;
            Output.TabStop = false;
            // 
            // Check
            // 
            Check.FormattingEnabled = true;
            Check.Items.AddRange(new object[] { "CarA", "CarB", "CarC" });
            Check.Location = new Point(48, 59);
            Check.Name = "Check";
            Check.Size = new Size(121, 23);
            Check.TabIndex = 35;
            Check.Text = "Check details";
            Check.SelectedIndexChanged += Check_SelectedIndexChanged;
            // 
            // Select_Add
            // 
            Select_Add.FormattingEnabled = true;
            Select_Add.Items.AddRange(new object[] { "CarA", "CarB", "CarC" });
            Select_Add.Location = new Point(269, 46);
            Select_Add.Name = "Select_Add";
            Select_Add.Size = new Size(121, 23);
            Select_Add.TabIndex = 34;
            Select_Add.Text = "Add new Car";
            // 
            // Add
            // 
            Add.Location = new Point(281, 309);
            Add.Name = "Add";
            Add.Size = new Size(90, 42);
            Add.TabIndex = 33;
            Add.Text = "Add to database";
            Add.UseVisualStyleBackColor = true;
            // 
            // Whe_Add
            // 
            Whe_Add.Location = new Point(290, 160);
            Whe_Add.Name = "Whe_Add";
            Whe_Add.Size = new Size(100, 23);
            Whe_Add.TabIndex = 32;
            // 
            // Wei_Add
            // 
            Wei_Add.Location = new Point(290, 208);
            Wei_Add.Name = "Wei_Add";
            Wei_Add.Size = new Size(100, 23);
            Wei_Add.TabIndex = 31;
            // 
            // Hei_Add
            // 
            Hei_Add.Location = new Point(290, 260);
            Hei_Add.Name = "Hei_Add";
            Hei_Add.Size = new Size(100, 23);
            Hei_Add.TabIndex = 30;
            // 
            // Reg_Add
            // 
            Reg_Add.Location = new Point(290, 104);
            Reg_Add.Name = "Reg_Add";
            Reg_Add.Size = new Size(100, 23);
            Reg_Add.TabIndex = 29;
            Reg_Add.TextChanged += Reg_Add_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(222, 133);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(73, 23);
            textBox4.TabIndex = 28;
            textBox4.Text = "Wheels";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(222, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(73, 23);
            textBox3.TabIndex = 27;
            textBox3.Text = "Weight (KG)";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(222, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 23);
            textBox2.TabIndex = 26;
            textBox2.Text = "Height";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(222, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 25;
            textBox1.Text = "Registration Number";
            // 
            // Car_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 417);
            Controls.Add(Remove);
            Controls.Add(Select_Edit);
            Controls.Add(Add_Edit);
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
            Name = "Car_Screen";
            Text = "Rental Reviewing system-Car";
            Load += Car_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)Output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Remove;
        private ComboBox Select_Edit;
        private Button Add_Edit;
        private TextBox Whe_Edit;
        private TextBox Wei_Edit;
        private TextBox Hei_Edit;
        private TextBox Reg_Edit;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button Check_Button;
        private PictureBox Output;
        private ComboBox Check;
        private ComboBox Select_Add;
        private Button Add;
        private TextBox Whe_Add;
        private TextBox Wei_Add;
        private TextBox Hei_Add;
        private TextBox Reg_Add;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}