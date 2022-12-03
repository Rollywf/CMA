using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class IDU_TracknumsForm : Form
    {
        
        string Cities = "SELECT * from Cities";
        
        public int x=0;
        string typeofoperation_ = "";
        DataBase dataBase= new DataBase();
        public IDU_TracknumsForm(string page,string username,string typeofoperation)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loadCB();
            label1.Text = page;
            typeofoperation_ = typeofoperation;
        }
        private void loadCB() 
        {               
                        SqlDataAdapter daT = new SqlDataAdapter(Cities, dataBase.getConnection());
                        DataTable dtT = new DataTable();
                        daT.Fill(dtT);
                        comboBox1.DataSource = dtT;
                        comboBox1.DisplayMember = "Description";
                        comboBox1.ValueMember = "ID_City";

                        daT = new SqlDataAdapter(Cities, dataBase.getConnection());
                        DataTable tCF = new DataTable();
                        daT.Fill(tCF);
                        comboBox2.DataSource = tCF;
                        comboBox2.DisplayMember = "Description";
                        comboBox2.ValueMember = "ID_City";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            loadCB();
            if (typeofoperation_ == "Update")
            {   
                SqlDataAdapter dau = new SqlDataAdapter("SELECT * FROM TrackNumbers where ID_TrackNumber=" + x, dataBase.getConnection());
                DataTable dt = new DataTable();
                dau.Fill(dt);
                
                textBox1.Text = dt.Rows[0][1].ToString();
                if (string.IsNullOrEmpty(dt.Rows[0][2].ToString())) { comboBox1.SelectedIndex = -1; } 
                else { comboBox1.SelectedValue = dt.Rows[0][2].ToString(); }
                if (string.IsNullOrEmpty(dt.Rows[0][3].ToString())) { comboBox2.SelectedIndex = -1; }
                else { comboBox2.SelectedValue = dt.Rows[0][3].ToString(); }
                textBox2.Text = dt.Rows[0][4].ToString();
            }
            else if (typeofoperation_ == "Insert")
            {   
                
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (typeofoperation_ == "Insert")
            {   if ((textBox1.Text != "") )
                {
                    SqlDataAdapter da = new SqlDataAdapter
                 (@"exec IDU_tracknum '" + textBox1.Text + "','" + comboBox1.SelectedValue+ "','" + comboBox2.SelectedValue +"','"+textBox2.Text +"','" + typeofoperation_ + "', 0", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox1.Text=="")) { 
                MessageBox.Show("Введите Трекномер!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typeofoperation_ == "Update") 
            {
                if ((textBox1.Text != ""))
                {
                    SqlDataAdapter da = new SqlDataAdapter
                    (@"exec IDU_tracknum '" + textBox1.Text + "','" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + textBox2.Text + "','" + typeofoperation_ + "', "+x, dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно обновлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox1.Text == ""))
                {
                    MessageBox.Show("Введите Трекномер!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
            private void cancelButton_Click(object sender, EventArgs e)
            {
            this.Close();
            }
    }
}