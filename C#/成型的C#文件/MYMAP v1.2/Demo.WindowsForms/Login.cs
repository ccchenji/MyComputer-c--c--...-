using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CCWin;
using System.Data.SqlClient;
using System.Configuration;
using Demo.WindowsForms.Forms;

namespace Demo.WindowsForms
{  
    public partial class Login : CCSkinMain
    {
        public Login()
        {
            InitializeComponent();
        }

        public hello hello = new hello();

        private void Login_Load(object sender, EventArgs e)
        {
            
            hello.timer1.Enabled = true;
            hello.ShowDialog();

            this.CenterToParent();                 //居中显示
            SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["coon"].ToString());
            String sql = "select * from [Umaster]";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            skinComboBox1.DataSource = ds.Tables[0];
            skinComboBox1.ValueMember = "Umaster_Name";

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            bool Check_ok = false;   //查找到符合的条目
            String str1 = skinComboBox1.SelectedValue.ToString().Trim();
            String str2 = TextBox1.Text.ToString().Trim();
            SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["coon"].ToString());
            String sql = "select * from [Umaster]";
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                if ((read[1].ToString().Trim() == str1) && (read[2].ToString().Trim() == str2))    //Trim()函数是将字符串开头和结尾的空格去除
                {
                    Form1 frm = new Form1();
                    frm.Sigin_state = true;
                    frm.Sigin_level = (int)read[3];
                    frm.Sigin_name = read[1].ToString();


                    this.Hide();    
                     
                      frm.ShowDialog();
                    Check_ok = true;

                    
                    break;
                }
            }
            if (Check_ok == false)
            {
                MessageBox.Show("对不起，您的用户名/密码不正确，请重新输入");
            }

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Sigin_state = false;
            frm.Sigin_level = 0;
            frm.Sigin_name = "public";

            this.Hide();
            frm.ShowDialog();
           
        }
    }
}
