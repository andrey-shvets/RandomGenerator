namespace RandomGenerator
{
    partial class MainForm
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
            this.lessCheckBox = new System.Windows.Forms.CheckBox();
            this.moreCheckBox = new System.Windows.Forms.CheckBox();
            this.dividedByTenCheckBox = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fillButton = new System.Windows.Forms.Button();
            this.secondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.firstNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numbersGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lessCheckBox
            // 
            this.lessCheckBox.AutoSize = true;
            this.lessCheckBox.Location = new System.Drawing.Point(160, 8);
            this.lessCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lessCheckBox.Name = "lessCheckBox";
            this.lessCheckBox.Size = new System.Drawing.Size(47, 17);
            this.lessCheckBox.TabIndex = 0;
            this.lessCheckBox.Text = "< 50";
            this.lessCheckBox.UseVisualStyleBackColor = true;
            this.lessCheckBox.CheckedChanged += new System.EventHandler(this.lessCheckBox_CheckedChanged);
            // 
            // moreCheckBox
            // 
            this.moreCheckBox.AutoSize = true;
            this.moreCheckBox.Location = new System.Drawing.Point(160, 27);
            this.moreCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moreCheckBox.Name = "moreCheckBox";
            this.moreCheckBox.Size = new System.Drawing.Size(47, 17);
            this.moreCheckBox.TabIndex = 1;
            this.moreCheckBox.Text = "> 70";
            this.moreCheckBox.UseVisualStyleBackColor = true;
            this.moreCheckBox.CheckedChanged += new System.EventHandler(this.moreCheckBox_CheckedChanged);
            // 
            // dividedByTenCheckBox
            // 
            this.dividedByTenCheckBox.AutoSize = true;
            this.dividedByTenCheckBox.Location = new System.Drawing.Point(160, 47);
            this.dividedByTenCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dividedByTenCheckBox.Name = "dividedByTenCheckBox";
            this.dividedByTenCheckBox.Size = new System.Drawing.Size(43, 17);
            this.dividedByTenCheckBox.TabIndex = 2;
            this.dividedByTenCheckBox.Text = "| 10";
            this.dividedByTenCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(160, 66);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(70, 25);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(8, 29);
            this.widthNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.widthNumericUpDown.TabIndex = 4;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(8, 8);
            this.heightNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.heightNumericUpDown.TabIndex = 5;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(8, 112);
            this.fillButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(70, 25);
            this.fillButton.TabIndex = 6;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // secondNumericUpDown
            // 
            this.secondNumericUpDown.Location = new System.Drawing.Point(8, 87);
            this.secondNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.secondNumericUpDown.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.secondNumericUpDown.Name = "secondNumericUpDown";
            this.secondNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.secondNumericUpDown.TabIndex = 8;
            this.secondNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // firstNumericUpDown
            // 
            this.firstNumericUpDown.Location = new System.Drawing.Point(8, 66);
            this.firstNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.firstNumericUpDown.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.firstNumericUpDown.Name = "firstNumericUpDown";
            this.firstNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.firstNumericUpDown.TabIndex = 7;
            this.firstNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            // 
            // numbersGroupBox
            // 
            this.numbersGroupBox.Location = new System.Drawing.Point(12, 142);
            this.numbersGroupBox.Name = "numbersGroupBox";
            this.numbersGroupBox.Size = new System.Drawing.Size(660, 307);
            this.numbersGroupBox.TabIndex = 9;
            this.numbersGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.numbersGroupBox);
            this.Controls.Add(this.secondNumericUpDown);
            this.Controls.Add(this.firstNumericUpDown);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.heightNumericUpDown);
            this.Controls.Add(this.widthNumericUpDown);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.dividedByTenCheckBox);
            this.Controls.Add(this.moreCheckBox);
            this.Controls.Add(this.lessCheckBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lessCheckBox;
        private System.Windows.Forms.CheckBox moreCheckBox;
        private System.Windows.Forms.CheckBox dividedByTenCheckBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.NumericUpDown secondNumericUpDown;
        private System.Windows.Forms.NumericUpDown firstNumericUpDown;
        private System.Windows.Forms.GroupBox numbersGroupBox;
    }
}

