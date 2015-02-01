namespace MakeClassesNotEnumsWinForms
{
    partial class Form1
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
            this.sqlJobEnumButton = new System.Windows.Forms.Button();
            this.fileJobEnumButton = new System.Windows.Forms.Button();
            this.classesGroupBox = new System.Windows.Forms.GroupBox();
            this.sqlJobClassButton = new System.Windows.Forms.Button();
            this.fileJobClassEnum = new System.Windows.Forms.Button();
            this.enumsGroupBox = new System.Windows.Forms.GroupBox();
            this.classesGroupBox.SuspendLayout();
            this.enumsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlJobEnumButton
            // 
            this.sqlJobEnumButton.Location = new System.Drawing.Point(6, 19);
            this.sqlJobEnumButton.Name = "sqlJobEnumButton";
            this.sqlJobEnumButton.Size = new System.Drawing.Size(75, 23);
            this.sqlJobEnumButton.TabIndex = 0;
            this.sqlJobEnumButton.Text = "SQL Job";
            this.sqlJobEnumButton.UseVisualStyleBackColor = true;
            this.sqlJobEnumButton.Click += new System.EventHandler(this.sqlJobEnumButton_Click);
            // 
            // fileJobEnumButton
            // 
            this.fileJobEnumButton.Location = new System.Drawing.Point(6, 48);
            this.fileJobEnumButton.Name = "fileJobEnumButton";
            this.fileJobEnumButton.Size = new System.Drawing.Size(75, 23);
            this.fileJobEnumButton.TabIndex = 1;
            this.fileJobEnumButton.Text = "File Job";
            this.fileJobEnumButton.UseVisualStyleBackColor = true;
            this.fileJobEnumButton.Click += new System.EventHandler(this.fileJobEnumButton_Click);
            // 
            // classesGroupBox
            // 
            this.classesGroupBox.Controls.Add(this.sqlJobClassButton);
            this.classesGroupBox.Controls.Add(this.fileJobClassEnum);
            this.classesGroupBox.Location = new System.Drawing.Point(106, 12);
            this.classesGroupBox.Name = "classesGroupBox";
            this.classesGroupBox.Size = new System.Drawing.Size(88, 100);
            this.classesGroupBox.TabIndex = 2;
            this.classesGroupBox.TabStop = false;
            this.classesGroupBox.Text = "Classes";
            // 
            // sqlJobClassButton
            // 
            this.sqlJobClassButton.Location = new System.Drawing.Point(6, 19);
            this.sqlJobClassButton.Name = "sqlJobClassButton";
            this.sqlJobClassButton.Size = new System.Drawing.Size(75, 23);
            this.sqlJobClassButton.TabIndex = 2;
            this.sqlJobClassButton.Text = "SQL Job";
            this.sqlJobClassButton.UseVisualStyleBackColor = true;
            this.sqlJobClassButton.Click += new System.EventHandler(this.sqlJobClassButton_Click);
            // 
            // fileJobClassEnum
            // 
            this.fileJobClassEnum.Location = new System.Drawing.Point(6, 48);
            this.fileJobClassEnum.Name = "fileJobClassEnum";
            this.fileJobClassEnum.Size = new System.Drawing.Size(75, 23);
            this.fileJobClassEnum.TabIndex = 3;
            this.fileJobClassEnum.Text = "File Job";
            this.fileJobClassEnum.UseVisualStyleBackColor = true;
            this.fileJobClassEnum.Click += new System.EventHandler(this.fileJobClassEnum_Click);
            // 
            // enumsGroupBox
            // 
            this.enumsGroupBox.Controls.Add(this.sqlJobEnumButton);
            this.enumsGroupBox.Controls.Add(this.fileJobEnumButton);
            this.enumsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.enumsGroupBox.Name = "enumsGroupBox";
            this.enumsGroupBox.Size = new System.Drawing.Size(88, 100);
            this.enumsGroupBox.TabIndex = 3;
            this.enumsGroupBox.TabStop = false;
            this.enumsGroupBox.Text = "Enums";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.enumsGroupBox);
            this.Controls.Add(this.classesGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.classesGroupBox.ResumeLayout(false);
            this.enumsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sqlJobEnumButton;
        private System.Windows.Forms.Button fileJobEnumButton;
        private System.Windows.Forms.GroupBox classesGroupBox;
        private System.Windows.Forms.Button sqlJobClassButton;
        private System.Windows.Forms.Button fileJobClassEnum;
        private System.Windows.Forms.GroupBox enumsGroupBox;
    }
}

