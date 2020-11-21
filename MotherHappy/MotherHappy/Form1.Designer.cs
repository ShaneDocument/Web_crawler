namespace MotherHappy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CatchInfinite = new System.Windows.Forms.Timer(this.components);
            this.seriestb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.seriesList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.intro = new System.Windows.Forms.RichTextBox();
            this.MovieImg = new System.Windows.Forms.PictureBox();
            this.Watch = new System.Windows.Forms.Button();
            this.SeriesName = new System.Windows.Forms.TextBox();
            this.LinkList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.HintLB = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MoveButton = new System.Windows.Forms.Button();
            this.SystemList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CatchInfinite
            // 
            this.CatchInfinite.Enabled = true;
            this.CatchInfinite.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // seriestb
            // 
            this.seriestb.Location = new System.Drawing.Point(149, 15);
            this.seriestb.Name = "seriestb";
            this.seriestb.Size = new System.Drawing.Size(100, 23);
            this.seriestb.TabIndex = 4;
            this.seriestb.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "搜尋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seriesList
            // 
            this.seriesList.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.seriesList.FormattingEnabled = true;
            this.seriesList.HorizontalScrollbar = true;
            this.seriesList.ItemHeight = 16;
            this.seriesList.Location = new System.Drawing.Point(12, 54);
            this.seriesList.Name = "seriesList";
            this.seriesList.Size = new System.Drawing.Size(189, 260);
            this.seriesList.TabIndex = 3;
            this.seriesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.intro);
            this.groupBox1.Controls.Add(this.MovieImg);
            this.groupBox1.Controls.Add(this.Watch);
            this.groupBox1.Controls.Add(this.SeriesName);
            this.groupBox1.Controls.Add(this.LinkList);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.HintLB);
            this.groupBox1.Controls.Add(this.seriestb);
            this.groupBox1.Controls.Add(this.seriesList);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 524);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影集搜尋";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(547, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "名詞解釋";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // intro
            // 
            this.intro.BackColor = System.Drawing.SystemColors.MenuBar;
            this.intro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intro.Font = new System.Drawing.Font("微軟正黑體 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.intro.Location = new System.Drawing.Point(223, 297);
            this.intro.Name = "intro";
            this.intro.ReadOnly = true;
            this.intro.Size = new System.Drawing.Size(237, 163);
            this.intro.TabIndex = 10;
            this.intro.Text = "";
            // 
            // MovieImg
            // 
            this.MovieImg.Location = new System.Drawing.Point(223, 54);
            this.MovieImg.Name = "MovieImg";
            this.MovieImg.Size = new System.Drawing.Size(176, 227);
            this.MovieImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MovieImg.TabIndex = 9;
            this.MovieImg.TabStop = false;
            this.MovieImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Watch
            // 
            this.Watch.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Watch.Location = new System.Drawing.Point(495, 13);
            this.Watch.Name = "Watch";
            this.Watch.Size = new System.Drawing.Size(75, 40);
            this.Watch.TabIndex = 5;
            this.Watch.Text = "觀看";
            this.Watch.UseVisualStyleBackColor = true;
            this.Watch.Click += new System.EventHandler(this.Watch_Click);
            // 
            // SeriesName
            // 
            this.SeriesName.Enabled = false;
            this.SeriesName.Location = new System.Drawing.Point(12, 28);
            this.SeriesName.Name = "SeriesName";
            this.SeriesName.Size = new System.Drawing.Size(100, 23);
            this.SeriesName.TabIndex = 8;
            this.SeriesName.TextChanged += new System.EventHandler(this.SeriesName_TextChanged);
            // 
            // LinkList
            // 
            this.LinkList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LinkList.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LinkList.FormattingEnabled = true;
            this.LinkList.HorizontalScrollbar = true;
            this.LinkList.ItemHeight = 16;
            this.LinkList.Location = new System.Drawing.Point(419, 54);
            this.LinkList.Name = "LinkList";
            this.LinkList.Size = new System.Drawing.Size(203, 228);
            this.LinkList.TabIndex = 7;
            this.LinkList.SelectedIndexChanged += new System.EventHandler(this.LinkList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.HistoryList);
            this.groupBox2.Location = new System.Drawing.Point(6, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 195);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "歷史紀錄";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "移除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // HistoryList
            // 
            this.HistoryList.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HistoryList.FormattingEnabled = true;
            this.HistoryList.HorizontalScrollbar = true;
            this.HistoryList.ItemHeight = 17;
            this.HistoryList.Location = new System.Drawing.Point(6, 22);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(186, 140);
            this.HistoryList.TabIndex = 6;
            this.HistoryList.SelectedIndexChanged += new System.EventHandler(this.HistoryList_SelectedIndexChanged);
            // 
            // HintLB
            // 
            this.HintLB.AutoSize = true;
            this.HintLB.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HintLB.Location = new System.Drawing.Point(348, 15);
            this.HintLB.Name = "HintLB";
            this.HintLB.Size = new System.Drawing.Size(0, 24);
            this.HintLB.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MoveButton);
            this.groupBox3.Controls.Add(this.SystemList);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(675, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 158);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "照片移動";
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(17, 118);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(120, 29);
            this.MoveButton.TabIndex = 1;
            this.MoveButton.Text = "移動！";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Visible = false;
            this.MoveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SystemList
            // 
            this.SystemList.FormattingEnabled = true;
            this.SystemList.Location = new System.Drawing.Point(17, 17);
            this.SystemList.Name = "SystemList";
            this.SystemList.Size = new System.Drawing.Size(120, 95);
            this.SystemList.TabIndex = 0;
            this.SystemList.SelectedIndexChanged += new System.EventHandler(this.SystemList_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(675, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "快速連結";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button6
            // 
            this.button6.Image = global::MotherHappy.Properties.Resources.擷取3;
            this.button6.Location = new System.Drawing.Point(100, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 38);
            this.button6.TabIndex = 10;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // button4
            // 
            this.button4.Image = global::MotherHappy.Properties.Resources.擷取21;
            this.button4.Location = new System.Drawing.Point(60, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 38);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::MotherHappy.Properties.Resources.擷取;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(18, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 38);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(775, 517);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "結束";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(775, 488);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "各功能使用教學";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(898, 552);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "媽媽樂";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieImg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer CatchInfinite;
        private System.Windows.Forms.TextBox seriestb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox seriesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label HintLB;
        private System.Windows.Forms.ListBox HistoryList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LinkList;
        private System.Windows.Forms.TextBox SeriesName;
        private System.Windows.Forms.Button Watch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox MovieImg;
        private System.Windows.Forms.RichTextBox intro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox SystemList;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

