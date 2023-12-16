namespace Crypty
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pAssemblyInfo = new System.Windows.Forms.Panel();
            this.btnShowMore = new System.Windows.Forms.Button();
            this.tbSha = new System.Windows.Forms.TextBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbBase64Key = new System.Windows.Forms.RadioButton();
            this.rbPassword = new System.Windows.Forms.RadioButton();
            this.pBase64Key = new System.Windows.Forms.Panel();
            this.btnGenerateBase64Key = new System.Windows.Forms.Button();
            this.tbBase64IV = new System.Windows.Forms.TextBox();
            this.lblBase64IV = new System.Windows.Forms.Label();
            this.tbBase64Key = new System.Windows.Forms.TextBox();
            this.lblBase64Key = new System.Windows.Forms.Label();
            this.pPassword = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnEncryptAs = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnDecryptAs = new System.Windows.Forms.Button();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.pAssemblyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pBase64Key.SuspendLayout();
            this.pPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pAssemblyInfo
            // 
            this.pAssemblyInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAssemblyInfo.Controls.Add(this.lblFileCount);
            this.pAssemblyInfo.Controls.Add(this.btnShowMore);
            this.pAssemblyInfo.Controls.Add(this.tbSha);
            this.pAssemblyInfo.Controls.Add(this.bSelect);
            this.pAssemblyInfo.Controls.Add(this.tbSize);
            this.pAssemblyInfo.Controls.Add(this.pbIcon);
            this.pAssemblyInfo.Controls.Add(this.tbPath);
            this.pAssemblyInfo.Location = new System.Drawing.Point(16, 18);
            this.pAssemblyInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pAssemblyInfo.Name = "pAssemblyInfo";
            this.pAssemblyInfo.Size = new System.Drawing.Size(571, 128);
            this.pAssemblyInfo.TabIndex = 1;
            // 
            // btnShowMore
            // 
            this.btnShowMore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowMore.ForeColor = System.Drawing.Color.Black;
            this.btnShowMore.Location = new System.Drawing.Point(491, 94);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(75, 25);
            this.btnShowMore.TabIndex = 4;
            this.btnShowMore.Text = "Show More";
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Visible = false;
            this.btnShowMore.Click += new System.EventHandler(this.btnShowMore_Click);
            // 
            // tbSha
            // 
            this.tbSha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbSha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSha.ForeColor = System.Drawing.Color.White;
            this.tbSha.Location = new System.Drawing.Point(134, 68);
            this.tbSha.Name = "tbSha";
            this.tbSha.ReadOnly = true;
            this.tbSha.Size = new System.Drawing.Size(432, 20);
            this.tbSha.TabIndex = 4;
            // 
            // bSelect
            // 
            this.bSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bSelect.ForeColor = System.Drawing.Color.Black;
            this.bSelect.Location = new System.Drawing.Point(534, 4);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(32, 20);
            this.bSelect.TabIndex = 3;
            this.bSelect.Text = "...";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // tbSize
            // 
            this.tbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSize.ForeColor = System.Drawing.Color.White;
            this.tbSize.Location = new System.Drawing.Point(134, 35);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(214, 20);
            this.tbSize.TabIndex = 2;
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(128, 128);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPath.ForeColor = System.Drawing.Color.White;
            this.tbPath.Location = new System.Drawing.Point(134, 3);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(394, 20);
            this.tbPath.TabIndex = 0;
            this.tbPath.Text = "Select a file";
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAlgorithm.ForeColor = System.Drawing.Color.White;
            this.cbAlgorithm.FormattingEnabled = true;
            this.cbAlgorithm.Location = new System.Drawing.Point(101, 153);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(155, 28);
            this.cbAlgorithm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Algorithm: ";
            // 
            // rbBase64Key
            // 
            this.rbBase64Key.AutoSize = true;
            this.rbBase64Key.Location = new System.Drawing.Point(17, 198);
            this.rbBase64Key.Name = "rbBase64Key";
            this.rbBase64Key.Size = new System.Drawing.Size(98, 24);
            this.rbBase64Key.TabIndex = 4;
            this.rbBase64Key.Text = "Base64Key";
            this.rbBase64Key.UseVisualStyleBackColor = true;
            this.rbBase64Key.CheckedChanged += new System.EventHandler(this.rbBase64Key_CheckedChanged);
            // 
            // rbPassword
            // 
            this.rbPassword.AutoSize = true;
            this.rbPassword.Checked = true;
            this.rbPassword.Location = new System.Drawing.Point(17, 228);
            this.rbPassword.Name = "rbPassword";
            this.rbPassword.Size = new System.Drawing.Size(131, 24);
            this.rbPassword.TabIndex = 6;
            this.rbPassword.TabStop = true;
            this.rbPassword.Text = "Password(Hash)";
            this.rbPassword.UseVisualStyleBackColor = true;
            this.rbPassword.CheckedChanged += new System.EventHandler(this.rbPassword_CheckedChanged);
            // 
            // pBase64Key
            // 
            this.pBase64Key.Controls.Add(this.btnGenerateBase64Key);
            this.pBase64Key.Controls.Add(this.tbBase64IV);
            this.pBase64Key.Controls.Add(this.lblBase64IV);
            this.pBase64Key.Controls.Add(this.tbBase64Key);
            this.pBase64Key.Controls.Add(this.lblBase64Key);
            this.pBase64Key.Location = new System.Drawing.Point(17, 258);
            this.pBase64Key.Name = "pBase64Key";
            this.pBase64Key.Size = new System.Drawing.Size(325, 110);
            this.pBase64Key.TabIndex = 7;
            this.pBase64Key.Visible = false;
            // 
            // btnGenerateBase64Key
            // 
            this.btnGenerateBase64Key.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateBase64Key.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateBase64Key.Location = new System.Drawing.Point(237, 78);
            this.btnGenerateBase64Key.Name = "btnGenerateBase64Key";
            this.btnGenerateBase64Key.Size = new System.Drawing.Size(75, 25);
            this.btnGenerateBase64Key.TabIndex = 8;
            this.btnGenerateBase64Key.Text = "Generate";
            this.btnGenerateBase64Key.UseVisualStyleBackColor = true;
            this.btnGenerateBase64Key.Click += new System.EventHandler(this.btnGenerateBase64Key_Click);
            // 
            // tbBase64IV
            // 
            this.tbBase64IV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBase64IV.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBase64IV.Location = new System.Drawing.Point(56, 50);
            this.tbBase64IV.Name = "tbBase64IV";
            this.tbBase64IV.Size = new System.Drawing.Size(256, 22);
            this.tbBase64IV.TabIndex = 7;
            // 
            // lblBase64IV
            // 
            this.lblBase64IV.AutoSize = true;
            this.lblBase64IV.Location = new System.Drawing.Point(16, 50);
            this.lblBase64IV.Name = "lblBase64IV";
            this.lblBase64IV.Size = new System.Drawing.Size(29, 20);
            this.lblBase64IV.TabIndex = 6;
            this.lblBase64IV.Text = "IV: ";
            // 
            // tbBase64Key
            // 
            this.tbBase64Key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBase64Key.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBase64Key.Location = new System.Drawing.Point(56, 10);
            this.tbBase64Key.Name = "tbBase64Key";
            this.tbBase64Key.Size = new System.Drawing.Size(256, 22);
            this.tbBase64Key.TabIndex = 5;
            // 
            // lblBase64Key
            // 
            this.lblBase64Key.AutoSize = true;
            this.lblBase64Key.Location = new System.Drawing.Point(5, 10);
            this.lblBase64Key.Name = "lblBase64Key";
            this.lblBase64Key.Size = new System.Drawing.Size(40, 20);
            this.lblBase64Key.TabIndex = 4;
            this.lblBase64Key.Text = "Key: ";
            // 
            // pPassword
            // 
            this.pPassword.Controls.Add(this.tbPassword);
            this.pPassword.Controls.Add(this.lblPassword);
            this.pPassword.Location = new System.Drawing.Point(17, 258);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(325, 110);
            this.pPassword.TabIndex = 8;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPassword.Location = new System.Drawing.Point(88, 7);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(232, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(5, 10);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password: ";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.Black;
            this.btnEncrypt.Location = new System.Drawing.Point(486, 343);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(102, 25);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Visible = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnEncryptAs
            // 
            this.btnEncryptAs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEncryptAs.ForeColor = System.Drawing.Color.Black;
            this.btnEncryptAs.Location = new System.Drawing.Point(378, 343);
            this.btnEncryptAs.Name = "btnEncryptAs";
            this.btnEncryptAs.Size = new System.Drawing.Size(102, 25);
            this.btnEncryptAs.TabIndex = 10;
            this.btnEncryptAs.Text = "Encrypt As";
            this.btnEncryptAs.UseVisualStyleBackColor = true;
            this.btnEncryptAs.Visible = false;
            this.btnEncryptAs.Click += new System.EventHandler(this.btnEncryptAs_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnDecrypt.Location = new System.Drawing.Point(486, 312);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(102, 25);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Visible = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnDecryptAs
            // 
            this.btnDecryptAs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecryptAs.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptAs.Location = new System.Drawing.Point(378, 312);
            this.btnDecryptAs.Name = "btnDecryptAs";
            this.btnDecryptAs.Size = new System.Drawing.Size(102, 25);
            this.btnDecryptAs.TabIndex = 12;
            this.btnDecryptAs.Text = "Decrypt As";
            this.btnDecryptAs.UseVisualStyleBackColor = true;
            this.btnDecryptAs.Visible = false;
            this.btnDecryptAs.Click += new System.EventHandler(this.btnDecryptAs_Click);
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFileCount.ForeColor = System.Drawing.Color.Gray;
            this.lblFileCount.Location = new System.Drawing.Point(134, 104);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(39, 15);
            this.lblFileCount.TabIndex = 5;
            this.lblFileCount.Text = "0 Files";
            this.lblFileCount.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(600, 378);
            this.Controls.Add(this.btnDecryptAs);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncryptAs);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.rbPassword);
            this.Controls.Add(this.rbBase64Key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAlgorithm);
            this.Controls.Add(this.pAssemblyInfo);
            this.Controls.Add(this.pBase64Key);
            this.Controls.Add(this.pPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypty";
            this.pAssemblyInfo.ResumeLayout(false);
            this.pAssemblyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pBase64Key.ResumeLayout(false);
            this.pBase64Key.PerformLayout();
            this.pPassword.ResumeLayout(false);
            this.pPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pAssemblyInfo;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private System.Windows.Forms.TextBox tbSha;
        private System.Windows.Forms.Button btnShowMore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBase64Key;
        private System.Windows.Forms.RadioButton rbPassword;
        private System.Windows.Forms.Panel pBase64Key;
        private System.Windows.Forms.TextBox tbBase64IV;
        private System.Windows.Forms.Label lblBase64IV;
        private System.Windows.Forms.TextBox tbBase64Key;
        private System.Windows.Forms.Label lblBase64Key;
        private System.Windows.Forms.Button btnGenerateBase64Key;
        private System.Windows.Forms.Panel pPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnEncryptAs;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnDecryptAs;
        private System.Windows.Forms.Label lblFileCount;
    }
}

