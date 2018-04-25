namespace EncodeOrDecode
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_EncodeType = new System.Windows.Forms.ComboBox();
            this.txt_EncodeBefore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_EncodeAfter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DecodeAfter = new System.Windows.Forms.TextBox();
            this.btn_EncodeOrDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编码类型：";
            // 
            // cmb_EncodeType
            // 
            this.cmb_EncodeType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_EncodeType.FormattingEnabled = true;
            this.cmb_EncodeType.Location = new System.Drawing.Point(83, 6);
            this.cmb_EncodeType.Name = "cmb_EncodeType";
            this.cmb_EncodeType.Size = new System.Drawing.Size(303, 20);
            this.cmb_EncodeType.TabIndex = 1;
            // 
            // txt_EncodeBefore
            // 
            this.txt_EncodeBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_EncodeBefore.Location = new System.Drawing.Point(83, 43);
            this.txt_EncodeBefore.Multiline = true;
            this.txt_EncodeBefore.Name = "txt_EncodeBefore";
            this.txt_EncodeBefore.Size = new System.Drawing.Size(303, 64);
            this.txt_EncodeBefore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "编码前：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "编码后：";
            // 
            // txt_EncodeAfter
            // 
            this.txt_EncodeAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_EncodeAfter.Location = new System.Drawing.Point(83, 126);
            this.txt_EncodeAfter.Multiline = true;
            this.txt_EncodeAfter.Name = "txt_EncodeAfter";
            this.txt_EncodeAfter.Size = new System.Drawing.Size(303, 64);
            this.txt_EncodeAfter.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "解码后：";
            // 
            // txt_DecodeAfter
            // 
            this.txt_DecodeAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DecodeAfter.Location = new System.Drawing.Point(83, 207);
            this.txt_DecodeAfter.Multiline = true;
            this.txt_DecodeAfter.Name = "txt_DecodeAfter";
            this.txt_DecodeAfter.Size = new System.Drawing.Size(303, 64);
            this.txt_DecodeAfter.TabIndex = 6;
            // 
            // btn_EncodeOrDecode
            // 
            this.btn_EncodeOrDecode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_EncodeOrDecode.Location = new System.Drawing.Point(162, 285);
            this.btn_EncodeOrDecode.Name = "btn_EncodeOrDecode";
            this.btn_EncodeOrDecode.Size = new System.Drawing.Size(75, 23);
            this.btn_EncodeOrDecode.TabIndex = 8;
            this.btn_EncodeOrDecode.Text = "编码|解码";
            this.btn_EncodeOrDecode.UseVisualStyleBackColor = true;
            this.btn_EncodeOrDecode.Click += new System.EventHandler(this.btn_EncodeOrDecode_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 320);
            this.Controls.Add(this.btn_EncodeOrDecode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DecodeAfter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_EncodeAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_EncodeBefore);
            this.Controls.Add(this.cmb_EncodeType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编码和解码";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_EncodeType;
        private System.Windows.Forms.TextBox txt_EncodeBefore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_EncodeAfter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DecodeAfter;
        private System.Windows.Forms.Button btn_EncodeOrDecode;
    }
}

