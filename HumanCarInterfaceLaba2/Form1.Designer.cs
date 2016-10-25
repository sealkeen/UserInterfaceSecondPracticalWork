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
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSmplf = new System.Windows.Forms.Button();
            this.numB = new HumanCarInterfaceLaba2.IntNumeric();
            this.numA = new HumanCarInterfaceLaba2.IntNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutput.Location = new System.Drawing.Point(137, 73);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(77, 26);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Output";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInput.Location = new System.Drawing.Point(137, 26);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(60, 26);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(12, 77);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(119, 23);
            this.btnReverse.TabIndex = 3;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnSmplf
            // 
            this.btnSmplf.Location = new System.Drawing.Point(12, 106);
            this.btnSmplf.Name = "btnSmplf";
            this.btnSmplf.Size = new System.Drawing.Size(119, 23);
            this.btnSmplf.TabIndex = 4;
            this.btnSmplf.Text = "Simplify";
            this.btnSmplf.UseVisualStyleBackColor = true;
            this.btnSmplf.Click += new System.EventHandler(this.btnSmplf_Click);
            // 
            // numB
            // 
            this.numB.DecimalPlaces = 1;
            this.numB.Location = new System.Drawing.Point(12, 42);
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
            this.numA.DecimalPlaces = 1;
            this.numA.Location = new System.Drawing.Point(12, 12);
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
            this.numA.Val = 10D;
            this.numA.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numA.ValueChanged += new System.EventHandler(this.numA_ValueChanged);
            // 
            // frmReversed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 158);
            this.Controls.Add(this.btnSmplf);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.MaximumSize = new System.Drawing.Size(700, 300);
            this.Name = "frmReversed";
            this.Text = "Reversed Complex Number";
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
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
    }
}

