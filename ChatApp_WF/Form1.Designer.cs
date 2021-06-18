
namespace ChatApp_WF
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
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.lb_msg = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(638, 75);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(179, 75);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(358, 24);
            this.txt_name.TabIndex = 1;
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(179, 151);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(358, 24);
            this.txt_msg.TabIndex = 2;
            // 
            // lb_msg
            // 
            this.lb_msg.FormattingEnabled = true;
            this.lb_msg.ItemHeight = 16;
            this.lb_msg.Location = new System.Drawing.Point(179, 211);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(358, 180);
            this.lb_msg.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "message";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.ListBox lb_msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

