using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class IDU_UsersForm : Form
    {
        string SecurityGroups = "select * from SecurityGroups";
        public int x=0;
        string typeofoperation_ = "";
        DataBase dataBase= new DataBase();
        public IDU_UsersForm(string page,string username,string typeofoperation)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loadCB();
            label1.Text = page;
            typeofoperation_ = typeofoperation;

        }
        private void loadCB() 
        {   
                        SqlDataAdapter daT = new SqlDataAdapter(SecurityGroups, dataBase.getConnection());
                        DataTable dtT = new DataTable();
                        daT.Fill(dtT);
                        comboBox1.DataSource = dtT;
                        comboBox1.DisplayMember = "Description";
                        comboBox1.ValueMember = "ID_SecurityGroup"; 
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            loadCB();
            if (typeofoperation_ == "Update")
            {   
                SqlDataAdapter dau = new SqlDataAdapter("SELECT * FROM Users where ID_user=" + x, dataBase.getConnection());
                DataTable dt = new DataTable();
                dau.Fill(dt);

                comboBox1.SelectedValue = dt.Rows[0][3].ToString();
                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
               
            }
            else if (typeofoperation_ == "Insert")
            {   
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (typeofoperation_ == "Insert")
            {   string query = "select count(*) from Users where UserName = ";

                string isfree = "";
                SqlDataAdapter isfr = new SqlDataAdapter(query+ "'"+textBox1.Text+"'", dataBase.getConnection());
                DataTable frdt = new DataTable();
                isfr.Fill(frdt);
                isfree=frdt.Rows[0][0].ToString();

                if ((textBox2.Text != "")&& (isfree!="1"))
                {
                    SqlDataAdapter da = new SqlDataAdapter
                    (@"exec IDU_user '" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedValue + "','" +
                    typeofoperation_ + "','" + x + "'", dataBase.getConnection()); 
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (isfree == "1")
                {
                    MessageBox.Show("Данный логин уже есть в базе!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Необходимо ввести пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }


            if (typeofoperation_ == "Update")
            {
                if ((textBox2.Text != ""))
                {
                    SqlDataAdapter da = new SqlDataAdapter
                    (@"exec IDU_user '" + textBox1.Text+ "','" + textBox2.Text + "','" + comboBox1.SelectedValue + "','" +
                    typeofoperation_ + "','" + x + "'", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно обновлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox2.Text == ""))
                {
                    MessageBox.Show("Необходимо ввести пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

            private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}