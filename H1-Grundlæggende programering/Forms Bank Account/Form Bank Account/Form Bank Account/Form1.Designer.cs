namespace Form_Bank_Account
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
            this.labelTxt = new System.Windows.Forms.Label();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.balanceBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTxt
            // 
            this.labelTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTxt.Location = new System.Drawing.Point(32, 32);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(228, 62);
            this.labelTxt.TabIndex = 0;
            this.labelTxt.Text = "Balance :";
            this.labelTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTxt.Click += new System.EventHandler(this.labelTxt_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.FlatAppearance.BorderSize = 2;
            this.withdrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdrawBtn.Location = new System.Drawing.Point(13, 123);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(75, 23);
            this.withdrawBtn.TabIndex = 1;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // balanceBtn
            // 
            this.balanceBtn.FlatAppearance.BorderSize = 2;
            this.balanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.balanceBtn.Location = new System.Drawing.Point(94, 123);
            this.balanceBtn.Name = "balanceBtn";
            this.balanceBtn.Size = new System.Drawing.Size(106, 23);
            this.balanceBtn.TabIndex = 2;
            this.balanceBtn.Text = "Show Balance";
            this.balanceBtn.UseVisualStyleBackColor = true;
            this.balanceBtn.Click += new System.EventHandler(this.balanceBtn_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.FlatAppearance.BorderSize = 2;
            this.depositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depositBtn.Location = new System.Drawing.Point(206, 123);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(75, 23);
            this.depositBtn.TabIndex = 3;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 2;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Location = new System.Drawing.Point(106, 152);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // InputText
            // 
            this.InputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputText.Location = new System.Drawing.Point(94, 95);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(106, 22);
            this.InputText.TabIndex = 5;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(298, 209);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.balanceBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.labelTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button balanceBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox InputText;
    }
}

