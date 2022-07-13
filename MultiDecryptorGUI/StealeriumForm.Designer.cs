namespace MultiDecryptorGUI
{
    partial class StealeriumForm
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PathStealerium = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Decrypt_draganddrop = new Guna.UI2.WinForms.Guna2Button();
            this.InputTextBoxStealeriumWebhook = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_troublveDecryptText = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(84, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(423, 45);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Stealerium Decryption";
            // 
            // PathStealerium
            // 
            this.PathStealerium.AllowDrop = true;
            this.PathStealerium.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(119)))));
            this.PathStealerium.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PathStealerium.DefaultText = "";
            this.PathStealerium.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PathStealerium.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PathStealerium.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathStealerium.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathStealerium.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.PathStealerium.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathStealerium.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PathStealerium.ForeColor = System.Drawing.Color.White;
            this.PathStealerium.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathStealerium.Location = new System.Drawing.Point(53, 115);
            this.PathStealerium.Multiline = true;
            this.PathStealerium.Name = "PathStealerium";
            this.PathStealerium.PasswordChar = '\0';
            this.PathStealerium.PlaceholderText = "Drag and drop";
            this.PathStealerium.ReadOnly = true;
            this.PathStealerium.SelectedText = "";
            this.PathStealerium.Size = new System.Drawing.Size(478, 62);
            this.PathStealerium.TabIndex = 6;
            this.PathStealerium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PathStealerium.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathStealerium_DragDrop);
            this.PathStealerium.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathStealerium_DragEnter);
            this.PathStealerium.DoubleClick += new System.EventHandler(this.PathStealerium_DoubleClick);
            // 
            // btn_Decrypt_draganddrop
            // 
            this.btn_Decrypt_draganddrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_Decrypt_draganddrop.BorderColor = System.Drawing.Color.White;
            this.btn_Decrypt_draganddrop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Decrypt_draganddrop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Decrypt_draganddrop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Decrypt_draganddrop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Decrypt_draganddrop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.btn_Decrypt_draganddrop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Decrypt_draganddrop.ForeColor = System.Drawing.Color.White;
            this.btn_Decrypt_draganddrop.Location = new System.Drawing.Point(219, 183);
            this.btn_Decrypt_draganddrop.Name = "btn_Decrypt_draganddrop";
            this.btn_Decrypt_draganddrop.Size = new System.Drawing.Size(145, 36);
            this.btn_Decrypt_draganddrop.TabIndex = 7;
            this.btn_Decrypt_draganddrop.Text = "Decrypt";
            this.btn_Decrypt_draganddrop.Click += new System.EventHandler(this.btn_Decrypt_draganddrop_Click);
            // 
            // InputTextBoxStealeriumWebhook
            // 
            this.InputTextBoxStealeriumWebhook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(119)))));
            this.InputTextBoxStealeriumWebhook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTextBoxStealeriumWebhook.DefaultText = "";
            this.InputTextBoxStealeriumWebhook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputTextBoxStealeriumWebhook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputTextBoxStealeriumWebhook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputTextBoxStealeriumWebhook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputTextBoxStealeriumWebhook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.InputTextBoxStealeriumWebhook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputTextBoxStealeriumWebhook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputTextBoxStealeriumWebhook.ForeColor = System.Drawing.Color.White;
            this.InputTextBoxStealeriumWebhook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputTextBoxStealeriumWebhook.Location = new System.Drawing.Point(53, 287);
            this.InputTextBoxStealeriumWebhook.Multiline = true;
            this.InputTextBoxStealeriumWebhook.Name = "InputTextBoxStealeriumWebhook";
            this.InputTextBoxStealeriumWebhook.PasswordChar = '\0';
            this.InputTextBoxStealeriumWebhook.PlaceholderText = "Enter Encrypted Webhook";
            this.InputTextBoxStealeriumWebhook.SelectedText = "";
            this.InputTextBoxStealeriumWebhook.Size = new System.Drawing.Size(478, 62);
            this.InputTextBoxStealeriumWebhook.TabIndex = 8;
            this.InputTextBoxStealeriumWebhook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_troublveDecryptText
            // 
            this.btn_troublveDecryptText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_troublveDecryptText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_troublveDecryptText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_troublveDecryptText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_troublveDecryptText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.btn_troublveDecryptText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_troublveDecryptText.ForeColor = System.Drawing.Color.White;
            this.btn_troublveDecryptText.Location = new System.Drawing.Point(219, 355);
            this.btn_troublveDecryptText.Name = "btn_troublveDecryptText";
            this.btn_troublveDecryptText.Size = new System.Drawing.Size(145, 36);
            this.btn_troublveDecryptText.TabIndex = 9;
            this.btn_troublveDecryptText.Text = "Decrypt";
            this.btn_troublveDecryptText.Click += new System.EventHandler(this.btn_troublveDecryptText_Click);
            // 
            // StealeriumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_troublveDecryptText);
            this.Controls.Add(this.InputTextBoxStealeriumWebhook);
            this.Controls.Add(this.btn_Decrypt_draganddrop);
            this.Controls.Add(this.PathStealerium);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StealeriumForm";
            this.Text = "StealeriumForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox PathStealerium;
        private Guna.UI2.WinForms.Guna2Button btn_Decrypt_draganddrop;
        private Guna.UI2.WinForms.Guna2TextBox InputTextBoxStealeriumWebhook;
        private Guna.UI2.WinForms.Guna2Button btn_troublveDecryptText;
    }
}