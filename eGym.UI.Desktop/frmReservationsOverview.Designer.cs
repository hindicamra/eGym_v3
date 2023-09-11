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
            label1 = new Label();
            dtpSearchTime = new DateTimePicker();
            btnSearch = new Button();
            dgvTrainings = new DataGridView();
            label2 = new Label();
            rtxbDescription = new RichTextBox();
            cmbType = new ComboBox();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            txtClient = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTrainings).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Datum";
            // 
            // dtpSearchTime
            // 
            dtpSearchTime.Location = new Point(61, 26);
            dtpSearchTime.Margin = new Padding(3, 2, 3, 2);
            dtpSearchTime.Name = "dtpSearchTime";
            dtpSearchTime.Size = new Size(219, 23);
            dtpSearchTime.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(286, 26);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Pretrazi";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvTrainings
            // 
            dgvTrainings.AllowUserToAddRows = false;
            dgvTrainings.AllowUserToDeleteRows = false;
            dgvTrainings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrainings.Location = new Point(12, 53);
            dgvTrainings.Margin = new Padding(3, 2, 3, 2);
            dgvTrainings.Name = "dgvTrainings";
            dgvTrainings.ReadOnly = true;
            dgvTrainings.RowHeadersWidth = 51;
            dgvTrainings.RowTemplate.Height = 29;
            dgvTrainings.Size = new Size(708, 213);
            dgvTrainings.TabIndex = 3;
            dgvTrainings.CellClick += dgvTrainings_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 4;
            label2.Text = "Prikaza dnevnog rasporeda";
            // 
            // rtxbDescription
            // 
            rtxbDescription.Location = new Point(130, 351);
            rtxbDescription.Margin = new Padding(3, 2, 3, 2);
            rtxbDescription.Name = "rtxbDescription";
            rtxbDescription.ReadOnly = true;
            rtxbDescription.Size = new Size(500, 84);
            rtxbDescription.TabIndex = 27;
            rtxbDescription.Text = "";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Tezinski", "Funkcionali", "Aerobik", "Kardio" });
            cmbType.Location = new Point(130, 324);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(233, 23);
            cmbType.TabIndex = 26;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(397, 297);
            dtpTo.Margin = new Padding(3, 2, 3, 2);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(233, 23);
            dtpTo.TabIndex = 25;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(130, 297);
            dtpFrom.Margin = new Padding(3, 2, 3, 2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(233, 23);
            dtpFrom.TabIndex = 24;
            // 
            // txtClient
            // 
            txtClient.Location = new Point(130, 270);
            txtClient.Margin = new Padding(3, 2, 3, 2);
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.Size = new Size(233, 23);
            txtClient.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 354);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 22;
            label7.Text = "Opis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 327);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 21;
            label6.Text = "Vrsta treninga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 303);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 20;
            label5.Text = "Do";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 303);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 19;
            label4.Text = "Od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 272);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 18;
            label3.Text = "Klijent";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(12, 459);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 28;
            // 
            // frmReservationsOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(732, 483);
            Controls.Add(labelError);
            Controls.Add(rtxbDescription);
            Controls.Add(cmbType);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(txtClient);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvTrainings);
            Controls.Add(btnSearch);
            Controls.Add(dtpSearchTime);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmReservationsOverview";
            Text = "Pregled treninga";
            Load += frmReservationsOverview_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrainings).EndInit();
            ResumeLayout(false);
            PerformLayout();
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