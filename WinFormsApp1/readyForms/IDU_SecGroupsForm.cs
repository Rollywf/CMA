using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class IDU_SecGroupsForm : Form
    {
        
        public int x=0;
        string typeofoperation_ = "";
        DataBase dataBase= new DataBase();
        public IDU_SecGroupsForm(string page,string username,string typeofoperation)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            label1.Text = page;
            typeofoperation_ = typeofoperation;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (typeofoperation_ == "Update")
            {   
                SqlDataAdapter dau = new SqlDataAdapter("SELECT * FROM SecurityGroups where ID_SecurityGroup=" + x, dataBase.getConnection());
                DataTable dt = new DataTable();
                dau.Fill(dt);
                textBox1.Text = dt.Rows[0][1].ToString();
            }
            else if (typeofoperation_ == "Insert")
            {   

            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (typeofoperation_ == "Insert")
            {   if ((textBox1.Text!=""))
                {
                    SqlDataAdapter da = new SqlDataAdapter
                    (@"exec IDU_SecGroup '"+ textBox1.Text+ "','"+ typeofoperation_ + "', null", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox1.Text == "")) { 
                MessageBox.Show("Наименование группы доступа должно быть указано!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typeofoperation_ == "Update") 
            {
                if ((textBox1.Text != ""))
                {
                    SqlDataAdapter da = new SqlDataAdapter
               (    @"exec IDU_SecGroup '" + textBox1.Text + "','" + typeofoperation_ + "', "+x, dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно обновлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox1.Text == ""))
                {
                    MessageBox.Show("Наименование группы доступа должно быть указано!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
            private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}