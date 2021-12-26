using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 虎科悠活咖啡館
{
    public partial class Form3 : Form
    {
        public int s, id;
        public bool  u;
        public string ac, psd, name, type;
        Class1 c1 = new Class1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_admin.Text == "" || text_password.Text == "" || text_name.Text == "")
            {
                MessageBox.Show("請勿空值", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (c1.CM("select*from manager where m_ac=@m_ac", text_admin.Text) && s == 1)
            {
                MessageBox.Show("帳號已存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (s == 1)
                {
                    c1.CM("insert into manager(m_ac,m_psd,m_name,m_type) values(@m_ac,@m_psd,@m_name,@m_type)", text_admin.Text, text_password.Text, text_name.Text, "", 0,0, 0, 0, Convert.ToInt32(box_type.SelectedIndex)+1);
                    MessageBox.Show("帳號註冊成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (s == 2)
                {
                    c1.CM("update manager set m_psd=@m_psd,m_name=@m_name,m_type=@m_type where m_no=@m_no", "", text_password.Text, text_name.Text, "", 0, id, 0, 0, Convert.ToInt32(box_type.SelectedIndex)+1);
                    MessageBox.Show("帳號更改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (s == 1)
            {
                this.Text = "新增";
                button1.Text = "註冊";
            }
            else if (s == 2)
            {
                this.Text = "修改";
                button1.Text = "更改";
                text_admin.Text = ac;
                text_admin.Enabled = false;
                text_password.Text = psd;
                text_name.Text = name;
                box_type.Text = box_type.Items[Convert.ToInt32(type)-1].ToString();
                if (!u)
                {
                    box_type.Enabled = false;
                }
            }
        }
    }
}
