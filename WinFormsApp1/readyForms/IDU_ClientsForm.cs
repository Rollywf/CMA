using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class IDU_ClientsForm : Form
    {
        string usersp = "SELECT * from usersp";
        string clientsP = "SELECT  * from clientsP";
        string TrackNumbersp = "SELECT  * from TrackNumbersp";
        string Cities = "SELECT * from Cities";
        string parcelsp = "select * from parcelsp";
        string Positions = "select * from Positions";
        string SecurityGroups = "select * from SecurityGroups";
        string clientsview = "SELECT  * from clientsview";
        string stuffp = "select * from stuffp";
        string TypesParcels = "select * from TypesParcels";
        string labellen = "label10";
        string page_ = "";
        string username_ = "";
        public int x=0;
        string typeofoperation_ = "";
        DataBase dataBase= new DataBase();
        public IDU_ClientsForm(string page,string username,string typeofoperation)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loadCB();
            label1.Text = page;
            page_= page;
            username_ = username;
            typeofoperation_ = typeofoperation;

        }
        private void loadCB() 
        {
            SqlDataAdapter daT = new SqlDataAdapter(usersp, dataBase.getConnection());
            DataTable dtT = new DataTable();
            daT.Fill(dtT);
            comboBox1.DataSource = dtT;
            comboBox1.DisplayMember = "Логин";
            comboBox1.ValueMember = "ID_user";
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            loadCB();
            if (typeofoperation_ == "Update")
            {   
                SqlDataAdapter dau = new SqlDataAdapter(clientsview+ " where ID_Client=" + x, dataBase.getConnection());
                DataTable dt = new DataTable();
                dau.Fill(dt);

                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
                textBox3.Text = dt.Rows[0][3].ToString();
                textBox4.Text = dt.Rows[0][4].ToString();
                textBox5.Text = dt.Rows[0][5].ToString();
                textBox6.Text = dt.Rows[0][6].ToString();
                textBox7.Text = dt.Rows[0][7].ToString();
                comboBox1.SelectedValue = dt.Rows[0][8].ToString();
                textBox8.Text = dt.Rows[0][9].ToString();
            }
            else if (typeofoperation_ == "Insert")
            {   
               
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (typeofoperation_ == "Insert")
            {
                if ((textBox1.Text != "") || (textBox2.Text != ""))
                {
                    SqlDataAdapter da = new SqlDataAdapter
                   (@"exec IDU_client '" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" +
                   textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + typeofoperation_ + "', null", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Фамилия и имя обязательны для заполнения!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typeofoperation_ == "Update")
            {
                if ((textBox1.Text != "") || (textBox2.Text != ""))
                {
                    SqlDataAdapter da = new SqlDataAdapter
                    (@"exec IDU_client '" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" +
                    textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + typeofoperation_ + "', " + x, dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно обновлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Фамилия и имя обязательны для заполнения!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        }
            private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}