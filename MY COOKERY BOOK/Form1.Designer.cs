namespace MY_COOKERY_BOOK
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.першіБлюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.другіБлюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.салатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десертиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.напоїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.першіБлюдаToolStripMenuItem,
            this.другіБлюдаToolStripMenuItem,
            this.салатиToolStripMenuItem,
            this.десертиToolStripMenuItem,
            this.напоїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // першіБлюдаToolStripMenuItem
            // 
            this.першіБлюдаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.першіБлюдаToolStripMenuItem.Name = "першіБлюдаToolStripMenuItem";
            this.першіБлюдаToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.першіБлюдаToolStripMenuItem.Text = "Перші страви";
            this.першіБлюдаToolStripMenuItem.Click += new System.EventHandler(this.першіБлюдаToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // другіБлюдаToolStripMenuItem
            // 
            this.другіБлюдаToolStripMenuItem.Name = "другіБлюдаToolStripMenuItem";
            this.другіБлюдаToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.другіБлюдаToolStripMenuItem.Text = "Другі страви";
            this.другіБлюдаToolStripMenuItem.Click += new System.EventHandler(this.другіБлюдаToolStripMenuItem_Click);
            // 
            // салатиToolStripMenuItem
            // 
            this.салатиToolStripMenuItem.Name = "салатиToolStripMenuItem";
            this.салатиToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.салатиToolStripMenuItem.Text = "Салати, закуски ";
            this.салатиToolStripMenuItem.Click += new System.EventHandler(this.салатиToolStripMenuItem_Click);
            // 
            // десертиToolStripMenuItem
            // 
            this.десертиToolStripMenuItem.Name = "десертиToolStripMenuItem";
            this.десертиToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.десертиToolStripMenuItem.Text = "Десерти";
            // 
            // напоїToolStripMenuItem
            // 
            this.напоїToolStripMenuItem.Name = "напоїToolStripMenuItem";
            this.напоїToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.напоїToolStripMenuItem.Text = "Напої";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(678, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem першіБлюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другіБлюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem салатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десертиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem напоїToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

