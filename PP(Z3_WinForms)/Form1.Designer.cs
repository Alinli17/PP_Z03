namespace PP_Z3_WinForms_
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
            this.Zadanie_1 = new System.Windows.Forms.GroupBox();
            this.Zadania_2_and_3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.Label();
            this.rez1 = new System.Windows.Forms.Label();
            this.Verify = new System.Windows.Forms.Button();
            this.rez_1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.per_a = new System.Windows.Forms.TextBox();
            this.the_end = new System.Windows.Forms.Label();
            this.per_b = new System.Windows.Forms.TextBox();
            this.step = new System.Windows.Forms.Label();
            this.per_h = new System.Windows.Forms.TextBox();
            this.rez_2and3 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Culculate = new System.Windows.Forms.Button();
            this.Zadanie_1.SuspendLayout();
            this.Zadania_2_and_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zadanie_1
            // 
            this.Zadanie_1.Controls.Add(this.rez_1);
            this.Zadanie_1.Controls.Add(this.Verify);
            this.Zadanie_1.Controls.Add(this.rez1);
            this.Zadanie_1.Controls.Add(this.rez);
            this.Zadanie_1.Controls.Add(this.num);
            this.Zadanie_1.Controls.Add(this.label1);
            this.Zadanie_1.Location = new System.Drawing.Point(0, 0);
            this.Zadanie_1.Name = "Zadanie_1";
            this.Zadanie_1.Size = new System.Drawing.Size(394, 396);
            this.Zadanie_1.TabIndex = 0;
            this.Zadanie_1.TabStop = false;
            this.Zadanie_1.Text = "Задание 1";
            // 
            // Zadania_2_and_3
            // 
            this.Zadania_2_and_3.Controls.Add(this.Culculate);
            this.Zadania_2_and_3.Controls.Add(this.rez_2and3);
            this.Zadania_2_and_3.Controls.Add(this.per_h);
            this.Zadania_2_and_3.Controls.Add(this.step);
            this.Zadania_2_and_3.Controls.Add(this.per_b);
            this.Zadania_2_and_3.Controls.Add(this.the_end);
            this.Zadania_2_and_3.Controls.Add(this.per_a);
            this.Zadania_2_and_3.Controls.Add(this.start);
            this.Zadania_2_and_3.Location = new System.Drawing.Point(400, 0);
            this.Zadania_2_and_3.Name = "Zadania_2_and_3";
            this.Zadania_2_and_3.Size = new System.Drawing.Size(398, 396);
            this.Zadania_2_and_3.TabIndex = 0;
            this.Zadania_2_and_3.TabStop = false;
            this.Zadania_2_and_3.Text = "Задания 2 и 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число:";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(201, 25);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(117, 22);
            this.num.TabIndex = 2;
            // 
            // rez
            // 
            this.rez.AutoSize = true;
            this.rez.Location = new System.Drawing.Point(103, 59);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(80, 17);
            this.rez.TabIndex = 3;
            this.rez.Text = "Результат:";
            // 
            // rez1
            // 
            this.rez1.AutoSize = true;
            this.rez1.Location = new System.Drawing.Point(119, 59);
            this.rez1.Name = "rez1";
            this.rez1.Size = new System.Drawing.Size(0, 17);
            this.rez1.TabIndex = 4;
            // 
            // Verify
            // 
            this.Verify.Location = new System.Drawing.Point(139, 101);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(117, 33);
            this.Verify.TabIndex = 5;
            this.Verify.Text = "Проверить";
            this.Verify.UseVisualStyleBackColor = true;
            this.Verify.Click += new System.EventHandler(this.Verify_Click);
            // 
            // rez_1
            // 
            this.rez_1.AutoSize = true;
            this.rez_1.Location = new System.Drawing.Point(198, 59);
            this.rez_1.Name = "rez_1";
            this.rez_1.Size = new System.Drawing.Size(0, 17);
            this.rez_1.TabIndex = 6;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(6, 28);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(194, 17);
            this.start.TabIndex = 1;
            this.start.Text = "Введите начало диапазона:";
            // 
            // per_a
            // 
            this.per_a.Location = new System.Drawing.Point(206, 25);
            this.per_a.Name = "per_a";
            this.per_a.Size = new System.Drawing.Size(117, 22);
            this.per_a.TabIndex = 2;
            // 
            // the_end
            // 
            this.the_end.AutoSize = true;
            this.the_end.Location = new System.Drawing.Point(6, 59);
            this.the_end.Name = "the_end";
            this.the_end.Size = new System.Drawing.Size(185, 17);
            this.the_end.TabIndex = 3;
            this.the_end.Text = "Введите конец диапазона:";
            // 
            // per_b
            // 
            this.per_b.Location = new System.Drawing.Point(206, 56);
            this.per_b.Name = "per_b";
            this.per_b.Size = new System.Drawing.Size(117, 22);
            this.per_b.TabIndex = 4;
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Location = new System.Drawing.Point(6, 90);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(95, 17);
            this.step.TabIndex = 5;
            this.step.Text = "Введите шаг:";
            // 
            // per_h
            // 
            this.per_h.Location = new System.Drawing.Point(206, 87);
            this.per_h.Name = "per_h";
            this.per_h.Size = new System.Drawing.Size(117, 22);
            this.per_h.TabIndex = 6;
            // 
            // rez_2and3
            // 
            this.rez_2and3.Location = new System.Drawing.Point(9, 115);
            this.rez_2and3.Name = "rez_2and3";
            this.rez_2and3.Size = new System.Drawing.Size(314, 216);
            this.rez_2and3.TabIndex = 7;
            this.rez_2and3.Text = "";
            // 
            // Culculate
            // 
            this.Culculate.Location = new System.Drawing.Point(136, 346);
            this.Culculate.Name = "Culculate";
            this.Culculate.Size = new System.Drawing.Size(117, 33);
            this.Culculate.TabIndex = 8;
            this.Culculate.Text = "Рассчитать";
            this.Culculate.UseVisualStyleBackColor = true;
            this.Culculate.Click += new System.EventHandler(this.Culculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 404);
            this.Controls.Add(this.Zadania_2_and_3);
            this.Controls.Add(this.Zadanie_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Zadanie_1.ResumeLayout(false);
            this.Zadanie_1.PerformLayout();
            this.Zadania_2_and_3.ResumeLayout(false);
            this.Zadania_2_and_3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie_1;
        private System.Windows.Forms.Button Verify;
        private System.Windows.Forms.Label rez1;
        private System.Windows.Forms.Label rez;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Zadania_2_and_3;
        private System.Windows.Forms.Label rez_1;
        private System.Windows.Forms.Button Culculate;
        private System.Windows.Forms.RichTextBox rez_2and3;
        private System.Windows.Forms.TextBox per_h;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.TextBox per_b;
        private System.Windows.Forms.Label the_end;
        private System.Windows.Forms.TextBox per_a;
        private System.Windows.Forms.Label start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

