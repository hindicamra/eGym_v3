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
            label1 = new Label();
            label2 = new Label();
            dgvReservations = new DataGridView();
            btnSearch = new Button();
            dtpDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtClient = new TextBox();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            cmbType = new ComboBox();
            rtxbDescription = new RichTextBox();
            btnDecline = new Button();
            btnAccept = new Button();
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Datum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 334);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Klijent";
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(12, 31);
            dgvReservations.Margin = new Padding(3, 2, 3, 2);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.RowTemplate.Height = 29;
            dgvReservations.Size = new Size(825, 296);
            dgvReservations.TabIndex = 3;
            dgvReservations.CellClick += dgvReservations_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(353, 3);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 24);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Pretrazi";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(61, 3);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(286, 23);
            dtpDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 368);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 7;
            label4.Text = "Od";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 368);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 8;
            label5.Text = "Do";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 403);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 9;
            label6.Text = "Vrsta treninga";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 429);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 10;
            label7.Text = "Opis";
            // 
            // txtClient
            // 
            txtClient.Location = new Point(98, 331);
            txtClient.Margin = new Padding(3, 2, 3, 2);
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.Size = new Size(233, 23);
            txtClient.TabIndex = 11;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(98, 362);
            dtpFrom.Margin = new Padding(3, 2, 3, 2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(233, 23);
            dtpFrom.TabIndex = 12;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(365, 362);
            dtpTo.Margin = new Padding(3, 2, 3, 2);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(233, 23);
            dtpTo.TabIndex = 13;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Tezinski", "Funkcionali", "Aerobik", "Kardio" });
            cmbType.Location = new Point(98, 400);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(233, 23);
            cmbType.TabIndex = 14;
            // 
            // rtxbDescription
            // 
            rtxbDescription.Location = new Point(98, 427);
            rtxbDescription.Margin = new Padding(3, 2, 3, 2);
            rtxbDescription.Name = "rtxbDescription";
            rtxbDescription.ReadOnly = true;
            rtxbDescription.Size = new Size(233, 145);
            rtxbDescription.TabIndex = 15;
            rtxbDescription.Text = "";
            // 
            // btnDecline
            // 
            btnDecline.Location = new Point(412, 605);
            btnDecline.Margin = new Padding(3, 2, 3, 2);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(91, 28);
            btnDecline.TabIndex = 16;
            btnDecline.Text = "Odbij";
            btnDecline.UseVisualStyleBackColor = true;
            btnDecline.Click += btnDecline_Click;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(509, 605);
            btnAccept.Margin = new Padding(3, 2, 3, 2);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(89, 28);
            btnAccept.TabIndex = 17;
            btnAccept.Text = "Prihvati";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(12, 642);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 18;
            // 
            // frmReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(849, 666);
            Controls.Add(labelError);
            Controls.Add(btnAccept);
            Controls.Add(btnDecline);
            Controls.Add(rtxbDescription);
            Controls.Add(cmbType);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(txtClient);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpDate);
            Controls.Add(btnSearch);
            Controls.Add(dgvReservations);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmReservation";
            Text = "Rezervacije";
            Load += frmReservation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
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