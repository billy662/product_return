using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Return
{
    public partial class Main : Form
    {
        private MySqlConnection conn;
        private LoadingScreen ls;

        public Main()
        {
            InitializeComponent();

            conn = DBConnect.getConnection();

            for (int i=0;i< dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12.75f);
            }
            cmbSearchCriteria.SelectedIndex = 0;
            ls = new LoadingScreen();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await checkServerStatus();
        }

        public void showRecords(String search)
        {
            ls.Show();
            dataGridView1.Rows.Clear();
            string sql = "SELECT * FROM `product_return`";
            if (cmbSearchCriteria.SelectedIndex == 0)
            {
                if (!search.Equals("all"))
                    sql = "SELECT * FROM `product_return` WHERE pid LIKE '%" + search + "%'";
            }
            else
            {
                if (!search.Equals("all"))
                    sql = "SELECT * FROM `product_return` WHERE invoice_id LIKE '%" + search + "%'";
            }
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(sql, conn);
                using (MySqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Boolean found = (Convert.ToInt32(dr.GetValue(8)) == 1);
                        Boolean packed = (Convert.ToInt32(dr.GetValue(9)) == 1);
                        dataGridView1.Rows.Add(new object[]
                        {
                                found,
                                packed,
                                dr.GetValue(0).ToString(),
                                dr.GetValue(1).ToString(),
                                dr.GetValue(2).ToString(),
                                dr.GetValue(3).ToString(),
                                dr.GetValue(4).ToString(),
                                dr.GetValue(5).ToString(),
                                dr.GetValue(6).ToString(),
                                dr.GetValue(7).ToString()
                        });
                        if(found || packed)
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        if (found && packed)
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(237, 237, 94);
                    }
                }
                lblRowsCount.Text = "Showing " + dataGridView1.Rows.Count + " record(s)";
                dataGridView1.ClearSelection();
                conn.Close();
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

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            Form newRecord = new NewRecord();
            newRecord.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbSearch.Text.Equals(""))
                showRecords("all");
            else
            {
                showRecords(tbSearch.Text);
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        //"found" checkbox clicked
                        checkCheckbox(e.RowIndex, e.ColumnIndex);
                        break;

                    case 1:
                        //"packed" checkbox clicked
                        checkCheckbox(e.RowIndex, e.ColumnIndex);
                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "true";
                            checkCheckbox(e.RowIndex, 0);
                        }
                        break;

                    case 10:
                        //edit button clicked
                        Record rec = new Record();
                        rec.invoiceID = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        rec.brand = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        rec.pid = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                        rec.shortCode = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                        rec.color = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                        rec.size = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                        rec.quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                        rec.price = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                        rec.found = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].EditedFormattedValue);
                        rec.packed = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[1].EditedFormattedValue);

                        Form updateRec = new UpdateRecord(rec, this);
                        updateRec.Show();
                        break;

                    default:

                        break;
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1 && e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string invoiceID = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                string pid = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                if (MessageBox.Show("Are you sure to delete the following record?\nProduct " + pid + " in invoice " + invoiceID, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ls.Show();
                    //delete record
                    try
                    {
                        conn.Open();
                        string sql = "DELETE FROM `product_return` WHERE `product_return`.`invoice_id` = '" + invoiceID + "' AND `product_return`.`pid` = '" + pid + "'";
                        MySqlCommand comm = new MySqlCommand(sql, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Record deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btnSearch.PerformClick();
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
            else if(e.KeyCode == Keys.Enter)
            {
                //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex - 1].Selected = true;
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        //prevent going to next row after pressing enter in dataGridView
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter && dataGridView1.IsCurrentCellInEditMode)
                return base.ProcessDialogKey(Keys.Tab);
            else
                return base.ProcessDialogKey(keyData);
        }

        private void checkCheckbox(int rowIndex, int columnIndex)
        {
            Boolean check = (Convert.ToBoolean(dataGridView1.Rows[rowIndex].Cells[columnIndex].EditedFormattedValue));
            int int_check = (check) ? 1 : 0;
            ls.Show();
            try
            {
                conn.Open();
                string sql = "UPDATE `product_return` SET " + ((columnIndex == 0) ? "`found`" : "`packed`") + " = '" + int_check + "' WHERE `product_return`.`invoice_id` = '" + dataGridView1[2, rowIndex].Value + "' AND `product_return`.`pid` = '" + dataGridView1[4, rowIndex].Value + "';";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();

                Boolean found = Convert.ToBoolean(dataGridView1.Rows[rowIndex].Cells[0].EditedFormattedValue);
                Boolean packed = Convert.ToBoolean(dataGridView1.Rows[rowIndex].Cells[1].EditedFormattedValue);
                if (found || packed)
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                if (found && packed)
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(237, 237, 94);
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

        private void btnManageBrands_Click(object sender, EventArgs e)
        {
            Form mb = new ManageBrands();
            mb.Show();
        }

        private async Task checkServerStatus()
        {
            updateServerStatus(99);
            Boolean isServerOnline = await Task.Factory.StartNew<Boolean>(() => getServerStatus());
            updateServerStatus(isServerOnline ? 1 : 0);
        }

        private Boolean getServerStatus()
        {
            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(DBConnect.serverIP, 3306);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        private async void btnChkSerStat_Click(object sender, EventArgs e)
        {
            await checkServerStatus();
        }

        private void updateServerStatus(int statusCode)
        {
            //0:  Server offline
            //1:  Server online
            //99: Loading
            switch (statusCode)
            {
                case 0:
                    lblServerStatus.ForeColor = System.Drawing.Color.Red;
                    lblServerStatus.Text = "Server Offline";
                    break;

                case 1:
                    lblServerStatus.ForeColor = System.Drawing.Color.Green;
                    lblServerStatus.Text = "Server Online";
                    break;

                case 99:
                    lblServerStatus.ForeColor = System.Drawing.Color.Black;
                    lblServerStatus.Text = "Updating server status...";
                    break;
            }
        }
    }
}
