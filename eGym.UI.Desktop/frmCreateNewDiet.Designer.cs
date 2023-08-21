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
            this.components = new System.ComponentModel.Container();
            this.cmbMeal = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMeal
            // 
            this.cmbMeal.FormattingEnabled = true;
            this.cmbMeal.Items.AddRange(new object[] {
            "Dorucak",
            "Rucak",
            "Vecera"});
            this.cmbMeal.Location = new System.Drawing.Point(108, 171);
            this.cmbMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMeal.Name = "cmbMeal";
            this.cmbMeal.Size = new System.Drawing.Size(280, 23);
            this.cmbMeal.TabIndex = 53;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Nedjelja",
            "Ponedjeljak",
            "Utorak",
            "Srijeda",
            "Cetvrtak",
            "Petak",
            "Subota"});
            this.cmbDay.Location = new System.Drawing.Point(108, 129);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(280, 23);
            this.cmbDay.TabIndex = 52;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(298, 396);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 27);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Spasi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(108, 226);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(280, 149);
            this.rtxtDescription.TabIndex = 50;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescription_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 83);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(280, 23);
            this.txtName.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Obrok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "Dan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Klijent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Kreiraj novi unos ishrane";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(17, 439);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 54;
            // 
            // frmCreateNewDiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(410, 463);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.cmbMeal);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmCreateNewDiet";
            this.Text = "Kreiraj novi unos";
            this.Load += new System.EventHandler(this.frmCreateNewDiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ErrorProvider errorProviderApp;
        private Label labelError;
    }
}