using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;

namespace MyTool
{
    #region Sql Sever Compact 服务
    public static class MyCompact
    {
        public static string source { private get; set; }
        private static string comm { get; set; }
        //
        //摘要:
        //     创建新的表
        public static void CreatTable(string name, string table)
        {
            using (SqlCeConnection sqlCe = new SqlCeConnection(source))
            {
                sqlCe.Open();
                comm = $"create table {name} ({table})";
                using (SqlCeCommand cm = new SqlCeCommand(comm, sqlCe))
                {
                    cm.ExecuteNonQuery();
                }
            }
        }
        //
        //摘要:
        //    删除表
        public static void DeleteTable(string name)
        {
            using (SqlCeConnection sqlCe = new SqlCeConnection(source))
            {
                sqlCe.Open();
                comm = $"drop table {name}";
                using (SqlCeCommand cm = new SqlCeCommand(comm, sqlCe))
                {
                    cm.ExecuteNonQuery();
                }
            }
        }
        //
        //摘要:
        //     向表中插入一行新数据
        public static void InsertData(string name, params object[] content)
        {
            using (SqlCeConnection sqlCe = new SqlCeConnection(source))
            {
                sqlCe.Open();
                string cm = "";
                object middleData = null;
                for (int i = 0; i < content.Length; i++)
                {
                    content[i].BeforeDataType(ref middleData);
                    cm += (middleData.ToString() + " " + ',');
                }
                if (cm.Length > 0)
                {
                    cm = cm.Substring(0, cm.Length - 1);
                }
                comm = $"insert into {name} values({cm})";
                using (SqlCeCommand concent = new SqlCeCommand(comm, sqlCe))
                {
                    concent.ExecuteNonQuery();
                }
            }
        }
        public static void InsertData(object[] content, string name)
        {
            using (SqlCeConnection sqlCe = new SqlCeConnection(source))
            {
                sqlCe.Open();
                string cm = "";
                object middleData = null;
                for (int i = 0; i < content.Length; i++)
                {
                    content[i].BeforeDataType(ref middleData);
                    cm += (middleData.ToString() + " " + ',');
                }
                if (cm.Length > 0)
                {
                    cm = cm.Substring(0, cm.Length - 1);
                }
                comm = $"insert into {name} values({cm})";
                using (SqlCeCommand concent = new SqlCeCommand(comm, sqlCe))
                {
                    concent.ExecuteNonQuery();
                }
            }
        }
        //
        //摘要:
        //    获取表中的所有数据
        //    返回DataTable
        public static DataTable GetData(string name)
        {
            using (SqlCeConnection sqlCe = new SqlCeConnection(source))
            {
                sqlCe.Open();
                using (SqlCeCommand sqlCom = new SqlCeCommand($"select *from {name}", sqlCe))
                {
                    DataTable dataTable = new DataTable();
                    SqlCeDataReader dataReader = sqlCom.ExecuteReader();
                    dataTable.Load(dataReader);
                    return dataTable;
                }
            }
        }
        //摘要;
        //  扩展方法:
        //      获得打包前的数据类型
        private static void BeforeDataType(this object nowData, ref object BeforeData)
        {
            BeforeData = nowData;
            switch (nowData.GetType().Name)
            {
                case "Init32": BeforeData = (int)BeforeData; break;
                case "String": BeforeData = string.Concat("'", $"{(string)BeforeData}", "'"); break;
                case "Single": BeforeData = (float)BeforeData; break;
                case "Double": BeforeData = (double)BeforeData; break;
                default: break;
            }
        }
    }
    #endregion
}
