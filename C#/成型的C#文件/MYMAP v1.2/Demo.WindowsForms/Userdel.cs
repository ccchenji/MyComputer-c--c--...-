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
    public partial class Userdel : CCSkinMain
    {
        public Userdel()
        {
            InitializeComponent();
        }


        private void Ref1()
        {
            /******************************填充整表**********************************/
            String myselect = "select * from [Umaster]";
            String str = ConfigurationSettings.AppSettings["coon"].ToString();
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter adap = new SqlDataAdapter(myselect, conn);
            DataSet dts = new DataSet();
            adap.Fill(dts);
            conn.Close();
            /***********************************************************************/

            skinDataGridView1.DataSource = dts.Tables[0];

            //设置dataGridView1控件第一列的列头文字
            skinDataGridView1.Columns[0].HeaderText = "ID编号";
            //设置dataGridView1控件第一列的列宽
            skinDataGridView1.Columns[0].Width = 80;

            skinDataGridView1.Columns[1].HeaderText = "用户名";
            skinDataGridView1.Columns[1].Width = 90;
            skinDataGridView1.Columns[2].HeaderText = "密码";
            skinDataGridView1.Columns[2].Width = 100;
            skinDataGridView1.Columns[3].HeaderText = "权限等级";
            skinDataGridView1.Columns[3].Width = 90;
        }

        /// <summary>
        /// 判断输入数据是不是一个数
        /// </summary>
        /// <param name="message"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private bool isNumberic(string message, out int result)
        {
            //判断是否为整数字符串
            //是的话则将其转换为数字并将其设为out类型的输出值、返回true, 否则为false
            result = -1;   //result 定义为out 用来输出值
            try
            {
                //当数字字符串的为是少于4时，以下三种都可以转换，任选一种
                //如果位数超过4的话，请选用Convert.ToInt32() 和int.Parse()

                //result = int.Parse(message);
                //result = Convert.ToInt16(message);
                result = Convert.ToInt32(message);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void userdeltime_Tick(object sender, EventArgs e)
        {
            Ref1();
        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {
            String str = ConfigurationSettings.AppSettings["coon"].ToString();
            SqlConnection conn = new SqlConnection(str);
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            int combox1text = 0;
            String myselect;
            if (skinWaterTextBox1.Text == "")
            {
                skinWaterTextBox1.Text = "";
                skinWaterTextBox2.Text = "";
                skinWaterTextBox3.Text = "";
                skinWaterTextBox4.Text = "";

            }
            if (isNumberic(skinWaterTextBox1.Text, out combox1text))
            {
                myselect = "select * from Umaster where Umaster_ID='" + skinWaterTextBox1.Text + "'";
                //在执行这句话之前检查一下combox1里的值满不满足条件  防止错误

                SqlCommand comm = new SqlCommand(myselect, conn); //建立查询
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    skinWaterTextBox1.Text = reader[0].ToString();
                    skinWaterTextBox2.Text = reader[1].ToString();
                    skinWaterTextBox3.Text = reader[2].ToString();
                    skinWaterTextBox4.Text = reader[3].ToString();
                }

            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要删除这条数据！", "删除信息", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String str = ConfigurationSettings.AppSettings["coon"].ToString();

                SqlConnection conn = new SqlConnection(str);
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }

                SqlDataAdapter d = new SqlDataAdapter();
                d.DeleteCommand = new SqlCommand("DELETE from Umaster where Umaster_ID='" + skinWaterTextBox1.Text + "'", conn);
                d.DeleteCommand.ExecuteNonQuery();
                conn.Close();

                skinWaterTextBox1.Text = "";
                skinWaterTextBox2.Text = "";
                skinWaterTextBox3.Text = "";
                skinWaterTextBox4.Text = "";
                //RefreshList();
            }
        }

        private void skinLabel3_Click(object sender, EventArgs e)
        {

        }
    }

}
