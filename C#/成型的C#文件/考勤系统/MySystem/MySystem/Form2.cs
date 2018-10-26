using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace MySystem
{
    public partial class Form2 : Form
    {
        public string TableName { get; set; }//显示的表的名称
        private string path;
        public event EventHandler Form2Closing;//Form2窗口关闭事件
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string tableName, string path)
        {
            InitializeComponent();
            this.TableName = tableName;
            this.path = path;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;//先屏蔽掉上传到数据库的按钮
        }
        /// <summary>
        /// 查询所有的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlCeConnection conn = new SqlCeConnection(path))
            {
                conn.Open();
                using (SqlCeCommand comm = new SqlCeCommand($"select * from {TableName}", conn))
                {
                    SqlCeDataAdapter ceDataAdapter = new SqlCeDataAdapter(comm);
                    ceDataAdapter.SelectCommand.ExecuteNonQuery();
                    DataSet dataSet = new DataSet();
                    dataSet.Clear();
                    ceDataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                    button3.Enabled = true;//这时就可以上传数据
                }
            }
        }
        /// <summary>
        /// 窗口关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form2Closing != null)
            {
                Form2Closing(this, new EventArgs());
            }
        }
        /// <summary>
        /// 上传到数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlCeConnection conn = new SqlCeConnection(path))
            {
                conn.Open();
                SqlCeCommand comm;
                using (comm = new SqlCeCommand($"DELETE FROM {TableName}", conn))//先清空表中的数据然后再写入
                {
                    comm.ExecuteNonQuery();
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string name = dataGridView1.Rows[i].Cells["姓名"].EditedFormattedValue.ToString();
                    string num = dataGridView1.Rows[i].Cells["学号"].EditedFormattedValue.ToString();
                    string card = dataGridView1.Rows[i].Cells["卡号"].EditedFormattedValue.ToString();
                    bool now = bool.Parse(dataGridView1.Rows[i].Cells["状态"].EditedFormattedValue.ToString());
                    if (card != "")
                    {
                        string Scomm = $"INSERT INTO {TableName} VALUES ('{name}','{num}','{card}','{now}')";
                        using (comm = new SqlCeCommand(Scomm, conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                    }
                }
            }
            MessageBox.Show("更新成功");
        }
        /// <summary>
        /// 查询未到人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlCeConnection conn = new SqlCeConnection(path))
            {
                conn.Open();
                using (SqlCeCommand comm = new SqlCeCommand($"select * from {TableName} where 状态 <1", conn))
                {
                    SqlCeDataAdapter ceDataAdapter = new SqlCeDataAdapter(comm);
                    ceDataAdapter.SelectCommand.ExecuteNonQuery();
                    DataSet dataSet = new DataSet();
                    dataSet.Clear();
                    ceDataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                    button3.Enabled = false;//这时不可以上传数据
                }
            }
        }
        /// <summary>
        /// 按照学号查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                using (SqlCeConnection conn = new SqlCeConnection(path))
                {
                    conn.Open();
                    using (SqlCeCommand comm = new SqlCeCommand($"select * from {TableName} where 学号 = {textBox1.Text}", conn))
                    {
                        SqlCeDataAdapter ceDataAdapter = new SqlCeDataAdapter(comm);
                        ceDataAdapter.SelectCommand.ExecuteNonQuery();
                        DataSet dataSet = new DataSet();
                        dataSet.Clear();
                        ceDataAdapter.Fill(dataSet);
                        dataGridView1.DataSource = dataSet.Tables[0];
                        button3.Enabled = true;//这时就可以上传数据
                    }
                }
            }
        }
    }
}
