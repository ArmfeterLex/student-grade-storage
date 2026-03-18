namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            label3 = new Label();
            comboBoxSubject = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnRead = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 20);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Класс:";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(97, 61);
            radioButton9.Margin = new Padding(4, 5, 4, 5);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(38, 24);
            radioButton9.TabIndex = 3;
            radioButton9.TabStop = true;
            radioButton9.Text = "9";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(146, 61);
            radioButton10.Margin = new Padding(4, 5, 4, 5);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(46, 24);
            radioButton10.TabIndex = 4;
            radioButton10.TabStop = true;
            radioButton10.Text = "10";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(203, 61);
            radioButton11.Margin = new Padding(4, 5, 4, 5);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(46, 24);
            radioButton11.TabIndex = 5;
            radioButton11.TabStop = true;
            radioButton11.Text = "11";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "Предмет:";
            // 
            // comboBoxSubject
            // 
            comboBoxSubject.FormattingEnabled = true;
            comboBoxSubject.Items.AddRange(new object[] { "физика", "математика", "химия" });
            comboBoxSubject.Location = new Point(97, 95);
            comboBoxSubject.Margin = new Padding(4, 5, 4, 5);
            comboBoxSubject.Name = "comboBoxSubject";
            comboBoxSubject.Size = new Size(239, 28);
            comboBoxSubject.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(16, 133);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Записать";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(124, 133);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(232, 133);
            btnRead.Margin = new Padding(4, 5, 4, 5);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(104, 35);
            btnRead.TabIndex = 10;
            btnRead.Text = "Прочитать";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 184);
            Controls.Add(btnRead);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(comboBoxSubject);
            Controls.Add(label3);
            Controls.Add(radioButton11);
            Controls.Add(radioButton10);
            Controls.Add(radioButton9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRead;
    }
}