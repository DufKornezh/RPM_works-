namespace MATRIXCALCULATOR
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.matrixAgroupBox = new System.Windows.Forms.GroupBox();
            this.RandomA = new System.Windows.Forms.Button();
            this.ColumnCounterNumericA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.RowCounetNumericA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.matrixA = new System.Windows.Forms.DataGridView();
            this.matrixBgroupBox = new System.Windows.Forms.GroupBox();
            this.RandomB = new System.Windows.Forms.Button();
            this.ColumnCounterNumericB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RowCounetNumericB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.matrixB = new System.Windows.Forms.DataGridView();
            this.buttonCopyToBottom = new System.Windows.Forms.Button();
            this.buttonCopyToUpper = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMatrixMultiply = new System.Windows.Forms.Button();
            this.buttonMatrixSubt = new System.Windows.Forms.Button();
            this.buttonMatrixSum = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MultiplicatorNumeric = new System.Windows.Forms.NumericUpDown();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonElementMinor = new System.Windows.Forms.Button();
            this.buttonDeterminant = new System.Windows.Forms.Button();
            this.buttonMatrixRang = new System.Windows.Forms.Button();
            this.buttonTranspose = new System.Windows.Forms.Button();
            this.buttonReversedMatrix = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultMatrix = new System.Windows.Forms.DataGridView();
            this.buttonCopyResultToB = new System.Windows.Forms.Button();
            this.matrixAgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCounterNumericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCounetNumericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).BeginInit();
            this.matrixBgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCounterNumericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCounetNumericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplicatorNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixAgroupBox
            // 
            this.matrixAgroupBox.Controls.Add(this.RandomA);
            this.matrixAgroupBox.Controls.Add(this.ColumnCounterNumericA);
            this.matrixAgroupBox.Controls.Add(this.label2);
            this.matrixAgroupBox.Controls.Add(this.RowCounetNumericA);
            this.matrixAgroupBox.Controls.Add(this.label1);
            this.matrixAgroupBox.Controls.Add(this.matrixA);
            this.matrixAgroupBox.Location = new System.Drawing.Point(12, 12);
            this.matrixAgroupBox.Name = "matrixAgroupBox";
            this.matrixAgroupBox.Size = new System.Drawing.Size(490, 300);
            this.matrixAgroupBox.TabIndex = 0;
            this.matrixAgroupBox.TabStop = false;
            this.matrixAgroupBox.Text = "Матрица А";
            // 
            // RandomA
            // 
            this.RandomA.Location = new System.Drawing.Point(383, 14);
            this.RandomA.Name = "RandomA";
            this.RandomA.Size = new System.Drawing.Size(93, 21);
            this.RandomA.TabIndex = 5;
            this.RandomA.Text = "Рандом";
            this.RandomA.UseVisualStyleBackColor = true;
            this.RandomA.Click += new System.EventHandler(this.RandomA_Click);
            // 
            // ColumnCounterNumericA
            // 
            this.ColumnCounterNumericA.Location = new System.Drawing.Point(341, 16);
            this.ColumnCounterNumericA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ColumnCounterNumericA.Name = "ColumnCounterNumericA";
            this.ColumnCounterNumericA.Size = new System.Drawing.Size(36, 20);
            this.ColumnCounterNumericA.TabIndex = 4;
            this.ColumnCounterNumericA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ColumnCounterNumericA.ValueChanged += new System.EventHandler(this.ColumnCounterNumericA_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(275, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Столбцов:";
            // 
            // RowCounetNumericA
            // 
            this.RowCounetNumericA.Location = new System.Drawing.Point(218, 16);
            this.RowCounetNumericA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RowCounetNumericA.Name = "RowCounetNumericA";
            this.RowCounetNumericA.Size = new System.Drawing.Size(36, 20);
            this.RowCounetNumericA.TabIndex = 2;
            this.RowCounetNumericA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RowCounetNumericA.ValueChanged += new System.EventHandler(this.RowCounetNumericA_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(152, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Строк:";
            // 
            // matrixA
            // 
            this.matrixA.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixA.ColumnHeadersVisible = false;
            this.matrixA.Location = new System.Drawing.Point(6, 42);
            this.matrixA.Name = "matrixA";
            this.matrixA.RowHeadersVisible = false;
            this.matrixA.Size = new System.Drawing.Size(478, 252);
            this.matrixA.TabIndex = 0;
            // 
            // matrixBgroupBox
            // 
            this.matrixBgroupBox.Controls.Add(this.RandomB);
            this.matrixBgroupBox.Controls.Add(this.ColumnCounterNumericB);
            this.matrixBgroupBox.Controls.Add(this.label3);
            this.matrixBgroupBox.Controls.Add(this.RowCounetNumericB);
            this.matrixBgroupBox.Controls.Add(this.label4);
            this.matrixBgroupBox.Controls.Add(this.matrixB);
            this.matrixBgroupBox.Location = new System.Drawing.Point(12, 362);
            this.matrixBgroupBox.Name = "matrixBgroupBox";
            this.matrixBgroupBox.Size = new System.Drawing.Size(490, 300);
            this.matrixBgroupBox.TabIndex = 1;
            this.matrixBgroupBox.TabStop = false;
            this.matrixBgroupBox.Text = "Матрица B";
            // 
            // RandomB
            // 
            this.RandomB.Location = new System.Drawing.Point(383, 16);
            this.RandomB.Name = "RandomB";
            this.RandomB.Size = new System.Drawing.Size(93, 21);
            this.RandomB.TabIndex = 6;
            this.RandomB.Text = "Рандом";
            this.RandomB.UseVisualStyleBackColor = true;
            this.RandomB.Click += new System.EventHandler(this.RandomB_Click);
            // 
            // ColumnCounterNumericB
            // 
            this.ColumnCounterNumericB.Location = new System.Drawing.Point(341, 16);
            this.ColumnCounterNumericB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ColumnCounterNumericB.Name = "ColumnCounterNumericB";
            this.ColumnCounterNumericB.Size = new System.Drawing.Size(36, 20);
            this.ColumnCounterNumericB.TabIndex = 9;
            this.ColumnCounterNumericB.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ColumnCounterNumericB.ValueChanged += new System.EventHandler(this.ColumnCounterNumericB_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(275, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Столбцов:";
            // 
            // RowCounetNumericB
            // 
            this.RowCounetNumericB.Location = new System.Drawing.Point(218, 14);
            this.RowCounetNumericB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RowCounetNumericB.Name = "RowCounetNumericB";
            this.RowCounetNumericB.Size = new System.Drawing.Size(36, 20);
            this.RowCounetNumericB.TabIndex = 7;
            this.RowCounetNumericB.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RowCounetNumericB.ValueChanged += new System.EventHandler(this.RowCounetNumericB_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(152, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Строк:";
            // 
            // matrixB
            // 
            this.matrixB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixB.ColumnHeadersVisible = false;
            this.matrixB.Location = new System.Drawing.Point(6, 42);
            this.matrixB.Name = "matrixB";
            this.matrixB.RowHeadersVisible = false;
            this.matrixB.Size = new System.Drawing.Size(478, 252);
            this.matrixB.TabIndex = 5;
            // 
            // buttonCopyToBottom
            // 
            this.buttonCopyToBottom.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyToBottom.Image")));
            this.buttonCopyToBottom.Location = new System.Drawing.Point(96, 318);
            this.buttonCopyToBottom.Name = "buttonCopyToBottom";
            this.buttonCopyToBottom.Size = new System.Drawing.Size(40, 38);
            this.buttonCopyToBottom.TabIndex = 2;
            this.buttonCopyToBottom.UseVisualStyleBackColor = true;
            this.buttonCopyToBottom.Click += new System.EventHandler(this.buttonCopyToBottom_Click);
            // 
            // buttonCopyToUpper
            // 
            this.buttonCopyToUpper.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyToUpper.Image")));
            this.buttonCopyToUpper.Location = new System.Drawing.Point(349, 318);
            this.buttonCopyToUpper.Name = "buttonCopyToUpper";
            this.buttonCopyToUpper.Size = new System.Drawing.Size(40, 38);
            this.buttonCopyToUpper.TabIndex = 3;
            this.buttonCopyToUpper.UseVisualStyleBackColor = true;
            this.buttonCopyToUpper.Click += new System.EventHandler(this.buttonCopyToUpper_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMatrixMultiply);
            this.groupBox1.Controls.Add(this.buttonMatrixSubt);
            this.groupBox1.Controls.Add(this.buttonMatrixSum);
            this.groupBox1.Location = new System.Drawing.Point(523, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции над матрицами A и B";
            // 
            // buttonMatrixMultiply
            // 
            this.buttonMatrixMultiply.Location = new System.Drawing.Point(296, 21);
            this.buttonMatrixMultiply.Name = "buttonMatrixMultiply";
            this.buttonMatrixMultiply.Size = new System.Drawing.Size(145, 42);
            this.buttonMatrixMultiply.TabIndex = 2;
            this.buttonMatrixMultiply.Text = "Умножение матриц";
            this.buttonMatrixMultiply.UseVisualStyleBackColor = true;
            this.buttonMatrixMultiply.Click += new System.EventHandler(this.buttonMatrixMultiply_Click);
            // 
            // buttonMatrixSubt
            // 
            this.buttonMatrixSubt.Location = new System.Drawing.Point(157, 21);
            this.buttonMatrixSubt.Name = "buttonMatrixSubt";
            this.buttonMatrixSubt.Size = new System.Drawing.Size(133, 42);
            this.buttonMatrixSubt.TabIndex = 1;
            this.buttonMatrixSubt.Text = "Вычитание матриц";
            this.buttonMatrixSubt.UseVisualStyleBackColor = true;
            this.buttonMatrixSubt.Click += new System.EventHandler(this.buttonMatrixSubt_Click);
            // 
            // buttonMatrixSum
            // 
            this.buttonMatrixSum.Location = new System.Drawing.Point(6, 21);
            this.buttonMatrixSum.Name = "buttonMatrixSum";
            this.buttonMatrixSum.Size = new System.Drawing.Size(145, 42);
            this.buttonMatrixSum.TabIndex = 0;
            this.buttonMatrixSum.Text = "Сложение матриц";
            this.buttonMatrixSum.UseVisualStyleBackColor = true;
            this.buttonMatrixSum.Click += new System.EventHandler(this.buttonMatrixSum_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.MultiplicatorNumeric);
            this.groupBox2.Controls.Add(this.buttonTimes);
            this.groupBox2.Controls.Add(this.buttonElementMinor);
            this.groupBox2.Controls.Add(this.buttonDeterminant);
            this.groupBox2.Controls.Add(this.buttonMatrixRang);
            this.groupBox2.Controls.Add(this.buttonTranspose);
            this.groupBox2.Controls.Add(this.buttonReversedMatrix);
            this.groupBox2.Location = new System.Drawing.Point(523, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции над матрицей A ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(293, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Множитель:";
            // 
            // MultiplicatorNumeric
            // 
            this.MultiplicatorNumeric.Location = new System.Drawing.Point(369, 113);
            this.MultiplicatorNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.MultiplicatorNumeric.Name = "MultiplicatorNumeric";
            this.MultiplicatorNumeric.Size = new System.Drawing.Size(71, 20);
            this.MultiplicatorNumeric.TabIndex = 9;
            // 
            // buttonTimes
            // 
            this.buttonTimes.Location = new System.Drawing.Point(296, 67);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(145, 42);
            this.buttonTimes.TabIndex = 8;
            this.buttonTimes.Text = "Умножить на число";
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this.buttonTimes_Click);
            // 
            // buttonElementMinor
            // 
            this.buttonElementMinor.Location = new System.Drawing.Point(157, 67);
            this.buttonElementMinor.Name = "buttonElementMinor";
            this.buttonElementMinor.Size = new System.Drawing.Size(133, 42);
            this.buttonElementMinor.TabIndex = 7;
            this.buttonElementMinor.Text = "Минор элемента";
            this.buttonElementMinor.UseVisualStyleBackColor = true;
            this.buttonElementMinor.Click += new System.EventHandler(this.buttonElementMinor_Click);
            // 
            // buttonDeterminant
            // 
            this.buttonDeterminant.Location = new System.Drawing.Point(6, 67);
            this.buttonDeterminant.Name = "buttonDeterminant";
            this.buttonDeterminant.Size = new System.Drawing.Size(145, 42);
            this.buttonDeterminant.TabIndex = 6;
            this.buttonDeterminant.Text = "Определитель";
            this.buttonDeterminant.UseVisualStyleBackColor = true;
            this.buttonDeterminant.Click += new System.EventHandler(this.buttonDeterminant_Click);
            // 
            // buttonMatrixRang
            // 
            this.buttonMatrixRang.Location = new System.Drawing.Point(296, 19);
            this.buttonMatrixRang.Name = "buttonMatrixRang";
            this.buttonMatrixRang.Size = new System.Drawing.Size(145, 42);
            this.buttonMatrixRang.TabIndex = 5;
            this.buttonMatrixRang.Text = "Ранг матрицы";
            this.buttonMatrixRang.UseVisualStyleBackColor = true;
            this.buttonMatrixRang.Click += new System.EventHandler(this.buttonMatrixRang_Click);
            // 
            // buttonTranspose
            // 
            this.buttonTranspose.Location = new System.Drawing.Point(157, 19);
            this.buttonTranspose.Name = "buttonTranspose";
            this.buttonTranspose.Size = new System.Drawing.Size(133, 42);
            this.buttonTranspose.TabIndex = 4;
            this.buttonTranspose.Text = "Транспонирование";
            this.buttonTranspose.UseVisualStyleBackColor = true;
            this.buttonTranspose.Click += new System.EventHandler(this.buttonTranspose_Click);
            // 
            // buttonReversedMatrix
            // 
            this.buttonReversedMatrix.Location = new System.Drawing.Point(6, 19);
            this.buttonReversedMatrix.Name = "buttonReversedMatrix";
            this.buttonReversedMatrix.Size = new System.Drawing.Size(145, 42);
            this.buttonReversedMatrix.TabIndex = 3;
            this.buttonReversedMatrix.Text = "Обратная матрица";
            this.buttonReversedMatrix.UseVisualStyleBackColor = true;
            this.buttonReversedMatrix.Click += new System.EventHandler(this.buttonReversedMatrix_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultMatrix);
            this.groupBox3.Location = new System.Drawing.Point(523, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 381);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // ResultMatrix
            // 
            this.ResultMatrix.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ResultMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultMatrix.ColumnHeadersVisible = false;
            this.ResultMatrix.Location = new System.Drawing.Point(6, 19);
            this.ResultMatrix.Name = "ResultMatrix";
            this.ResultMatrix.RowHeadersVisible = false;
            this.ResultMatrix.Size = new System.Drawing.Size(434, 356);
            this.ResultMatrix.TabIndex = 6;
            // 
            // buttonCopyResultToB
            // 
            this.buttonCopyResultToB.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyResultToB.Image")));
            this.buttonCopyResultToB.Location = new System.Drawing.Point(523, 237);
            this.buttonCopyResultToB.Name = "buttonCopyResultToB";
            this.buttonCopyResultToB.Size = new System.Drawing.Size(40, 38);
            this.buttonCopyResultToB.TabIndex = 7;
            this.buttonCopyResultToB.UseVisualStyleBackColor = true;
            this.buttonCopyResultToB.Click += new System.EventHandler(this.buttonCopyResultToB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.buttonCopyResultToB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCopyToUpper);
            this.Controls.Add(this.buttonCopyToBottom);
            this.Controls.Add(this.matrixBgroupBox);
            this.Controls.Add(this.matrixAgroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.matrixAgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCounterNumericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCounetNumericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).EndInit();
            this.matrixBgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCounterNumericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCounetNumericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MultiplicatorNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox matrixAgroupBox;
        private System.Windows.Forms.GroupBox matrixBgroupBox;
        private System.Windows.Forms.Button buttonCopyToBottom;
        private System.Windows.Forms.Button buttonCopyToUpper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown ColumnCounterNumericA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RowCounetNumericA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ColumnCounterNumericB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RowCounetNumericB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView matrixB;
        private System.Windows.Forms.Button buttonMatrixMultiply;
        private System.Windows.Forms.Button buttonMatrixSubt;
        private System.Windows.Forms.Button buttonMatrixSum;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonElementMinor;
        private System.Windows.Forms.Button buttonDeterminant;
        private System.Windows.Forms.Button buttonMatrixRang;
        private System.Windows.Forms.Button buttonTranspose;
        private System.Windows.Forms.Button buttonReversedMatrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MultiplicatorNumeric;
        private System.Windows.Forms.DataGridView ResultMatrix;
        private System.Windows.Forms.Button buttonCopyResultToB;
        private System.Windows.Forms.DataGridView matrixA;
        private System.Windows.Forms.Button RandomA;
        private System.Windows.Forms.Button RandomB;
    }
}

