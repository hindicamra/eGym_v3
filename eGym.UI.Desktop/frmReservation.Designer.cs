namespace eGym.UI.Desktop
{
    partial class frmReservation
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.rtxbDescription = new System.Windows.Forms.RichTextBox();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klijent";
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(12, 31);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 29;
            this.dgvReservations.Size = new System.Drawing.Size(825, 296);
            this.dgvReservations.TabIndex = 3;
            this.dgvReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(353, 3);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pretrazi";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(61, 3);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(286, 23);
            this.dtpDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vrsta treninga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Opis";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(98, 331);
            this.txtClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(233, 23);
            this.txtClient.TabIndex = 11;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(98, 362);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(233, 23);
            this.dtpFrom.TabIndex = 12;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(365, 362);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(233, 23);
            this.dtpTo.TabIndex = 13;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Tezinski",
            "Funkcionali",
            "Aerobik",
            "Kardio"});
            this.cmbType.Location = new System.Drawing.Point(98, 400);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(233, 23);
            this.cmbType.TabIndex = 14;
            // 
            // rtxbDescription
            // 
            this.rtxbDescription.Location = new System.Drawing.Point(98, 427);
            this.rtxbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxbDescription.Name = "rtxbDescription";
            this.rtxbDescription.ReadOnly = true;
            this.rtxbDescription.Size = new System.Drawing.Size(233, 145);
            this.rtxbDescription.TabIndex = 15;
            this.rtxbDescription.Text = "";
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(412, 605);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(91, 28);
            this.btnDecline.TabIndex = 16;
            this.btnDecline.Text = "Odbij";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(509, 605);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(89, 28);
            this.btnAccept.TabIndex = 17;
            this.btnAccept.Text = "Prihvati";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 642);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 18;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(849, 666);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.rtxbDescription);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmReservation";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvReservations;
        private Button btnSearch;
        private DateTimePicker dtpDate;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtClient;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private ComboBox cmbType;
        private RichTextBox rtxbDescription;
        private Button btnDecline;
        private Button btnAccept;
        private Label labelError;
    }
}