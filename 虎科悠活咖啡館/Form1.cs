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
    public partial class Form1 : Form
    {
        Class1 c1 = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool login = c1.CM("select*from manager where m_ac=@m_ac and m_psd=@m_psd", text_admin.Text, text_password.Text);
            if (login)
            {
                c1.CM("update manager set m_date=@m_date where m_no=@m_no", "", "", "", "", 0, c1.id);
                c1.CM("insert into logs(l_m_no,l_type,l_date) values(@l_m_no,@l_type,@l_date)", "", "", "", "", 0,0, c1.id, 0, 1);
                Form2 f2 = new Form2();
                f2.id = c1.id;
                Hide();
                f2.ShowDialog();
                c1.CM("insert into logs(l_m_no,l_type,l_date) values(@l_m_no,@l_type,@l_date)","","","","",0,0,c1.id,0,2);
                if (f2.logout == true)
                {
                    text_admin.Text = "";
                    text_password.Text = "";
                    Show();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
