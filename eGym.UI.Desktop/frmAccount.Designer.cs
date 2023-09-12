namespace eGym.UI.Desktop
{
    partial class frmAccount
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
            txtUsername = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            rbZensko = new RadioButton();
            rbMale = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            txtName = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            ID = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvAccount = new DataGridView();
            firstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            birthDate = new DataGridViewTextBoxColumn();
            labelError = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(180, 494);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 23);
            txtUsername.TabIndex = 47;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 467);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 46;
            // 
            // rbZensko
            // 
            rbZensko.AutoSize = true;
            rbZensko.Enabled = false;
            rbZensko.Location = new Point(336, 444);
            rbZensko.Margin = new Padding(3, 2, 3, 2);
            rbZensko.Name = "rbZensko";
            rbZensko.Size = new Size(63, 19);
            rbZensko.TabIndex = 45;
            rbZensko.TabStop = true;
            rbZensko.Text = "Zensko";
            rbZensko.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Enabled = false;
            rbMale.Location = new Point(180, 444);
            rbMale.Margin = new Padding(3, 2, 3, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(61, 19);
            rbMale.TabIndex = 44;
            rbMale.TabStop = true;
            rbMale.Text = "Musko";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Location = new Point(12, 497);
            label7.Name = "label7";
            label7.Size = new Size(76, 16);
            label7.TabIndex = 41;
            label7.Text = "Username";
            // 
            // label6
            // 
            label6.Location = new Point(12, 473);
            label6.Name = "label6";
            label6.Size = new Size(103, 16);
            label6.TabIndex = 40;
            label6.Text = "Datum rodjenja";
            // 
            // label5
            // 
            label5.Location = new Point(12, 446);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 39;
            label5.Text = "Spol";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(487, 417);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(219, 23);
            txtLastName.TabIndex = 38;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // label4
            // 
            label4.Location = new Point(405, 420);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 37;
            label4.Text = "Prezime";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(577, 521);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 34);
            btnSave.TabIndex = 36;
            btnSave.Text = "Spasi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(442, 521);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 34);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Obrisi";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 417);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 23);
            txtName.TabIndex = 34;
            txtName.Validating += txtName_Validating;
            // 
            // label3
            // 
            label3.Location = new Point(12, 420);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 33;
            label3.Text = "Ime";
            // 
            // txtId
            // 
            txtId.Location = new Point(213, 390);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(219, 23);
            txtId.TabIndex = 32;
            txtId.Visible = false;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(108, 395);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 31;
            ID.Text = "ID";
            ID.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 395);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 30;
            label2.Text = "Detalji korisnika";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 8);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 29;
            label1.Text = "Lista korisnika";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(180, 27);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "Pretrazi";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 26);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(161, 23);
            txtSearch.TabIndex = 27;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { firstName, lastName, username, email, role, gender, birthDate });
            dgvAccount.Location = new Point(12, 53);
            dgvAccount.Margin = new Padding(3, 2, 3, 2);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.Size = new Size(872, 340);
            dgvAccount.TabIndex = 25;
            dgvAccount.CellClick += dgvAccount_CellClick;
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
            username.HeaderText = "Username";
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
            birthDate.HeaderText = "Datum rodenja";
            birthDate.Name = "birthDate";
            birthDate.ReadOnly = true;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(12, 567);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 49;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Aqua;
            ClientSize = new Size(896, 591);
            Controls.Add(labelError);
            Controls.Add(txtUsername);
            Controls.Add(dateTimePicker1);
            Controls.Add(rbZensko);
            Controls.Add(rbMale);
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
            Controls.Add(dgvAccount);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmAccount";
            Text = "Korisnici";
            Load += frmAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbZensko;
        private RadioButton rbMale;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private Button btnSave;
        private Button btnDelete;
        private TextBox txtName;
        private Label label3;
        private TextBox txtId;
        private Label ID;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnCreateEmployee;
        private DataGridView dgvAccount;
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