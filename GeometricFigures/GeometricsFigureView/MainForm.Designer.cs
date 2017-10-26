namespace GeometricsFigureView
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddFigureButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RandomFigureButton = new System.Windows.Forms.Button();
            this.RemoveFigureButton = new System.Windows.Forms.Button();
            this.ModifyFigureButton = new System.Windows.Forms.Button();
            this.FigureDataGridView = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perimeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFiguresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFiguresBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AddFigureButton);
            this.groupBox1.Controls.Add(this.SearchTextBox);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.RandomFigureButton);
            this.groupBox1.Controls.Add(this.RemoveFigureButton);
            this.groupBox1.Controls.Add(this.ModifyFigureButton);
            this.groupBox1.Controls.Add(this.FigureDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // AddFigureButton
            // 
            this.AddFigureButton.Location = new System.Drawing.Point(395, 24);
            this.AddFigureButton.Name = "AddFigureButton";
            this.AddFigureButton.Size = new System.Drawing.Size(82, 22);
            this.AddFigureButton.TabIndex = 8;
            this.AddFigureButton.Text = "Добавить";
            this.AddFigureButton.UseVisualStyleBackColor = true;
            this.AddFigureButton.Click += new System.EventHandler(this.AddFigureButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(395, 118);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(167, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(395, 144);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(170, 22);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RandomFigureButton
            // 
            this.RandomFigureButton.Location = new System.Drawing.Point(395, 80);
            this.RandomFigureButton.Name = "RandomFigureButton";
            this.RandomFigureButton.Size = new System.Drawing.Size(167, 22);
            this.RandomFigureButton.TabIndex = 5;
            this.RandomFigureButton.Text = "Произвольное заполнение ";
            this.RandomFigureButton.UseVisualStyleBackColor = true;
            this.RandomFigureButton.Click += new System.EventHandler(this.RandomFigureButton_Click);
            // 
            // RemoveFigureButton
            // 
            this.RemoveFigureButton.Location = new System.Drawing.Point(483, 24);
            this.RemoveFigureButton.Name = "RemoveFigureButton";
            this.RemoveFigureButton.Size = new System.Drawing.Size(82, 22);
            this.RemoveFigureButton.TabIndex = 4;
            this.RemoveFigureButton.Text = "Удалить";
            this.RemoveFigureButton.UseVisualStyleBackColor = true;
            this.RemoveFigureButton.Click += new System.EventHandler(this.RemoveFigureButton_Click);
            // 
            // ModifyFigureButton
            // 
            this.ModifyFigureButton.Location = new System.Drawing.Point(395, 52);
            this.ModifyFigureButton.Name = "ModifyFigureButton";
            this.ModifyFigureButton.Size = new System.Drawing.Size(167, 22);
            this.ModifyFigureButton.TabIndex = 3;
            this.ModifyFigureButton.Text = "Изменить";
            this.ModifyFigureButton.UseVisualStyleBackColor = true;
            this.ModifyFigureButton.Click += new System.EventHandler(this.ModifyFigureButton_Click);
            // 
            // FigureDataGridView
            // 
            this.FigureDataGridView.AllowUserToAddRows = false;
            this.FigureDataGridView.AllowUserToDeleteRows = false;
            this.FigureDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FigureDataGridView.AutoGenerateColumns = false;
            this.FigureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FigureDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FigureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FigureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.perimeterDataGridViewTextBoxColumn});
            this.FigureDataGridView.DataSource = this.iFiguresBindingSource;
            this.FigureDataGridView.Location = new System.Drawing.Point(6, 19);
            this.FigureDataGridView.Name = "FigureDataGridView";
            this.FigureDataGridView.ReadOnly = true;
            this.FigureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FigureDataGridView.Size = new System.Drawing.Size(383, 291);
            this.FigureDataGridView.TabIndex = 1;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perimeterDataGridViewTextBoxColumn
            // 
            this.perimeterDataGridViewTextBoxColumn.DataPropertyName = "Perimeter";
            this.perimeterDataGridViewTextBoxColumn.HeaderText = "Perimeter";
            this.perimeterDataGridViewTextBoxColumn.Name = "perimeterDataGridViewTextBoxColumn";
            this.perimeterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iFiguresBindingSource
            // 
            this.iFiguresBindingSource.DataSource = typeof(GeometricFigures.IFigure);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сериализация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Десериализация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Geometric Figures - Вычисление площади и периметра";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFiguresBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddFigureButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RandomFigureButton;
        private System.Windows.Forms.Button RemoveFigureButton;
        private System.Windows.Forms.Button ModifyFigureButton;
        private System.Windows.Forms.DataGridView FigureDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.BindingSource iFiguresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perimeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}