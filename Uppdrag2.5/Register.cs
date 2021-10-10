using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Uppdrag2._5
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtComPassword.Clear();
            txtUserName.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and PAssword fields are empty", "Reg failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (txtPassword.Text == txtComPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtUserName.Text + "','" + txtPassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUserName.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Ditt Konto har skapats", "Registrering lyckades", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lösenord stämmer inte, Försök Igen", "Registrering Misslyckades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }

        }
    }
}
