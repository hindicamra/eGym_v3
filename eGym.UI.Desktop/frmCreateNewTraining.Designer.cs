namespace eGym.UI.Desktop
{
    partial class frmCreateNewTraining
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
            cmbDay = new ComboBox();
            rtxtDescription = new RichTextBox();
            txtName = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSave = new Button();
            labelError = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // cmbDay
            // 
            cmbDay.FormattingEnabled = true;
            cmbDay.Items.AddRange(new object[] { "Nedjelja", "Ponedjeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota" });
            cmbDay.Location = new Point(108, 160);
            cmbDay.Margin = new Padding(3, 2, 3, 2);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(280, 23);
            cmbDay.TabIndex = 63;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(108, 220);
            rtxtDescription.Margin = new Padding(3, 2, 3, 2);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(280, 149);
            rtxtDescription.TabIndex = 62;
            rtxtDescription.Text = "";
            rtxtDescription.Validating += rtxtDescription_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 98);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(280, 23);
            txtName.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 222);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 60;
            label6.Text = "Opis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 162);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 59;
            label4.Text = "Dan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 100);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 58;
            label3.Text = "Klijent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 18);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 57;
            label2.Text = "Kreiraj novi unos";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(285, 391);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 26);
            btnSave.TabIndex = 64;
            btnSave.Text = "Spasi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(17, 430);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 65;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmCreateNewTraining
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Aqua;
            ClientSize = new Size(428, 454);
            Controls.Add(labelError);
            Controls.Add(btnSave);
            Controls.Add(cmbDay);
            Controls.Add(rtxtDescription);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmCreateNewTraining";
            Text = "Kreiraj novi unos";
            Load += frmCreateNewTraining_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDay;
        private RichTextBox rtxtDescription;
        private TextBox txtName;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSave;
        private Label labelError;
        private ErrorProvider err;
    }
}