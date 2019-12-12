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
    public partial class UpdateRecord : Form
    {
        private MySqlConnection conn;
        public Record rec;
        private Main main;
        private LoadingScreen ls;

        public UpdateRecord()
        {
            InitializeComponent();
            conn = DBConnect.getConnection();
        }

        public UpdateRecord(Record rec, Main main)
        {
            InitializeComponent();
            conn = DBConnect.getConnection();
            this.rec = rec;
            this.main = main;
            ls = new LoadingScreen();
        }

        private void UpdateRecord_Load(object sender, EventArgs e)
        {
            getAllBrandName();
            setData();
        }

        private void setData()
        {
            tbInovice.Text = rec.invoiceID;
            cmbBrand.Text = rec.brand;
            tbPid.Text = rec.pid;
            tbShortCode.Text = (rec.shortCode == null || rec.shortCode.Equals("")) ? "" : rec.shortCode;
            tbColor.Text = (rec.color == null || rec.color.Equals("")) ? "" : rec.color;
            tbSize.Text = (rec.size == null || rec.size.Equals("")) ? "" : rec.size;
            nudQuantity.Value = rec.quantity;
            tbPrice.Text = (rec.price == null || rec.price.Equals("")) ? "" : rec.price;
        }

        private void tbInovice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ls.Show();
            try
            {
                conn.Open();
                string sql = "UPDATE `product_return` " +
                    "SET invoice_id = '" + tbInovice.Text + "' " +
                    ", brand = '" + cmbBrand.Text + "'" +
                    ", pid = '" + tbPid.Text + "' " +
                    ", short_code = " + (tbShortCode.Text.Equals("") ? "NULL" : "'" + tbShortCode.Text + "'") + " " +
                    ", color = " + (tbColor.Text.Equals("") ? "NULL" : "'" + tbColor.Text + "'") + " " +
                    ", size = " + (tbSize.Text.Equals("") ? "NULL" : "'" + tbSize.Text + "'") + " " +
                    ", quantity = '" + nudQuantity.Value + "' " +
                    ", price = " + (tbPrice.Text.Equals("") ? "NULL" : "'" + tbPrice.Text + "'") + " " +
                    "WHERE `invoice_id` = '" + rec.invoiceID + "' " +
                    "AND `pid` = '" + rec.pid + "';";
                Clipboard.SetText(sql);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                if(comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully updated record", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                main.btnSearch.PerformClick();
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

        private void getAllBrandName()
        {
            ls.Show();
            string sql = "SELECT * FROM `Brand`";
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(sql, conn);
                using (MySqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbBrand.Items.Add(dr.GetValue(0).ToString());
                    }
                }
                conn.Close();
                cmbBrand.SelectedIndex = 0;
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
                Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Please send the following to the developer for fixing this error:\n" + ex.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
            ls.Hide();
        }

        private void tbInovice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void cmbBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void tbPid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void tbShortCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void tbColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void tbSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void tbPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void nudQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
    }
}
