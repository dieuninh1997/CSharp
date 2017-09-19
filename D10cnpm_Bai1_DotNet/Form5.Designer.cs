namespace D10cnpm_Bai1_DotNet
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbH1 = new System.Windows.Forms.Label();
            this.lbH3 = new System.Windows.Forms.Label();
            this.lbH2 = new System.Windows.Forms.Label();
            this.lbH4 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnNl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(41, 25);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(199, 20);
            this.txtN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "n=";
            // 
            // lbH1
            // 
            this.lbH1.AutoSize = true;
            this.lbH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH1.Location = new System.Drawing.Point(28, 134);
            this.lbH1.Name = "lbH1";
            this.lbH1.Size = new System.Drawing.Size(32, 24);
            this.lbH1.TabIndex = 2;
            this.lbH1.Text = "n=";
            // 
            // lbH3
            // 
            this.lbH3.AutoSize = true;
            this.lbH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH3.Location = new System.Drawing.Point(326, 134);
            this.lbH3.Name = "lbH3";
            this.lbH3.Size = new System.Drawing.Size(32, 24);
            this.lbH3.TabIndex = 2;
            this.lbH3.Text = "n=";
            // 
            // lbH2
            // 
            this.lbH2.AutoSize = true;
            this.lbH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH2.Location = new System.Drawing.Point(624, 134);
            this.lbH2.Name = "lbH2";
            this.lbH2.Size = new System.Drawing.Size(32, 24);
            this.lbH2.TabIndex = 3;
            this.lbH2.Text = "n=";
            // 
            // lbH4
            // 
            this.lbH4.AutoSize = true;
            this.lbH4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH4.Location = new System.Drawing.Point(909, 134);
            this.lbH4.Name = "lbH4";
            this.lbH4.Size = new System.Drawing.Size(32, 24);
            this.lbH4.TabIndex = 4;
            this.lbH4.Text = "n=";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(310, 40);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnNl
            // 
            this.btnNl.Location = new System.Drawing.Point(420, 40);
            this.btnNl.Name = "btnNl";
            this.btnNl.Size = new System.Drawing.Size(75, 23);
            this.btnNl.TabIndex = 6;
            this.btnNl.Text = "Nhập lại";
            this.btnNl.UseVisualStyleBackColor = true;
            this.btnNl.Click += new System.EventHandler(this.btnNl_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 509);
            this.Controls.Add(this.btnNl);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbH4);
            this.Controls.Add(this.lbH3);
            this.Controls.Add(this.lbH2);
            this.Controls.Add(this.lbH1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbH1;
        private System.Windows.Forms.Label lbH3;
        private System.Windows.Forms.Label lbH2;
        private System.Windows.Forms.Label lbH4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnNl;
    }
}