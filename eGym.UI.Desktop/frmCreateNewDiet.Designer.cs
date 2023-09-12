namespace eGym.UI.Desktop
{
    partial class frmCreateNewDiet
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
            cmbMeal = new ComboBox();
            cmbDay = new ComboBox();
            btnSave = new Button();
            rtxtDescription = new RichTextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelError = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // cmbMeal
            // 
            cmbMeal.FormattingEnabled = true;
            cmbMeal.Items.AddRange(new object[] { "Dorucak", "Rucak", "Vecera" });
            cmbMeal.Location = new Point(108, 171);
            cmbMeal.Margin = new Padding(3, 2, 3, 2);
            cmbMeal.Name = "cmbMeal";
            cmbMeal.Size = new Size(280, 23);
            cmbMeal.TabIndex = 53;
            cmbMeal.Validating += cmbMeal_Validating;
            // 
            // cmbDay
            // 
            cmbDay.FormattingEnabled = true;
            cmbDay.Items.AddRange(new object[] { "Nedjelja", "Ponedjeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota" });
            cmbDay.Location = new Point(108, 129);
            cmbDay.Margin = new Padding(3, 2, 3, 2);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(280, 23);
            cmbDay.TabIndex = 52;
            cmbDay.Validating += cmbDay_Validating;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(298, 396);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 27);
            btnSave.TabIndex = 51;
            btnSave.Text = "Spasi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(108, 226);
            rtxtDescription.Margin = new Padding(3, 2, 3, 2);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(280, 149);
            rtxtDescription.TabIndex = 50;
            rtxtDescription.Text = "";
            rtxtDescription.Validating += rtxtDescription_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 83);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(280, 23);
            txtName.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 226);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 48;
            label6.Text = "Opis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 177);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 47;
            label5.Text = "Obrok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 135);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 46;
            label4.Text = "Dan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 88);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 45;
            label3.Text = "Klijent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 7);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 44;
            label2.Text = "Kreiraj novi unos ishrane";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(17, 439);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 54;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmCreateNewDiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Aqua;
            ClientSize = new Size(410, 463);
            Controls.Add(labelError);
            Controls.Add(cmbMeal);
            Controls.Add(cmbDay);
            Controls.Add(btnSave);
            Controls.Add(rtxtDescription);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmCreateNewDiet";
            Text = "Kreiraj novi unos";
            Load += frmCreateNewDiet_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMeal;
        private ComboBox cmbDay;
        private Button btnSave;
        private RichTextBox rtxtDescription;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelError;
        private ErrorProvider err;
    }
}