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
    public partial class Form2 : Form
    {
        Class1 c1 = new Class1();
        public bool logout = false;
        public int id;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            date1_1.CustomFormat = "yyyy/MM/dd";
            date1_2.CustomFormat = "yyyy/MM/dd";
            date2.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            dateTimePicker3.CustomFormat = "yyyy/MM/dd";
            date1_1.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
            date1_2.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
            date2.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
            dateTimePicker2.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
            dateTimePicker3.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
            if (c1.CM("select*from manager where m_no=@m_no and m_type=@m_type", "", "", "", "", 0, id, 0, 0, 1))
            {
                m_del.Visible = true;
                m_add.Visible = true;
            }
            c1.showtable($"select * from manager", dataGridView1, id);
            c1.showtable($"select * from customer", dataGridView2, id);
            c1.showtable($"select sales.s_no,c_phone,s_type,m_name,s_date,s_amount from sales inner join manager on manager.m_no = sales.s_m_no inner join customer on customer.c_no = sales.s_c_no;", dataGridView3, id);
            c1.showtable("select logs.l_no,m_name,l_type,l_date from logs inner join manager on manager.m_no = logs.l_m_no", dataGridView4, id);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == id)
                {
                    user.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    Text = "虎科悠活咖啡館  使用者 : " + dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
            }
        }

        private void m_add_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.s = 1;
            f3.id = dataGridView1.RowCount;
            f3.ShowDialog();
            c1.showtable($"select * from manager", dataGridView1, id);
        }

        private void m_up_Click(object sender, EventArgs e)
        {
            bool u = true;
            if (Convert.ToInt32(dataGridView1.SelectedCells[0].Value) == id)
            {
                u = false;
            }
            Form3 f3 = new Form3();
            f3.s = 2;
            f3.ac = dataGridView1.SelectedCells[1].Value.ToString();
            f3.psd = dataGridView1.SelectedCells[2].Value.ToString();
            f3.name = dataGridView1.SelectedCells[3].Value.ToString();
            f3.id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            f3.type = dataGridView1.SelectedCells[4].Value.ToString();
            f3.u = u;
            f3.ShowDialog();
            c1.showtable($"select * from manager", dataGridView1, id);
        }

        private void m_del_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

            DialogResult f_del = MessageBox.Show("確定刪除" + dataGridView1.SelectedCells[3].Value.ToString() + "?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (no != id && f_del == DialogResult.Yes)
            {
                c1.CM("delete from manager where m_no=@m_no", "", "", "", "", 0, no);
                c1.showtable($"select * from manager", dataGridView1, id);
            }
            else if (no == id && f_del == DialogResult.Yes)
            {
                MessageBox.Show("無法刪除自己", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void allsee1_Click(object sender, EventArgs e)
        {
            s_text.Text = "";
            c1.showtable($"select * from customer", dataGridView2, id);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1.showtable($"select * from manager", dataGridView1, id);
            c1.showtable($"select * from customer", dataGridView2, id);
            c1.showtable($"select sales.s_no,c_phone,s_type,m_name,s_date,s_amount from sales inner join manager on manager.m_no = sales.s_m_no inner join customer on customer.c_no = sales.s_c_no;", dataGridView3, id);
            c1.showtable("select logs.l_no,m_name,l_type,l_date from logs inner join manager on manager.m_no = logs.l_m_no", dataGridView4, id);
        }

        private void m_logout_Click(object sender, EventArgs e)
        {
            DialogResult f_logout = MessageBox.Show("確定登出?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f_logout == DialogResult.Yes)
            {
                logout = true;
                Close();
            }
        }

        private void c_add_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.s = 1;
            f4.id = dataGridView2.RowCount;
            f4.ShowDialog();
            c1.showtable($"select * from customer", dataGridView2, id);
        }

        private void c_up_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.s = 2;
            f4.phone = dataGridView2.SelectedCells[1].Value.ToString();
            f4.name = dataGridView2.SelectedCells[2].Value.ToString();
            f4.card = dataGridView2.SelectedCells[3].Value.ToString();
            f4.love = dataGridView2.SelectedCells[4].Value.ToString();
            f4.cup = Convert.ToInt32(dataGridView2.SelectedCells[5].Value);
            f4.id = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
            f4.ShowDialog();
            c1.showtable($"select * from customer", dataGridView2, id);
        }

        private void c_del_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);

            DialogResult f_del = MessageBox.Show("確定刪除" + dataGridView2.SelectedCells[2].Value.ToString() + "?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (f_del == DialogResult.Yes)
            {
                c1.CM("delete from customer where c_no=@c_no", "", "", "", "", 0, no);
                c1.showtable($"select * from customer", dataGridView2, id);
            }
        }

        private void c_5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(dataGridView2.CurrentCell.RowIndex);
            c1.CM("update customer set c_cup=@c_cup,c_date=@c_date where c_no=@c_no", "", "", "", "", Convert.ToInt32(dataGridView2.SelectedCells[5].Value) + 5, Convert.ToInt32(dataGridView2.SelectedCells[0].Value));
            c1.CM("insert into sales(s_c_no,s_type,s_m_no,s_date,s_amount) values(@s_c_no,@s_type,@s_m_no,@s_date,@s_amount)", "", "", "", "",5, 0, id,Convert.ToInt32(dataGridView2.SelectedCells[0].Value), 1);
            c1.showtable($"select * from customer", dataGridView2, id);
            c1.showtable($"select sales.s_no,c_phone,s_type,m_name,s_date,s_amount from sales inner join manager on manager.m_no = sales.s_m_no inner join customer on customer.c_no = sales.s_c_no;", dataGridView3, id);
            dataGridView2.CurrentCell = dataGridView2.Rows[x].Cells[1];
        }

        private void c_1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView2.SelectedCells[5].Value) > 0)
            {
                int x = Convert.ToInt32(dataGridView2.CurrentCell.RowIndex);
                c1.CM("update customer set c_cup=@c_cup,c_date=@c_date where c_no=@c_no", "", "", "", "", Convert.ToInt32(dataGridView2.SelectedCells[5].Value) - 1, Convert.ToInt32(dataGridView2.SelectedCells[0].Value));
                c1.CM("insert into sales(s_c_no,s_type,s_m_no,s_date,s_amount) values(@s_c_no,@s_type,@s_m_no,@s_date,@s_amount)", "", "", "", "", 1, 0, id, Convert.ToInt32(dataGridView2.SelectedCells[0].Value), 2);
                c1.showtable($"select * from customer", dataGridView2, id);
                c1.showtable($"select sales.s_no,c_phone,s_type,m_name,s_date,s_amount from sales inner join manager on manager.m_no = sales.s_m_no inner join customer on customer.c_no = sales.s_c_no;", dataGridView3, id);
                dataGridView2.CurrentCell = dataGridView2.Rows[x].Cells[1];
            }
            else
            {
                MessageBox.Show("無法少於0", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c_s_Click(object sender, EventArgs e)
        {
            if (s_text.Text != "")
            {
                c1.showtable($"select * from customer where c_id like '%" + s_text.Text + "%' or c_phone like '%" + s_text.Text + "%'", dataGridView2, id);
            }
        }

        private void s_s_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                c1.showtable($"select sales.s_no,c_phone,s_type,m_name,s_date,s_amount from sales inner join manager on manager.m_no = sales.s_m_no inner join customer on customer.c_no = sales.s_c_no where c_phone like '%" + s_stext.Text + "%' and s_type = '1';", dataGridView3, id);
            }
            else if(checkBox2.Checked)
            {
                c1.showtable($"select sales.s_no,c_phone,s_type,m_name,s_date,s_amount from sales inner join manager on manager.m_no = sales.s_m_no inner join customer on customer.c_no = sales.s_c_no where s_date between '" + date1_1.Text.Replace("/", "") + " 00:00:00.000' AND '" + date1_2.Text.Replace("/", "") + " 23:59:59.997' and s_type = '1'", dataGridView3, id);
            }
            else if (checkBox3.Checked)
            {
                c1.showtable($"select sales.s_no,c_phone,s_type,m_name,s_date,s_amount from sales inner join manager on manager.m_no = sales.s_m_no inner join customer on customer.c_no = sales.s_c_no where s_date between '" + date2.Text.Replace("/","") + " 00:00:00.000' AND '" + date2.Text.Replace("/", "") + " 23:59:59.997' and s_type = '1'", dataGridView3, id);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                label1.Enabled = true;
                label3.Enabled = true;
                s_stext.Enabled = true;
                s_s.Enabled = true;
            }
            else
            {
                label1.Enabled = false;
                label3.Enabled = false;
                s_stext.Enabled = false;
                s_s.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                label2.Enabled = true;
                date1_1.Enabled = true;
                date1_2.Enabled = true;
                s_s.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
                date1_1.Enabled = false;
                date1_2.Enabled = false;
                s_s.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                date2.Enabled = true;
                s_s.Enabled = true;
            }
            else
            {
                date2.Enabled = false;
                s_s.Enabled = false;
            }
        }

        private void allsee2_Click(object sender, EventArgs e)
        {
            c1.showtable($"select sales.s_no,c_phone,s_type,m_name,s_date,s_amount from sales inner join manager on manager.m_no = sales.s_m_no inner join customer on customer.c_no = sales.s_c_no;", dataGridView3, id);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox5.Checked = false;
                checkBox4.Checked = false;
                label6.Enabled = true;
                label4.Enabled = true;
                textBox1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                label6.Enabled = false;
                label4.Enabled = false;
                textBox1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
                checkBox6.Checked = false;
                label5.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                label5.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                dateTimePicker3.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                dateTimePicker3.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                c1.showtable($"select logs.l_no,m_name,l_type,l_date from logs inner join manager on manager.m_no = logs.l_m_no where m_name like '" + textBox1.Text + "';", dataGridView4, id);
            }
            else if (checkBox5.Checked)
            {
                c1.showtable($"select logs.l_no,m_name,l_type,l_date from logs inner join manager on manager.m_no = logs.l_m_no where l_date between '" + dateTimePicker2.Text.Replace("/", "") + " 00:00:00.000' AND '" + dateTimePicker1.Text.Replace("/", "") + " 23:59:59.997'", dataGridView4, id);
            }
            else if (checkBox4.Checked)
            {
                c1.showtable($"select logs.l_no,m_name,l_type,l_date from logs inner join manager on manager.m_no = logs.l_m_no where l_date between '" + dateTimePicker3.Text.Replace("/", "") + " 00:00:00.000' AND '" + dateTimePicker3.Text.Replace("/", "") + " 23:59:59.997'", dataGridView4, id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.showtable($"select logs.l_no,m_name,l_type,l_date from logs inner join manager on manager.m_no = logs.l_m_no;", dataGridView4, id);
        }
    }
}
