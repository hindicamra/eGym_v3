namespace eGym.UI.Desktop
{
    partial class frmCreateAccount
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
            txtEmail = new TextBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            btnCreate = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelError = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 210);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 215);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 36;
            label9.Text = "Email";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 179);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(321, 152);
            rbFemale.Margin = new Padding(3, 2, 3, 2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 33;
            rbFemale.TabStop = true;
            rbFemale.Text = "Zensko";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(170, 152);
            rbMale.Margin = new Padding(3, 2, 3, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(61, 19);
            rbMale.TabIndex = 32;
            rbMale.TabStop = true;
            rbMale.Text = "Musko";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(170, 284);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 23);
            txtPassword.TabIndex = 31;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(170, 244);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 23);
            txtUsername.TabIndex = 30;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(170, 111);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(219, 23);
            txtLastName.TabIndex = 29;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 74);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 23);
            txtName.TabIndex = 28;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(192, 356);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(98, 32);
            btnCreate.TabIndex = 27;
            btnCreate.Text = "Kreiraj";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 290);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 25;
            label7.Text = "Lozinka";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 250);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 24;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 184);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 23;
            label5.Text = "Datum rodjenja";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 145);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 22;
            label4.Text = "Spol";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 111);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 21;
            label3.Text = "Prezime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 76);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 20;
            label2.Text = "Ime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 19;
            label1.Text = "Kreiraj korisnika";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(12, 393);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 38;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmCreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(465, 417);
            Controls.Add(labelError);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(btnCreate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmCreateAccount";
            Text = "Kreiranje korisnika";
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtLastName;
        private TextBox txtName;
        private Button btnCreate;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelError;
        private ErrorProvider err;
    }
}