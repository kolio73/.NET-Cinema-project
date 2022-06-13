
namespace Cinema.Presentation
{
    partial class ChangeMoviesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMoviesForm));
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.projectionLabel = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.projectionComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.movieTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.priceLabel.Location = new System.Drawing.Point(52, 210);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(62, 30);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Цена:";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceNumericUpDown.Location = new System.Drawing.Point(151, 204);
            this.priceNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(189, 38);
            this.priceNumericUpDown.TabIndex = 14;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.prevButton.Location = new System.Drawing.Point(359, 199);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(38, 36);
            this.prevButton.TabIndex = 15;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.nextButton.Location = new System.Drawing.Point(462, 199);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(38, 36);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.deleteButton.Location = new System.Drawing.Point(359, 141);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(141, 36);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Изтриване";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.updateButton.Location = new System.Drawing.Point(359, 98);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(141, 36);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Промяна";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.addButton.Location = new System.Drawing.Point(359, 54);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 36);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Добавяне";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // projectionLabel
            // 
            this.projectionLabel.AutoSize = true;
            this.projectionLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.projectionLabel.Location = new System.Drawing.Point(48, 54);
            this.projectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectionLabel.Name = "projectionLabel";
            this.projectionLabel.Size = new System.Drawing.Size(115, 30);
            this.projectionLabel.TabIndex = 20;
            this.projectionLabel.Text = "Прожекция:";
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.movieLabel.Location = new System.Drawing.Point(48, 98);
            this.movieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(68, 30);
            this.movieLabel.TabIndex = 21;
            this.movieLabel.Text = "Филм:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.genreLabel.Location = new System.Drawing.Point(49, 141);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(66, 30);
            this.genreLabel.TabIndex = 22;
            this.genreLabel.Text = "Жанр:";
            // 
            // projectionComboBox
            // 
            this.projectionComboBox.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.projectionComboBox.FormattingEnabled = true;
            this.projectionComboBox.Location = new System.Drawing.Point(164, 54);
            this.projectionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.projectionComboBox.Name = "projectionComboBox";
            this.projectionComboBox.Size = new System.Drawing.Size(150, 38);
            this.projectionComboBox.TabIndex = 23;
            // 
            // genreComboBox
            // 
            this.genreComboBox.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(164, 141);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(150, 38);
            this.genreComboBox.TabIndex = 24;
            // 
            // movieTextBox
            // 
            this.movieTextBox.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.movieTextBox.Location = new System.Drawing.Point(164, 98);
            this.movieTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieTextBox.Name = "movieTextBox";
            this.movieTextBox.Size = new System.Drawing.Size(150, 38);
            this.movieTextBox.TabIndex = 25;
            // 
            // ChangeMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 295);
            this.Controls.Add(this.movieTextBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.projectionComboBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.projectionLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeMoviesForm";
            this.Text = "Управление на данните за филмите";
            this.Load += new System.EventHandler(this.ChangeMoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label projectionLabel;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox projectionComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.TextBox movieTextBox;
    }
}