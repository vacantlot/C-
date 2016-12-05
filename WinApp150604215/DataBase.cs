using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Reflection;

namespace WinApp150604215
{
    class DataBase
    {
        private static string _strConn;//数据库连接信息
        private OleDbConnection _oleDbConn;//Access数据库连接对象

        /// <summary>
        /// 连接是否打开
        /// </summary>
        public bool ConIsOpen()
        {
            try
            {
                _strConn = @"Provider=Microsoft.ACE.OLEDB.14.0;Data Source=C:\Users\Chen\Desktop\桌面\C#\ConApp150604215\WinApp150604215\bin\Debug\WinApp150604215.accdb";
               // _strConn = @"provider=Microsoft.ACE.OLEDB.12.0; Data Source=";
                _oleDbConn = new OleDbConnection(_strConn);//根据链接信息实例化链接对象
                _oleDbConn.Open();//打开连接;
                return true;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                _oleDbConn.Close();
            }
        }
        ///// <summary>
        ///// 创建一个命令对象并返回该对象
        ///// </summary>
        ///// <param name="sqlStr">数据库语句</param>
        ///// <param name="file">数据库所在路径</param>
        ///// <returns>OleDbCommand</returns>
        //private OleDbCommand CreateCommand(string sqlStr, string file)
        //{
        //    ConIsOpen(file);
        //    OleDbCommand cmd = new OleDbCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = sqlStr;
        //    cmd.Connection = _oleDbConn;
        //    return cmd;
        //}
        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="sqlStr">SQL语句</param>
        /// <param name="file">数据库所在路径</param>
        /// <returns>返回数值当执行成功时候返回true,失败则返回false</returns>
        //public bool ExecuteNonQury(string sqlStr, string file)
        //{
        //    OleDbCommand cmd = CreateCommand(sqlStr, file);
        //    int result = cmd.ExecuteNonQuery();
        //    if (result == -1 | result == 0)
        //    {
        //        cmd.Dispose();
        //        Close();
        //        return false;
        //    }
        //    else
        //    {
        //        cmd.Dispose();
        //        Close();
        //        return true;
        //    }
        //}
        ///// <summary>
        ///// 执行数据库查询
        ///// </summary>
        ///// <param name="sqlStr">查询语句</param>
        ///// <param name="tableName">填充数据集表格的名称</param>
        ///// <param name="file">数据库所在路径</param>
        ///// <returns>查询的数据集</returns>
        //public DataSet GetDataSet(string sqlStr, string file)
        //{
        //    DataSet ds = new DataSet();
        //    OleDbCommand cmd = CreateCommand(sqlStr, file);
        //    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
        //    dataAdapter.Fill(ds);
        //    cmd.Dispose();
        //    Close();
        //    dataAdapter.Dispose();
        //    return ds;
        //}
        ///// <summary>
        ///// 生成一个数据读取器OleDbDataReader并返回该OleDbDataReader
        ///// </summary>
        ///// <param name="sqlStr">数据库查询语句</param>
        ///// <returns>返回一个DataReader对象</returns>
        //public OleDbDataReader GetReader(string sqlStr, string file)
        //{
        //    OleDbCommand cmd = CreateCommand(sqlStr, file);
        //    OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //    //CommadnBehavior.CloseConnection是将于DataReader的数据库链接关联起来
        //    //当关闭DataReader对象时候也自动关闭链接
        //    return reader;
        //}

        ///// <summary>
        ///// 关闭数据库
        ///// </summary>
        //public void Close()
        //{
        //    if (_oleDbConn != null)
        //        _oleDbConn.Close();
        //    _oleDbConn = null;
        //}

    }
}
