namespace WinFormsApp1.forms
{
    partial class form_Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Dashboard));
            panelLeft = new Panel();
            btn_sales = new Button();
            btn_expenses = new Button();
            btn_settings = new Button();
            btn_purchase = new Button();
            btn_saleBooks = new Button();
            btn_home = new Button();
            sidePanel = new Panel();
            panel4 = new Panel();
            btn_dropDown = new Button();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_logOff2 = new Button();
            btn_logOff = new Button();
            label2 = new Label();
            panel3 = new Panel();
            label_time = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            time_timer = new System.Windows.Forms.Timer(components);
            panelLeft.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.RoyalBlue;
            panelLeft.Controls.Add(btn_sales);
            panelLeft.Controls.Add(btn_expenses);
            panelLeft.Controls.Add(btn_settings);
            panelLeft.Controls.Add(btn_purchase);
            panelLeft.Controls.Add(btn_saleBooks);
            panelLeft.Controls.Add(btn_home);
            panelLeft.Controls.Add(sidePanel);
            panelLeft.Controls.Add(panel4);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(215, 720);
            panelLeft.TabIndex = 0;
            // 
            // btn_sales
            // 
            btn_sales.FlatAppearance.BorderSize = 0;
            btn_sales.FlatStyle = FlatStyle.Flat;
            btn_sales.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sales.ForeColor = Color.White;
            btn_sales.Image = (Image)resources.GetObject("btn_sales.Image");
            btn_sales.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sales.Location = new Point(9, 490);
            btn_sales.Name = "btn_sales";
            btn_sales.Size = new Size(203, 60);
            btn_sales.TabIndex = 9;
            btn_sales.Text = "            Sales";
            btn_sales.TextAlign = ContentAlignment.MiddleLeft;
            btn_sales.UseVisualStyleBackColor = true;
            btn_sales.Click += btn_sales_Click;
            // 
            // btn_expenses
            // 
            btn_expenses.FlatAppearance.BorderSize = 0;
            btn_expenses.FlatStyle = FlatStyle.Flat;
            btn_expenses.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_expenses.ForeColor = Color.White;
            btn_expenses.Image = (Image)resources.GetObject("btn_expenses.Image");
            btn_expenses.ImageAlign = ContentAlignment.MiddleLeft;
            btn_expenses.Location = new Point(9, 414);
            btn_expenses.Name = "btn_expenses";
            btn_expenses.Size = new Size(203, 60);
            btn_expenses.TabIndex = 7;
            btn_expenses.Text = "            Expenses";
            btn_expenses.TextAlign = ContentAlignment.MiddleLeft;
            btn_expenses.UseVisualStyleBackColor = true;
            btn_expenses.Click += btn_expenses_Click;
            // 
            // btn_settings
            // 
            btn_settings.FlatAppearance.BorderSize = 0;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_settings.ForeColor = Color.White;
            btn_settings.Image = (Image)resources.GetObject("btn_settings.Image");
            btn_settings.ImageAlign = ContentAlignment.MiddleLeft;
            btn_settings.Location = new Point(9, 565);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(203, 60);
            btn_settings.TabIndex = 5;
            btn_settings.Text = "            Settings\r\n";
            btn_settings.TextAlign = ContentAlignment.MiddleLeft;
            btn_settings.UseVisualStyleBackColor = true;
            btn_settings.Click += btn_settings_Click;
            // 
            // btn_purchase
            // 
            btn_purchase.FlatAppearance.BorderSize = 0;
            btn_purchase.FlatStyle = FlatStyle.Flat;
            btn_purchase.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_purchase.ForeColor = Color.White;
            btn_purchase.Image = (Image)resources.GetObject("btn_purchase.Image");
            btn_purchase.ImageAlign = ContentAlignment.MiddleLeft;
            btn_purchase.Location = new Point(9, 339);
            btn_purchase.Name = "btn_purchase";
            btn_purchase.Size = new Size(203, 60);
            btn_purchase.TabIndex = 5;
            btn_purchase.Text = "            Purchase";
            btn_purchase.TextAlign = ContentAlignment.MiddleLeft;
            btn_purchase.UseVisualStyleBackColor = true;
            btn_purchase.Click += btn_purchase_Click;
            // 
            // btn_saleBooks
            // 
            btn_saleBooks.FlatAppearance.BorderSize = 0;
            btn_saleBooks.FlatStyle = FlatStyle.Flat;
            btn_saleBooks.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_saleBooks.ForeColor = Color.White;
            btn_saleBooks.Image = (Image)resources.GetObject("btn_saleBooks.Image");
            btn_saleBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btn_saleBooks.Location = new Point(9, 271);
            btn_saleBooks.Name = "btn_saleBooks";
            btn_saleBooks.Size = new Size(203, 60);
            btn_saleBooks.TabIndex = 5;
            btn_saleBooks.Text = "            Sale Books";
            btn_saleBooks.TextAlign = ContentAlignment.MiddleLeft;
            btn_saleBooks.UseVisualStyleBackColor = true;
            btn_saleBooks.Click += btn_saleBooks_Click;
            // 
            // btn_home
            // 
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.ForeColor = Color.White;
            btn_home.Image = (Image)resources.GetObject("btn_home.Image");
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(9, 201);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(203, 60);
            btn_home.TabIndex = 3;
            btn_home.Text = "            Home";
            btn_home.TextAlign = ContentAlignment.MiddleLeft;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.White;
            sidePanel.Location = new Point(0, 201);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(7, 60);
            sidePanel.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_dropDown);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 138);
            panel4.TabIndex = 0;
            // 
            // btn_dropDown
            // 
            btn_dropDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_dropDown.FlatAppearance.BorderSize = 0;
            btn_dropDown.FlatStyle = FlatStyle.Flat;
            btn_dropDown.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dropDown.ForeColor = Color.White;
            btn_dropDown.Image = (Image)resources.GetObject("btn_dropDown.Image");
            btn_dropDown.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dropDown.Location = new Point(169, -1);
            btn_dropDown.Name = "btn_dropDown";
            btn_dropDown.Size = new Size(39, 46);
            btn_dropDown.TabIndex = 4;
            btn_dropDown.TextAlign = ContentAlignment.MiddleLeft;
            btn_dropDown.UseVisualStyleBackColor = true;
            btn_dropDown.Click += btn_dropDown_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 138);
            panel6.Name = "panel6";
            panel6.Size = new Size(12, 66);
            panel6.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 103);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 3;
            label1.Text = "Inkling";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_logOff2);
            panel1.Controls.Add(btn_logOff);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(215, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 52);
            panel1.TabIndex = 1;
            // 
            // btn_logOff2
            // 
            btn_logOff2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logOff2.BackColor = Color.Transparent;
            btn_logOff2.FlatAppearance.BorderSize = 0;
            btn_logOff2.FlatStyle = FlatStyle.Flat;
            btn_logOff2.ForeColor = Color.White;
            btn_logOff2.Image = (Image)resources.GetObject("btn_logOff2.Image");
            btn_logOff2.Location = new Point(904, -4);
            btn_logOff2.Name = "btn_logOff2";
            btn_logOff2.Size = new Size(75, 56);
            btn_logOff2.TabIndex = 8;
            btn_logOff2.TextAlign = ContentAlignment.TopRight;
            btn_logOff2.UseVisualStyleBackColor = false;
            btn_logOff2.Click += btn_logOff2_Click;
            // 
            // btn_logOff
            // 
            btn_logOff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logOff.BackColor = Color.Transparent;
            btn_logOff.FlatAppearance.BorderSize = 0;
            btn_logOff.FlatStyle = FlatStyle.Flat;
            btn_logOff.ForeColor = Color.AliceBlue;
            btn_logOff.Image = (Image)resources.GetObject("btn_logOff.Image");
            btn_logOff.Location = new Point(1011, 0);
            btn_logOff.Name = "btn_logOff";
            btn_logOff.Size = new Size(75, 56);
            btn_logOff.TabIndex = 7;
            btn_logOff.TextAlign = ContentAlignment.TopRight;
            btn_logOff.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(22, 15);
            label2.Name = "label2";
            label2.Size = new Size(330, 21);
            label2.TabIndex = 0;
            label2.Text = "Inkling Books and Stationary, Bahawalpur";
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(label_time);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(215, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 86);
            panel3.TabIndex = 2;
            // 
            // label_time
            // 
            label_time.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_time.AutoSize = true;
            label_time.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_time.ForeColor = Color.Transparent;
            label_time.Location = new Point(892, 59);
            label_time.Name = "label_time";
            label_time.Size = new Size(87, 19);
            label_time.TabIndex = 6;
            label_time.Text = " HH:MM:SS";
            label_time.TextAlign = ContentAlignment.MiddleCenter;
            label_time.Click += time_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(486, 41);
            label5.Name = "label5";
            label5.Size = new Size(108, 19);
            label5.TabIndex = 5;
            label5.Text = " Mirza Rehan";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(415, 41);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 4;
            label4.Text = "Admin:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(467, 12);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 3;
            label3.Text = "Welcome";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // time_timer
            // 
            time_timer.Tick += time_timer_Tick;
            // 
            // form_Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1200, 720);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panelLeft);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Dashboard";
            Text = "form_Dashboard";
            WindowState = FormWindowState.Maximized;
            panelLeft.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLeft;
        private Panel panel4;
        private Button btn_home;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private Panel sidePanel;
        private Button btn_settings;
        private Button btn_purchase;
        private Button btn_saleBooks;
        private Button btn_sales;
        private Button btn_expenses;
        private Button btn_dropDown;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button btn_logOff;
        private Label label_time;
        private System.Windows.Forms.Timer timer1;
        private Button btn_logOff2;
        private System.Windows.Forms.Timer time_timer;
    }
}