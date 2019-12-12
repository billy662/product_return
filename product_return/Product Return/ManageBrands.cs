using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Return
{
    public partial class ManageBrands : Form
    {
        private MySqlConnection conn;
        private LoadingScreen ls;

        public ManageBrands()
        {
            InitializeComponent();

            conn = DBConnect.getConnection();
            ls = new LoadingScreen();
        }

        private void ManageBrands_Load(object sender, EventArgs e)
        {
            showBrands();
        }

        public void showBrands()
        {
            ls.Show();
            dataGridView1.Rows.Clear();
            string sql = "SELECT * FROM `brand`";
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(sql, conn);
                using (MySqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(new object[]
                        {
                            dr.GetValue(0).ToString()
                        });
                    }
                }
                lblRowsCount.Text = "Showing " + dataGridView1.Rows.Count + " record(s)";
                conn.Close();
                dataGridView1.ClearSelection();
            }
            catch (MySqlException sqlEx)
            {
                conn.Close();
                if (sqlEx.Number == 0 || sqlEx.Number == 1042)
                {
                    MessageBox.Show("Connection timed out\nPlease try again", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please send the following to the developer for fixing this error:\n" + sqlEx.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Please send the following to the developer for fixing this error:\n" + ex.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ls.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                Form ed = new EditBrand(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(), this);
                ed.Show();
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string brandName = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                if (MessageBox.Show("Are you sure to delete the following record?\nBrand Name: " + brandName , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ls.Show();
                    //delete record
                    try
                    {
                        conn.Open();
                        string sql = "DELETE FROM `brand` WHERE `brand`.`name` = '" + brandName + "'";
                        MySqlCommand comm = new MySqlCommand(sql, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Record deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        showBrands();
                    }
                    catch (MySqlException sqlEx)
                    {
                        conn.Close();
                        if (sqlEx.Number == 0 || sqlEx.Number == 1042)
                        {
                            MessageBox.Show("Connection timed out\nPlease try again", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Please send the following to the developer for fixing this error:\n" + sqlEx.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Please send the following to the developer for fixing this error:\n" + ex.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ls.Hide();
                }
            }
            BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ls.Show();
            try
            {
                if (!string.IsNullOrWhiteSpace(tbBrand.Text))
                {
                    conn.Open();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `brand` (`name`) VALUES (@name);";
                    comm.Parameters.AddWithValue("@name", tbBrand.Text);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("New brand successfully added to database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbBrand.Text = "";
                    showBrands();
                }
            }
            catch (MySqlException sqlEx)
            {
                conn.Close();
                if (sqlEx.Number == 1062)
                {
                    MessageBox.Show("The same brand is existing in the database.", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sqlEx.Number == 0 || sqlEx.Number == 1042)
                {
                    MessageBox.Show("Connection timed out\nPlease try again", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please send the following to the developer for fixing this error:\n" + sqlEx.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Please send the following to the developer for fixing this error:\n" + ex.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ls.Hide();
            BringToFront();
        }

        private void tbBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }
    }
}
