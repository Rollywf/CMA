using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class Auth : Form
    {
        DataBase dataBase = new DataBase();
        public Auth()
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
        }
        private void Auth_Load(object sender, EventArgs e)
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            
            String Login = textBox1.Text;
            String Password = textBox2.Text;

            
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserName =@uL AND Password =@uP and Active='Y'", dataBase.getConnection());
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@uP", SqlDbType.VarChar).Value = Password;
            da.SelectCommand = command;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Form2 f = new Form2(textBox1.Text);
                Hide();
                f.ShowDialog();
                this.Close();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                da = new SqlDataAdapter();
                DataTable dtNA = new DataTable();
                SqlCommand commandNA = new SqlCommand("SELECT * FROM Users WHERE UserName =@uL AND Password =@uP and Active='N'", dataBase.getConnection());
                commandNA.Parameters.Add("@uL", SqlDbType.VarChar).Value = Login;
                commandNA.Parameters.Add("@uP", SqlDbType.VarChar).Value = Password;
                da.SelectCommand = commandNA;
                da.Fill(dtNA); 
                if (dtNA.Rows.Count > 0)
                {
                    MessageBox.Show("Ваша учетная запись была деактивирована. Обратитесь к администратору!");
                }
                else 
                {
                    textBox2.Text = "";
                    MessageBox.Show("Неверный Логин и/или Пароль. Попробуйте Снова!");
                }


                   
            }
        }
    }
}
