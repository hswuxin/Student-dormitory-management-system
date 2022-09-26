using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;

namespace 学生宿舍管理系统
{
    class DBAccess
    {   
        //MD5
        public static string md5(string str)
        {
            try
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] bytValue, bytHash;
                bytValue = System.Text.Encoding.UTF8.GetBytes(str);
                bytHash = md5.ComputeHash(bytValue);
                md5.Clear();
                string sTemp = "";
                for (int i = 0; i < bytHash.Length; i++)
                {
                    sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
                }
                str = sTemp.ToLower();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return str;
        }
        //创建connection对象
        public static SqlConnection EXE_cn()
        {
            SqlConnection cn =
                new SqlConnection(@"server=DESKTOP-5OF4LA4\SQLEXPRESS;database=DormMangement;integrated security=true");
            return cn;
        } 
        //断开式读数据
        public static DataSet EXE_ds(string strcmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(strcmd, EXE_cn());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet EXE_ds(string strcmd,string connstr)
        {
            SqlConnection cn = new SqlConnection(connstr);
            SqlDataAdapter da = new SqlDataAdapter(strcmd,cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //连接式访问读操作
        public static bool EXE_select(string strcmd)
        {
            SqlConnection cn=EXE_cn();
            SqlCommand cmd = new SqlCommand(strcmd, cn);
            try
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                if (cmd.ExecuteReader().HasRows == true)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open  ) cn.Close();
            }
        }
        //连接式访问写操作
        public static bool EXE_update(string strcmd)
        {
            SqlConnection cn = EXE_cn();
            SqlCommand cmd = new SqlCommand(strcmd, cn);
            try
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                cmd.ExecuteNonQuery();
                return true;                
            }
            catch
            {
                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }
        public static bool EXE_update(string strcmd,string connstr)
        {
            SqlConnection cn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand(strcmd, cn);
            try
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }
        //执行select语句方法——ExecuteReader
        public static SqlDataReader ExeDataReader(string sqlText)
        {
            SqlConnection cn = EXE_cn();
            cn.Open();
            SqlCommand comm = new SqlCommand(sqlText, cn);
            return comm.ExecuteReader();
        }
    }
}
