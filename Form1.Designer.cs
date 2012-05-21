using PC;
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cmdGet = new System.Windows.Forms.Button();
            this.lstNews = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(6, 29);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(1354, 20);
            this.txtURL.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(6, 19);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(1475, 157);
            this.txtContent.TabIndex = 2;
            // 
            // cmdGet
            // 
            this.cmdGet.Location = new System.Drawing.Point(1406, 26);
            this.cmdGet.Name = "cmdGet";
            this.cmdGet.Size = new System.Drawing.Size(75, 23);
            this.cmdGet.TabIndex = 3;
            this.cmdGet.Text = "Get Feed";
            this.cmdGet.UseVisualStyleBackColor = true;
            this.cmdGet.Click += new System.EventHandler(this.cmdGet_Click);
            // 
            // lstNews
            // 
            this.lstNews.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstNews.GridLines = true;
            this.lstNews.HotTracking = true;
            this.lstNews.HoverSelection = true;
            this.lstNews.Location = new System.Drawing.Point(6, 29);
            this.lstNews.Name = "lstNews";
            this.lstNews.Size = new System.Drawing.Size(1475, 211);
            this.lstNews.TabIndex = 4;
            this.lstNews.UseCompatibleStateImageBehavior = false;
            this.lstNews.View = System.Windows.Forms.View.List;
            this.lstNews.SelectedIndexChanged += new System.EventHandler(this.lstNews_SelectedIndexChanged);
            this.lstNews.DoubleClick += new System.EventHandler(this.lstNews_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Controls.Add(this.cmdGet);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1496, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Feed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstNews);
            this.groupBox2.Location = new System.Drawing.Point(24, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1496, 246);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Feeds";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtContent);
            this.groupBox3.Location = new System.Drawing.Point(24, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1496, 191);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 598);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RSS Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button cmdGet;
        private System.Windows.Forms.ListView lstNews;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }


