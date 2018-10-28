namespace Kursach
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textStreet = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textF = new System.Windows.Forms.TextBox();
            this.textIm = new System.Windows.Forms.TextBox();
            this.textOt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(163, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите данные о найденном предмете.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(394, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата нахождения";
            // 
            // textItem
            // 
            this.textItem.Location = new System.Drawing.Point(168, 89);
            this.textItem.Name = "textItem";
            this.textItem.Size = new System.Drawing.Size(175, 22);
            this.textItem.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Район";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Описание";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(168, 211);
            this.textBox.MaxLength = 300;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(303, 81);
            this.textBox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(627, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(509, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(394, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Улица";
            // 
            // textStreet
            // 
            this.textStreet.Location = new System.Drawing.Point(627, 89);
            this.textStreet.Name = "textStreet";
            this.textStreet.Size = new System.Drawing.Size(175, 22);
            this.textStreet.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Авиастроительный",
            "Вахитовский",
            "Кировский",
            "Московский",
            "Ново-Савиновский",
            "Приволжский",
            "Советский"});
            this.comboBox1.Location = new System.Drawing.Point(168, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(196, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Введите персональные данные.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(12, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Фамилия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(12, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Имя";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(12, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Отчество";
            // 
            // textF
            // 
            this.textF.Location = new System.Drawing.Point(168, 436);
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(175, 22);
            this.textF.TabIndex = 21;
            // 
            // textIm
            // 
            this.textIm.Location = new System.Drawing.Point(168, 490);
            this.textIm.Name = "textIm";
            this.textIm.Size = new System.Drawing.Size(175, 22);
            this.textIm.TabIndex = 22;
            // 
            // textOt
            // 
            this.textOt.Location = new System.Drawing.Point(168, 542);
            this.textOt.Name = "textOt";
            this.textOt.Size = new System.Drawing.Size(175, 22);
            this.textOt.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(399, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "Номер телефона";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(662, 440);
            this.textPhone.MaxLength = 12;
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(175, 22);
            this.textPhone.TabIndex = 25;
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhone_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(242, 377);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(275, 28);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Не оставлять свои данные";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(635, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "+7";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 588);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textOt);
            this.Controls.Add(this.textIm);
            this.Controls.Add(this.textF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textStreet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Добавить предмет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textStreet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.TextBox textIm;
        private System.Windows.Forms.TextBox textOt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label12;
    }
}