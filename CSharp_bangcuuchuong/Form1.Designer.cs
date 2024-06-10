namespace CSharp_bangcuuchuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lsbkq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG CỬU CHƯƠNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "BẠN MUỐN HIỂN THỊ BẢNG CỬU CHƯƠNG MẤY? ";
            // 
            // txtso
            // 
            this.txtso.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso.Location = new System.Drawing.Point(316, 186);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(285, 50);
            this.txtso.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(619, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "XEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbkq
            // 
            this.lsbkq.FormattingEnabled = true;
            this.lsbkq.Location = new System.Drawing.Point(316, 269);
            this.lsbkq.Name = "lsbkq";
            this.lsbkq.Size = new System.Drawing.Size(477, 342);
            this.lsbkq.TabIndex = 4;
            this.lsbkq.SelectedIndexChanged += new System.EventHandler(this.lsbkq_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 668);
            this.Controls.Add(this.lsbkq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsbkq;
    }
}

