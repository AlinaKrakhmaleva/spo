namespace GeometricsFigureView
{
    partial class AddFigureForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.figureControl = new GeometricsFigureView.Controls.FigureControl();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(124, 208);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(86, 25);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CanselButton
            // 
            this.CanselButton.Location = new System.Drawing.Point(240, 208);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(86, 25);
            this.CanselButton.TabIndex = 2;
            this.CanselButton.Text = "Отмена";
            this.CanselButton.UseVisualStyleBackColor = true;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // figureControl
            // 
            this.figureControl.Figure = null;
            this.figureControl.Location = new System.Drawing.Point(12, 12);
            this.figureControl.Name = "figureControl";
            this.figureControl.Size = new System.Drawing.Size(420, 190);
            this.figureControl.TabIndex = 0;
            this.figureControl.Load += new System.EventHandler(this.figureControl_Load);
            // 
            // AddFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.figureControl);
            this.Name = "AddFigureForm";
            this.Text = "Создать фигуру";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.FigureControl figureControl;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CanselButton;
    }
}