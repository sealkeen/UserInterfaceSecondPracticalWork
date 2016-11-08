namespace HumanCarInterfaceLaba2
{
    partial class frmReversed
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSmplf = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.numB = new HumanCarInterfaceLaba2.IntNumeric();
            this.numA = new HumanCarInterfaceLaba2.IntNumeric();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripFirstLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutput.Location = new System.Drawing.Point(12, 75);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(80, 26);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Вывод";
            this.tipHelp.SetToolTip(this.lblOutput, "Обратное комплексное число");
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInput.Location = new System.Drawing.Point(12, 24);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(64, 26);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Ввод";
            this.tipHelp.SetToolTip(this.lblInput, "Исходное число, которое Вы вводите в числовые поля");
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReverse.Location = new System.Drawing.Point(267, 133);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(119, 23);
            this.btnReverse.TabIndex = 3;
            this.btnReverse.Text = "Обратить";
            this.tipHelp.SetToolTip(this.btnReverse, "Найти обратное комплексное число");
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnSmplf
            // 
            this.btnSmplf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSmplf.Location = new System.Drawing.Point(267, 159);
            this.btnSmplf.Name = "btnSmplf";
            this.btnSmplf.Size = new System.Drawing.Size(119, 23);
            this.btnSmplf.TabIndex = 4;
            this.btnSmplf.Text = "Упростить";
            this.tipHelp.SetToolTip(this.btnSmplf, "Попытаться упростить дробь");
            this.btnSmplf.UseVisualStyleBackColor = true;
            this.btnSmplf.Click += new System.EventHandler(this.btnSmplf_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Помощь";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tipHelp
            // 
            this.tipHelp.AutomaticDelay = 100;
            this.tipHelp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipHelp.ToolTipTitle = "Подсказка";
            this.tipHelp.UseAnimation = false;
            this.tipHelp.UseFading = false;
            // 
            // numB
            // 
            this.numB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numB.DecimalPlaces = 1;
            this.numB.Location = new System.Drawing.Point(142, 162);
            this.numB.Maximum = new decimal(new int[] {
            -1539607553,
            11,
            0,
            0});
            this.numB.Minimum = new decimal(new int[] {
            -1539607553,
            11,
            0,
            -2147483648});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(119, 20);
            this.numB.TabIndex = 0;
            this.tipHelp.SetToolTip(this.numB, "Значение от -49999999999.0 до 49999999999.0");
            this.numB.Val = 10D;
            this.numB.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numB.ValueChanged += new System.EventHandler(this.numB_ValueChanged);
            // 
            // numA
            // 
            this.numA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numA.DecimalPlaces = 1;
            this.numA.Location = new System.Drawing.Point(12, 162);
            this.numA.Maximum = new decimal(new int[] {
            -1539607553,
            11,
            0,
            0});
            this.numA.Minimum = new decimal(new int[] {
            -1539607553,
            11,
            0,
            -2147483648});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(119, 20);
            this.numA.TabIndex = 0;
            this.tipHelp.SetToolTip(this.numA, "Значение от -49999999999.0 до 49999999999.0");
            this.numA.Val = 10D;
            this.numA.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numA.ValueChanged += new System.EventHandler(this.numA_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFirstLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(394, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripFirstLabel
            // 
            this.toolStripFirstLabel.Name = "toolStripFirstLabel";
            this.toolStripFirstLabel.Size = new System.Drawing.Size(230, 17);
            this.toolStripFirstLabel.Text = "Никаких действий не предпринималось.";
            // 
            // frmReversed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 211);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSmplf);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(700, 300);
            this.MinimumSize = new System.Drawing.Size(410, 250);
            this.Name = "frmReversed";
            this.Text = "Обратное комплексное число";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntNumeric numA;
        private IntNumeric numB;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSmplf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFirstLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

