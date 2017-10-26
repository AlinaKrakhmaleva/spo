namespace GeometricsFigureView.Controls
{
    partial class RectangleControl
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
            this.SideALabel = new System.Windows.Forms.Label();
            this.SideBLabel = new System.Windows.Forms.Label();
            this.SideATextBox = new System.Windows.Forms.TextBox();
            this.SideBTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SideALabel
            // 
            this.SideALabel.AutoSize = true;
            this.SideALabel.Location = new System.Drawing.Point(53, 35);
            this.SideALabel.Name = "SideALabel";
            this.SideALabel.Size = new System.Drawing.Size(59, 13);
            this.SideALabel.TabIndex = 0;
            this.SideALabel.Text = "Сторона А";
            // 
            // SideBLabel
            // 
            this.SideBLabel.AutoSize = true;
            this.SideBLabel.Location = new System.Drawing.Point(221, 35);
            this.SideBLabel.Name = "SideBLabel";
            this.SideBLabel.Size = new System.Drawing.Size(59, 13);
            this.SideBLabel.TabIndex = 1;
            this.SideBLabel.Text = "Сторона B";
            // 
            // SideATextBox
            // 
            this.SideATextBox.Location = new System.Drawing.Point(56, 51);
            this.SideATextBox.Name = "SideATextBox";
            this.SideATextBox.Size = new System.Drawing.Size(97, 20);
            this.SideATextBox.TabIndex = 2;
            // 
            // SideBTextBox
            // 
            this.SideBTextBox.Location = new System.Drawing.Point(224, 51);
            this.SideBTextBox.Name = "SideBTextBox";
            this.SideBTextBox.Size = new System.Drawing.Size(97, 20);
            this.SideBTextBox.TabIndex = 3;
            // 
            // RectangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SideBTextBox);
            this.Controls.Add(this.SideATextBox);
            this.Controls.Add(this.SideBLabel);
            this.Controls.Add(this.SideALabel);
            this.Name = "RectangleControl";
            this.Size = new System.Drawing.Size(390, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SideALabel;
        private System.Windows.Forms.Label SideBLabel;
        private System.Windows.Forms.TextBox SideATextBox;
        private System.Windows.Forms.TextBox SideBTextBox;
    }
}
