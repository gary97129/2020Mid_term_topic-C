
namespace 虎科悠活咖啡館
{
    partial class Form3
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
            this.box_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_admin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box_type
            // 
            this.box_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_type.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.box_type.FormattingEnabled = true;
            this.box_type.Items.AddRange(new object[] {
            "主管",
            "員工"});
            this.box_type.Location = new System.Drawing.Point(116, 24);
            this.box_type.Name = "box_type";
            this.box_type.Size = new System.Drawing.Size(160, 29);
            this.box_type.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(23, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "職位 :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(113, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("新細明體", 13.5F);
            this.text_name.Location = new System.Drawing.Point(116, 174);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(160, 29);
            this.text_name.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(23, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "暱稱 :";
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("新細明體", 13.5F);
            this.text_password.Location = new System.Drawing.Point(116, 125);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(160, 29);
            this.text_password.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "密碼 :";
            // 
            // text_admin
            // 
            this.text_admin.Font = new System.Drawing.Font("新細明體", 13.5F);
            this.text_admin.Location = new System.Drawing.Point(116, 74);
            this.text_admin.Name = "text_admin";
            this.text_admin.Size = new System.Drawing.Size(160, 29);
            this.text_admin.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "帳號 :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 295);
            this.Controls.Add(this.box_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_admin);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_admin;
        private System.Windows.Forms.Label label1;
    }
}