
namespace 虎科悠活咖啡館
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.manager = new System.Windows.Forms.TabPage();
            this.m_del = new System.Windows.Forms.Button();
            this.m_up = new System.Windows.Forms.Button();
            this.m_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customer = new System.Windows.Forms.TabPage();
            this.allsee1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.s_text = new System.Windows.Forms.TextBox();
            this.c_s = new System.Windows.Forms.Button();
            this.c_1 = new System.Windows.Forms.Button();
            this.c_5 = new System.Windows.Forms.Button();
            this.c_del = new System.Windows.Forms.Button();
            this.c_up = new System.Windows.Forms.Button();
            this.c_add = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sales = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.allsee2 = new System.Windows.Forms.Button();
            this.date1_2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date1_1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.s_s = new System.Windows.Forms.Button();
            this.s_stext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.m_logout = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.manager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.customer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.manager);
            this.tabControl1.Controls.Add(this.customer);
            this.tabControl1.Controls.Add(this.sales);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(26, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1233, 625);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // manager
            // 
            this.manager.BackColor = System.Drawing.Color.White;
            this.manager.Controls.Add(this.m_del);
            this.manager.Controls.Add(this.m_up);
            this.manager.Controls.Add(this.m_add);
            this.manager.Controls.Add(this.dataGridView1);
            this.manager.Location = new System.Drawing.Point(4, 29);
            this.manager.Name = "manager";
            this.manager.Padding = new System.Windows.Forms.Padding(3);
            this.manager.Size = new System.Drawing.Size(1225, 592);
            this.manager.TabIndex = 0;
            this.manager.Text = "manager";
            // 
            // m_del
            // 
            this.m_del.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_del.Location = new System.Drawing.Point(364, 464);
            this.m_del.Name = "m_del";
            this.m_del.Size = new System.Drawing.Size(89, 63);
            this.m_del.TabIndex = 7;
            this.m_del.Text = "刪除";
            this.m_del.UseVisualStyleBackColor = true;
            this.m_del.Visible = false;
            this.m_del.Click += new System.EventHandler(this.m_del_Click);
            // 
            // m_up
            // 
            this.m_up.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_up.Location = new System.Drawing.Point(566, 464);
            this.m_up.Name = "m_up";
            this.m_up.Size = new System.Drawing.Size(89, 63);
            this.m_up.TabIndex = 6;
            this.m_up.Text = "修改";
            this.m_up.UseVisualStyleBackColor = true;
            this.m_up.Click += new System.EventHandler(this.m_up_Click);
            // 
            // m_add
            // 
            this.m_add.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_add.Location = new System.Drawing.Point(769, 464);
            this.m_add.Name = "m_add";
            this.m_add.Size = new System.Drawing.Size(89, 63);
            this.m_add.TabIndex = 5;
            this.m_add.Text = "新增";
            this.m_add.UseVisualStyleBackColor = true;
            this.m_add.Visible = false;
            this.m_add.Click += new System.EventHandler(this.m_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // customer
            // 
            this.customer.Controls.Add(this.allsee1);
            this.customer.Controls.Add(this.groupBox2);
            this.customer.Controls.Add(this.c_1);
            this.customer.Controls.Add(this.c_5);
            this.customer.Controls.Add(this.c_del);
            this.customer.Controls.Add(this.c_up);
            this.customer.Controls.Add(this.c_add);
            this.customer.Controls.Add(this.dataGridView2);
            this.customer.Location = new System.Drawing.Point(4, 29);
            this.customer.Name = "customer";
            this.customer.Padding = new System.Windows.Forms.Padding(3);
            this.customer.Size = new System.Drawing.Size(1225, 592);
            this.customer.TabIndex = 1;
            this.customer.Text = "customer";
            this.customer.UseVisualStyleBackColor = true;
            // 
            // allsee1
            // 
            this.allsee1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allsee1.Location = new System.Drawing.Point(6, 0);
            this.allsee1.Name = "allsee1";
            this.allsee1.Size = new System.Drawing.Size(1213, 34);
            this.allsee1.TabIndex = 19;
            this.allsee1.Text = "全部顯示";
            this.allsee1.UseVisualStyleBackColor = true;
            this.allsee1.Click += new System.EventHandler(this.allsee1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.s_text);
            this.groupBox2.Controls.Add(this.c_s);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(481, 447);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 132);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "卡號與電話搜尋";
            // 
            // s_text
            // 
            this.s_text.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.s_text.Location = new System.Drawing.Point(12, 38);
            this.s_text.Name = "s_text";
            this.s_text.Size = new System.Drawing.Size(244, 33);
            this.s_text.TabIndex = 6;
            // 
            // c_s
            // 
            this.c_s.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.c_s.Location = new System.Drawing.Point(69, 85);
            this.c_s.Name = "c_s";
            this.c_s.Size = new System.Drawing.Size(127, 37);
            this.c_s.TabIndex = 7;
            this.c_s.Text = "搜尋";
            this.c_s.UseVisualStyleBackColor = true;
            this.c_s.Click += new System.EventHandler(this.c_s_Click);
            // 
            // c_1
            // 
            this.c_1.Location = new System.Drawing.Point(998, 485);
            this.c_1.Name = "c_1";
            this.c_1.Size = new System.Drawing.Size(89, 63);
            this.c_1.TabIndex = 7;
            this.c_1.Text = "消費";
            this.c_1.UseVisualStyleBackColor = true;
            this.c_1.Click += new System.EventHandler(this.c_1_Click);
            // 
            // c_5
            // 
            this.c_5.Location = new System.Drawing.Point(903, 485);
            this.c_5.Name = "c_5";
            this.c_5.Size = new System.Drawing.Size(89, 63);
            this.c_5.TabIndex = 6;
            this.c_5.Text = "寄杯";
            this.c_5.UseVisualStyleBackColor = true;
            this.c_5.Click += new System.EventHandler(this.c_5_Click);
            // 
            // c_del
            // 
            this.c_del.Location = new System.Drawing.Point(286, 485);
            this.c_del.Name = "c_del";
            this.c_del.Size = new System.Drawing.Size(89, 63);
            this.c_del.TabIndex = 4;
            this.c_del.Text = "刪除";
            this.c_del.UseVisualStyleBackColor = true;
            this.c_del.Click += new System.EventHandler(this.c_del_Click);
            // 
            // c_up
            // 
            this.c_up.Location = new System.Drawing.Point(191, 485);
            this.c_up.Name = "c_up";
            this.c_up.Size = new System.Drawing.Size(89, 63);
            this.c_up.TabIndex = 3;
            this.c_up.Text = "修改";
            this.c_up.UseVisualStyleBackColor = true;
            this.c_up.Click += new System.EventHandler(this.c_up_Click);
            // 
            // c_add
            // 
            this.c_add.Location = new System.Drawing.Point(96, 485);
            this.c_add.Name = "c_add";
            this.c_add.Size = new System.Drawing.Size(89, 63);
            this.c_add.TabIndex = 2;
            this.c_add.Text = "新增";
            this.c_add.UseVisualStyleBackColor = true;
            this.c_add.Click += new System.EventHandler(this.c_add_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1213, 399);
            this.dataGridView2.TabIndex = 1;
            // 
            // sales
            // 
            this.sales.Controls.Add(this.label3);
            this.sales.Controls.Add(this.allsee2);
            this.sales.Controls.Add(this.date1_2);
            this.sales.Controls.Add(this.label2);
            this.sales.Controls.Add(this.date1_1);
            this.sales.Controls.Add(this.checkBox3);
            this.sales.Controls.Add(this.checkBox2);
            this.sales.Controls.Add(this.checkBox1);
            this.sales.Controls.Add(this.date2);
            this.sales.Controls.Add(this.s_s);
            this.sales.Controls.Add(this.s_stext);
            this.sales.Controls.Add(this.label1);
            this.sales.Controls.Add(this.dataGridView3);
            this.sales.Location = new System.Drawing.Point(4, 29);
            this.sales.Name = "sales";
            this.sales.Padding = new System.Windows.Forms.Padding(3);
            this.sales.Size = new System.Drawing.Size(1225, 592);
            this.sales.TabIndex = 2;
            this.sales.Text = "sales";
            this.sales.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(183, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "(輸入電話)";
            // 
            // allsee2
            // 
            this.allsee2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allsee2.Location = new System.Drawing.Point(6, 0);
            this.allsee2.Name = "allsee2";
            this.allsee2.Size = new System.Drawing.Size(1213, 34);
            this.allsee2.TabIndex = 18;
            this.allsee2.Text = "全部顯示";
            this.allsee2.UseVisualStyleBackColor = true;
            this.allsee2.Click += new System.EventHandler(this.allsee2_Click);
            // 
            // date1_2
            // 
            this.date1_2.Enabled = false;
            this.date1_2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date1_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1_2.Location = new System.Drawing.Point(473, 552);
            this.date1_2.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.date1_2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.date1_2.Name = "date1_2";
            this.date1_2.Size = new System.Drawing.Size(200, 27);
            this.date1_2.TabIndex = 17;
            this.date1_2.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(554, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "到";
            // 
            // date1_1
            // 
            this.date1_1.Enabled = false;
            this.date1_1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date1_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1_1.Location = new System.Drawing.Point(473, 485);
            this.date1_1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.date1_1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.date1_1.Name = "date1_1";
            this.date1_1.Size = new System.Drawing.Size(200, 27);
            this.date1_1.TabIndex = 15;
            this.date1_1.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox3.Location = new System.Drawing.Point(789, 443);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 28);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "啟用";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox2.Location = new System.Drawing.Point(530, 443);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 28);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "啟用";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(197, 443);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 28);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "啟用";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // date2
            // 
            this.date2.Enabled = false;
            this.date2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(737, 517);
            this.date2.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.date2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 27);
            this.date2.TabIndex = 11;
            // 
            // s_s
            // 
            this.s_s.Enabled = false;
            this.s_s.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.s_s.Location = new System.Drawing.Point(1010, 464);
            this.s_s.Name = "s_s";
            this.s_s.Size = new System.Drawing.Size(150, 97);
            this.s_s.TabIndex = 8;
            this.s_s.Text = "搜尋";
            this.s_s.UseVisualStyleBackColor = true;
            this.s_s.Click += new System.EventHandler(this.s_s_Click);
            // 
            // s_stext
            // 
            this.s_stext.Enabled = false;
            this.s_stext.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.s_stext.Location = new System.Drawing.Point(228, 521);
            this.s_stext.Name = "s_stext";
            this.s_stext.Size = new System.Drawing.Size(170, 27);
            this.s_stext.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(76, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "特定顧客搜尋 :";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 34);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1213, 399);
            this.dataGridView3.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox5);
            this.tabPage1.Controls.Add(this.checkBox6);
            this.tabPage1.Controls.Add(this.dateTimePicker3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1225, 592);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(183, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "(輸入暱稱)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1213, 34);
            this.button1.TabIndex = 31;
            this.button1.Text = "全部顯示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(473, 552);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(554, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "到";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(473, 485);
            this.dateTimePicker2.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 28;
            this.dateTimePicker2.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox4.Location = new System.Drawing.Point(789, 443);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(77, 28);
            this.checkBox4.TabIndex = 27;
            this.checkBox4.Text = "啟用";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox5.Location = new System.Drawing.Point(530, 443);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(77, 28);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.Text = "啟用";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox6.Location = new System.Drawing.Point(197, 443);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(77, 28);
            this.checkBox6.TabIndex = 25;
            this.checkBox6.Text = "啟用";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(737, 517);
            this.dateTimePicker3.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker3.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker3.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(1010, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 97);
            this.button2.TabIndex = 22;
            this.button2.Text = "搜尋";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(228, 521);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 27);
            this.textBox1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(76, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "特定顧客搜尋 :";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 34);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1213, 399);
            this.dataGridView4.TabIndex = 20;
            // 
            // m_logout
            // 
            this.m_logout.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_logout.Location = new System.Drawing.Point(1167, 10);
            this.m_logout.Name = "m_logout";
            this.m_logout.Size = new System.Drawing.Size(76, 38);
            this.m_logout.TabIndex = 11;
            this.m_logout.Text = "登出";
            this.m_logout.UseVisualStyleBackColor = true;
            this.m_logout.Click += new System.EventHandler(this.m_logout_Click);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("新細明體", 28F);
            this.user.Location = new System.Drawing.Point(334, 10);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(827, 38);
            this.user.TabIndex = 12;
            this.user.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.user);
            this.Controls.Add(this.m_logout);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.manager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.customer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.sales.ResumeLayout(false);
            this.sales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage manager;
        private System.Windows.Forms.Button m_del;
        private System.Windows.Forms.Button m_up;
        private System.Windows.Forms.Button m_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage customer;
        private System.Windows.Forms.Button allsee1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox s_text;
        private System.Windows.Forms.Button c_s;
        private System.Windows.Forms.Button c_1;
        private System.Windows.Forms.Button c_5;
        private System.Windows.Forms.Button c_del;
        private System.Windows.Forms.Button c_up;
        private System.Windows.Forms.Button c_add;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage sales;
        private System.Windows.Forms.Button allsee2;
        private System.Windows.Forms.DateTimePicker date1_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date1_1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Button s_s;
        private System.Windows.Forms.TextBox s_stext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button m_logout;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}