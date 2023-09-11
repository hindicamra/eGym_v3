namespace eGym.UI.Desktop
{
    partial class frmCreateEmployee
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnCreate = new Button();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            cbRole = new ComboBox();
            label9 = new Label();
            txtEmail = new TextBox();
            labelError = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Kreiraj uposlenika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 69);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Ime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 104);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Prezime";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 137);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Spol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 177);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Datum rodjenja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 242);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 282);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 6;
            label7.Text = "Lozinka";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 322);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 7;
            label8.Text = "Rola";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(172, 349);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(98, 32);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Kreiraj";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 67);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 23);
            txtName.TabIndex = 9;
            txtName.Validating += txtName_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 104);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(219, 23);
            txtLastName.TabIndex = 10;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(150, 237);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 23);
            txtUsername.TabIndex = 11;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 277);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 23);
            txtPassword.TabIndex = 12;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(150, 144);
            rbMale.Margin = new Padding(3, 2, 3, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(61, 19);
            rbMale.TabIndex = 13;
            rbMale.TabStop = true;
            rbMale.Text = "Musko";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(301, 144);
            rbFemale.Margin = new Padding(3, 2, 3, 2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 14;
            rbFemale.TabStop = true;
            rbFemale.Text = "Zensko";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(150, 172);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Employee" });
            cbRole.Location = new Point(150, 316);
            cbRole.Margin = new Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(219, 23);
            cbRole.TabIndex = 16;
            cbRole.Validating += cbRole_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 208);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 17;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 202);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 18;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(28, 392);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 19;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Aqua;
            ClientSize = new Size(437, 416);
            Controls.Add(labelError);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(cbRole);
            Controls.Add(dateTimePicker1);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(btnCreate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmCreateEmployee";
            Text = "Create Employee";
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnCreate;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbRole;
        private Label label9;
        private TextBox txtEmail;
        private Label labelError;
        private ErrorProvider err;
    }
}