namespace FloatingHorizont
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
            System.Windows.Forms.Label label_div;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label_range;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label_function;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.curveNY = new System.Windows.Forms.NumericUpDown();
            this.curveNX = new System.Windows.Forms.NumericUpDown();
            this.curveY1 = new System.Windows.Forms.NumericUpDown();
            this.curveX1 = new System.Windows.Forms.NumericUpDown();
            this.curveY0 = new System.Windows.Forms.NumericUpDown();
            this.curveX0 = new System.Windows.Forms.NumericUpDown();
            this.curveType = new System.Windows.Forms.ComboBox();
            this.label_controls = new System.Windows.Forms.Label();
            label_div = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label_range = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label_function = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveNY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveNX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveX0)).BeginInit();
            this.SuspendLayout();
            // 
            // label_div
            // 
            label_div.AutoSize = true;
            label_div.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            label_div.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label_div.Location = new System.Drawing.Point(512, 206);
            label_div.Name = "label_div";
            label_div.Size = new System.Drawing.Size(63, 19);
            label_div.TabIndex = 41;
            label_div.Text = "Divisions";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(512, 266);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(20, 19);
            label6.TabIndex = 40;
            label6.Text = "Y:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label5.Location = new System.Drawing.Point(512, 239);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(20, 19);
            label5.TabIndex = 38;
            label5.Text = "X:";
            // 
            // label_range
            // 
            label_range.AutoSize = true;
            label_range.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            label_range.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label_range.Location = new System.Drawing.Point(512, 98);
            label_range.Name = "label_range";
            label_range.Size = new System.Drawing.Size(47, 19);
            label_range.TabIndex = 36;
            label_range.Text = "Range";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(643, 155);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 19);
            label4.TabIndex = 35;
            label4.Text = "Y1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label2.Location = new System.Drawing.Point(512, 152);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 19);
            label2.TabIndex = 33;
            label2.Text = "X1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(643, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(28, 19);
            label3.TabIndex = 31;
            label3.Text = "Y0:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(512, 127);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(28, 19);
            label1.TabIndex = 29;
            label1.Text = "X0:";
            // 
            // label_function
            // 
            label_function.AutoSize = true;
            label_function.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            label_function.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label_function.Location = new System.Drawing.Point(512, 13);
            label_function.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label_function.Name = "label_function";
            label_function.Size = new System.Drawing.Size(62, 19);
            label_function.TabIndex = 27;
            label_function.Text = "Function";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // curveNY
            // 
            this.curveNY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curveNY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curveNY.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.curveNY.Location = new System.Drawing.Point(536, 266);
            this.curveNY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.curveNY.Name = "curveNY";
            this.curveNY.Size = new System.Drawing.Size(62, 22);
            this.curveNY.TabIndex = 39;
            this.curveNY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.curveNY.ValueChanged += new System.EventHandler(this.curve_ValueChanged);
            // 
            // curveNX
            // 
            this.curveNX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curveNX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curveNX.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.curveNX.Location = new System.Drawing.Point(536, 239);
            this.curveNX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.curveNX.Name = "curveNX";
            this.curveNX.Size = new System.Drawing.Size(62, 22);
            this.curveNX.TabIndex = 37;
            this.curveNX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.curveNX.ValueChanged += new System.EventHandler(this.curve_ValueChanged);
            // 
            // curveY1
            // 
            this.curveY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curveY1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curveY1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.curveY1.Location = new System.Drawing.Point(673, 153);
            this.curveY1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.curveY1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.curveY1.Name = "curveY1";
            this.curveY1.Size = new System.Drawing.Size(62, 22);
            this.curveY1.TabIndex = 34;
            this.curveY1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.curveY1.ValueChanged += new System.EventHandler(this.curve_ValueChanged);
            // 
            // curveX1
            // 
            this.curveX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curveX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curveX1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.curveX1.Location = new System.Drawing.Point(543, 152);
            this.curveX1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.curveX1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.curveX1.Name = "curveX1";
            this.curveX1.Size = new System.Drawing.Size(62, 22);
            this.curveX1.TabIndex = 32;
            this.curveX1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.curveX1.ValueChanged += new System.EventHandler(this.curve_ValueChanged);
            // 
            // curveY0
            // 
            this.curveY0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curveY0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curveY0.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.curveY0.Location = new System.Drawing.Point(673, 124);
            this.curveY0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.curveY0.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.curveY0.Name = "curveY0";
            this.curveY0.Size = new System.Drawing.Size(62, 22);
            this.curveY0.TabIndex = 30;
            this.curveY0.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.curveY0.ValueChanged += new System.EventHandler(this.curve_ValueChanged);
            // 
            // curveX0
            // 
            this.curveX0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curveX0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curveX0.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.curveX0.Location = new System.Drawing.Point(543, 124);
            this.curveX0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.curveX0.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.curveX0.Name = "curveX0";
            this.curveX0.Size = new System.Drawing.Size(62, 22);
            this.curveX0.TabIndex = 28;
            this.curveX0.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.curveX0.ValueChanged += new System.EventHandler(this.curve_ValueChanged);
            // 
            // curveType
            // 
            this.curveType.CausesValidation = false;
            this.curveType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.curveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.curveType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.curveType.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.curveType.FormattingEnabled = true;
            this.curveType.Items.AddRange(new object[] {
            "f(x, y) = 5 * cos(x * x + y * y + 1) / (x * x + y * y + 1) + 0.1",
            "f(x, y) = cos(x * x + y * y) / (x * x + y * y + 1)",
            "f(x, y) = sin(x) * cos(y)",
            "f(x, y) = sin(x) + cos(y)",
            "f(x, y) = x * x + y * y"});
            this.curveType.Location = new System.Drawing.Point(515, 42);
            this.curveType.Name = "curveType";
            this.curveType.Size = new System.Drawing.Size(384, 27);
            this.curveType.TabIndex = 26;
            this.curveType.TabStop = false;
            this.curveType.SelectedIndexChanged += new System.EventHandler(this.curveType_SelectedIndexChanged);
            this.curveType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.curveType_KeyDown);
            // 
            // label_controls
            // 
            this.label_controls.AutoSize = true;
            this.label_controls.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label_controls.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_controls.Location = new System.Drawing.Point(10, 483);
            this.label_controls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_controls.Name = "label_controls";
            this.label_controls.Size = new System.Drawing.Size(440, 19);
            this.label_controls.TabIndex = 42;
            this.label_controls.Text = "camera controls: W/S - up/down, A/D - left/right, Q/E - tilt, R/F - zoom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 506);
            this.Controls.Add(this.label_controls);
            this.Controls.Add(label_div);
            this.Controls.Add(label6);
            this.Controls.Add(this.curveNY);
            this.Controls.Add(label5);
            this.Controls.Add(this.curveNX);
            this.Controls.Add(label_range);
            this.Controls.Add(label4);
            this.Controls.Add(this.curveY1);
            this.Controls.Add(label2);
            this.Controls.Add(this.curveX1);
            this.Controls.Add(label3);
            this.Controls.Add(this.curveY0);
            this.Controls.Add(label1);
            this.Controls.Add(this.curveX0);
            this.Controls.Add(label_function);
            this.Controls.Add(this.curveType);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveNY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveNX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curveX0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown curveNY;
        private System.Windows.Forms.NumericUpDown curveNX;
        private System.Windows.Forms.NumericUpDown curveY1;
        private System.Windows.Forms.NumericUpDown curveX1;
        private System.Windows.Forms.NumericUpDown curveY0;
        private System.Windows.Forms.NumericUpDown curveX0;
        private System.Windows.Forms.ComboBox curveType;
        private System.Windows.Forms.Label label_controls;
    }
}

