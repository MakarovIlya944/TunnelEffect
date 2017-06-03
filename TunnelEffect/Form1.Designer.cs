namespace TunnelEffect
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
            this.components = new System.ComponentModel.Container();
            this.ant = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.светToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьИсточникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУмолчаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.левыйИсточникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правыйИсточникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TimeValue = new System.Windows.Forms.Label();
            this.buttonStartTime = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ant
            // 
            this.ant.AccumBits = ((byte)(0));
            this.ant.AutoCheckErrors = false;
            this.ant.AutoFinish = false;
            this.ant.AutoMakeCurrent = true;
            this.ant.AutoSwapBuffers = true;
            this.ant.BackColor = System.Drawing.Color.Black;
            this.ant.ColorBits = ((byte)(32));
            this.ant.DepthBits = ((byte)(16));
            this.ant.Location = new System.Drawing.Point(5, 20);
            this.ant.Name = "ant";
            this.ant.Size = new System.Drawing.Size(600, 500);
            this.ant.StencilBits = ((byte)(0));
            this.ant.TabIndex = 0;
            this.ant.Load += new System.EventHandler(this.ant_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.светToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            // 
            // светToolStripMenuItem
            // 
            this.светToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переместитьИсточникToolStripMenuItem});
            this.светToolStripMenuItem.Name = "светToolStripMenuItem";
            this.светToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.светToolStripMenuItem.Text = "Свет";
            // 
            // переместитьИсточникToolStripMenuItem
            // 
            this.переместитьИсточникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поУмолчаниюToolStripMenuItem,
            this.левыйИсточникToolStripMenuItem,
            this.правыйИсточникToolStripMenuItem});
            this.переместитьИсточникToolStripMenuItem.Name = "переместитьИсточникToolStripMenuItem";
            this.переместитьИсточникToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.переместитьИсточникToolStripMenuItem.Text = "Переместить источник";
            // 
            // поУмолчаниюToolStripMenuItem
            // 
            this.поУмолчаниюToolStripMenuItem.Name = "поУмолчаниюToolStripMenuItem";
            this.поУмолчаниюToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.поУмолчаниюToolStripMenuItem.Text = "По умолчанию";
            // 
            // левыйИсточникToolStripMenuItem
            // 
            this.левыйИсточникToolStripMenuItem.Name = "левыйИсточникToolStripMenuItem";
            this.левыйИсточникToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.левыйИсточникToolStripMenuItem.Text = "Левый источник";
            // 
            // правыйИсточникToolStripMenuItem
            // 
            this.правыйИсточникToolStripMenuItem.Name = "правыйИсточникToolStripMenuItem";
            this.правыйИсточникToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.правыйИсточникToolStripMenuItem.Text = "Правый источник";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.TimeStep);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Значение бегунка";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.Location = new System.Drawing.Point(638, 128);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(276, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(638, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 57);
            this.label2.TabIndex = 8;
            this.label2.Text = "Числа";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Показать график";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowGraphic);
            // 
            // TimeValue
            // 
            this.TimeValue.AutoSize = true;
            this.TimeValue.Location = new System.Drawing.Point(638, 289);
            this.TimeValue.Name = "TimeValue";
            this.TimeValue.Size = new System.Drawing.Size(40, 13);
            this.TimeValue.TabIndex = 11;
            this.TimeValue.Text = "Время";
            // 
            // buttonStartTime
            // 
            this.buttonStartTime.Location = new System.Drawing.Point(789, 395);
            this.buttonStartTime.Name = "buttonStartTime";
            this.buttonStartTime.Size = new System.Drawing.Size(92, 23);
            this.buttonStartTime.TabIndex = 12;
            this.buttonStartTime.Text = "Старт таймера";
            this.buttonStartTime.UseVisualStyleBackColor = true;
            this.buttonStartTime.Click += new System.EventHandler(this.StarTimer);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Включить пулю";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStartTime);
            this.Controls.Add(this.TimeValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ant);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Туннельный эффект";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl ant;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TimeValue;
        private System.Windows.Forms.Button buttonStartTime;
        private System.Windows.Forms.ToolStripMenuItem светToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переместитьИсточникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУмолчаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem левыйИсточникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правыйИсточникToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

