using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class IDU_ParcelsForm : Form
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
        public IDU_ParcelsForm(string page,string username,string typeofoperation)
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
        {   //Прогружаем в combobox'ы данные;
                        SqlDataAdapter daT = new SqlDataAdapter(TrackNumbersp, dataBase.getConnection());
                        DataTable dtT = new DataTable();
                        daT.Fill(dtT);
                        comboBox1.DataSource = dtT;
                        comboBox1.DisplayMember = "Трекномер";
                        comboBox1.ValueMember = "ID_TrackNumber";

                        daT = new SqlDataAdapter(clientsP, dataBase.getConnection());
                        DataTable tCF = new DataTable();
                        daT.Fill(tCF);
                        comboBox2.DataSource = tCF;
                        comboBox2.DisplayMember = "FIOSN";
                        comboBox2.ValueMember = "ID_Client";

                        daT = new SqlDataAdapter(clientsP, dataBase.getConnection());
                        DataTable tCT = new DataTable();
                        daT.Fill(tCT);
                        comboBox3.DataSource = tCT;
                        comboBox3.DisplayMember = "FIOSN";
                        comboBox3.ValueMember = "ID_Client";

                        daT = new SqlDataAdapter(stuffp , dataBase.getConnection());
                        DataTable tstuff = new DataTable();
                        daT.Fill(tstuff);
                        comboBox4.DataSource = tstuff;
                        comboBox4.DisplayMember = "ФИО";
                        comboBox4.ValueMember = "ID_staff";

                        daT = new SqlDataAdapter(TypesParcels, dataBase.getConnection());
                        DataTable ttypepar = new DataTable();
                        daT.Fill(ttypepar);
                        comboBox5.DataSource = ttypepar;
                        comboBox5.DisplayMember = "Description";
                        comboBox5.ValueMember = "ID_typeParcel"; 
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            loadCB();
            if (typeofoperation_ == "Update")
            {   
                SqlDataAdapter dau = new SqlDataAdapter("SELECT * FROM Parcels where ID_parcel=" + x, dataBase.getConnection());
                DataTable dt = new DataTable();
                dau.Fill(dt);

                comboBox1.SelectedValue = dt.Rows[0][1].ToString();
                textBox1.Text = dt.Rows[0][2].ToString();
                textBox2.Text = dt.Rows[0][3].ToString();
                comboBox2.SelectedValue = dt.Rows[0][4].ToString();
                comboBox3.SelectedValue = dt.Rows[0][5].ToString();
                textBox3.Text = dt.Rows[0][6].ToString();
                textBox5.Enabled = false;
                comboBox4.SelectedValue = dt.Rows[0][7].ToString();
                textBox5.Text = dt.Rows[0][8].ToString();
                textBox4.Text = dt.Rows[0][9].ToString();
                comboBox5.SelectedValue = dt.Rows[0][10].ToString();
            }
            else if (typeofoperation_ == "Insert")
            {   
                SqlDataAdapter das = new SqlDataAdapter("select ID_staff, ФИО from stuffp where Логин='"+username_+"'", dataBase.getConnection());
                DataTable tstuffcurren = new DataTable();
                das.Fill(tstuffcurren);
                comboBox4.DataSource = tstuffcurren;
                comboBox4.DisplayMember = "ФИО";
                comboBox4.ValueMember = "ID_staff";
                textBox5.Enabled = false;
                textBox5.Text=DateTime.Now.ToString();
                //comboBox4.SelectedValue = tstuffcurren.Rows[0][1].ToString();
            }

        }
        CultureInfo pointfornumeric = new CultureInfo("fr-FR");
        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime datetext4;
            DateTime datetext5 = Convert.ToDateTime(textBox5.Text);
            if (textBox4.Text != "") { datetext4 = Convert.ToDateTime(textBox4.Text); } else { datetext4 = datetext5; datetext4.AddHours(1); }


            if (typeofoperation_ == "Insert")
            {   if ((textBox4.Text == "") || (DateTime.Compare(datetext4, DateTime.Now) > 0))
                {
                    SqlDataAdapter da = new SqlDataAdapter
               (@"exec IDU_parcel '" + comboBox1.SelectedValue + "','" + textBox1.Text.Replace(',', '.') + "','" + textBox2.Text + "','" + comboBox2.SelectedValue + "','" +
               comboBox3.SelectedValue + "','" + textBox3.Text + "','" + comboBox4.SelectedValue + "','" + textBox5.Text + "','" + textBox4.Text + "','" + comboBox5.SelectedValue + "','" + typeofoperation_ + "', null", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox4.Text != "") && (DateTime.Compare(datetext4, DateTime.Now) <= 0 )) { 
                MessageBox.Show("Дата получения посылки не может быть раньше её отправки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typeofoperation_ == "Update") 
            {
                if ((textBox4.Text == "" || textBox4.Text == " ") || (DateTime.Compare(datetext4, datetext5) > 0))
                {
                    SqlDataAdapter da = new SqlDataAdapter
              (@"exec IDU_parcel '" + comboBox1.SelectedValue + "','" + textBox1.Text.Replace(',', '.') + "','" + textBox2.Text + "','" + comboBox2.SelectedValue + "','" +
              comboBox3.SelectedValue + "','" + textBox3.Text + "','" + comboBox4.SelectedValue + "','" + textBox5.Text + "','" + textBox4.Text + "','" +
              comboBox5.SelectedValue + "','" + typeofoperation_ + "','" + x + "'", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно обновлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (DateTime.Compare(datetext4, datetext5)<0)
                {
                    MessageBox.Show("Дата получения посылки не может быть раньше её отправки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

            private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}