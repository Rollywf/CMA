using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class IDU_CitiesForm : Form
    {
        string usersp = "SELECT * from usersp";
        string clientsP = "SELECT  * from clientsP";
        string TrackNumbersp = "SELECT  * from TrackNumbersp";
        string Cities = "SELECT * from Cities";
        string parcelsp = "select * from parcelsp";
        string Positions = "select * from Positions";
        string SecurityGroups = "select * from SecurityGroups";
        string stuffp = "select * from stuffp";
        string TypesParcels = "select * from TypesParcels";
        string labellen = "label10";
        string page_ = "";
        string username_ = "";
        public int x=0;
        string typeofoperation_ = "";
        DataBase dataBase= new DataBase();
        public IDU_CitiesForm(string page,string username,string typeofoperation)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            label1.Text = page;
            page_= page;
            username_ = username;
            typeofoperation_ = typeofoperation;

        }
     
       
        private void Form1_Load(object sender, EventArgs e)
        {

            if (typeofoperation_ == "Update")
            {   
                SqlDataAdapter dau = new SqlDataAdapter("SELECT * FROM Cities where ID_City=" + x, dataBase.getConnection());
                DataTable dt = new DataTable();
                dau.Fill(dt);
                textBox1.Text = dt.Rows[0][1].ToString();
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (typeofoperation_ == "Insert")
            {   if ((textBox1.Text != "") )
                {
                    SqlDataAdapter da = new SqlDataAdapter
                    (@"exec IDU_City '"+ textBox1.Text+ "','" + typeofoperation_ + "', null", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (textBox1.Text=="") { 
                MessageBox.Show("Поле наименования не должно быть пустым!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typeofoperation_ == "Update") 
            {
                if ((textBox1.Text != ""))
                {
                    SqlDataAdapter da = new SqlDataAdapter
                    (@"exec IDU_City '" + textBox1.Text + "','" + typeofoperation_ + "',"+x, dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно обновлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox1.Text == ""))
                {
                    MessageBox.Show("Поле наименования не должно быть пустым!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

            private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}