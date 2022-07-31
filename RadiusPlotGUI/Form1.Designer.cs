namespace RadiusPlotGUI
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
            this.sphereRadius = new System.Windows.Forms.TextBox();
            this.toolRadius = new System.Windows.Forms.TextBox();
            this.startAngle = new System.Windows.Forms.TextBox();
            this.sphereAngle = new System.Windows.Forms.TextBox();
            this.lineLengh = new System.Windows.Forms.TextBox();
            this.zOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tool = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // sphereRadius
            // 
            this.sphereRadius.Cursor = System.Windows.Forms.Cursors.Default;
            this.sphereRadius.Location = new System.Drawing.Point(649, 61);
            this.sphereRadius.Name = "sphereRadius";
            this.sphereRadius.Size = new System.Drawing.Size(100, 20);
            this.sphereRadius.TabIndex = 0;
            this.sphereRadius.TextChanged += new System.EventHandler(this.sphereRadius_TextChanged);
            // 
            // toolRadius
            // 
            this.toolRadius.Location = new System.Drawing.Point(649, 111);
            this.toolRadius.Name = "toolRadius";
            this.toolRadius.Size = new System.Drawing.Size(100, 20);
            this.toolRadius.TabIndex = 1;
            this.toolRadius.TextChanged += new System.EventHandler(this.toolRadius_TextChanged);
            // 
            // startAngle
            // 
            this.startAngle.Location = new System.Drawing.Point(649, 161);
            this.startAngle.Name = "startAngle";
            this.startAngle.Size = new System.Drawing.Size(100, 20);
            this.startAngle.TabIndex = 2;
            this.startAngle.TextChanged += new System.EventHandler(this.startAngle_TextChanged);
            // 
            // sphereAngle
            // 
            this.sphereAngle.Location = new System.Drawing.Point(649, 211);
            this.sphereAngle.Name = "sphereAngle";
            this.sphereAngle.Size = new System.Drawing.Size(100, 20);
            this.sphereAngle.TabIndex = 3;
            this.sphereAngle.TextChanged += new System.EventHandler(this.sphereAngle_TextChanged);
            // 
            // lineLengh
            // 
            this.lineLengh.Location = new System.Drawing.Point(649, 261);
            this.lineLengh.Name = "lineLengh";
            this.lineLengh.Size = new System.Drawing.Size(100, 20);
            this.lineLengh.TabIndex = 4;
            this.lineLengh.TextChanged += new System.EventHandler(this.lineLengh_TextChanged);
            // 
            // zOffset
            // 
            this.zOffset.Location = new System.Drawing.Point(649, 311);
            this.zOffset.Name = "zOffset";
            this.zOffset.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.zOffset.Size = new System.Drawing.Size(100, 20);
            this.zOffset.TabIndex = 5;
            this.zOffset.TextChanged += new System.EventHandler(this.zOffset_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Радиус сферы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tool
            // 
            this.tool.AutoSize = true;
            this.tool.Location = new System.Drawing.Point(614, 95);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(160, 13);
            this.tool.TabIndex = 7;
            this.tool.Text = "Радиус вершины инструмента";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(635, 145);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(126, 13);
            this.start.TabIndex = 8;
            this.start.Text = "Начальный угол сферы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Угол сферы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Длина отрезка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Смещение по Z";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(649, 369);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(98, 56);
            this.run.TabIndex = 12;
            this.run.Text = "Расчитать";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(41, 48);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox8.Size = new System.Drawing.Size(228, 283);
            this.textBox8.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(294, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 283);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(791, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.run);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zOffset);
            this.Controls.Add(this.lineLengh);
            this.Controls.Add(this.sphereAngle);
            this.Controls.Add(this.startAngle);
            this.Controls.Add(this.toolRadius);
            this.Controls.Add(this.sphereRadius);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sphereRadius;
        private System.Windows.Forms.TextBox toolRadius;
        private System.Windows.Forms.TextBox startAngle;
        private System.Windows.Forms.TextBox sphereAngle;
        private System.Windows.Forms.TextBox lineLengh;
        private System.Windows.Forms.TextBox zOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tool;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

