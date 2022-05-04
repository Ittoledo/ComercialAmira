using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Data;

namespace Connection
{
    class Connection
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string _myConnection;
        static string host;
        static string database;
        static string userDB;
        static string password;
        public static string strProvider = "server=" + host + ";Database="
            + database + ";User ID=" + userDB + ";Password=" + password;
        public bool Open()
        {
            try
            {
                strProvider = "server=" + host + ";Database=" + database +
                    ";User ID=" + userDB + ";Password=" + password;
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error de conexión " + er.Message, "Informacion");
            }
            return false;
        }
        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }
        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mySqlTransaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mySqlTransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

    }
}
