
namespace Emailaddress
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textemail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textsubject = new System.Windows.Forms.TextBox();
            this.textmessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textemail
            // 
            this.textemail.BackColor = System.Drawing.Color.DarkViolet;
            this.textemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textemail.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemail.ForeColor = System.Drawing.Color.White;
            this.textemail.Location = new System.Drawing.Point(93, 163);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(215, 27);
            this.textemail.TabIndex = 1;
            this.textemail.Text = "Email";
            this.textemail.Enter += new System.EventHandler(this.textemail_enter);
            this.textemail.Leave += new System.EventHandler(this.textemail_leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(93, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textsubject
            // 
            this.textsubject.BackColor = System.Drawing.Color.DarkViolet;
            this.textsubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textsubject.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsubject.ForeColor = System.Drawing.Color.White;
            this.textsubject.Location = new System.Drawing.Point(93, 208);
            this.textsubject.Multiline = true;
            this.textsubject.Name = "textsubject";
            this.textsubject.Size = new System.Drawing.Size(215, 27);
            this.textsubject.TabIndex = 2;
            this.textsubject.Text = "Subject";
            this.textsubject.Enter += new System.EventHandler(this.textsubject_enter);
            this.textsubject.Leave += new System.EventHandler(this.textsubject_leave);
            // 
            // textmessage
            // 
            this.textmessage.BackColor = System.Drawing.Color.DarkViolet;
            this.textmessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textmessage.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmessage.ForeColor = System.Drawing.Color.White;
            this.textmessage.Location = new System.Drawing.Point(93, 254);
            this.textmessage.Multiline = true;
            this.textmessage.Name = "textmessage";
            this.textmessage.Size = new System.Drawing.Size(215, 126);
            this.textmessage.TabIndex = 3;
            this.textmessage.Text = "Message";
            this.textmessage.Enter += new System.EventHandler(this.textmessage_enter);
            this.textmessage.Leave += new System.EventHandler(this.textmessage_leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textmessage);
            this.Controls.Add(this.textsubject);
            this.Controls.Add(this.textemail);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textsubject;
        private System.Windows.Forms.TextBox textmessage;
    }
}

