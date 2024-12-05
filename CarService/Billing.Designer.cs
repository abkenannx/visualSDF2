namespace CarService
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            textBox1 = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            label5 = new Label();
            panel7 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Logout = new Label();
            label9 = new Label();
            BillingMenu = new Label();
            EmployeesMenu = new Label();
            StocksMenu = new Label();
            CarsMenu = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(824, 115);
            textBox1.MaxLength = 12;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Car Number";
            textBox1.Size = new Size(255, 40);
            textBox1.TabIndex = 5;
            textBox1.Text = "Customer Name";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 14);
            label2.Name = "label2";
            label2.Size = new Size(276, 49);
            label2.TabIndex = 4;
            label2.Text = "Bill Information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(275, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(1307, 609);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Candara Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cash", "Card" });
            comboBox1.Location = new Point(824, 280);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 36);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "Payment Method";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Silver;
            textBox5.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(824, 202);
            textBox5.MaxLength = 12;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Customer Phone";
            textBox5.Size = new Size(255, 40);
            textBox5.TabIndex = 20;
            textBox5.Text = "Customer Phone";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Silver;
            textBox4.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(497, 359);
            textBox4.MaxLength = 12;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Car Brand";
            textBox4.Size = new Size(230, 40);
            textBox4.TabIndex = 19;
            textBox4.Text = "Total Price";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(497, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 34);
            dateTimePicker1.TabIndex = 18;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century", 10.2F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(189, 546);
            button4.Name = "button4";
            button4.Size = new Size(117, 41);
            button4.TabIndex = 17;
            button4.Text = "PRINT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(157, 77);
            label5.Name = "label5";
            label5.Size = new Size(166, 35);
            label5.TabIndex = 16;
            label5.Text = "Spare Detals";
            label5.Click += label5_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(83, 115);
            panel7.Name = "panel7";
            panel7.Size = new Size(320, 359);
            panel7.TabIndex = 15;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(295, 489);
            button3.Name = "button3";
            button3.Size = new Size(108, 41);
            button3.TabIndex = 13;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(189, 489);
            button2.Name = "button2";
            button2.Size = new Size(78, 41);
            button2.TabIndex = 12;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(85, 489);
            button1.Name = "button1";
            button1.Size = new Size(73, 41);
            button1.TabIndex = 11;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Silver;
            textBox3.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(497, 204);
            textBox3.MaxLength = 12;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Car Model";
            textBox3.Size = new Size(230, 40);
            textBox3.TabIndex = 7;
            textBox3.Text = "Bill Price";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(497, 280);
            textBox2.MaxLength = 12;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Car Brand";
            textBox2.Size = new Size(230, 40);
            textBox2.TabIndex = 6;
            textBox2.Text = "Service Fees";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(65, 624);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(40, 45);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 22;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(36, 420);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(58, 61);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(36, 351);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(58, 61);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(36, 282);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(36, 495);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(0, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(30, 801);
            panel6.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(-14, -10);
            panel5.Name = "panel5";
            panel5.Size = new Size(347, 38);
            panel5.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-58, 789);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 36);
            panel4.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 215);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 150);
            label4.Name = "label4";
            label4.Size = new Size(97, 36);
            label4.TabIndex = 5;
            label4.Text = "MENU";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 654);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 47);
            label3.Name = "label3";
            label3.Size = new Size(208, 47);
            label3.TabIndex = 3;
            label3.Text = "AB Garage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 74);
            label1.Name = "label1";
            label1.Size = new Size(119, 49);
            label1.TabIndex = 2;
            label1.Text = "Billing";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1381, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(BillingMenu);
            panel2.Controls.Add(EmployeesMenu);
            panel2.Controls.Add(StocksMenu);
            panel2.Controls.Add(CarsMenu);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 821);
            panel2.TabIndex = 0;
            // 
            // Logout
            // 
            Logout.AutoSize = true;
            Logout.Cursor = Cursors.Hand;
            Logout.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            Logout.ForeColor = Color.Black;
            Logout.Location = new Point(103, 635);
            Logout.Name = "Logout";
            Logout.Size = new Size(90, 27);
            Logout.TabIndex = 34;
            Logout.Text = "Log out";
            Logout.Click += Logout_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(103, 504);
            label9.Name = "label9";
            label9.Size = new Size(108, 27);
            label9.TabIndex = 33;
            label9.Text = "Analytics";
            label9.Click += AnalyticsMenu_Click;
            // 
            // BillingMenu
            // 
            BillingMenu.AutoSize = true;
            BillingMenu.Cursor = Cursors.Hand;
            BillingMenu.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            BillingMenu.ForeColor = Color.Blue;
            BillingMenu.Location = new Point(103, 442);
            BillingMenu.Name = "BillingMenu";
            BillingMenu.Size = new Size(81, 27);
            BillingMenu.TabIndex = 32;
            BillingMenu.Text = "Billing";
            BillingMenu.Click += BillingMenu_Click;
            // 
            // EmployeesMenu
            // 
            EmployeesMenu.AutoSize = true;
            EmployeesMenu.Cursor = Cursors.Hand;
            EmployeesMenu.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            EmployeesMenu.ForeColor = Color.Black;
            EmployeesMenu.Location = new Point(103, 371);
            EmployeesMenu.Name = "EmployeesMenu";
            EmployeesMenu.Size = new Size(125, 27);
            EmployeesMenu.TabIndex = 31;
            EmployeesMenu.Text = "Employees";
            EmployeesMenu.Click += EmployeesMenu_Click;
            // 
            // StocksMenu
            // 
            StocksMenu.AutoSize = true;
            StocksMenu.Cursor = Cursors.Hand;
            StocksMenu.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            StocksMenu.ForeColor = Color.Black;
            StocksMenu.Location = new Point(103, 303);
            StocksMenu.Name = "StocksMenu";
            StocksMenu.Size = new Size(70, 27);
            StocksMenu.TabIndex = 30;
            StocksMenu.Text = "Stock";
            StocksMenu.Click += StockMenu_Click;
            // 
            // CarsMenu
            // 
            CarsMenu.AutoSize = true;
            CarsMenu.Cursor = Cursors.Hand;
            CarsMenu.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            CarsMenu.ForeColor = Color.Black;
            CarsMenu.Location = new Point(103, 233);
            CarsMenu.Name = "CarsMenu";
            CarsMenu.Size = new Size(59, 27);
            CarsMenu.TabIndex = 29;
            CarsMenu.Text = "Cars";
            CarsMenu.Click += CarsMenu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1604, 821);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 821);
            Controls.Add(panel1);
            Name = "Billing";
            Text = "Billing";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel panel1;
        private Label Logout;
        private Label label9;
        private Label BillingMenu;
        private Label EmployeesMenu;
        private Label StocksMenu;
        private Label CarsMenu;
        private Panel panel7;
        private Label label5;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
    }
}