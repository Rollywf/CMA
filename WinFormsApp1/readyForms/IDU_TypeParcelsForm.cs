using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class IDU_TypeParcelsForm : Form
    {
        public int x=0;
        string typeofoperation_ = "";
        DataBase dataBase= new DataBase();
        public IDU_TypeParcelsForm(string page,string username,string typeofoperation)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            typeofoperation_ = typeofoperation;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (typeofoperation_ == "Update")
            {   
                SqlDataAdapter dau = new SqlDataAdapter("SELECT * FROM TypesParcels where ID_typeParcel=" + x, dataBase.getConnection());
                DataTable dt = new DataTable();
                dau.Fill(dt);
                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
                textBox3.Text = dt.Rows[0][3].ToString();
                textBox4.Text = dt.Rows[0][4].ToString();
                textBox5.Text = dt.Rows[0][5].ToString();
                textBox6.Text = dt.Rows[0][6].ToString();
                textBox7.Text = dt.Rows[0][7].ToString();
            }
            else if (typeofoperation_ == "Insert")
            {  

            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (typeofoperation_ == "Insert")
            {   if ((textBox1.Text!="")&&(textBox6.Text!="") && (textBox7.Text!=""))
                {
                    SqlDataAdapter da = new SqlDataAdapter
                       // (@"exec IDU_TypeParcel '"+textBox1.Text+"' , '"+textBox2.Text.Replace(",",".")+)
                    (@"exec IDU_TypeParcel '" + textBox1.Text + "','" + textBox2.Text.Replace(",", ".") + "','" + textBox3.Text.Replace(",", ".") + "','" + textBox4.Text.Replace(",", ".") + "','" + textBox5.Text.Replace(",", ".") +"','"
                    + textBox6.Text + "','" + textBox7.Text.Replace(",", ".") + "','" + typeofoperation_ + "', null", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Запись успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox1.Text == "") || (textBox6.Text == "") || (textBox7.Text == "")) { 
                MessageBox.Show("Наименование,приоритет и стоимость должны быть указаны!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typeofoperation_ == "Update") 
            {
                if ((textBox1.Text != "") && (textBox6.Text != "") && (textBox7.Text != ""))
                {
                    SqlDataAdapter da1 = new SqlDataAdapter(@"exec IDU_TypeParcel '" +textBox1.Text + "' , '" + textBox2.Text.Replace(',', '.') + "' , '" + textBox3.Text.Replace(',', '.') + "' , '" + textBox4.Text.Replace(',', '.') + "' , '" + textBox5.Text.Replace(',', '.') + "' , '" + textBox6.Text + "' , '" + textBox7.Text.Replace(',','.') + "' , '" + typeofoperation_ + "' , " + x, dataBase.getConnection());  
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Запись успешно обновлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((textBox1.Text == "") || (textBox6.Text == "") || (textBox7.Text == ""))
                {
                    MessageBox.Show("Наименование,приоритет и стоимость должны быть указаны!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}