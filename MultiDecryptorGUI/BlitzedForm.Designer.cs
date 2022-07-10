namespace MultiDecryptorGUI
{
    partial class BlitzedForm
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
            this.PathBlitzed = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Decrypt_DragAndDrop = new Guna.UI2.WinForms.Guna2Button();
            this.InputTextBoxBlitzedWebhook = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_BlitzedDecryptText = new Guna.UI2.WinForms.Guna2Button();
            this.key_ = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(84, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(363, 45);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Blitzed Decryption";
            // 
            // PathBlitzed
            // 
            this.PathBlitzed.AllowDrop = true;
            this.PathBlitzed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(119)))));
            this.PathBlitzed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PathBlitzed.DefaultText = "";
            this.PathBlitzed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PathBlitzed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PathBlitzed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathBlitzed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathBlitzed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.PathBlitzed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathBlitzed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PathBlitzed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathBlitzed.Location = new System.Drawing.Point(53, 115);
            this.PathBlitzed.Multiline = true;
            this.PathBlitzed.Name = "PathBlitzed";
            this.PathBlitzed.PasswordChar = '\0';
            this.PathBlitzed.PlaceholderText = "Drag and drop";
            this.PathBlitzed.ReadOnly = true;
            this.PathBlitzed.SelectedText = "";
            this.PathBlitzed.Size = new System.Drawing.Size(478, 62);
            this.PathBlitzed.TabIndex = 7;
            this.PathBlitzed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PathBlitzed.TextChanged += new System.EventHandler(this.PathBlitzed_TextChanged);
            this.PathBlitzed.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathBlitzed_DragDrop);
            this.PathBlitzed.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathBlitzed_DragEnter);
            this.PathBlitzed.DoubleClick += new System.EventHandler(this.PathBlitzed_DoubleClick);
            // 
            // btn_Decrypt_DragAndDrop
            // 
            this.btn_Decrypt_DragAndDrop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Decrypt_DragAndDrop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Decrypt_DragAndDrop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Decrypt_DragAndDrop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Decrypt_DragAndDrop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.btn_Decrypt_DragAndDrop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Decrypt_DragAndDrop.ForeColor = System.Drawing.Color.White;
            this.btn_Decrypt_DragAndDrop.Location = new System.Drawing.Point(219, 183);
            this.btn_Decrypt_DragAndDrop.Name = "btn_Decrypt_DragAndDrop";
            this.btn_Decrypt_DragAndDrop.Size = new System.Drawing.Size(145, 36);
            this.btn_Decrypt_DragAndDrop.TabIndex = 8;
            this.btn_Decrypt_DragAndDrop.Text = "Decrypt";
            this.btn_Decrypt_DragAndDrop.Click += new System.EventHandler(this.btn_Decrypt_DragAndDrop_Click);
            // 
            // InputTextBoxBlitzedWebhook
            // 
            this.InputTextBoxBlitzedWebhook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(119)))));
            this.InputTextBoxBlitzedWebhook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTextBoxBlitzedWebhook.DefaultText = "";
            this.InputTextBoxBlitzedWebhook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputTextBoxBlitzedWebhook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputTextBoxBlitzedWebhook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputTextBoxBlitzedWebhook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputTextBoxBlitzedWebhook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.InputTextBoxBlitzedWebhook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputTextBoxBlitzedWebhook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputTextBoxBlitzedWebhook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.InputTextBoxBlitzedWebhook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputTextBoxBlitzedWebhook.Location = new System.Drawing.Point(53, 287);
            this.InputTextBoxBlitzedWebhook.Multiline = true;
            this.InputTextBoxBlitzedWebhook.Name = "InputTextBoxBlitzedWebhook";
            this.InputTextBoxBlitzedWebhook.PasswordChar = '\0';
            this.InputTextBoxBlitzedWebhook.PlaceholderText = "Enter Encrypted Webhook";
            this.InputTextBoxBlitzedWebhook.SelectedText = "";
            this.InputTextBoxBlitzedWebhook.Size = new System.Drawing.Size(216, 62);
            this.InputTextBoxBlitzedWebhook.TabIndex = 9;
            this.InputTextBoxBlitzedWebhook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_BlitzedDecryptText
            // 
            this.btn_BlitzedDecryptText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_BlitzedDecryptText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_BlitzedDecryptText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_BlitzedDecryptText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_BlitzedDecryptText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.btn_BlitzedDecryptText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_BlitzedDecryptText.ForeColor = System.Drawing.Color.White;
            this.btn_BlitzedDecryptText.Location = new System.Drawing.Point(219, 355);
            this.btn_BlitzedDecryptText.Name = "btn_BlitzedDecryptText";
            this.btn_BlitzedDecryptText.Size = new System.Drawing.Size(145, 36);
            this.btn_BlitzedDecryptText.TabIndex = 10;
            this.btn_BlitzedDecryptText.Text = "Decrypt";
            this.btn_BlitzedDecryptText.Click += new System.EventHandler(this.btn_BlitzedDecryptText_Click);
            // 
            // key_
            // 
            this.key_.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(119)))));
            this.key_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.key_.DefaultText = "";
            this.key_.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.key_.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.key_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key_.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key_.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.key_.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.key_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.key_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.key_.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.key_.Location = new System.Drawing.Point(315, 287);
            this.key_.Multiline = true;
            this.key_.Name = "key_";
            this.key_.PasswordChar = '\0';
            this.key_.PlaceholderText = "Enter Key";
            this.key_.SelectedText = "";
            this.key_.Size = new System.Drawing.Size(216, 62);
            this.key_.TabIndex = 11;
            this.key_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlitzedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.key_);
            this.Controls.Add(this.btn_BlitzedDecryptText);
            this.Controls.Add(this.InputTextBoxBlitzedWebhook);
            this.Controls.Add(this.btn_Decrypt_DragAndDrop);
            this.Controls.Add(this.PathBlitzed);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BlitzedForm";
            this.Text = "BlitzedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox PathBlitzed;
        private Guna.UI2.WinForms.Guna2Button btn_Decrypt_DragAndDrop;
        private Guna.UI2.WinForms.Guna2TextBox InputTextBoxBlitzedWebhook;
        private Guna.UI2.WinForms.Guna2Button btn_BlitzedDecryptText;
        private Guna.UI2.WinForms.Guna2TextBox key_;
    }
}