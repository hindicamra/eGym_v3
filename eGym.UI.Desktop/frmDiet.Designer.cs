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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.dgvDiet = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lista korisnika";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(177, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Pretrazi";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 23);
            this.txtSearch.TabIndex = 31;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(10, 53);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 29;
            this.dgvAccount.Size = new System.Drawing.Size(874, 340);
            this.dgvAccount.TabIndex = 30;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // dgvDiet
            // 
            this.dgvDiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiet.Location = new System.Drawing.Point(10, 412);
            this.dgvDiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDiet.Name = "dgvDiet";
            this.dgvDiet.RowHeadersWidth = 51;
            this.dgvDiet.RowTemplate.Height = 29;
            this.dgvDiet.Size = new System.Drawing.Size(874, 140);
            this.dgvDiet.TabIndex = 44;
            this.dgvDiet.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiet_CellContentDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Trenutni plan ishrane";
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(781, 556);
            this.btnCreateNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateNew.Size = new System.Drawing.Size(103, 22);
            this.btnCreateNew.TabIndex = 46;
            this.btnCreateNew.Text = "Kreiraj novi";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 587);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 47;
            // 
            // frmDiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(896, 611);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAccount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmDiet";
            this.Text = "Plan ishrane";
            this.Load += new System.EventHandler(this.frmDiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}