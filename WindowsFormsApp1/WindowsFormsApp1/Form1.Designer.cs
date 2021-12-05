namespace WindowsFormsApp1
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIntomoney4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUniPrice3 = new System.Windows.Forms.TextBox();
            this.txtMoney2 = new System.Windows.Forms.TextBox();
            this.txtMoney1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(188, 315);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(425, 20);
            this.txtAddress.TabIndex = 27;
            this.txtAddress.Text = "Address: No. 114, Lane 604, Group 21, Ngoc Thuy Ward, Long Bien District, Hanoi C" +
    "ity";
            // 
            // txtIntomoney4
            // 
            this.txtIntomoney4.Location = new System.Drawing.Point(344, 241);
            this.txtIntomoney4.Name = "txtIntomoney4";
            this.txtIntomoney4.Size = new System.Drawing.Size(100, 20);
            this.txtIntomoney4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Into money";
            // 
            // txtUniPrice3
            // 
            this.txtUniPrice3.Location = new System.Drawing.Point(344, 197);
            this.txtUniPrice3.Name = "txtUniPrice3";
            this.txtUniPrice3.Size = new System.Drawing.Size(100, 20);
            this.txtUniPrice3.TabIndex = 24;
            // 
            // txtMoney2
            // 
            this.txtMoney2.Location = new System.Drawing.Point(344, 152);
            this.txtMoney2.Name = "txtMoney2";
            this.txtMoney2.Size = new System.Drawing.Size(100, 20);
            this.txtMoney2.TabIndex = 23;
            // 
            // txtMoney1
            // 
            this.txtMoney1.Location = new System.Drawing.Point(344, 116);
            this.txtMoney1.Name = "txtMoney1";
            this.txtMoney1.Size = new System.Drawing.Size(100, 20);
            this.txtMoney1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "money last month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Unit price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "This month\'s money";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIntomoney4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUniPrice3);
            this.Controls.Add(this.txtMoney2);
            this.Controls.Add(this.txtMoney1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtIntomoney4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUniPrice3;
        private System.Windows.Forms.TextBox txtMoney2;
        private System.Windows.Forms.TextBox txtMoney1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

