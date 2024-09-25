using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MSSQLWinForm
{
    public partial class Form1 : Form
    {
        BindingSource bindingSource = new BindingSource();
        DataTable dt = new DataTable();
        //string conn = "Server=localhost;Database=TestDB;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executeQuery_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                tb_log.Text = "SQL 연결 성공";
                SelectData(sqlConnection1);
            }
            catch (Exception ex)
            {
                tb_log.Text = ex.Message;
            }
            finally { sqlConnection1.Close(); }
        }
        void SelectData(SqlConnection conn)
        {
            string query = "select ID, NAME, CNT from TestTable order by ID;";
            dt.Clear();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                    bindingSource.DataSource = dt;

                }
            }
            if(bindingSource.DataSource!= null)
            {
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
            }
            else
            {
                bindingSource.ResetBindings(false);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string item = tb_insertItem.Text;
            
            try
            {
                sqlConnection1.Open();
                InsertItem(sqlConnection1,item);
                SelectData(sqlConnection1);
            }
            catch (Exception ex)
            {
                tb_log.Text = ex.Message;
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
        void InsertItem(SqlConnection conn, string item)
        {
            string query = "select ID from TestTable where name = @item;";
            string insert_new = "insert into TestTable values (@item,1)";
            string insert_update = "update TestTable set CNT=CNT+1 where ID=@id";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@item", item);
                object res = cmd.ExecuteScalar();
                if(res != null)
                {
                    int id = Convert.ToInt32(res);
                    using (SqlCommand cmd2 = new SqlCommand(insert_update, conn))
                    {
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand cmd2 = new SqlCommand(insert_new, conn))
                    {
                        cmd2.Parameters.AddWithValue("@item", item);
                        cmd2.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btn_removeAll_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                RemoveAll(sqlConnection1);
                SelectData(sqlConnection1);
            }
            catch (Exception ex)
            {
                tb_log.Text = ex.Message;
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
        void RemoveAll(SqlConnection conn)
        {
            string query = "delete from TestTable;";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void btn_removeOne_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;
            if (dataGridView1.CurrentRow == null) return;
            
            string item = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int count = (int)(dataGridView1.CurrentRow.Cells[2].Value);
            try
            {
                sqlConnection1.Open();
                RemoveOne(sqlConnection1, item, (count>1));
                SelectData(sqlConnection1);
            }
            catch (Exception ex)
            {
                tb_log.Text = ex.Message;
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
        void RemoveOne(SqlConnection conn, string item, bool OverOne)
        {
            string query_update = "update TestTable set CNT=CNT-1 where ID=@id";
            string query_delete = "delete from TestTable where id = @id";
            if (OverOne)
            {
                using (SqlCommand cmd = new SqlCommand(query_update, conn))
                {
                    cmd.Parameters.AddWithValue("@id", item);
                    cmd.ExecuteNonQuery();
                }
                return;
            }
            using (SqlCommand cmd = new SqlCommand(query_delete, conn))
            {
                cmd.Parameters.AddWithValue("@id", item);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
