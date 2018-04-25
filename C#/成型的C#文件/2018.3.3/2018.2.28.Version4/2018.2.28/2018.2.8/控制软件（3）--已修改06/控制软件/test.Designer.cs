namespace 控制软件
{
    partial class test
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
            this.components = new System.ComponentModel.Container();
            this.ComGiv = new System.Windows.Forms.ComboBox();
            this.BaudGiv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComGet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BaudGet = new System.Windows.Forms.ComboBox();
            this.TestPost = new System.Windows.Forms.RichTextBox();
            this.TestRecv = new System.Windows.Forms.RichTextBox();
            this.StartTest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ErrorNum = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.resultDat = new System.Windows.Forms.RichTextBox();
            this.Ps = new System.Windows.Forms.Label();
            this.MSKTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComGiv
            // 
            this.ComGiv.FormattingEnabled = true;
            this.ComGiv.Location = new System.Drawing.Point(53, 20);
            this.ComGiv.Name = "ComGiv";
            this.ComGiv.Size = new System.Drawing.Size(81, 20);
            this.ComGiv.TabIndex = 0;
            this.ComGiv.SelectedIndexChanged += new System.EventHandler(this.ComGiv_SelectedIndexChanged);
            // 
            // BaudGiv
            // 
            this.BaudGiv.FormattingEnabled = true;
            this.BaudGiv.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "4300",
            "5600",
            "115200"});
            this.BaudGiv.Location = new System.Drawing.Point(53, 46);
            this.BaudGiv.Name = "BaudGiv";
            this.BaudGiv.Size = new System.Drawing.Size(81, 20);
            this.BaudGiv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComGiv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BaudGiv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送端口";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComGet);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BaudGet);
            this.groupBox2.Location = new System.Drawing.Point(157, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 78);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收端口";
            // 
            // ComGet
            // 
            this.ComGet.FormattingEnabled = true;
            this.ComGet.Location = new System.Drawing.Point(53, 20);
            this.ComGet.Name = "ComGet";
            this.ComGet.Size = new System.Drawing.Size(81, 20);
            this.ComGet.TabIndex = 0;
            this.ComGet.SelectedIndexChanged += new System.EventHandler(this.ComGet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "波特率";
            // 
            // BaudGet
            // 
            this.BaudGet.FormattingEnabled = true;
            this.BaudGet.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "4300",
            "5600",
            "115200"});
            this.BaudGet.Location = new System.Drawing.Point(53, 46);
            this.BaudGet.Name = "BaudGet";
            this.BaudGet.Size = new System.Drawing.Size(81, 20);
            this.BaudGet.TabIndex = 1;
            // 
            // TestPost
            // 
            this.TestPost.Location = new System.Drawing.Point(6, 30);
            this.TestPost.Name = "TestPost";
            this.TestPost.Size = new System.Drawing.Size(284, 67);
            this.TestPost.TabIndex = 7;
            this.TestPost.Text = "";
            // 
            // TestRecv
            // 
            this.TestRecv.Location = new System.Drawing.Point(6, 122);
            this.TestRecv.Name = "TestRecv";
            this.TestRecv.Size = new System.Drawing.Size(279, 67);
            this.TestRecv.TabIndex = 8;
            this.TestRecv.Text = "";
            // 
            // StartTest
            // 
            this.StartTest.Location = new System.Drawing.Point(316, 28);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(98, 71);
            this.StartTest.TabIndex = 9;
            this.StartTest.Text = "打开端口";
            this.StartTest.UseVisualStyleBackColor = true;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "发送内容";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "接收内容";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(420, 28);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(147, 71);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ErrorNum
            // 
            this.ErrorNum.Location = new System.Drawing.Point(151, 205);
            this.ErrorNum.Name = "ErrorNum";
            this.ErrorNum.Size = new System.Drawing.Size(67, 20);
            this.ErrorNum.TabIndex = 17;
            this.ErrorNum.Text = "误比特率";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TestRecv);
            this.groupBox3.Controls.Add(this.ErrorNum);
            this.groupBox3.Controls.Add(this.TestPost);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 241);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口误码率测试";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.resultDat);
            this.groupBox4.Controls.Add(this.Ps);
            this.groupBox4.Controls.Add(this.MSKTest);
            this.groupBox4.Location = new System.Drawing.Point(316, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 241);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MSK解调误码率测试";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "音频发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultDat
            // 
            this.resultDat.Location = new System.Drawing.Point(0, 30);
            this.resultDat.Name = "resultDat";
            this.resultDat.Size = new System.Drawing.Size(237, 159);
            this.resultDat.TabIndex = 3;
            this.resultDat.Text = "";
            // 
            // Ps
            // 
            this.Ps.AutoSize = true;
            this.Ps.Location = new System.Drawing.Point(185, 205);
            this.Ps.Name = "Ps";
            this.Ps.Size = new System.Drawing.Size(41, 12);
            this.Ps.TabIndex = 2;
            this.Ps.Text = "label5";
            // 
            // MSKTest
            // 
            this.MSKTest.Location = new System.Drawing.Point(104, 197);
            this.MSKTest.Name = "MSKTest";
            this.MSKTest.Size = new System.Drawing.Size(75, 28);
            this.MSKTest.TabIndex = 0;
            this.MSKTest.Text = "测试";
            this.MSKTest.UseVisualStyleBackColor = true;
            this.MSKTest.Click += new System.EventHandler(this.MSKTest_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 360);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartTest);
            this.Name = "test";
            this.Text = "误码率测试";
            this.Load += new System.EventHandler(this.test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComGiv;
        private System.Windows.Forms.ComboBox BaudGiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ComGet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BaudGet;
        private System.Windows.Forms.RichTextBox TestPost;
        private System.Windows.Forms.RichTextBox TestRecv;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label ErrorNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Ps;
        private System.Windows.Forms.Button MSKTest;
        private System.Windows.Forms.RichTextBox resultDat;
        private System.Windows.Forms.Button button2;
    }
}