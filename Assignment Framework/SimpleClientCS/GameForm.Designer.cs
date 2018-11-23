namespace SimpleClientCS
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.NickName = new System.Windows.Forms.TextBox();
            this.CursorImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameChat = new System.Windows.Forms.RichTextBox();
            this.UserChatInput = new System.Windows.Forms.TextBox();
            this.FocusOnMe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CursorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(13, 31);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(185, 20);
            this.NickName.TabIndex = 0;
            this.NickName.Text = "Enter Nickname";
            this.NickName.Enter += new System.EventHandler(this.NickName_Enter);
            // 
            // CursorImage
            // 
            this.CursorImage.BackColor = System.Drawing.Color.Transparent;
            this.CursorImage.Image = ((System.Drawing.Image)(resources.GetObject("CursorImage.Image")));
            this.CursorImage.ImageLocation = "";
            this.CursorImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("CursorImage.InitialImage")));
            this.CursorImage.Location = new System.Drawing.Point(861, 2);
            this.CursorImage.Name = "CursorImage";
            this.CursorImage.Size = new System.Drawing.Size(25, 24);
            this.CursorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CursorImage.TabIndex = 7;
            this.CursorImage.TabStop = false;
            this.CursorImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CursorImage_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(556, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 248);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(556, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 10);
            this.label2.TabIndex = 10;
            // 
            // GameChat
            // 
            this.GameChat.Location = new System.Drawing.Point(12, 57);
            this.GameChat.Name = "GameChat";
            this.GameChat.Size = new System.Drawing.Size(186, 291);
            this.GameChat.TabIndex = 11;
            this.GameChat.Text = "";
            // 
            // UserChatInput
            // 
            this.UserChatInput.Location = new System.Drawing.Point(13, 354);
            this.UserChatInput.Name = "UserChatInput";
            this.UserChatInput.Size = new System.Drawing.Size(185, 20);
            this.UserChatInput.TabIndex = 12;
            // 
            // FocusOnMe
            // 
            this.FocusOnMe.AutoSize = true;
            this.FocusOnMe.Location = new System.Drawing.Point(12, 9);
            this.FocusOnMe.Name = "FocusOnMe";
            this.FocusOnMe.Size = new System.Drawing.Size(78, 13);
            this.FocusOnMe.TabIndex = 13;
            this.FocusOnMe.Text = "No, Don\'t Do It";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.FocusOnMe);
            this.Controls.Add(this.UserChatInput);
            this.Controls.Add(this.GameChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CursorImage);
            this.Controls.Add(this.NickName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.CursorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.PictureBox CursorImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox GameChat;
        private System.Windows.Forms.TextBox UserChatInput;
        private System.Windows.Forms.Label FocusOnMe;
    }
}