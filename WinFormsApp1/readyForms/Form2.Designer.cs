namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.insertButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.FilterBox = new System.Windows.Forms.ComboBox();
            this.UserName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.userNameButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.админаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TablesAll = new System.Windows.Forms.TabControl();
            this.ParcelsPage = new System.Windows.Forms.TabPage();
            this.TypeParPage = new System.Windows.Forms.TabPage();
            this.ClientsPage = new System.Windows.Forms.TabPage();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.SecGroupPage = new System.Windows.Forms.TabPage();
            this.StuffPage = new System.Windows.Forms.TabPage();
            this.PositionsPage = new System.Windows.Forms.TabPage();
            this.CitiesPage = new System.Windows.Forms.TabPage();
            this.TracknumbersPage = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.TablesAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.insertButton.Location = new System.Drawing.Point(0, 1051);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(167, 40);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.Location = new System.Drawing.Point(173, 1051);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(167, 40);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Редактировать";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(346, 1051);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(167, 40);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1002, 1053);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Поиск по всем ячейкам";
            this.textBox1.Size = new System.Drawing.Size(339, 35);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1359, 1014);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 34);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Поиск по ячейке";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // FilterBox
            // 
            this.FilterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.Location = new System.Drawing.Point(1347, 1054);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(227, 38);
            this.FilterBox.TabIndex = 8;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(0, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 23);
            this.UserName.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameButton,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1578, 40);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // userNameButton
            // 
            this.userNameButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userNameButton.BackColor = System.Drawing.SystemColors.Control;
            this.userNameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.userNameButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.профильToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.userNameButton.Image = ((System.Drawing.Image)(resources.GetObject("userNameButton.Image")));
            this.userNameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userNameButton.Name = "userNameButton";
            this.userNameButton.Size = new System.Drawing.Size(90, 34);
            this.userNameButton.Text = "Name";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 35);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(218, 40);
            this.профильToolStripMenuItem.Text = "Профиль";
            this.профильToolStripMenuItem.Click += new System.EventHandler(this.профильToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(218, 40);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.добавлениеToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(93, 34);
            this.toolStripDropDownButton1.Text = "Меню";
            this.toolStripDropDownButton1.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.клиентыToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuItem1.Text = "Активация";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(244, 40);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(244, 40);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // добавлениеToolStripMenuItem
            // 
            this.добавлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.админаToolStripMenuItem});
            this.добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            this.добавлениеToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.добавлениеToolStripMenuItem.Text = "Добавление ";
            // 
            // админаToolStripMenuItem
            // 
            this.админаToolStripMenuItem.Name = "админаToolStripMenuItem";
            this.админаToolStripMenuItem.Size = new System.Drawing.Size(195, 40);
            this.админаToolStripMenuItem.Text = "Админ";
            this.админаToolStripMenuItem.Click += new System.EventHandler(this.админаToolStripMenuItem_Click);
            // 
            // TablesAll
            // 
            this.TablesAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesAll.Controls.Add(this.ParcelsPage);
            this.TablesAll.Controls.Add(this.TypeParPage);
            this.TablesAll.Controls.Add(this.ClientsPage);
            this.TablesAll.Controls.Add(this.UsersPage);
            this.TablesAll.Controls.Add(this.SecGroupPage);
            this.TablesAll.Controls.Add(this.StuffPage);
            this.TablesAll.Controls.Add(this.PositionsPage);
            this.TablesAll.Controls.Add(this.CitiesPage);
            this.TablesAll.Controls.Add(this.TracknumbersPage);
            this.TablesAll.Location = new System.Drawing.Point(0, 44);
            this.TablesAll.Name = "TablesAll";
            this.TablesAll.SelectedIndex = 0;
            this.TablesAll.Size = new System.Drawing.Size(1578, 925);
            this.TablesAll.TabIndex = 13;
            this.TablesAll.Tag = "";
            this.TablesAll.SelectedIndexChanged += new System.EventHandler(this.TablesAll_SelectedIndexChanged);
            // 
            // ParcelsPage
            // 
            this.ParcelsPage.Location = new System.Drawing.Point(4, 39);
            this.ParcelsPage.Name = "ParcelsPage";
            this.ParcelsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParcelsPage.Size = new System.Drawing.Size(1570, 882);
            this.ParcelsPage.TabIndex = 0;
            this.ParcelsPage.Text = "Посылки";
            this.ParcelsPage.UseVisualStyleBackColor = true;
            // 
            // TypeParPage
            // 
            this.TypeParPage.Location = new System.Drawing.Point(4, 39);
            this.TypeParPage.Name = "TypeParPage";
            this.TypeParPage.Padding = new System.Windows.Forms.Padding(3);
            this.TypeParPage.Size = new System.Drawing.Size(1570, 882);
            this.TypeParPage.TabIndex = 1;
            this.TypeParPage.Text = "Типы посылок";
            this.TypeParPage.UseVisualStyleBackColor = true;
            // 
            // ClientsPage
            // 
            this.ClientsPage.Location = new System.Drawing.Point(4, 39);
            this.ClientsPage.Name = "ClientsPage";
            this.ClientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientsPage.Size = new System.Drawing.Size(1570, 882);
            this.ClientsPage.TabIndex = 2;
            this.ClientsPage.Text = "Клиенты";
            this.ClientsPage.UseVisualStyleBackColor = true;
            // 
            // UsersPage
            // 
            this.UsersPage.Location = new System.Drawing.Point(4, 39);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Size = new System.Drawing.Size(1570, 882);
            this.UsersPage.TabIndex = 3;
            this.UsersPage.Text = "Пользователи";
            this.UsersPage.UseVisualStyleBackColor = true;
            // 
            // SecGroupPage
            // 
            this.SecGroupPage.Location = new System.Drawing.Point(4, 39);
            this.SecGroupPage.Name = "SecGroupPage";
            this.SecGroupPage.Size = new System.Drawing.Size(1570, 882);
            this.SecGroupPage.TabIndex = 4;
            this.SecGroupPage.Text = "Группы доступов";
            this.SecGroupPage.UseVisualStyleBackColor = true;
            // 
            // StuffPage
            // 
            this.StuffPage.Location = new System.Drawing.Point(4, 39);
            this.StuffPage.Name = "StuffPage";
            this.StuffPage.Size = new System.Drawing.Size(1570, 882);
            this.StuffPage.TabIndex = 5;
            this.StuffPage.Text = "Сотрудники";
            this.StuffPage.UseVisualStyleBackColor = true;
            // 
            // PositionsPage
            // 
            this.PositionsPage.Location = new System.Drawing.Point(4, 39);
            this.PositionsPage.Name = "PositionsPage";
            this.PositionsPage.Size = new System.Drawing.Size(1570, 882);
            this.PositionsPage.TabIndex = 6;
            this.PositionsPage.Text = "Должности";
            this.PositionsPage.UseVisualStyleBackColor = true;
            // 
            // CitiesPage
            // 
            this.CitiesPage.Location = new System.Drawing.Point(4, 39);
            this.CitiesPage.Name = "CitiesPage";
            this.CitiesPage.Size = new System.Drawing.Size(1570, 882);
            this.CitiesPage.TabIndex = 7;
            this.CitiesPage.Text = "Города";
            this.CitiesPage.UseVisualStyleBackColor = true;
            // 
            // TracknumbersPage
            // 
            this.TracknumbersPage.Location = new System.Drawing.Point(4, 39);
            this.TracknumbersPage.Name = "TracknumbersPage";
            this.TracknumbersPage.Size = new System.Drawing.Size(1570, 882);
            this.TracknumbersPage.TabIndex = 8;
            this.TracknumbersPage.Text = "Трекномера";
            this.TracknumbersPage.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1104);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TablesAll);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.DeleteButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.SizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TablesAll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button insertButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private ComboBox FilterBox;
        private Label UserName;
        private ToolStrip toolStrip1;
        private TabControl TablesAll;
        private TabPage ParcelsPage;
        private TabPage TypeParPage;
        private TabPage ClientsPage;
        private TabPage UsersPage;
        private TabPage SecGroupPage;
        private TabPage StuffPage;
        private TabPage PositionsPage;
        private TabPage CitiesPage;
        private TabPage TracknumbersPage;
        private ToolStripDropDownButton userNameButton;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem профильToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem добавлениеToolStripMenuItem;
        private ToolStripMenuItem админаToolStripMenuItem;
    }
}