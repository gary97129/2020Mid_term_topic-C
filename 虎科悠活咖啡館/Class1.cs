using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 虎科悠活咖啡館
{
    class Class1
    {
        public int id = -1;
        public bool CM(string sql = "", string ac_phone = "", string psd_id = "", string name = "", string love = "", int cup_amount = 0, int no = 0, int m_no = 0, int c_no = 0, int type = 0)
        {
            bool flag = false;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            cn.Open();
            if (cn.State == ConnectionState.Open)
            {

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add(new SqlParameter("@m_ac", SqlDbType.NVarChar, 50));
                cmd.Parameters["@m_ac"].Value = ac_phone;

                cmd.Parameters.Add(new SqlParameter("@m_psd", SqlDbType.NVarChar, 50));
                cmd.Parameters["@m_psd"].Value = psd_id;

                cmd.Parameters.Add(new SqlParameter("@m_name", SqlDbType.NVarChar, 50));
                cmd.Parameters["@m_name"].Value = name;

                cmd.Parameters.Add(new SqlParameter("@m_date", SqlDbType.DateTime));
                cmd.Parameters["@m_date"].Value = DateTime.Now;

                cmd.Parameters.Add(new SqlParameter("@m_no", SqlDbType.Int));
                cmd.Parameters["@m_no"].Value = no;

                cmd.Parameters.Add(new SqlParameter("@m_type", SqlDbType.TinyInt));
                cmd.Parameters["@m_type"].Value = type;

                cmd.Parameters.Add(new SqlParameter("@c_no", SqlDbType.Int));
                cmd.Parameters["@c_no"].Value = no;

                cmd.Parameters.Add(new SqlParameter("@c_phone", SqlDbType.NVarChar, 50));
                cmd.Parameters["@c_phone"].Value = ac_phone;

                cmd.Parameters.Add(new SqlParameter("@c_id", SqlDbType.NVarChar, 50));
                cmd.Parameters["@c_id"].Value = psd_id;

                cmd.Parameters.Add(new SqlParameter("@c_name", SqlDbType.NVarChar, 50));
                cmd.Parameters["@c_name"].Value = name;

                cmd.Parameters.Add(new SqlParameter("@c_cup", SqlDbType.Int));
                cmd.Parameters["@c_cup"].Value = cup_amount;

                cmd.Parameters.Add(new SqlParameter("@c_love", SqlDbType.NVarChar, 50));
                cmd.Parameters["@c_love"].Value = love;

                cmd.Parameters.Add(new SqlParameter("@c_date", SqlDbType.DateTime));
                cmd.Parameters["@c_date"].Value = DateTime.Now;

                cmd.Parameters.Add(new SqlParameter("@s_no", SqlDbType.Int));
                cmd.Parameters["@s_no"].Value = no;

                cmd.Parameters.Add(new SqlParameter("@s_c_no", SqlDbType.Int));
                cmd.Parameters["@s_c_no"].Value = c_no;

                cmd.Parameters.Add(new SqlParameter("@s_m_no", SqlDbType.Int));
                cmd.Parameters["@s_m_no"].Value = m_no;

                cmd.Parameters.Add(new SqlParameter("@s_type", SqlDbType.TinyInt));
                cmd.Parameters["@s_type"].Value = type;

                cmd.Parameters.Add(new SqlParameter("@s_date", SqlDbType.DateTime));
                cmd.Parameters["@s_date"].Value = DateTime.Now;

                cmd.Parameters.Add(new SqlParameter("@s_amount", SqlDbType.Int));
                cmd.Parameters["@s_amount"].Value = cup_amount;

                cmd.Parameters.Add(new SqlParameter("@l_no", SqlDbType.Int));
                cmd.Parameters["@l_no"].Value = no;

                cmd.Parameters.Add(new SqlParameter("@l_m_no", SqlDbType.Int));
                cmd.Parameters["@l_m_no"].Value = m_no;

                cmd.Parameters.Add(new SqlParameter("@l_type", SqlDbType.TinyInt));
                cmd.Parameters["@l_type"].Value = type;

                cmd.Parameters.Add(new SqlParameter("@l_date", SqlDbType.DateTime));
                cmd.Parameters["@l_date"].Value = DateTime.Now;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (sql == "select*from manager where m_ac=@m_ac and m_psd=@m_psd") { id = Convert.ToInt32(dr["m_no"]); }
                    flag = true;
                }

            }
            cn.Close();
            return flag;
        }

        public void showtable(string s, DataGridView d, int id)
        {
            int a = 0;
            if (s.Contains("manager"))
            {
                a = 1;
            }
            if (s.Contains("customer"))
            {
                a = 2;
            }
            if (s.Contains("sales"))
            {
                a = 3;
            }
            if (s.Contains("logs"))
            {
                a = 4;
            }
            string[] n = { "", "select * from manager", "select * from customer","select sales.s_no,c_phone,s_type,m_name,s_date,s_amount from sales inner join manager on manager.m_no = sales.s_m_no inner join customer on customer.c_no = sales.s_c_no;", "select logs.l_no,m_name,l_type,l_date from logs inner join manager on manager.m_no = logs.l_m_no" };

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            cn.Open();

            DataSet ds = new DataSet();

            if (cn.State == ConnectionState.Open)
            {
                string sql = s;

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                if (a == 4)
                {
                    da.Fill(ds, s);
                }
                else
                {
                    da.Fill(ds, s);
                }

                d.DataSource = ds.Tables[s];

                d.ColumnHeadersDefaultCellStyle.Font = new Font("標楷體", 14);
                d.DefaultCellStyle.Font = new Font("標楷體", 12);

                if (a==1)
                {
                    d.Columns["m_no"].HeaderText = "編號";
                    d.Columns["m_ac"].HeaderText = "帳號";
                    d.Columns["m_psd"].HeaderText = "密碼";
                    d.Columns["m_name"].HeaderText = "暱稱";
                    d.Columns["m_type"].HeaderText = "職位";
                    d.Columns["m_date"].HeaderText = "最後登入日期";
                }
                else if (a==2)
                {
                    d.Columns["c_no"].HeaderText = "編號";
                    d.Columns["c_phone"].HeaderText = "電話";
                    d.Columns["c_name"].HeaderText = "暱稱";
                    d.Columns["c_id"].HeaderText = "卡號";
                    d.Columns["c_love"].HeaderText = "偏好";
                    d.Columns["c_cup"].HeaderText = "寄杯數";
                    d.Columns["c_date"].HeaderText = "最後消費日期";
                }else if (a == 3)
                {
                    d.Columns["s_no"].HeaderText = "序號";
                    d.Columns["c_phone"].HeaderText = "電話";
                    d.Columns["s_type"].HeaderText = "交易項目";
                    d.Columns["m_name"].HeaderText = "暱稱";
                    d.Columns["s_date"].HeaderText = "交易日期";
                    d.Columns["s_amount"].HeaderText = "個人總消費";
                }
                else if (a == 4)
                {
                    d.Columns["l_no"].HeaderText = "序號";
                    d.Columns["m_name"].HeaderText = "暱稱";
                    d.Columns["l_type"].HeaderText = "登入or登出";
                    d.Columns["l_date"].HeaderText = "登入登出日期";
                }

                for (int j = 0; j < d.Columns.Count; j++)
                {
                    if (j == 0)
                    {
                        d.Columns[j].Width = 75;
                    }
                    else
                    {
                        d.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    d.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
                    d.Columns[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    d.Columns[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                d.AllowUserToAddRows = false;
                d.ReadOnly = true;
                d.AllowUserToResizeColumns = false;
                d.AllowUserToResizeRows = false;
                d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (a==1 && !CM("select*from manager where m_no=@m_no and m_type=@m_type", "", "", "", "", 0, id, 0, 0, 1))
                {
                    d.Columns[0].Visible = false;
                    for (int i = d.RowCount - 1; i >= 0; i--)
                    {
                        if (Convert.ToInt32(d.Rows[i].Cells[0].Value) != id)
                        {
                            d.Rows[i].Visible = false;
                        }
                        else
                        {
                            d.CurrentCell = d.Rows[i].Cells[1];
                        }
                    }
                }
                if (d.RowCount == 0)
                {
                    showtable(n[a],d,id);
                    MessageBox.Show("查無此值", "查詢", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
