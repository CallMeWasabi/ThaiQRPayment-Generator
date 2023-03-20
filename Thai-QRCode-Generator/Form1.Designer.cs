namespace AutoGeneratePromptPay
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
            this.button_generate = new System.Windows.Forms.Button();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_isStatic = new System.Windows.Forms.CheckBox();
            this.checkBox_rcManage = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(177, 110);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(75, 23);
            this.button_generate.TabIndex = 1;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(100, 43);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(152, 20);
            this.textBox_phoneNumber.TabIndex = 2;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(100, 78);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(152, 20);
            this.textBox_amount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thai QR Payment Generator";
            // 
            // checkbox_isStatic
            // 
            this.checkbox_isStatic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkbox_isStatic.AutoSize = true;
            this.checkbox_isStatic.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkbox_isStatic.Location = new System.Drawing.Point(76, 110);
            this.checkbox_isStatic.Name = "checkbox_isStatic";
            this.checkbox_isStatic.Size = new System.Drawing.Size(53, 17);
            this.checkbox_isStatic.TabIndex = 7;
            this.checkbox_isStatic.Text = "Static";
            this.checkbox_isStatic.UseVisualStyleBackColor = true;
            // 
            // checkBox_rcManage
            // 
            this.checkBox_rcManage.AutoSize = true;
            this.checkBox_rcManage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_rcManage.Location = new System.Drawing.Point(14, 133);
            this.checkBox_rcManage.Name = "checkBox_rcManage";
            this.checkBox_rcManage.Size = new System.Drawing.Size(115, 17);
            this.checkBox_rcManage.TabIndex = 8;
            this.checkBox_rcManage.Text = "Sender set amount";
            this.checkBox_rcManage.UseVisualStyleBackColor = true;
            this.checkBox_rcManage.CheckedChanged += new System.EventHandler(this.checkBox_rcManage_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 174);
            this.Controls.Add(this.checkBox_rcManage);
            this.Controls.Add(this.checkbox_isStatic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox_phoneNumber);
            this.Controls.Add(this.button_generate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "QRCode Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbox_isStatic;
        private System.Windows.Forms.CheckBox checkBox_rcManage;
    }
}

