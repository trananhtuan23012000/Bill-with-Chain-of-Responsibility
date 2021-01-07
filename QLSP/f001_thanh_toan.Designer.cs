namespace QLSP
{
    partial class f001_thanh_toan
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
            this.m_rdb_hdt = new System.Windows.Forms.RadioButton();
            this.m_rdb_hdgtgt = new System.Windows.Forms.RadioButton();
            this.back = new System.Windows.Forms.Button();
            this.m_cmd_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn loại hình hóa đơn thanh toán";
            // 
            // m_rdb_hdt
            // 
            this.m_rdb_hdt.AutoSize = true;
            this.m_rdb_hdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_rdb_hdt.Location = new System.Drawing.Point(342, 34);
            this.m_rdb_hdt.Name = "m_rdb_hdt";
            this.m_rdb_hdt.Size = new System.Drawing.Size(132, 22);
            this.m_rdb_hdt.TabIndex = 1;
            this.m_rdb_hdt.TabStop = true;
            this.m_rdb_hdt.Text = "Hóa đơn thường";
            this.m_rdb_hdt.UseVisualStyleBackColor = true;
            // 
            // m_rdb_hdgtgt
            // 
            this.m_rdb_hdgtgt.AutoSize = true;
            this.m_rdb_hdgtgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_rdb_hdgtgt.Location = new System.Drawing.Point(342, 71);
            this.m_rdb_hdgtgt.Name = "m_rdb_hdgtgt";
            this.m_rdb_hdgtgt.Size = new System.Drawing.Size(129, 22);
            this.m_rdb_hdgtgt.TabIndex = 2;
            this.m_rdb_hdgtgt.TabStop = true;
            this.m_rdb_hdgtgt.Text = "Hóa đơn GTGT";
            this.m_rdb_hdgtgt.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.BackgroundImage = global::QLSP.Properties.Resources.phai3;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.back.Location = new System.Drawing.Point(47, 130);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(99, 29);
            this.back.TabIndex = 5;
            this.back.UseVisualStyleBackColor = true;
            // 
            // m_cmd_next
            // 
            this.m_cmd_next.BackgroundImage = global::QLSP.Properties.Resources.phai2;
            this.m_cmd_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_next.ForeColor = System.Drawing.Color.Red;
            this.m_cmd_next.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.m_cmd_next.Location = new System.Drawing.Point(361, 130);
            this.m_cmd_next.Name = "m_cmd_next";
            this.m_cmd_next.Size = new System.Drawing.Size(99, 29);
            this.m_cmd_next.TabIndex = 4;
            this.m_cmd_next.UseVisualStyleBackColor = true;
            this.m_cmd_next.Click += new System.EventHandler(this.button1_Click);
            // 
            // f001_thanh_toan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 203);
            this.Controls.Add(this.back);
            this.Controls.Add(this.m_cmd_next);
            this.Controls.Add(this.m_rdb_hdgtgt);
            this.Controls.Add(this.m_rdb_hdt);
            this.Controls.Add(this.label1);
            this.Name = "f001_thanh_toan";
            this.Text = "F001-Chon thanh toan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton m_rdb_hdt;
        private System.Windows.Forms.RadioButton m_rdb_hdgtgt;
        private System.Windows.Forms.Button m_cmd_next;
        private System.Windows.Forms.Button back;
    }
}

