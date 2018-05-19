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
    public partial class Useradd : CCSkinMain
    {
        public Useradd()
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

        private void skinButton1_Click(object sender, EventArgs e)
        {

            if (skinWaterTextBox1.Text == "" || skinWaterTextBox2.Text == "" || skinWaterTextBox3.Text == "" || skinWaterTextBox4.Text == "")
                MessageBox.Show("请输入数据，进行添加");
            else
            {
                String str = ConfigurationSettings.AppSettings["coon"].ToString();
                SqlConnection conn = new SqlConnection(str);
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }

                try
                {
                    SqlDataAdapter d = new SqlDataAdapter();
                    d.InsertCommand = new SqlCommand("INSERT INTO Umaster(Umaster_ID,Umaster_Name,Umaster_Password,Umaster_Level_State)Values('" + skinWaterTextBox1.Text + "',+'" + skinWaterTextBox2.Text + "','" + skinWaterTextBox3.Text + "','" + skinWaterTextBox4.Text + "')", conn);
                    d.InsertCommand.ExecuteNonQuery();
                    skinWaterTextBox1.Text = "";
                    skinWaterTextBox2.Text = "";
                    skinWaterTextBox3.Text = "";
                    skinWaterTextBox4.Text = "";
                    MessageBox.Show("添加成功");
                }
                catch { }
                conn.Close();

            }


        }

        private void useradd_time_Tick(object sender, EventArgs e)
        {
            Ref1();
        }

        private void Useradd_Load(object sender, EventArgs e)
        {

        }
    }
}
