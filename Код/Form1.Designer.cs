namespace GeekBrains
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Date = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Load = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Zero = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Powt = new System.Windows.Forms.CheckBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.NumRand = new System.Windows.Forms.TextBox();
            this.Result1 = new System.Windows.Forms.Label();
            this.Gener = new System.Windows.Forms.Button();
            this.Do = new System.Windows.Forms.NumericUpDown();
            this.Ot = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Blocknot = new System.Windows.Forms.TabPage();
            this.NotePad = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BCopy = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.BuildPas = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.bConvert = new System.Windows.Forms.Button();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.bSwap = new System.Windows.Forms.Button();
            this.cbMetrics = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Do)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ot)).BeginInit();
            this.Blocknot.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.блокнотToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Date,
            this.Time,
            this.toolStripMenuItem1,
            this.Save,
            this.Load});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // Date
            // 
            this.Date.Name = "Date";
            this.Date.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.Date.Size = new System.Drawing.Size(200, 22);
            this.Date.Text = "Вставить дату";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // Time
            // 
            this.Time.Name = "Time";
            this.Time.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.Time.Size = new System.Drawing.Size(200, 22);
            this.Time.Text = "Вставить время";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 6);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(200, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Name = "Load";
            this.Load.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.Load.Size = new System.Drawing.Size(200, 22);
            this.Load.Text = "Загрузить";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Blocknot);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 238);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Zero);
            this.tabPage1.Controls.Add(this.Result);
            this.tabPage1.Controls.Add(this.Minus);
            this.tabPage1.Controls.Add(this.Plus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счетчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zero.Location = new System.Drawing.Point(156, 90);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(75, 23);
            this.Zero.TabIndex = 3;
            this.Zero.Text = "Сброс";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(58, 90);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(16, 16);
            this.Result.TabIndex = 2;
            this.Result.Text = "0";
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(58, 144);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 23);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(58, 33);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 23);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Powt);
            this.tabPage2.Controls.Add(this.Copy);
            this.tabPage2.Controls.Add(this.Clear);
            this.tabPage2.Controls.Add(this.NumRand);
            this.tabPage2.Controls.Add(this.Result1);
            this.tabPage2.Controls.Add(this.Gener);
            this.tabPage2.Controls.Add(this.Do);
            this.tabPage2.Controls.Add(this.Ot);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Powt
            // 
            this.Powt.AutoSize = true;
            this.Powt.Location = new System.Drawing.Point(32, 178);
            this.Powt.Name = "Powt";
            this.Powt.Size = new System.Drawing.Size(106, 17);
            this.Powt.TabIndex = 9;
            this.Powt.Text = "без повторений";
            this.Powt.UseVisualStyleBackColor = true;
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(32, 137);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 23);
            this.Copy.TabIndex = 8;
            this.Copy.Text = "Копировать";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(32, 98);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // NumRand
            // 
            this.NumRand.Location = new System.Drawing.Point(144, 100);
            this.NumRand.Multiline = true;
            this.NumRand.Name = "NumRand";
            this.NumRand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NumRand.Size = new System.Drawing.Size(86, 95);
            this.NumRand.TabIndex = 6;
            // 
            // Result1
            // 
            this.Result1.AutoSize = true;
            this.Result1.Location = new System.Drawing.Point(144, 62);
            this.Result1.Name = "Result1";
            this.Result1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Result1.Size = new System.Drawing.Size(13, 13);
            this.Result1.TabIndex = 5;
            this.Result1.Text = "0";
            this.Result1.Click += new System.EventHandler(this.Result1_Click);
            // 
            // Gener
            // 
            this.Gener.Location = new System.Drawing.Point(144, 22);
            this.Gener.Name = "Gener";
            this.Gener.Size = new System.Drawing.Size(86, 23);
            this.Gener.TabIndex = 4;
            this.Gener.Text = "Генерировать";
            this.Gener.UseVisualStyleBackColor = true;
            this.Gener.Click += new System.EventHandler(this.Gener_Click);
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(65, 56);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(53, 20);
            this.Do.TabIndex = 3;
            // 
            // Ot
            // 
            this.Ot.Location = new System.Drawing.Point(65, 22);
            this.Ot.Name = "Ot";
            this.Ot.Size = new System.Drawing.Size(53, 20);
            this.Ot.TabIndex = 2;
            this.Ot.ValueChanged += new System.EventHandler(this.Ot_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "От";
            // 
            // Blocknot
            // 
            this.Blocknot.Controls.Add(this.NotePad);
            this.Blocknot.Location = new System.Drawing.Point(4, 22);
            this.Blocknot.Name = "Blocknot";
            this.Blocknot.Size = new System.Drawing.Size(276, 212);
            this.Blocknot.TabIndex = 2;
            this.Blocknot.Text = "Блокнот";
            this.Blocknot.UseVisualStyleBackColor = true;
            // 
            // NotePad
            // 
            this.NotePad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotePad.Location = new System.Drawing.Point(0, 0);
            this.NotePad.Name = "NotePad";
            this.NotePad.Size = new System.Drawing.Size(276, 212);
            this.NotePad.TabIndex = 0;
            this.NotePad.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BCopy);
            this.tabPage3.Controls.Add(this.tbPass);
            this.tabPage3.Controls.Add(this.BuildPas);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.checkedListBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(276, 212);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Пароли";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BCopy
            // 
            this.BCopy.Location = new System.Drawing.Point(8, 168);
            this.BCopy.Name = "BCopy";
            this.BCopy.Size = new System.Drawing.Size(126, 23);
            this.BCopy.TabIndex = 5;
            this.BCopy.Text = "Копировать пароль";
            this.BCopy.UseVisualStyleBackColor = true;
            this.BCopy.Click += new System.EventHandler(this.BCopy_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(11, 142);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(198, 20);
            this.tbPass.TabIndex = 4;
            // 
            // BuildPas
            // 
            this.BuildPas.Location = new System.Drawing.Point(11, 113);
            this.BuildPas.Name = "BuildPas";
            this.BuildPas.Size = new System.Drawing.Size(107, 23);
            this.BuildPas.TabIndex = 3;
            this.BuildPas.Text = "Создать пароль";
            this.BuildPas.UseVisualStyleBackColor = true;
            this.BuildPas.Click += new System.EventHandler(this.BuildPas_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(121, 82);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Длина пароля:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Специальные символы: %, $,&,^,*,_,-,#,@"});
            this.checkedListBox1.Location = new System.Drawing.Point(8, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(239, 64);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbMetrics);
            this.tabPage4.Controls.Add(this.bSwap);
            this.tabPage4.Controls.Add(this.tbTo);
            this.tabPage4.Controls.Add(this.tbFrom);
            this.tabPage4.Controls.Add(this.bConvert);
            this.tabPage4.Controls.Add(this.cbTo);
            this.tabPage4.Controls.Add(this.cbFrom);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(276, 212);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Конвертер";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(180, 82);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(85, 20);
            this.tbTo.TabIndex = 4;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(5, 82);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(80, 20);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "1";
            // 
            // bConvert
            // 
            this.bConvert.Location = new System.Drawing.Point(91, 79);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(83, 23);
            this.bConvert.TabIndex = 2;
            this.bConvert.Text = "Конверт";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbTo.Location = new System.Drawing.Point(180, 47);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(85, 21);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "mm";
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(5, 47);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(80, 21);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "mm";
            // 
            // bSwap
            // 
            this.bSwap.Location = new System.Drawing.Point(91, 47);
            this.bSwap.Name = "bSwap";
            this.bSwap.Size = new System.Drawing.Size(83, 23);
            this.bSwap.TabIndex = 5;
            this.bSwap.Text = "<->";
            this.bSwap.UseVisualStyleBackColor = true;
            this.bSwap.Click += new System.EventHandler(this.bSwap_Click);
            // 
            // cbMetrics
            // 
            this.cbMetrics.FormattingEnabled = true;
            this.cbMetrics.Items.AddRange(new object[] {
            "длина",
            "вес"});
            this.cbMetrics.Location = new System.Drawing.Point(91, 20);
            this.cbMetrics.Name = "cbMetrics";
            this.cbMetrics.Size = new System.Drawing.Size(83, 21);
            this.cbMetrics.TabIndex = 6;
            this.cbMetrics.Text = "длина";
            this.cbMetrics.SelectedIndexChanged += new System.EventHandler(this.cbMetrics_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Мини-программы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Do)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ot)).EndInit();
            this.Blocknot.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Result1;
        private System.Windows.Forms.Button Gener;
        private System.Windows.Forms.NumericUpDown Do;
        private System.Windows.Forms.NumericUpDown Ot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumRand;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.CheckBox Powt;
        private System.Windows.Forms.TabPage Blocknot;
        private System.Windows.Forms.RichTextBox NotePad;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Date;
        private System.Windows.Forms.ToolStripMenuItem Time;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Load;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button BuildPas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button BCopy;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button bSwap;
        private System.Windows.Forms.ComboBox cbMetrics;
    }
}

