
namespace Cinema.Presentation
{
    partial class ChangeUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUsersForm));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.firstNameDataLabel = new System.Windows.Forms.Label();
            this.lastNameDataLabel = new System.Windows.Forms.Label();
            this.usernameDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.firstNameLabel.Location = new System.Drawing.Point(78, 44);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 30);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "Име:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.label1.Location = new System.Drawing.Point(78, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Име:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.usernameLabel.Location = new System.Drawing.Point(78, 141);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(203, 30);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Потребителско име:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.passwordLabel.Location = new System.Drawing.Point(78, 209);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 30);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Роля:";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(141, 205);
            this.rolesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(184, 38);
            this.rolesComboBox.TabIndex = 13;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.updateButton.Location = new System.Drawing.Point(421, 44);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(141, 36);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Промяна";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.deleteButton.Location = new System.Drawing.Point(421, 108);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(141, 36);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Изтриване";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.prevButton.Location = new System.Drawing.Point(421, 194);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(38, 36);
            this.prevButton.TabIndex = 16;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.nextButton.Location = new System.Drawing.Point(525, 194);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(38, 36);
            this.nextButton.TabIndex = 17;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // firstNameDataLabel
            // 
            this.firstNameDataLabel.AutoSize = true;
            this.firstNameDataLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.firstNameDataLabel.Location = new System.Drawing.Point(256, 44);
            this.firstNameDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameDataLabel.Name = "firstNameDataLabel";
            this.firstNameDataLabel.Size = new System.Drawing.Size(0, 30);
            this.firstNameDataLabel.TabIndex = 18;
            // 
            // lastNameDataLabel
            // 
            this.lastNameDataLabel.AutoSize = true;
            this.lastNameDataLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.lastNameDataLabel.Location = new System.Drawing.Point(256, 91);
            this.lastNameDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameDataLabel.Name = "lastNameDataLabel";
            this.lastNameDataLabel.Size = new System.Drawing.Size(0, 30);
            this.lastNameDataLabel.TabIndex = 19;
            // 
            // usernameDataLabel
            // 
            this.usernameDataLabel.AutoSize = true;
            this.usernameDataLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F);
            this.usernameDataLabel.Location = new System.Drawing.Point(256, 141);
            this.usernameDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameDataLabel.Name = "usernameDataLabel";
            this.usernameDataLabel.Size = new System.Drawing.Size(0, 30);
            this.usernameDataLabel.TabIndex = 20;
            // 
            // ChangeUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 278);
            this.Controls.Add(this.usernameDataLabel);
            this.Controls.Add(this.lastNameDataLabel);
            this.Controls.Add(this.firstNameDataLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUsersForm";
            this.Text = "Промени при потребителите";
            this.Load += new System.EventHandler(this.ChangeUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label firstNameDataLabel;
        private System.Windows.Forms.Label lastNameDataLabel;
        private System.Windows.Forms.Label usernameDataLabel;
    }
}