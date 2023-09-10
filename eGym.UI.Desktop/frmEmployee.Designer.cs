namespace eGym.UI.Desktop
{
    partial class frmEmployee
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
            components = new System.ComponentModel.Container();
            dgvEmployee = new DataGridView();
            firstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            birthDate = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            ID = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            btnDelete = new Button();
            btnSave = new Button();
            label4 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            rbMale = new RadioButton();
            rbZensko = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            txtUsername = new TextBox();
            comboBox1 = new ComboBox();
            labelError = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AllowUserToDeleteRows = false;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { firstName, lastName, username, email, role, gender, birthDate });
            dgvEmployee.Location = new Point(10, 53);
            dgvEmployee.Margin = new Padding(3, 2, 3, 2);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(873, 335);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // firstName
            // 
            firstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstName.DataPropertyName = "firstName";
            firstName.HeaderText = "Ime";
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastName.DataPropertyName = "lastName";
            lastName.HeaderText = "Prezime";
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // username
            // 
            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            username.DataPropertyName = "username";
            username.HeaderText = "Korisnicko ime";
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            role.DataPropertyName = "role";
            role.HeaderText = "Uloga";
            role.Name = "role";
            role.ReadOnly = true;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gender.DataPropertyName = "gender";
            gender.HeaderText = "Spol";
            gender.Name = "gender";
            gender.ReadOnly = true;
            // 
            // birthDate
            // 
            birthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            birthDate.DataPropertyName = "birthDate";
            birthDate.HeaderText = "Datum rodjenja";
            birthDate.Name = "birthDate";
            birthDate.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(10, 26);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(161, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(177, 25);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Pretrazi";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 4;
            label1.Text = "Lista zaposlenih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 395);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 5;
            label2.Text = "Detalji zaposlenika";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(127, 397);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 6;
            ID.Text = "ID";
            ID.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(232, 392);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(219, 23);
            txtId.TabIndex = 7;
            txtId.Visible = false;
            // 
            // label3
            // 
            label3.Location = new Point(12, 422);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Ime";
            // 
            // txtName
            // 
            txtName.Location = new Point(232, 419);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 23);
            txtName.TabIndex = 9;
            txtName.Validating += textBoxName_Validating;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(480, 551);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Obrisi";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(615, 551);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Spasi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.Location = new Point(457, 422);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 12;
            label4.Text = "Prezime";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(525, 419);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(219, 23);
            txtLastName.TabIndex = 13;
            txtLastName.Validating += textBoxLastName_Validating;
            // 
            // label5
            // 
            label5.Location = new Point(12, 448);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 14;
            label5.Text = "Spol";
            // 
            // label6
            // 
            label6.Location = new Point(12, 475);
            label6.Name = "label6";
            label6.Size = new Size(103, 16);
            label6.TabIndex = 15;
            label6.Text = "Datum rodjenja";
            // 
            // label7
            // 
            label7.Location = new Point(12, 500);
            label7.Name = "label7";
            label7.Size = new Size(76, 16);
            label7.TabIndex = 16;
            label7.Text = "Username";
            // 
            // label9
            // 
            label9.Location = new Point(12, 527);
            label9.Name = "label9";
            label9.Size = new Size(76, 16);
            label9.TabIndex = 18;
            label9.Text = "Rola";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(232, 446);
            rbMale.Margin = new Padding(3, 2, 3, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(61, 19);
            rbMale.TabIndex = 19;
            rbMale.TabStop = true;
            rbMale.Text = "Musko";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbZensko
            // 
            rbZensko.AutoSize = true;
            rbZensko.Location = new Point(388, 446);
            rbZensko.Margin = new Padding(3, 2, 3, 2);
            rbZensko.Name = "rbZensko";
            rbZensko.Size = new Size(63, 19);
            rbZensko.TabIndex = 20;
            rbZensko.TabStop = true;
            rbZensko.Text = "Zensko";
            rbZensko.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(232, 469);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(232, 497);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 23);
            txtUsername.TabIndex = 22;
            txtUsername.Validating += textBoxUserName_Validating;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Employee" });
            comboBox1.Location = new Point(232, 524);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 23);
            comboBox1.TabIndex = 24;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(10, 606);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 25;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(895, 630);
            Controls.Add(labelError);
            Controls.Add(comboBox1);
            Controls.Add(txtUsername);
            Controls.Add(dateTimePicker1);
            Controls.Add(rbZensko);
            Controls.Add(rbMale);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(ID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvEmployee);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmEmployee";
            Text = "Zaposlenici";
            Load += frmEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private Button btnCreateEmployee;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private Label label2;
        private Label ID;
        private TextBox txtId;
        private Label label3;
        private TextBox txtName;
        private Button btnDelete;
        private Button btnSave;
        private Label label4;
        private TextBox txtLastName;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private RadioButton rbMale;
        private RadioButton rbZensko;
        private DateTimePicker dateTimePicker1;
        private TextBox txtUsername;
        private ComboBox comboBox1;
        private Label labelError;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn birthDate;
        private ErrorProvider err;
    }
}