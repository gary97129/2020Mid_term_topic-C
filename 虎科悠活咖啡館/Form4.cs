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
    public partial class Form4 : Form

    {
        Class1 c1 = new Class1();
        public int s, id, cup;
        public string phone, name, card, love;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_phone.Text == "" || text_love.Text == "")
            {
                MessageBox.Show("請勿空值", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (c1.CM("select*from customer where c_phone=@c_phone", text_phone.Text) && (s == 1 || phone != text_phone.Text))
            {
                MessageBox.Show("手機已存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (text_phone.Text.Length != 10)
            {
                MessageBox.Show("電話不正確", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (text_id.Text != "" && c1.CM("select*from customer where c_id=@c_id", "", text_id.Text) && (s == 1 || card != text_id.Text))
            {
                MessageBox.Show("卡號已存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (text_id.Text != "" && text_id.Text.Length != 10)
            {
                MessageBox.Show("卡號不是十位數", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (s == 1)
                {
                    c1.CM("insert into customer(c_phone,c_name,c_id,c_love,c_cup) values(@c_phone,@c_name,@c_id,@c_love,@c_cup)", text_phone.Text, text_id.Text, text_name.Text, text_love.Text, 0);
                    MessageBox.Show("帳號新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (s == 2)
                {
                    c1.CM("update customer set c_phone=@c_phone,c_id=@c_id,c_name=@c_name,c_love=@c_love where c_no=@c_no", text_phone.Text, text_id.Text, text_name.Text, text_love.Text, cup, id);
                    MessageBox.Show("帳號更改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (s == 1)
            {
                this.Text = "新增";
                button1.Text = "新增";
            }
            else if (s == 2)
            {
                this.Text = "修改";
                button1.Text = "更改";
                text_phone.Text = phone;
                text_name.Text = name;
                text_id.Text = card;
                text_love.Text = love;
            }
        }
    }
}
