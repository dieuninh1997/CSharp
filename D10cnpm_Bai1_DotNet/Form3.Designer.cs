namespace D10cnpm_Bai1_DotNet
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKq = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnNl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(40, 29);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(181, 20);
            this.txtN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "n=";
            // 
            // lbKq
            // 
            this.lbKq.AutoSize = true;
            this.lbKq.Location = new System.Drawing.Point(12, 145);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(35, 13);
            this.lbKq.TabIndex = 0;
            this.lbKq.Text = "label1";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(221, 103);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnNl
            // 
            this.btnNl.Location = new System.Drawing.Point(107, 103);
            this.btnNl.Name = "btnNl";
            this.btnNl.Size = new System.Drawing.Size(75, 23);
            this.btnNl.TabIndex = 3;
            this.btnNl.Text = "Nhập lại";
            this.btnNl.UseVisualStyleBackColor = true;
            this.btnNl.Click += new System.EventHandler(this.btnNl_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 386);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.btnNl);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKq;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnNl;
    }
}