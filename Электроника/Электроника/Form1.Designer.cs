namespace Электроника
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
            this.textBoxADDR = new System.Windows.Forms.TextBox();
            this.STEP = new System.Windows.Forms.Button();
            this.MEM = new System.Windows.Forms.Button();
            this.NEXT = new System.Windows.Forms.Button();
            this.ADDR = new System.Windows.Forms.Button();
            this.textBoxREG = new System.Windows.Forms.TextBox();
            this.textBoxMEM = new System.Windows.Forms.TextBox();
            this.REG = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CLR = new System.Windows.Forms.Button();
            this.RST = new System.Windows.Forms.Button();
            this.BRK = new System.Windows.Forms.Button();
            this.RUN = new System.Windows.Forms.Button();
            this.CYlabel = new System.Windows.Forms.Label();
            this.Zlabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаМнемокодовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.примерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxZ = new System.Windows.Forms.PictureBox();
            this.pictureBoxCY = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCY)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxADDR
            // 
            this.textBoxADDR.Location = new System.Drawing.Point(171, 36);
            this.textBoxADDR.Name = "textBoxADDR";
            this.textBoxADDR.ReadOnly = true;
            this.textBoxADDR.Size = new System.Drawing.Size(100, 20);
            this.textBoxADDR.TabIndex = 0;
            // 
            // STEP
            // 
            this.STEP.Location = new System.Drawing.Point(341, 233);
            this.STEP.Name = "STEP";
            this.STEP.Size = new System.Drawing.Size(75, 23);
            this.STEP.TabIndex = 1;
            this.STEP.Text = "STEP";
            this.STEP.UseVisualStyleBackColor = true;
            this.STEP.Click += new System.EventHandler(this.STEP_Click);
            // 
            // MEM
            // 
            this.MEM.Location = new System.Drawing.Point(341, 135);
            this.MEM.Name = "MEM";
            this.MEM.Size = new System.Drawing.Size(75, 23);
            this.MEM.TabIndex = 2;
            this.MEM.Text = "MEM";
            this.MEM.UseVisualStyleBackColor = true;
            this.MEM.Click += new System.EventHandler(this.MEM_Click);
            // 
            // NEXT
            // 
            this.NEXT.Location = new System.Drawing.Point(341, 283);
            this.NEXT.Name = "NEXT";
            this.NEXT.Size = new System.Drawing.Size(75, 23);
            this.NEXT.TabIndex = 3;
            this.NEXT.Text = "NEXT";
            this.NEXT.UseVisualStyleBackColor = true;
            this.NEXT.Click += new System.EventHandler(this.NEXT_Click);
            // 
            // ADDR
            // 
            this.ADDR.Location = new System.Drawing.Point(341, 163);
            this.ADDR.Name = "ADDR";
            this.ADDR.Size = new System.Drawing.Size(75, 23);
            this.ADDR.TabIndex = 4;
            this.ADDR.Text = "ADDR";
            this.ADDR.UseVisualStyleBackColor = true;
            this.ADDR.Click += new System.EventHandler(this.ADDR_Click);
            // 
            // textBoxREG
            // 
            this.textBoxREG.Location = new System.Drawing.Point(277, 36);
            this.textBoxREG.Name = "textBoxREG";
            this.textBoxREG.ReadOnly = true;
            this.textBoxREG.Size = new System.Drawing.Size(58, 20);
            this.textBoxREG.TabIndex = 5;
            // 
            // textBoxMEM
            // 
            this.textBoxMEM.Location = new System.Drawing.Point(342, 36);
            this.textBoxMEM.Name = "textBoxMEM";
            this.textBoxMEM.ReadOnly = true;
            this.textBoxMEM.Size = new System.Drawing.Size(54, 20);
            this.textBoxMEM.TabIndex = 6;
            // 
            // REG
            // 
            this.REG.Location = new System.Drawing.Point(341, 106);
            this.REG.Name = "REG";
            this.REG.Size = new System.Drawing.Size(75, 23);
            this.REG.TabIndex = 7;
            this.REG.Text = "REG";
            this.REG.UseVisualStyleBackColor = true;
            this.REG.Click += new System.EventHandler(this.REG_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(24, 106);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(50, 50);
            this.buttonC.TabIndex = 8;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonD.ForeColor = System.Drawing.Color.White;
            this.buttonD.Location = new System.Drawing.Point(74, 106);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(50, 50);
            this.buttonD.TabIndex = 9;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonE.ForeColor = System.Drawing.Color.White;
            this.buttonE.Location = new System.Drawing.Point(124, 106);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(50, 50);
            this.buttonE.TabIndex = 10;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.Green;
            this.buttonF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonF.ForeColor = System.Drawing.Color.White;
            this.buttonF.Location = new System.Drawing.Point(174, 106);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(50, 50);
            this.buttonF.TabIndex = 11;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = false;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(24, 156);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 12;
            this.button8.Text = "8/H";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(74, 156);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 13;
            this.button9.Text = "9/L";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(124, 156);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(50, 50);
            this.buttonA.TabIndex = 14;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonB.ForeColor = System.Drawing.Color.White;
            this.buttonB.Location = new System.Drawing.Point(174, 156);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(50, 50);
            this.buttonB.TabIndex = 15;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 17;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(124, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 18;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(174, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 19;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(24, 256);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 20;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "1/P";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 22;
            this.button2.Text = "2/T";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 23;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CLR
            // 
            this.CLR.Location = new System.Drawing.Point(260, 106);
            this.CLR.Name = "CLR";
            this.CLR.Size = new System.Drawing.Size(75, 23);
            this.CLR.TabIndex = 26;
            this.CLR.Text = "CLR";
            this.CLR.UseVisualStyleBackColor = true;
            // 
            // RST
            // 
            this.RST.Location = new System.Drawing.Point(260, 135);
            this.RST.Name = "RST";
            this.RST.Size = new System.Drawing.Size(75, 23);
            this.RST.TabIndex = 27;
            this.RST.Text = "RST";
            this.RST.UseVisualStyleBackColor = true;
            // 
            // BRK
            // 
            this.BRK.Location = new System.Drawing.Point(260, 164);
            this.BRK.Name = "BRK";
            this.BRK.Size = new System.Drawing.Size(75, 23);
            this.BRK.TabIndex = 28;
            this.BRK.Text = "BRK";
            this.BRK.UseVisualStyleBackColor = true;
            // 
            // RUN
            // 
            this.RUN.Location = new System.Drawing.Point(260, 233);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(75, 23);
            this.RUN.TabIndex = 29;
            this.RUN.Text = "RUN";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            // 
            // CYlabel
            // 
            this.CYlabel.AutoSize = true;
            this.CYlabel.Location = new System.Drawing.Point(27, 43);
            this.CYlabel.Name = "CYlabel";
            this.CYlabel.Size = new System.Drawing.Size(21, 13);
            this.CYlabel.TabIndex = 32;
            this.CYlabel.Text = "CY";
            // 
            // Zlabel
            // 
            this.Zlabel.AutoSize = true;
            this.Zlabel.Location = new System.Drawing.Point(34, 69);
            this.Zlabel.Name = "Zlabel";
            this.Zlabel.Size = new System.Drawing.Size(14, 13);
            this.Zlabel.TabIndex = 33;
            this.Zlabel.Text = "Z";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаМнемокодовToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.примерыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // таблицаМнемокодовToolStripMenuItem
            // 
            this.таблицаМнемокодовToolStripMenuItem.Name = "таблицаМнемокодовToolStripMenuItem";
            this.таблицаМнемокодовToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.таблицаМнемокодовToolStripMenuItem.Text = "Таблица команд";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // примерыToolStripMenuItem
            // 
            this.примерыToolStripMenuItem.Name = "примерыToolStripMenuItem";
            this.примерыToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.примерыToolStripMenuItem.Text = "Примеры";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // pictureBoxZ
            // 
            this.pictureBoxZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxZ.BackgroundImage")));
            this.pictureBoxZ.Location = new System.Drawing.Point(54, 62);
            this.pictureBoxZ.Name = "pictureBoxZ";
            this.pictureBoxZ.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxZ.TabIndex = 31;
            this.pictureBoxZ.TabStop = false;
            // 
            // pictureBoxCY
            // 
            this.pictureBoxCY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCY.BackgroundImage")));
            this.pictureBoxCY.Location = new System.Drawing.Point(54, 36);
            this.pictureBoxCY.Name = "pictureBoxCY";
            this.pictureBoxCY.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCY.TabIndex = 30;
            this.pictureBoxCY.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Электроника.Properties.Resources.kstu;
            this.ClientSize = new System.Drawing.Size(425, 376);
            this.Controls.Add(this.Zlabel);
            this.Controls.Add(this.CYlabel);
            this.Controls.Add(this.pictureBoxZ);
            this.Controls.Add(this.pictureBoxCY);
            this.Controls.Add(this.RUN);
            this.Controls.Add(this.BRK);
            this.Controls.Add(this.RST);
            this.Controls.Add(this.CLR);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.REG);
            this.Controls.Add(this.textBoxMEM);
            this.Controls.Add(this.textBoxREG);
            this.Controls.Add(this.ADDR);
            this.Controls.Add(this.NEXT);
            this.Controls.Add(this.MEM);
            this.Controls.Add(this.STEP);
            this.Controls.Add(this.textBoxADDR);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Электроника-580";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxADDR;
        private System.Windows.Forms.Button STEP;
        private System.Windows.Forms.Button MEM;
        private System.Windows.Forms.Button NEXT;
        private System.Windows.Forms.Button ADDR;
        private System.Windows.Forms.TextBox textBoxREG;
        private System.Windows.Forms.TextBox textBoxMEM;
        private System.Windows.Forms.Button REG;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CLR;
        private System.Windows.Forms.Button RST;
        private System.Windows.Forms.Button BRK;
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.PictureBox pictureBoxCY;
        private System.Windows.Forms.PictureBox pictureBoxZ;
        private System.Windows.Forms.Label CYlabel;
        private System.Windows.Forms.Label Zlabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаМнемокодовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem примерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

