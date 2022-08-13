namespace stamina
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
            this.button1 = new System.Windows.Forms.Button();
            this.bir = new System.Windows.Forms.Label();
            this.eki = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baslawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qisqaSozlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzinSozlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.waqit = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(50, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1332, 123);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // bir
            // 
            this.bir.BackColor = System.Drawing.Color.White;
            this.bir.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bir.Location = new System.Drawing.Point(713, 160);
            this.bir.Name = "bir";
            this.bir.Size = new System.Drawing.Size(651, 85);
            this.bir.TabIndex = 1;
            this.bir.Text = "Esc-TOQTATIW";
            this.bir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bir.Click += new System.EventHandler(this.label1_Click);
            // 
            // eki
            // 
            this.eki.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.eki.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eki.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eki.Location = new System.Drawing.Point(69, 160);
            this.eki.Name = "eki";
            this.eki.Size = new System.Drawing.Size(644, 85);
            this.eki.TabIndex = 2;
            this.eki.Text = "Probel-BASLAW, ";
            this.eki.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baslawToolStripMenuItem,
            this.rejimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1420, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baslawToolStripMenuItem
            // 
            this.baslawToolStripMenuItem.Name = "baslawToolStripMenuItem";
            this.baslawToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.baslawToolStripMenuItem.Text = "Baslaw";
            this.baslawToolStripMenuItem.Click += new System.EventHandler(this.baslawToolStripMenuItem_Click);
            // 
            // rejimToolStripMenuItem
            // 
            this.rejimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanlarToolStripMenuItem,
            this.qisqaSozlerToolStripMenuItem,
            this.uzinSozlerToolStripMenuItem});
            this.rejimToolStripMenuItem.Name = "rejimToolStripMenuItem";
            this.rejimToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.rejimToolStripMenuItem.Text = "Jaziw tu\'ri";
            this.rejimToolStripMenuItem.Click += new System.EventHandler(this.rejimToolStripMenuItem_Click);
            // 
            // sanlarToolStripMenuItem
            // 
            this.sanlarToolStripMenuItem.Name = "sanlarToolStripMenuItem";
            this.sanlarToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.sanlarToolStripMenuItem.Text = "Sanlar";
            this.sanlarToolStripMenuItem.Click += new System.EventHandler(this.sanlarToolStripMenuItem_Click);
            // 
            // qisqaSozlerToolStripMenuItem
            // 
            this.qisqaSozlerToolStripMenuItem.Name = "qisqaSozlerToolStripMenuItem";
            this.qisqaSozlerToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.qisqaSozlerToolStripMenuItem.Text = "Qisqa so\'zler";
            this.qisqaSozlerToolStripMenuItem.Click += new System.EventHandler(this.qisqaSozlerToolStripMenuItem_Click);
            // 
            // uzinSozlerToolStripMenuItem
            // 
            this.uzinSozlerToolStripMenuItem.Name = "uzinSozlerToolStripMenuItem";
            this.uzinSozlerToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.uzinSozlerToolStripMenuItem.Text = "Uzin so\'zler";
            this.uzinSozlerToolStripMenuItem.Click += new System.EventHandler(this.uzinSozlerToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(522, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 336);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(203, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Dawam ettiriw";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(28, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tamamlaw";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 68);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "\r\nwaqit:00:09\r\n50 den 6 belgi jazildi\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Na\'tiyje";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // waqit
            // 
            this.waqit.Interval = 1000;
            this.waqit.Tick += new System.EventHandler(this.waqit_Tick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(1179, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 68);
            this.label4.TabIndex = 5;
            this.label4.Text = "00:00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1420, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eki);
            this.Controls.Add(this.bir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label bir;
        private System.Windows.Forms.Label eki;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baslawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qisqaSozlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzinSozlerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer waqit;
        private System.Windows.Forms.Label label4;
    }
}

