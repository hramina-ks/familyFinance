namespace familyFinance
{
    partial class frmFinance
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIncomeAdd = new System.Windows.Forms.TextBox();
            this.numIncomeDay = new System.Windows.Forms.NumericUpDown();
            this.cmbIncomeArticles = new System.Windows.Forms.ComboBox();
            this.btnIncomeAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExpenseAdd = new System.Windows.Forms.TextBox();
            this.numExpenseDay = new System.Windows.Forms.NumericUpDown();
            this.cmbExpenseArticles = new System.Windows.Forms.ComboBox();
            this.btnExpenseAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSavesAdd = new System.Windows.Forms.TextBox();
            this.numSavesDay = new System.Windows.Forms.NumericUpDown();
            this.cmbSavesArticles = new System.Windows.Forms.ComboBox();
            this.btnSavesAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIncomeDay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpenseDay)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSavesDay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(13, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Статья:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "День:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Значение:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIncomeAdd);
            this.groupBox1.Controls.Add(this.numIncomeDay);
            this.groupBox1.Controls.Add(this.cmbIncomeArticles);
            this.groupBox1.Controls.Add(this.btnIncomeAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Доходы:";
            // 
            // txtIncomeAdd
            // 
            this.txtIncomeAdd.Location = new System.Drawing.Point(70, 76);
            this.txtIncomeAdd.Name = "txtIncomeAdd";
            this.txtIncomeAdd.Size = new System.Drawing.Size(100, 22);
            this.txtIncomeAdd.TabIndex = 9;
            // 
            // numIncomeDay
            // 
            this.numIncomeDay.Location = new System.Drawing.Point(70, 48);
            this.numIncomeDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numIncomeDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIncomeDay.Name = "numIncomeDay";
            this.numIncomeDay.Size = new System.Drawing.Size(43, 22);
            this.numIncomeDay.TabIndex = 8;
            this.numIncomeDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbIncomeArticles
            // 
            this.cmbIncomeArticles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncomeArticles.FormattingEnabled = true;
            this.cmbIncomeArticles.Location = new System.Drawing.Point(70, 21);
            this.cmbIncomeArticles.Name = "cmbIncomeArticles";
            this.cmbIncomeArticles.Size = new System.Drawing.Size(120, 21);
            this.cmbIncomeArticles.TabIndex = 7;
            // 
            // btnIncomeAdd
            // 
            this.btnIncomeAdd.Location = new System.Drawing.Point(50, 111);
            this.btnIncomeAdd.Name = "btnIncomeAdd";
            this.btnIncomeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnIncomeAdd.TabIndex = 6;
            this.btnIncomeAdd.Text = "Добавить";
            this.btnIncomeAdd.UseVisualStyleBackColor = true;
            this.btnIncomeAdd.Click += new System.EventHandler(this.btnIncomeAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExpenseAdd);
            this.groupBox2.Controls.Add(this.numExpenseDay);
            this.groupBox2.Controls.Add(this.cmbExpenseArticles);
            this.groupBox2.Controls.Add(this.btnExpenseAdd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(247, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 147);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расходы:";
            // 
            // txtExpenseAdd
            // 
            this.txtExpenseAdd.Location = new System.Drawing.Point(70, 76);
            this.txtExpenseAdd.Name = "txtExpenseAdd";
            this.txtExpenseAdd.Size = new System.Drawing.Size(100, 22);
            this.txtExpenseAdd.TabIndex = 9;
            // 
            // numExpenseDay
            // 
            this.numExpenseDay.Location = new System.Drawing.Point(70, 48);
            this.numExpenseDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numExpenseDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExpenseDay.Name = "numExpenseDay";
            this.numExpenseDay.Size = new System.Drawing.Size(43, 22);
            this.numExpenseDay.TabIndex = 8;
            this.numExpenseDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbExpenseArticles
            // 
            this.cmbExpenseArticles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpenseArticles.FormattingEnabled = true;
            this.cmbExpenseArticles.Location = new System.Drawing.Point(70, 21);
            this.cmbExpenseArticles.Name = "cmbExpenseArticles";
            this.cmbExpenseArticles.Size = new System.Drawing.Size(120, 21);
            this.cmbExpenseArticles.TabIndex = 7;
            // 
            // btnExpenseAdd
            // 
            this.btnExpenseAdd.Location = new System.Drawing.Point(50, 111);
            this.btnExpenseAdd.Name = "btnExpenseAdd";
            this.btnExpenseAdd.Size = new System.Drawing.Size(75, 23);
            this.btnExpenseAdd.TabIndex = 6;
            this.btnExpenseAdd.Text = "Добавить";
            this.btnExpenseAdd.UseVisualStyleBackColor = true;
            this.btnExpenseAdd.Click += new System.EventHandler(this.btnExpenseAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Значение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "День:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Статья:";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(11, 235);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(680, 188);
            this.rtbOutput.TabIndex = 8;
            this.rtbOutput.Text = "";
            this.rtbOutput.WordWrap = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Text documents|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text documents|*.txt";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(616, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Новое";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSavesAdd);
            this.groupBox3.Controls.Add(this.numSavesDay);
            this.groupBox3.Controls.Add(this.cmbSavesArticles);
            this.groupBox3.Controls.Add(this.btnSavesAdd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(483, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 147);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сбережения:";
            // 
            // txtSavesAdd
            // 
            this.txtSavesAdd.Location = new System.Drawing.Point(70, 76);
            this.txtSavesAdd.Name = "txtSavesAdd";
            this.txtSavesAdd.Size = new System.Drawing.Size(100, 22);
            this.txtSavesAdd.TabIndex = 9;
            // 
            // numSavesDay
            // 
            this.numSavesDay.Location = new System.Drawing.Point(70, 48);
            this.numSavesDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numSavesDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSavesDay.Name = "numSavesDay";
            this.numSavesDay.Size = new System.Drawing.Size(43, 22);
            this.numSavesDay.TabIndex = 8;
            this.numSavesDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbSavesArticles
            // 
            this.cmbSavesArticles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSavesArticles.FormattingEnabled = true;
            this.cmbSavesArticles.Location = new System.Drawing.Point(70, 21);
            this.cmbSavesArticles.Name = "cmbSavesArticles";
            this.cmbSavesArticles.Size = new System.Drawing.Size(120, 21);
            this.cmbSavesArticles.TabIndex = 7;
            // 
            // btnSavesAdd
            // 
            this.btnSavesAdd.Location = new System.Drawing.Point(50, 111);
            this.btnSavesAdd.Name = "btnSavesAdd";
            this.btnSavesAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSavesAdd.TabIndex = 6;
            this.btnSavesAdd.Text = "Добавить";
            this.btnSavesAdd.UseVisualStyleBackColor = true;
            this.btnSavesAdd.Click += new System.EventHandler(this.btnSavesAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Значение:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "День:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Статья:";
            // 
            // frmFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFinance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Семейный бюджет";
            this.Load += new System.EventHandler(this.frmFinance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIncomeDay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpenseDay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSavesDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIncomeAdd;
        private System.Windows.Forms.NumericUpDown numIncomeDay;
        private System.Windows.Forms.ComboBox cmbIncomeArticles;
        private System.Windows.Forms.Button btnIncomeAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExpenseAdd;
        private System.Windows.Forms.NumericUpDown numExpenseDay;
        private System.Windows.Forms.ComboBox cmbExpenseArticles;
        private System.Windows.Forms.Button btnExpenseAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSavesAdd;
        private System.Windows.Forms.NumericUpDown numSavesDay;
        private System.Windows.Forms.ComboBox cmbSavesArticles;
        private System.Windows.Forms.Button btnSavesAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

