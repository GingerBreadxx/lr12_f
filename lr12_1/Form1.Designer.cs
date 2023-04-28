namespace lr12_1
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
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbCoordinates = new System.Windows.Forms.TextBox();
            this.listBoxVectors = new System.Windows.Forms.ListBox();
            this.btnAddVector = new System.Windows.Forms.Button();
            this.btnShowVectors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(101, 38);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(100, 20);
            this.tbLength.TabIndex = 0;
            // 
            // tbCoordinates
            // 
            this.tbCoordinates.Location = new System.Drawing.Point(275, 38);
            this.tbCoordinates.Name = "tbCoordinates";
            this.tbCoordinates.Size = new System.Drawing.Size(100, 20);
            this.tbCoordinates.TabIndex = 1;
            // 
            // listBoxVectors
            // 
            this.listBoxVectors.FormattingEnabled = true;
            this.listBoxVectors.Location = new System.Drawing.Point(101, 109);
            this.listBoxVectors.Name = "listBoxVectors";
            this.listBoxVectors.Size = new System.Drawing.Size(120, 95);
            this.listBoxVectors.TabIndex = 2;
            // 
            // btnAddVector
            // 
            this.btnAddVector.Location = new System.Drawing.Point(101, 278);
            this.btnAddVector.Name = "btnAddVector";
            this.btnAddVector.Size = new System.Drawing.Size(75, 23);
            this.btnAddVector.TabIndex = 3;
            this.btnAddVector.Text = "Посчитать";
            this.btnAddVector.UseVisualStyleBackColor = true;
            this.btnAddVector.Click += new System.EventHandler(this.btnAddVector_Click);
            // 
            // btnShowVectors
            // 
            this.btnShowVectors.Location = new System.Drawing.Point(101, 334);
            this.btnShowVectors.Name = "btnShowVectors";
            this.btnShowVectors.Size = new System.Drawing.Size(75, 23);
            this.btnShowVectors.TabIndex = 4;
            this.btnShowVectors.Text = "Вывести";
            this.btnShowVectors.UseVisualStyleBackColor = true;
            this.btnShowVectors.Click += new System.EventHandler(this.btnShowVectors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Длина вектора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Координаты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вывод:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowVectors);
            this.Controls.Add(this.btnAddVector);
            this.Controls.Add(this.listBoxVectors);
            this.Controls.Add(this.tbCoordinates);
            this.Controls.Add(this.tbLength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbCoordinates;
        private System.Windows.Forms.ListBox listBoxVectors;
        private System.Windows.Forms.Button btnAddVector;
        private System.Windows.Forms.Button btnShowVectors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

