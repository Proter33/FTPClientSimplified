namespace FTPClientSimplified {
    partial class Form1 {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DownloadLocation = new System.Windows.Forms.TextBox();
            this.button_ChangeDownloadLocation = new System.Windows.Forms.Button();
            this.button_Download = new System.Windows.Forms.Button();
            this.progressBar_Download = new System.Windows.Forms.ProgressBar();
            this.dataGridView_FileList = new System.Windows.Forms.DataGridView();
            this.label_connected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FileList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_IP
            // 
            this.textBox_IP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_IP.Location = new System.Drawing.Point(12, 13);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(164, 20);
            this.textBox_IP.TabIndex = 1;
            this.textBox_IP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_IP_KeyDown);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(182, 11);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 2;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Download Location:";
            // 
            // textBox_DownloadLocation
            // 
            this.textBox_DownloadLocation.Location = new System.Drawing.Point(12, 419);
            this.textBox_DownloadLocation.Name = "textBox_DownloadLocation";
            this.textBox_DownloadLocation.Size = new System.Drawing.Size(280, 20);
            this.textBox_DownloadLocation.TabIndex = 5;
            this.textBox_DownloadLocation.Text = "C:/";
            // 
            // button_ChangeDownloadLocation
            // 
            this.button_ChangeDownloadLocation.Location = new System.Drawing.Point(298, 417);
            this.button_ChangeDownloadLocation.Name = "button_ChangeDownloadLocation";
            this.button_ChangeDownloadLocation.Size = new System.Drawing.Size(75, 23);
            this.button_ChangeDownloadLocation.TabIndex = 6;
            this.button_ChangeDownloadLocation.Text = "Change";
            this.button_ChangeDownloadLocation.UseVisualStyleBackColor = true;
            this.button_ChangeDownloadLocation.Click += new System.EventHandler(this.button_ChangeDownloadLocation_Click);
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(15, 446);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(99, 43);
            this.button_Download.TabIndex = 8;
            this.button_Download.Text = "Download";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // progressBar_Download
            // 
            this.progressBar_Download.Location = new System.Drawing.Point(121, 446);
            this.progressBar_Download.Name = "progressBar_Download";
            this.progressBar_Download.Size = new System.Drawing.Size(265, 23);
            this.progressBar_Download.TabIndex = 9;
            // 
            // dataGridView_FileList
            // 
            this.dataGridView_FileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_FileList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView_FileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FileList.Location = new System.Drawing.Point(12, 40);
            this.dataGridView_FileList.MultiSelect = false;
            this.dataGridView_FileList.Name = "dataGridView_FileList";
            this.dataGridView_FileList.ReadOnly = true;
            this.dataGridView_FileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_FileList.Size = new System.Drawing.Size(374, 359);
            this.dataGridView_FileList.TabIndex = 0;
            // 
            // label_connected
            // 
            this.label_connected.AutoSize = true;
            this.label_connected.ForeColor = System.Drawing.Color.Red;
            this.label_connected.Location = new System.Drawing.Point(263, 16);
            this.label_connected.Name = "label_connected";
            this.label_connected.Size = new System.Drawing.Size(79, 13);
            this.label_connected.TabIndex = 10;
            this.label_connected.Text = "Not Connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 522);
            this.Controls.Add(this.label_connected);
            this.Controls.Add(this.dataGridView_FileList);
            this.Controls.Add(this.progressBar_Download);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.button_ChangeDownloadLocation);
            this.Controls.Add(this.textBox_DownloadLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox_IP);
            this.Name = "Form1";
            this.Text = "FTP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FileList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DownloadLocation;
        private System.Windows.Forms.Button button_ChangeDownloadLocation;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.ProgressBar progressBar_Download;
        private System.Windows.Forms.DataGridView dataGridView_FileList;
        private System.Windows.Forms.Label label_connected;
    }
}

