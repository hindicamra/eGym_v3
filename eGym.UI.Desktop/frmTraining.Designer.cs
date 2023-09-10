namespace eGym.UI.Desktop
{
    partial class frmTraining
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
            dgvTraining = new DataGridView();
            label5 = new Label();
            btnCreateNewTraining = new Button();
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTraining).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 47;
            label1.Text = "Lista korisnika";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(179, 27);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 46;
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
            txtSearch.TabIndex = 45;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Location = new Point(10, 53);
            dgvAccount.Margin = new Padding(3, 2, 3, 2);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.Size = new Size(875, 340);
            dgvAccount.TabIndex = 44;
            dgvAccount.CellClick += dgvAccount_CellClick;
            // 
            // dgvTraining
            // 
            dgvTraining.AllowUserToAddRows = false;
            dgvTraining.AllowUserToDeleteRows = false;
            dgvTraining.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTraining.Location = new Point(10, 412);
            dgvTraining.Margin = new Padding(3, 2, 3, 2);
            dgvTraining.Name = "dgvTraining";
            dgvTraining.ReadOnly = true;
            dgvTraining.RowHeadersWidth = 51;
            dgvTraining.RowTemplate.Height = 29;
            dgvTraining.Size = new Size(875, 130);
            dgvTraining.TabIndex = 57;
            dgvTraining.CellDoubleClick += dgvTraining_CellDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 395);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 58;
            label5.Text = "Lista postojecih treninga";
            // 
            // btnCreateNewTraining
            // 
            btnCreateNewTraining.Location = new Point(779, 546);
            btnCreateNewTraining.Margin = new Padding(3, 2, 3, 2);
            btnCreateNewTraining.Name = "btnCreateNewTraining";
            btnCreateNewTraining.RightToLeft = RightToLeft.No;
            btnCreateNewTraining.Size = new Size(106, 22);
            btnCreateNewTraining.TabIndex = 59;
            btnCreateNewTraining.Text = "Kreiraj novi";
            btnCreateNewTraining.UseVisualStyleBackColor = true;
            btnCreateNewTraining.Click += btnCreateNewTraining_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(10, 573);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 60;
            // 
            // frmTraining
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(897, 597);
            Controls.Add(labelError);
            Controls.Add(btnCreateNewTraining);
            Controls.Add(label5);
            Controls.Add(dgvTraining);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvAccount);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmTraining";
            Text = "Plan Treninga";
            Load += frmTraining_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTraining).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvAccount;
        private DataGridView dgvTraining;
        private Label label5;
        private Button btnCreateNewTraining;
        private Label labelError;
    }
}