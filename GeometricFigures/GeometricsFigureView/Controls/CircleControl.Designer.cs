namespace GeometricsFigureView.Controls
{
    partial class CircleControl
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
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(152, 28);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.RadiusLabel.TabIndex = 0;
            this.RadiusLabel.Text = "Радиус";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(151, 48);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(101, 20);
            this.RadiusTextBox.TabIndex = 1;
            // 
            // CircleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.RadiusLabel);
            this.Name = "CircleControl";
            this.Size = new System.Drawing.Size(390, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox;
    }
}
