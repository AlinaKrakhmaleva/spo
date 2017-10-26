using System;

namespace GeometricsFigureView.Controls
{
    partial class TriangleControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideATextBox = new System.Windows.Forms.TextBox();
            this.SideBTextBox = new System.Windows.Forms.TextBox();
            this.SideCTextBox = new System.Windows.Forms.TextBox();
            this.SideALabel = new System.Windows.Forms.Label();
            this.SideBLabel = new System.Windows.Forms.Label();
            this.SideCLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SideATextBox
            // 
            this.SideATextBox.Location = new System.Drawing.Point(24, 52);
            this.SideATextBox.Name = "SideATextBox";
            this.SideATextBox.Size = new System.Drawing.Size(100, 20);
            this.SideATextBox.TabIndex = 0;
            // 
            // SideBTextBox
            // 
            this.SideBTextBox.Location = new System.Drawing.Point(145, 52);
            this.SideBTextBox.Name = "SideBTextBox";
            this.SideBTextBox.Size = new System.Drawing.Size(100, 20);
            this.SideBTextBox.TabIndex = 1;
            // 
            // SideCTextBox
            // 
            this.SideCTextBox.Location = new System.Drawing.Point(273, 52);
            this.SideCTextBox.Name = "SideCTextBox";
            this.SideCTextBox.Size = new System.Drawing.Size(100, 20);
            this.SideCTextBox.TabIndex = 2;
            // 
            // SideALabel
            // 
            this.SideALabel.AutoSize = true;
            this.SideALabel.Location = new System.Drawing.Point(21, 36);
            this.SideALabel.Name = "SideALabel";
            this.SideALabel.Size = new System.Drawing.Size(59, 13);
            this.SideALabel.TabIndex = 3;
            this.SideALabel.Text = "Сторона А";
            // 
            // SideBLabel
            // 
            this.SideBLabel.AutoSize = true;
            this.SideBLabel.Location = new System.Drawing.Point(142, 36);
            this.SideBLabel.Name = "SideBLabel";
            this.SideBLabel.Size = new System.Drawing.Size(59, 13);
            this.SideBLabel.TabIndex = 4;
            this.SideBLabel.Text = "Сторона B";
            // 
            // SideCLabel
            // 
            this.SideCLabel.AutoSize = true;
            this.SideCLabel.Location = new System.Drawing.Point(270, 36);
            this.SideCLabel.Name = "SideCLabel";
            this.SideCLabel.Size = new System.Drawing.Size(59, 13);
            this.SideCLabel.TabIndex = 5;
            this.SideCLabel.Text = "Сторона C";
            // 
            // TriangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SideCLabel);
            this.Controls.Add(this.SideBLabel);
            this.Controls.Add(this.SideALabel);
            this.Controls.Add(this.SideCTextBox);
            this.Controls.Add(this.SideBTextBox);
            this.Controls.Add(this.SideATextBox);
            this.Name = "TriangleControl";
            this.Size = new System.Drawing.Size(390, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SideATextBox;
        private System.Windows.Forms.TextBox SideBTextBox;
        private System.Windows.Forms.TextBox SideCTextBox;

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private System.Windows.Forms.Label SideALabel;
        private System.Windows.Forms.Label SideBLabel;
        private System.Windows.Forms.Label SideCLabel;
    }
}
