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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.dgvTraining = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateNewTraining = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Lista korisnika";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(179, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 46;
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
            this.txtSearch.TabIndex = 45;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(10, 53);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 29;
            this.dgvAccount.Size = new System.Drawing.Size(875, 340);
            this.dgvAccount.TabIndex = 44;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // dgvTraining
            // 
            this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraining.Location = new System.Drawing.Point(10, 412);
            this.dgvTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.RowHeadersWidth = 51;
            this.dgvTraining.RowTemplate.Height = 29;
            this.dgvTraining.Size = new System.Drawing.Size(875, 130);
            this.dgvTraining.TabIndex = 57;
            this.dgvTraining.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraining_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Lista postojecih treninga";
            // 
            // btnCreateNewTraining
            // 
            this.btnCreateNewTraining.Location = new System.Drawing.Point(779, 546);
            this.btnCreateNewTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNewTraining.Name = "btnCreateNewTraining";
            this.btnCreateNewTraining.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateNewTraining.Size = new System.Drawing.Size(106, 22);
            this.btnCreateNewTraining.TabIndex = 59;
            this.btnCreateNewTraining.Text = "Kreiraj novi";
            this.btnCreateNewTraining.UseVisualStyleBackColor = true;
            this.btnCreateNewTraining.Click += new System.EventHandler(this.btnCreateNewTraining_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(10, 573);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 60;
            // 
            // frmTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(897, 597);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnCreateNewTraining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTraining);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAccount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmTraining";
            this.Text = "Plan Treninga";
            this.Load += new System.EventHandler(this.frmTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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