namespace eGym.UI.Desktop
{
    partial class frmEditTraining
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
            btnDelete = new Button();
            cmbDay = new ComboBox();
            btnSave = new Button();
            rtxtDescription = new RichTextBox();
            txtName = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelError = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(182, 364);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 27);
            btnDelete.TabIndex = 69;
            btnDelete.Text = "Obrisi";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbDay
            // 
            cmbDay.FormattingEnabled = true;
            cmbDay.Items.AddRange(new object[] { "Nedjelja", "Ponedjeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota" });
            cmbDay.Location = new Point(102, 131);
            cmbDay.Margin = new Padding(3, 2, 3, 2);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(280, 23);
            cmbDay.TabIndex = 68;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(293, 364);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 27);
            btnSave.TabIndex = 67;
            btnSave.Text = "Spasi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(102, 191);
            rtxtDescription.Margin = new Padding(3, 2, 3, 2);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(280, 149);
            rtxtDescription.TabIndex = 66;
            rtxtDescription.Text = "";
            rtxtDescription.Validating += rtxtDescription_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(102, 69);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(280, 23);
            txtName.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 194);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 64;
            label6.Text = "Opis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 134);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 63;
            label4.Text = "Dan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 71);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 62;
            label3.Text = "Klijent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 14);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 61;
            label2.Text = "Plan treninga";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(11, 398);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 70;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmEditTraining
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(404, 422);
            Controls.Add(labelError);
            Controls.Add(btnDelete);
            Controls.Add(cmbDay);
            Controls.Add(btnSave);
            Controls.Add(rtxtDescription);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmEditTraining";
            Text = "Edit Trening";
            Load += frmEditTraining_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private ComboBox cmbDay;
        private Button btnSave;
        private RichTextBox rtxtDescription;
        private TextBox txtName;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelError;
        private ErrorProvider err;
    }
}