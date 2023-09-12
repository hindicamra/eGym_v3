namespace eGym.UI.Desktop
{
    partial class frmDiet
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
            label1 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvAccount = new DataGridView();
            dgvDiet = new DataGridView();
            day = new DataGridViewTextBoxColumn();
            meal = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            label7 = new Label();
            btnCreateNew = new Button();
            labelError = new Label();
            firstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            birthDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 33;
            label1.Text = "Lista korisnika";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(177, 25);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Pretrazi";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(10, 26);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(161, 23);
            txtSearch.TabIndex = 31;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { firstName, lastName, username, email, role, gender, birthDate });
            dgvAccount.Location = new Point(10, 53);
            dgvAccount.Margin = new Padding(3, 2, 3, 2);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.Size = new Size(874, 340);
            dgvAccount.TabIndex = 30;
            dgvAccount.CellClick += dgvAccount_CellClick;
            // 
            // dgvDiet
            // 
            dgvDiet.AllowUserToAddRows = false;
            dgvDiet.AllowUserToDeleteRows = false;
            dgvDiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiet.Columns.AddRange(new DataGridViewColumn[] { day, meal, description });
            dgvDiet.Location = new Point(10, 412);
            dgvDiet.Margin = new Padding(3, 2, 3, 2);
            dgvDiet.Name = "dgvDiet";
            dgvDiet.ReadOnly = true;
            dgvDiet.RowHeadersWidth = 51;
            dgvDiet.RowTemplate.Height = 29;
            dgvDiet.Size = new Size(874, 140);
            dgvDiet.TabIndex = 44;
            dgvDiet.CellContentDoubleClick += dgvDiet_CellContentDoubleClick;
            // 
            // day
            // 
            day.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            day.DataPropertyName = "day";
            day.HeaderText = "Dan";
            day.Name = "day";
            day.ReadOnly = true;
            // 
            // meal
            // 
            meal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            meal.DataPropertyName = "meal";
            meal.HeaderText = "Obrok";
            meal.Name = "meal";
            meal.ReadOnly = true;
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description.DataPropertyName = "description";
            description.HeaderText = "Opis";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 395);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 45;
            label7.Text = "Trenutni plan ishrane";
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(781, 556);
            btnCreateNew.Margin = new Padding(3, 2, 3, 2);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.RightToLeft = RightToLeft.No;
            btnCreateNew.Size = new Size(103, 22);
            btnCreateNew.TabIndex = 46;
            btnCreateNew.Text = "Kreiraj novi";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(12, 587);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 47;
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
            username.HeaderText = "Korisniko Ime";
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
            // frmDiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(896, 611);
            Controls.Add(labelError);
            Controls.Add(btnCreateNew);
            Controls.Add(label7);
            Controls.Add(dgvDiet);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvAccount);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmDiet";
            Text = "Plan ishrane";
            Load += frmDiet_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvAccount;
        private DataGridView dgvDiet;
        private Label label7;
        private Button btnCreateNew;
        private Label labelError;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn meal;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn birthDate;
    }
}