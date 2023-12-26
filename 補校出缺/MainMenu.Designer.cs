namespace 補校出缺
{
    partial class MainMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.txt1 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.com1 = new System.Windows.Forms.ComboBox();
            this.com2 = new System.Windows.Forms.ComboBox();
            this.com3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.lv1 = new System.Windows.Forms.ListView();
            this.bt5 = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Window;
            this.txt1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt1.Location = new System.Drawing.Point(16, 30);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(187, 36);
            this.txt1.TabIndex = 0;
            this.txt1.Enter += new System.EventHandler(this.Txt1_Enter);
            this.txt1.Leave += new System.EventHandler(this.Txt1_Leave);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt1.Location = new System.Drawing.Point(209, 28);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(78, 39);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "搜尋";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt2.Location = new System.Drawing.Point(794, 27);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(170, 36);
            this.txt2.TabIndex = 3;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb2.Location = new System.Drawing.Point(682, 33);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(106, 24);
            this.lb2.TabIndex = 4;
            this.lb2.Text = "學生姓名";
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt3.Location = new System.Drawing.Point(80, 230);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(158, 33);
            this.txt3.TabIndex = 5;
            this.txt3.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txt3.Enter += new System.EventHandler(this.Txt3_Enter);
            this.txt3.Leave += new System.EventHandler(this.Txt3_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(10, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "日期1";
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt2.Location = new System.Drawing.Point(16, 365);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(117, 42);
            this.bt2.TabIndex = 8;
            this.bt2.Text = "確定登入";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.Bt2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(473, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 42);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // com1
            // 
            this.com1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.com1.FormattingEnabled = true;
            this.com1.Location = new System.Drawing.Point(76, 109);
            this.com1.Name = "com1";
            this.com1.Size = new System.Drawing.Size(65, 29);
            this.com1.TabIndex = 10;
            // 
            // com2
            // 
            this.com2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.com2.FormattingEnabled = true;
            this.com2.Location = new System.Drawing.Point(76, 170);
            this.com2.Name = "com2";
            this.com2.Size = new System.Drawing.Size(65, 29);
            this.com2.TabIndex = 11;
            // 
            // com3
            // 
            this.com3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.com3.FormattingEnabled = true;
            this.com3.Location = new System.Drawing.Point(170, 170);
            this.com3.Name = "com3";
            this.com3.Size = new System.Drawing.Size(65, 29);
            this.com3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "假別";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "節次";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(147, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "~";
            // 
            // lv1
            // 
            this.lv1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(394, 81);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(572, 335);
            this.lv1.TabIndex = 16;
            this.lv1.UseCompatibleStateImageBehavior = false;
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Transparent;
            this.bt5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt5.Image = ((System.Drawing.Image)(resources.GetObject("bt5.Image")));
            this.bt5.Location = new System.Drawing.Point(908, 422);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(58, 39);
            this.bt5.TabIndex = 20;
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt4.Location = new System.Drawing.Point(81, 299);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(158, 33);
            this.txt4.TabIndex = 21;
            this.txt4.Enter += new System.EventHandler(this.Txt4_Enter);
            this.txt4.Leave += new System.EventHandler(this.Txt4_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(141, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "~";
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt6.Location = new System.Drawing.Point(164, 365);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(74, 42);
            this.bt6.TabIndex = 23;
            this.bt6.Text = "統計";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.Bt6_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(293, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 39);
            this.button2.TabIndex = 24;
            this.button2.Text = "清除";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(9, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "日期2";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(991, 530);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.com3);
            this.Controls.Add(this.com2);
            this.Controls.Add(this.com1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txt1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox com1;
        private System.Windows.Forms.ComboBox com2;
        private System.Windows.Forms.ComboBox com3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}

