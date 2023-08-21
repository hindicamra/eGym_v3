namespace eGym.UI.Desktop
{
    partial class frmReservationsOverview
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
            this.dtpSearchTime = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTrainings = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxbDescription = new System.Windows.Forms.RichTextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpSearchTime
            // 
            this.dtpSearchTime.Location = new System.Drawing.Point(61, 26);
            this.dtpSearchTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSearchTime.Name = "dtpSearchTime";
            this.dtpSearchTime.Size = new System.Drawing.Size(219, 23);
            this.dtpSearchTime.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(286, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pretrazi";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTrainings
            // 
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainings.Location = new System.Drawing.Point(12, 53);
            this.dgvTrainings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.RowHeadersWidth = 51;
            this.dgvTrainings.RowTemplate.Height = 29;
            this.dgvTrainings.Size = new System.Drawing.Size(708, 213);
            this.dgvTrainings.TabIndex = 3;
            this.dgvTrainings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainings_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prikaza dnevnog rasporeda";
            // 
            // rtxbDescription
            // 
            this.rtxbDescription.Location = new System.Drawing.Point(130, 351);
            this.rtxbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxbDescription.Name = "rtxbDescription";
            this.rtxbDescription.ReadOnly = true;
            this.rtxbDescription.Size = new System.Drawing.Size(500, 84);
            this.rtxbDescription.TabIndex = 27;
            this.rtxbDescription.Text = "";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Tezinski",
            "Funkcionali",
            "Aerobik",
            "Kardio"});
            this.cmbType.Location = new System.Drawing.Point(130, 324);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(233, 23);
            this.cmbType.TabIndex = 26;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(397, 297);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(233, 23);
            this.dtpTo.TabIndex = 25;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(130, 297);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(233, 23);
            this.dtpFrom.TabIndex = 24;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(130, 270);
            this.txtClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(233, 23);
            this.txtClient.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Opis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Vrsta treninga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Klijent";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 459);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 28;
            // 
            // frmReservationsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(732, 483);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.rtxbDescription);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTrainings);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpSearchTime);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmReservationsOverview";
            this.Text = "Pregled treninga";
            this.Load += new System.EventHandler(this.frmReservationsOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dtpSearchTime;
        private Button btnSearch;
        private DataGridView dgvTrainings;
        private Label label2;
        private RichTextBox rtxbDescription;
        private ComboBox cmbType;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private TextBox txtClient;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelError;
    }
}