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
            this.components = new System.ComponentModel.Container();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbZensko = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(487, 494);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 23);
            this.txtPassword.TabIndex = 48;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(180, 494);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 23);
            this.txtUsername.TabIndex = 47;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserName_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 467);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // rbZensko
            // 
            this.rbZensko.AutoSize = true;
            this.rbZensko.Location = new System.Drawing.Point(336, 444);
            this.rbZensko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(63, 19);
            this.rbZensko.TabIndex = 45;
            this.rbZensko.TabStop = true;
            this.rbZensko.Text = "Zensko";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(180, 444);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(61, 19);
            this.rbMale.TabIndex = 44;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Musko";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(405, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Datum rodjenja";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Spol";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(487, 417);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(219, 23);
            this.txtLastName.TabIndex = 38;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastName_Validating);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(405, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Prezime";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(577, 521);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 34);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Spasi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(442, 521);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 34);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 417);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 23);
            this.txtName.TabIndex = 34;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ime";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(213, 390);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(219, 23);
            this.txtId.TabIndex = 32;
            this.txtId.Visible = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(108, 395);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 15);
            this.ID.TabIndex = 31;
            this.ID.Text = "ID";
            this.ID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Detalji korisnika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Lista korisnika";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(180, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Pretrazi";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 23);
            this.txtSearch.TabIndex = 27;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(12, 53);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 29;
            this.dgvAccount.Size = new System.Drawing.Size(872, 340);
            this.dgvAccount.TabIndex = 25;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 567);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 49;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(896, 591);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rbZensko);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAccount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmAccount";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbZensko;
        private RadioButton rbMale;
        private Label label8;
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
        private ErrorProvider errorProviderApp;
        private Label labelError;
    }
}