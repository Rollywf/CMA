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

namespace WinFormsApp1.readyForms
{
    public partial class ActivateUserForm : Form
    {   DataBase dataBase = new DataBase();
        public int x = 0;
        string typeofoperation_ = "";
        public ActivateUserForm(string page, string username, string typeofoperation)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loadCB();
            typeofoperation_ = typeofoperation;
        }
        private void loadCB()
        {   if (typeofoperation_ == "ActivateStuff")
            {
                SqlDataAdapter daT = new SqlDataAdapter("select * from deactivatedstuff", dataBase.getConnection());
                DataTable dtT = new DataTable();
                daT.Fill(dtT);
                comboBox1.DataSource = dtT;
                comboBox1.DisplayMember = "FIO";
                comboBox1.ValueMember = "ID_staff";
                comboBox2.DataSource = dtT;
                comboBox2.DisplayMember = "UserName";
                comboBox2.ValueMember = "ID_staff";
            }
            else if (typeofoperation_ == "ActivateClient")
            {
                SqlDataAdapter daT = new SqlDataAdapter("select * from deactivatedclients", dataBase.getConnection());
                DataTable dtT = new DataTable();
                daT.Fill(dtT);
                comboBox1.DataSource = dtT;
                comboBox1.DisplayMember = "FIO";
                comboBox1.ValueMember = "ID_client";
                comboBox2.DataSource = dtT;
                comboBox2.DisplayMember = "UserName";
                comboBox2.ValueMember = "ID_client";
            }

        }
        private void ActivateUserForm_Load(object sender, EventArgs e)
        {
            loadCB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (typeofoperation_ == "ActivateStuff")
            {
                if ((comboBox1.SelectedIndex >=0))
                {    typeofoperation_ = "Activate";
                    SqlDataAdapter da = new SqlDataAdapter
                    (@"exec IDU_stuff '0','0',null ,'0','0',null,'0','0',null,'"+ typeofoperation_ + "','" + comboBox1.SelectedValue + "'", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Учетная запись активирована!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((comboBox1.SelectedIndex ==-1))
                {
                    MessageBox.Show("Необходимо выбрать сотрудника!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typeofoperation_ == "ActivateClient")
            {
                if ((comboBox1.SelectedIndex >= 0))
                {
                    typeofoperation_ = "Activate";
                    SqlDataAdapter da = new SqlDataAdapter
                    (@"exec IDU_client '0','0',null ,'0','0','0','0',null,'" + typeofoperation_ + "','" + comboBox1.SelectedValue + "'", dataBase.getConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Учетная запись активирована!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if ((comboBox1.SelectedIndex == -1))
                {
                    MessageBox.Show("Необходимо выбрать клиента!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedValue = comboBox1.SelectedValue;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox1.SelectedValue= comboBox2.SelectedValue ;
        }
    }
}
