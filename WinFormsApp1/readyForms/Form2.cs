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
using WinFormsApp1.readyForms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {   string username_ = "";
        string isclient = "";
        string typeofoperation = "";
        string usersp = "SELECT * from usersp";
        string clientsP = "SELECT  * from clientsP";
        string TrackNumbersp = "SELECT  * from TrackNumbersp";
        string Cities = "SELECT * from Cities";
        string parcelsp = "select * from parcelsp";
        string Positions = "select * from Positions";
        string SecurityGroups = "select * from SecurityGroups";
        string stuffp = "select * from stuffp";
        string TypesParcels = "select * from TypesParcels";
        string username = "";

        DataBase dataBase = new DataBase();
        DataGridView dgv = new DataGridView();
        public Form2(string qs)
        {
            InitializeComponent();
            this.TablesAll.SelectedTab = TablesAll.TabPages[0];
            StartPosition = FormStartPosition.CenterScreen;
            UserName.Text = qs;
            username = qs;
            dgv.Parent = this.TablesAll.TabPages[0];
            dgv.Visible = true;
            dgv.Name = "dgv";
            dgv.Height = TablesAll.Height - TablesAll.Top;
            dgv.Width = TablesAll.Width - TablesAll.Left;
            dgv.CellContentClick += dgv_CellContentClick;
            dgv.CellClick += dgv_CellClick;
            this.TablesAll.SelectedTab= TablesAll.TabPages[0];
            //SqlDataAdapter dac = new SqlDataAdapter();
            //DataTable dt = new DataTable();
            //SqlCommand command = new SqlCommand("SELECT ID_Client, FIO,UserName,Description FROM fio_username where UserName=@uL", dataBase.getConnection());
            //command.Parameters.Add("@uL", SqlDbType.NVarChar).Value = qs;
            //dac.SelectCommand = command;
            //dac.Fill(dt);
            //userNameButton.Text = dt.Rows[0].ItemArray[1].ToString();
            //username_ = dt.Rows[0].ItemArray[2].ToString();
            //toolStripTextBox1.Text = dt.Rows[0].ItemArray[3].ToString();
            LoadTable();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isclient !="1") 
            {
                if (e.RowIndex > -1 && !dgv[0, e.RowIndex].Value.GetType().ToString().Contains("DBNull"))
                {
                    id = Convert.ToInt32(dgv[0, e.RowIndex].Value);

                    typeofoperation = "Update";

                    switch (TablesAll.SelectedTab.Name)
                    {
                        case "ParcelsPage":
                            {
                                IDU_ParcelsForm f = new IDU_ParcelsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                                f.x = id;
                                f.ShowDialog();
                            }
                            break;
                        case "TypeParPage":
                            {
                                IDU_TypeParcelsForm f = new IDU_TypeParcelsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                                f.x = id;
                                f.ShowDialog();
                            }
                            break;
                        case "ClientsPage":
                            {
                                IDU_ClientsForm f = new IDU_ClientsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                                f.x = id;
                                f.ShowDialog();
                            }
                            break;
                        case "UsersPage":
                            {
                                IDU_UsersForm f = new IDU_UsersForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                                f.x = id;
                                f.ShowDialog();
                            }
                            break;
                        case "SecGroupPage":
                            {
                                IDU_SecGroupsForm f = new IDU_SecGroupsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                                f.x = id;
                                f.ShowDialog();
                            }
                            break;
                        case "StuffPage":
                            {
                                IDU_StuffForm f = new IDU_StuffForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                                f.x = id;
                                f.ShowDialog();
                            }
                            break;
                        case "PositionsPage":
                            {
                                IDU_PositionsForm f = new IDU_PositionsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                                f.x = id;
                                f.ShowDialog();
                            }
                            break;
                        case "CitiesPage":
                            {
                                IDU_CitiesForm f = new IDU_CitiesForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                                f.x = id;
                                f.ShowDialog();
                            }
                            break;
                        case "TracknumbersPage":
                            {
                                IDU_TracknumsForm f = new IDU_TracknumsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                                f.x = id;
                                f.ShowDialog();
                            }
                            break;
                        default:
                            break;
                    }
                }
                LoadTable();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isclient != "1")
            {
                if (e.RowIndex > -1 && !dgv[0, e.RowIndex].Value.GetType().ToString().Contains("DBNull"))
                {
                    id = Convert.ToInt32(dgv[0, e.RowIndex].Value);
                }
            }
        }



        private void LoadTable()
        {
            dgv.Height = TablesAll.Height - TablesAll.Top;
            dgv.Width = TablesAll.Width - TablesAll.Left;
            dgv.BackgroundColor = Form.DefaultBackColor;
            switch (TablesAll.SelectedTab.Name)
            {
                case "ParcelsPage":
                    {   
                        switch (isclient)
                        {
                            case "1":
                                {
                                    SqlDataAdapter da = new SqlDataAdapter(parcelsp+ " where [От Клиента]=(select ct.FIOSN from clientsp ct where Логин = '" + username_+"')"+
                                    "or [Клиенту] = (select ct.FIOSN from clientsp ct where Логин = '" + username_ +"')", dataBase.getConnection());
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    dgv.Parent = this.TablesAll.SelectedTab;
                                    dgv.DataSource = dt;
                                    dgv.Columns[0].Visible = false;
                                }
                                break;
                            default:
                                {
                                    SqlDataAdapter da = new SqlDataAdapter(parcelsp, dataBase.getConnection());
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    dgv.Parent = this.TablesAll.SelectedTab;
                                    dgv.DataSource = dt;
                                    dgv.Columns[0].Visible = false; 
                                }
                                break;
                        }
                              
                    }                                    
                    break;
                case "TypeParPage":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(TypesParcels, dataBase.getConnection());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.Parent = this.TablesAll.SelectedTab;
                        dgv.DataSource = dt;
                        dgv.Columns[0].Visible = false;
                    }
                    break;
                case "ClientsPage":
                    {
                        switch (toolStripTextBox1.Text)
                        {
                            case "Client":
                                {
                                    SqlDataAdapter da = new SqlDataAdapter(clientsP + " where Логин='" + username_+"'", dataBase.getConnection());
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    dgv.Parent = this.TablesAll.SelectedTab;
                                    dgv.DataSource = dt;
                                    dgv.Columns[0].Visible = false;
                                    dgv.Columns[1].Visible = false;
                                }
                                break;
                            default:
                                {
                                    SqlDataAdapter da = new SqlDataAdapter(clientsP, dataBase.getConnection());
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    dgv.Parent = this.TablesAll.SelectedTab;
                                    dgv.DataSource = dt;
                                    dgv.Columns[0].Visible = false;
                                    dgv.Columns[1].Visible = false;
                                }
                                break;
                        }
                        
                        
                    }break;
                case "UsersPage":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(usersp,dataBase.getConnection());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.Parent = this.TablesAll.SelectedTab;
                        dgv.DataSource = dt;
                        dgv.Columns[0].Visible = false;
                    }
                    break;
                case "SecGroupPage":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(SecurityGroups, dataBase.getConnection());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.Parent = this.TablesAll.SelectedTab;
                        dgv.DataSource = dt;
                        dgv.Columns[0].Visible = false;
                    }
                    break;
                case "StuffPage":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(stuffp, dataBase.getConnection());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.Parent = this.TablesAll.SelectedTab;
                        dgv.DataSource = dt;
                        dgv.Columns[0].Visible = false;
                        dgv.Columns[1].Visible = false;
                    }
                    break;
                case "PositionsPage":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(Positions, dataBase.getConnection());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.Parent = this.TablesAll.SelectedTab;
                        dgv.DataSource = dt;
                        dgv.Columns[0].Visible = false;
                    }
                    break;
                case "CitiesPage":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(Cities, dataBase.getConnection());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.Parent = this.TablesAll.SelectedTab;
                        dgv.DataSource = dt;
                        dgv.Columns[0].Visible = false;
                    }
                    break;
                case "TracknumbersPage":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(TrackNumbersp, dataBase.getConnection());
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.Parent = this.TablesAll.SelectedTab;
                        dgv.DataSource = dt;
                        dgv.Columns[0].Visible = false;
                    }
                    break;
                default:
                    break;
            }
            SqlDataAdapter dauser = new SqlDataAdapter();
            DataTable dtuser = new DataTable();
            SqlCommand command = new SqlCommand("SELECT ID_Client, FIO,UserName,Description FROM fio_username where UserName=@uL", dataBase.getConnection());
            command.Parameters.Add("@uL", SqlDbType.NVarChar).Value = username;
            dauser.SelectCommand = command;
            dauser.Fill(dtuser);
            userNameButton.Text = dtuser.Rows[0].ItemArray[1].ToString();
            username_ = dtuser.Rows[0].ItemArray[2].ToString();
            toolStripTextBox1.Text = dtuser.Rows[0].ItemArray[3].ToString();
            //toolStripDropDownButton1.Visible = true;
            SqlDataAdapter dacl = new SqlDataAdapter();
            DataTable dtclient = new DataTable();
            SqlCommand command1 = new SqlCommand("SELECT Count(*) as 'count' FROM clientsP where Логин = @uL", dataBase.getConnection());
            command1.Parameters.Add("@uL", SqlDbType.NVarChar).Value = UserName.Text;
            dacl.SelectCommand = command1;
            dacl.Fill(dtclient);
            isclient = dtclient.Rows[0].ItemArray[0].ToString();
            if (isclient == "1")
            {
                TablesAll.TabPages.RemoveByKey("UsersPage");
                TablesAll.TabPages.RemoveByKey("SecGroupPage");
                TablesAll.TabPages.RemoveByKey("StuffPage");
                TablesAll.TabPages.RemoveByKey("PositionsPage");
                TablesAll.TabPages.RemoveByKey("CitiesPage");
                TablesAll.TabPages.RemoveByKey("TracknumbersPage");
                toolStripDropDownButton1.Visible = false;
                insertButton.Enabled = false;
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else if (toolStripTextBox1.Text != "Admin")
            {
                TablesAll.TabPages.RemoveByKey("UsersPage");
                TablesAll.TabPages.RemoveByKey("SecGroupPage");
                toolStripDropDownButton1.Visible = false;

            }  
            else if (toolStripTextBox1.Text == "Admin") { toolStripDropDownButton1.Visible = true; }
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
            LoadTable();   
        }
        private void TablesAll_SelectedIndexChanged(object sender, EventArgs e)
        {

            FilterBox.Items.Clear();
            FilterBox.SelectedIndex = -1;
            refreshfilterbox();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("select fu.Description from fio_username fu where fu.UserName= @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", SqlDbType.NVarChar).Value = UserName.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            string isadmin = dt.Rows[0].ItemArray[0].ToString();

            if (isadmin !="Admin" && TablesAll.SelectedTab.Name =="StuffPage" 
              || isadmin != "Admin" && TablesAll.SelectedTab.Name == "PositionsPage" )
            {
                insertButton.Enabled = false;
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else {
                insertButton.Enabled = true;
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
            }

            LoadTable();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Auth f = new Auth();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void профильToolStripMenuItem_Click(object sender, EventArgs e)
        {   if (toolStripTextBox1.Text == "Client")
            TablesAll.SelectedTab = TablesAll.TabPages["ClientsPage"];
            else TablesAll.SelectedTab = TablesAll.TabPages["StuffPage"];
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            typeofoperation = "Insert";
            switch (TablesAll.SelectedTab.Name)
            {
                case "ParcelsPage":
                    {
                        IDU_ParcelsForm f = new IDU_ParcelsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                        f.ShowDialog();
                    }
                    break;
                case "TypeParPage":
                    {
                        IDU_TypeParcelsForm f = new IDU_TypeParcelsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                        f.ShowDialog();
                    }
                    break;
                case "ClientsPage":
                    {
                        IDU_ClientsForm f = new IDU_ClientsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                        f.x = id;
                        f.ShowDialog();
                    }
                    break;
                case "UsersPage":
                    {
                        IDU_UsersForm f = new IDU_UsersForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                        f.ShowDialog();

                    }
                    break;
                case "SecGroupPage":
                    {
                        IDU_SecGroupsForm f = new IDU_SecGroupsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                        f.ShowDialog();
                    }
                    break;
                case "StuffPage":
                    {
                        IDU_StuffForm f = new IDU_StuffForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                        f.ShowDialog();
                    }
                    break;
                case "PositionsPage":
                    {
                        IDU_PositionsForm f = new IDU_PositionsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                        f.ShowDialog();
                    }
                    break;
                case "CitiesPage":
                    {
                        IDU_CitiesForm f = new IDU_CitiesForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                        f.ShowDialog();
                    }
                    break;
                case "TracknumbersPage":
                    {
                        IDU_TracknumsForm f = new IDU_TracknumsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                        f.ShowDialog();
                    }
                    break;
                default:
                    break;
            }   
            LoadTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            if (id > 0){
                typeofoperation = "Update";
                switch (TablesAll.SelectedTab.Name)
                {
                    case "ParcelsPage":
                        {
                            IDU_ParcelsForm f = new IDU_ParcelsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                            f.x = id;
                            f.ShowDialog();

                        }
                        break;
                    case "TypeParPage":
                        {
                            IDU_TypeParcelsForm f = new IDU_TypeParcelsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                            f.x = id;
                            f.ShowDialog();
                        }
                        break;
                    case "ClientsPage":
                        {
                            IDU_ClientsForm f = new IDU_ClientsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                            f.x = id;
                            f.ShowDialog();

                        }
                        break;
                    case "UsersPage":
                        {
                            IDU_UsersForm f = new IDU_UsersForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                            f.x = id;
                            f.ShowDialog();

                        }
                        break;
                    case "SecGroupPage":
                        {
                            IDU_SecGroupsForm f = new IDU_SecGroupsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                            f.x = id;
                            f.ShowDialog();
                        }
                        break;
                    case "StuffPage":
                        {
                            IDU_StuffForm f = new IDU_StuffForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                            f.x = id;
                            f.ShowDialog();
                        }
                        break;
                    case "PositionsPage":
                        {
                            IDU_PositionsForm f = new IDU_PositionsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                            f.x = id;
                            f.ShowDialog();
                        }
                        break;
                    case "CitiesPage":
                        {
                            IDU_CitiesForm f = new IDU_CitiesForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                            f.x = id;
                            f.ShowDialog();
                        }
                        break;
                    case "TracknumbersPage":
                        {
                            IDU_TracknumsForm f = new IDU_TracknumsForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
                            f.x = id;
                            f.ShowDialog();
                        }
                        break;
                    default:
                        break;
                }
            }
            LoadTable();     
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {   
            if (id > 0) 
            {
                if (MessageBox.Show(this, "Вы уверены, что хотите удалить строку?", "Предупреждение", MessageBoxButtons.YesNo,MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    typeofoperation = "Delete";
                    switch (TablesAll.SelectedTab.Name)
                    {
                        case "ParcelsPage":
                            {
                                SqlDataAdapter da = new SqlDataAdapter
                                (@"exec IDU_parcel '0','0',null,'0','0','0','0',null,null,'0', @typeofoperation='" + typeofoperation +
                                "', @id='" + id + "'", dataBase.getConnection());
                                DataTable dt = new DataTable();
                                da.Fill(dt);

                            }
                            break;
                        case "TypeParPage":
                            {
                                SqlDataAdapter da = new SqlDataAdapter
                                (@"exec IDU_TypeParcel '0','0','0','0','0','0','0', @typeofoperation='" + typeofoperation +"', @id='" + id + "'", dataBase.getConnection());
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                            }
                            break;
                        case "ClientsPage":
                            {
                                SqlDataAdapter da = new SqlDataAdapter
                                (@"exec IDU_client '0','0',null,'0','0',null,null,'0', @typeofoperation='" + typeofoperation +
                                "', @id='" + id + "'", dataBase.getConnection());
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                            }
                            break;
                        case "UsersPage":
                            {
                                SqlDataAdapter da = new SqlDataAdapter
                                (@"exec IDU_user '0','0','0', @typeofoperation='" + typeofoperation +"', @id='" + id + "'", dataBase.getConnection());
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                            }
                            break;
                        case "SecGroupPage":
                            {
                                SqlDataAdapter da = new SqlDataAdapter
                                (@"exec IDU_SecGroup '0', @typeofoperation='" + typeofoperation + "', @id='" + id + "'", dataBase.getConnection());
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                            }
                            break;
                        case "StuffPage":
                            {
                                SqlDataAdapter da = new SqlDataAdapter
                                (@"exec IDU_stuff '0','0','0','0','0',null,'0','0','0', @typeofoperation='" + typeofoperation +
                                "', @id='" + id + "'", dataBase.getConnection());
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                            }
                            break;
                        case "PositionsPage":
                            {
                                SqlDataAdapter da = new SqlDataAdapter
                                (@"exec IDU_Position '0','0', @typeofoperation='" + typeofoperation +"', @id='" + id + "'", dataBase.getConnection());
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                            }
                            break;
                        case "CitiesPage":
                            {
                                SqlDataAdapter da = new SqlDataAdapter
                                (@"exec IDU_City '0', @typeofoperation='" + typeofoperation +
                                "', @id='" + id + "'", dataBase.getConnection());
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                            }
                            break;
                        case "TracknumbersPage":
                            {
                                SqlDataAdapter da = new SqlDataAdapter
                                (@"exec IDU_tracknum '0','0', 0','0', @typeofoperation='" + typeofoperation +"', @id='" + id + "'", dataBase.getConnection());
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                            }
                            break;
                        default:
                            break;
                    }
                }
                LoadTable();
                
            }
        }
        int id = 0;

        private void Form2_SizeChanged(object sender, EventArgs e)
        {   
            LoadTable();
            if (textBox1.Text != "")
            {
                filtering();
            }
        }
        private void filtering()
        {
            if ((FilterBox.SelectedIndex >= 0) && (textBox1.Text != ""))
            {
                StringBuilder sb = new StringBuilder();

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    sb.AppendFormat("CONVERT({0}, System.String) LIKE '%{1}%' OR ", $"[{FilterBox.SelectedItem}]", textBox1.Text);
                }
                sb.Remove(sb.Length - 3, 3);
                (dgv.DataSource as DataTable).DefaultView.RowFilter = sb.ToString();
            }
            else if ((FilterBox.SelectedIndex == -1) && (textBox1.Text != ""))
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    sb.AppendFormat("CONVERT({0}, System.String) LIKE '%{1}%' OR ", $"[{column.Name}]", textBox1.Text);
                }
                sb.Remove(sb.Length - 3, 3);
                (dgv.DataSource as DataTable).DefaultView.RowFilter = sb.ToString();
            }
            else if ((textBox1.Text == "")) { LoadTable(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           filtering();
        }

        private void refreshfilterbox() 
        {
            if (checkBox1.Checked == true)
            {
                textBox1.PlaceholderText= "Поиск по выбранной ячейке";
                for (int i = 1; i < dgv.Columns.Count - 1; i++)
                {
                    FilterBox.Items.Add(dgv.Columns[i].HeaderText);
                    FilterBox.SelectedIndex = 0;
                }
            }
            else if (checkBox1.Checked == false) { textBox1.PlaceholderText = "Поиск по всем ячейкам"; FilterBox.Items.Clear(); FilterBox.SelectedIndex = -1;FilterBox.Text = ""; }
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            refreshfilterbox();
            LoadTable();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeofoperation = "ActivateStuff";
            ActivateUserForm f = new ActivateUserForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
            //f.x = id;
            f.ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeofoperation = "ActivateClient";
            ActivateUserForm f = new ActivateUserForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
            //f.x = id;
            f.ShowDialog();

        }

        private void админаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeofoperation = "InsertAdmin";
            IDU_StuffForm f = new IDU_StuffForm(TablesAll.SelectedTab.Name, username_, typeofoperation);
            f.x = id;
            f.ShowDialog();
        }
    }
}
