using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Data;

namespace Connection_DB
{
    class Connection
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        static string host = "localhost";
        static string database = "testDB";
        static string userDB = "admin";
        static string password = "#E69L]8%),V,S2i";
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
                MessageBox.Show("Error de conexión " + er.Message, "Information");
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
