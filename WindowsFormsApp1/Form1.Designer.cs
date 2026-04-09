namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxTask1 = new System.Windows.Forms.GroupBox();
            this.lblResultTask1 = new System.Windows.Forms.Label();
            this.btnCheckPoint = new System.Windows.Forms.Button();
            this.txtCircleR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCircleCy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCircleCx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPointY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTask2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPiResult = new System.Windows.Forms.Label();
            this.btnRunMonteCarlo = new System.Windows.Forms.Button();
            this.txtPointsCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxTask1.SuspendLayout();
            this.groupBoxTask2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask1
            // 
            this.groupBoxTask1.Controls.Add(this.lblResultTask1);
            this.groupBoxTask1.Controls.Add(this.btnCheckPoint);
            this.groupBoxTask1.Controls.Add(this.txtCircleR);
            this.groupBoxTask1.Controls.Add(this.label5);
            this.groupBoxTask1.Controls.Add(this.txtCircleCy);
            this.groupBoxTask1.Controls.Add(this.label4);
            this.groupBoxTask1.Controls.Add(this.txtCircleCx);
            this.groupBoxTask1.Controls.Add(this.label3);
            this.groupBoxTask1.Controls.Add(this.txtPointY);
            this.groupBoxTask1.Controls.Add(this.label2);
            this.groupBoxTask1.Controls.Add(this.txtPointX);
            this.groupBoxTask1.Controls.Add(this.label1);
            this.groupBoxTask1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask1.Name = "groupBoxTask1";
            this.groupBoxTask1.Size = new System.Drawing.Size(400, 200);
            this.groupBoxTask1.TabIndex = 0;
            this.groupBoxTask1.TabStop = false;
            this.groupBoxTask1.Text = "Задача 1: Попадание точки в круг";
            // 
            // lblResultTask1
            // 
            this.lblResultTask1.AutoSize = true;
            this.lblResultTask1.Location = new System.Drawing.Point(6, 175);
            this.lblResultTask1.Name = "lblResultTask1";
            this.lblResultTask1.Size = new System.Drawing.Size(63, 13);
            this.lblResultTask1.TabIndex = 11;
            this.lblResultTask1.Text = "Результат: ...";
            // 
            // btnCheckPoint
            // 
            this.btnCheckPoint.Location = new System.Drawing.Point(270, 140);
            this.btnCheckPoint.Name = "btnCheckPoint";
            this.btnCheckPoint.Size = new System.Drawing.Size(120, 23);
            this.btnCheckPoint.TabIndex = 10;
            this.btnCheckPoint.Text = "Проверить точку";
            this.btnCheckPoint.UseVisualStyleBackColor = true;
            // 
            // txtCircleR
            // 
            this.txtCircleR.Location = new System.Drawing.Point(270, 110);
            this.txtCircleR.Name = "txtCircleR";
            this.txtCircleR.Size = new System.Drawing.Size(100, 20);
            this.txtCircleR.TabIndex = 9;
            this.txtCircleR.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Радиус R:";
            // 
            // txtCircleCy
            // 
            this.txtCircleCy.Location = new System.Drawing.Point(270, 80);
            this.txtCircleCy.Name = "txtCircleCy";
            this.txtCircleCy.Size = new System.Drawing.Size(100, 20);
            this.txtCircleCy.TabIndex = 7;
            this.txtCircleCy.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Центр Cy:";
            // 
            // txtCircleCx
            // 
            this.txtCircleCx.Location = new System.Drawing.Point(90, 110);
            this.txtCircleCx.Name = "txtCircleCx";
            this.txtCircleCx.Size = new System.Drawing.Size(100, 20);
            this.txtCircleCx.TabIndex = 5;
            this.txtCircleCx.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Центр Cx:";
            // 
            // txtPointY
            // 
            this.txtPointY.Location = new System.Drawing.Point(90, 50);
            this.txtPointY.Name = "txtPointY";
            this.txtPointY.Size = new System.Drawing.Size(100, 20);
            this.txtPointY.TabIndex = 3;
            this.txtPointY.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Точка Y:";
            // 
            // txtPointX
            // 
            this.txtPointX.Location = new System.Drawing.Point(90, 20);
            this.txtPointX.Name = "txtPointX";
            this.txtPointX.Size = new System.Drawing.Size(100, 20);
            this.txtPointX.TabIndex = 1;
            this.txtPointX.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Точка X:";
            // 
            // groupBoxTask2
            // 
            this.groupBoxTask2.Controls.Add(this.pictureBox1);
            this.groupBoxTask2.Controls.Add(this.lblPiResult);
            this.groupBoxTask2.Controls.Add(this.btnRunMonteCarlo);
            this.groupBoxTask2.Controls.Add(this.txtPointsCount);
            this.groupBoxTask2.Controls.Add(this.label6);
            this.groupBoxTask2.Location = new System.Drawing.Point(420, 12);
            this.groupBoxTask2.Name = "groupBoxTask2";
            this.groupBoxTask2.Size = new System.Drawing.Size(450, 500);
            this.groupBoxTask2.TabIndex = 1;
            this.groupBoxTask2.TabStop = false;
            this.groupBoxTask2.Text = "Задачи 2-3: Метод Монте-Карло и визуализация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblPiResult
            // 
            this.lblPiResult.AutoSize = true;
            this.lblPiResult.Location = new System.Drawing.Point(20, 55);
            this.lblPiResult.Name = "lblPiResult";
            this.lblPiResult.Size = new System.Drawing.Size(40, 13);
            this.lblPiResult.TabIndex = 3;
            this.lblPiResult.Text = "π = ...";
            // 
            // btnRunMonteCarlo
            // 
            this.btnRunMonteCarlo.Location = new System.Drawing.Point(270, 50);
            this.btnRunMonteCarlo.Name = "btnRunMonteCarlo";
            this.btnRunMonteCarlo.Size = new System.Drawing.Size(150, 23);
            this.btnRunMonteCarlo.TabIndex = 2;
            this.btnMonteCarlo.Text = "Запустить моделирование";
            this.btnRunMonteCarlo.UseVisualStyleBackColor = true;
            // 
            // txtPointsCount
            // 
            this.txtPointsCount.Location = new System.Drawing.Point(150, 20);
            this.txtPointsCount.Name = "txtPointsCount";
            this.txtPointsCount.Size = new System.Drawing.Size(100, 20);
            this.txtPointsCount.TabIndex = 1;
            this.txtPointsCount.Text = "5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Количество точек N:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(858, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить всё";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBoxTask2);
            this.Controls.Add(this.groupBoxTask1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2 - Вариант 17";
            this.groupBoxTask1.ResumeLayout(false);
            this.groupBoxTask1.PerformLayout();
            this.groupBoxTask2.ResumeLayout(false);
            this.groupBoxTask2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask1;
        private System.Windows.Forms.Label lblResultTask1;
        private System.Windows.Forms.Button btnCheckPoint;
        private System.Windows.Forms.TextBox txtCircleR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCircleCy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCircleCx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPointY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTask2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPiResult;
        private System.Windows.Forms.Button btnRunMonteCarlo;
        private System.Windows.Forms.TextBox txtPointsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
    }
}