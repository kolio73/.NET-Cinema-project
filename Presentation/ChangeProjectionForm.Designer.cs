
namespace Cinema.Presentation
{
    partial class ChangeProjectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeProjectionForm));
            this.projectionLabel = new System.Windows.Forms.Label();
            this.projectionTextBox = new System.Windows.Forms.TextBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectionLabel
            // 
            this.projectionLabel.AutoSize = true;
            this.projectionLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.projectionLabel.Location = new System.Drawing.Point(24, 41);
            this.projectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectionLabel.Name = "projectionLabel";
            this.projectionLabel.Size = new System.Drawing.Size(115, 30);
            this.projectionLabel.TabIndex = 0;
            this.projectionLabel.Text = "Прожекция:";
            // 
            // projectionTextBox
            // 
            this.projectionTextBox.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.projectionTextBox.Location = new System.Drawing.Point(184, 41);
            this.projectionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.projectionTextBox.Name = "projectionTextBox";
            this.projectionTextBox.Size = new System.Drawing.Size(124, 38);
            this.projectionTextBox.TabIndex = 1;
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.prevButton.Location = new System.Drawing.Point(184, 112);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(49, 29);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.nextButton.Location = new System.Drawing.Point(260, 112);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(49, 29);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.addButton.Location = new System.Drawing.Point(119, 174);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 32);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добави";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.updateButton.Location = new System.Drawing.Point(260, 174);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(114, 32);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Промени";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ChangeProjectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 260);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.projectionTextBox);
            this.Controls.Add(this.projectionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeProjectionForm";
            this.Text = "Управление на данните за прожекциите";
            this.Load += new System.EventHandler(this.ChangeProjectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectionLabel;
        private System.Windows.Forms.TextBox projectionTextBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
    }
}