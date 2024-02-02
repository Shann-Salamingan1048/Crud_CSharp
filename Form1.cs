using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crud_CSharp
{
    public partial class Form1 : Form
    {
        private string connection = "server=localhost;uid=root;pwd=sqlpass1234554321;database=crudcsharp";
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and deletion
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO employees(Employee_ID,First_Name,Middle_Name,Last_Name,Age,Address,Email_Address)VALUES('" 
                + this.EmployeeID_TextBox.Text + "','" + this.FN_TextBox.Text + "','" + this.MN_TextBox.Text + "','" 
                + this.LN_TextBox.Text + "','" + this.Age_TextBox.Text + "','" + this.Address_TextBox.Text + "','" + this.Email_Ad_TextBox.Text 
                + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved");
            conn.Close();
        }

        private void Read_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM employees";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE employees SET First_Name='" + this.FN_TextBox.Text +
                    "', Middle_Name='" + this.MN_TextBox.Text +
                    "', Last_Name='" + this.LN_TextBox.Text +
                    "', Age='" + this.Age_TextBox.Text +
                    "', Address='" + this.Address_TextBox.Text +
                    "', Email_Address='" + this.Email_Ad_TextBox.Text +
                    "' WHERE Employee_ID='" + this.EmployeeID_TextBox.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully Updated");
            conn.Close();

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM employees WHERE Employee_ID='" + this.EmployeeID_TextBox.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully Deleted!!");
            conn.Close();
        }
    }
}
