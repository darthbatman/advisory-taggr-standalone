namespace atUITest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.explicitButton = new System.Windows.Forms.Button();
            this.explicitCheckBox = new System.Windows.Forms.CheckBox();
            this.cleanCheckBox = new System.Windows.Forms.CheckBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.noneCheckBox = new System.Windows.Forms.CheckBox();
            this.noneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // explicitButton
            // 
            this.explicitButton.Location = new System.Drawing.Point(30, 191);
            this.explicitButton.Name = "explicitButton";
            this.explicitButton.Size = new System.Drawing.Size(75, 23);
            this.explicitButton.TabIndex = 0;
            this.explicitButton.Text = "Explicit";
            this.explicitButton.UseVisualStyleBackColor = true;
            this.explicitButton.Click += new System.EventHandler(this.explicitButton_Click);
            // 
            // explicitCheckBox
            // 
            this.explicitCheckBox.AutoSize = true;
            this.explicitCheckBox.Enabled = false;
            this.explicitCheckBox.Location = new System.Drawing.Point(9, 196);
            this.explicitCheckBox.Name = "explicitCheckBox";
            this.explicitCheckBox.Size = new System.Drawing.Size(15, 14);
            this.explicitCheckBox.TabIndex = 1;
            this.explicitCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleanCheckBox
            // 
            this.cleanCheckBox.AutoSize = true;
            this.cleanCheckBox.Enabled = false;
            this.cleanCheckBox.Location = new System.Drawing.Point(141, 196);
            this.cleanCheckBox.Name = "cleanCheckBox";
            this.cleanCheckBox.Size = new System.Drawing.Size(15, 14);
            this.cleanCheckBox.TabIndex = 3;
            this.cleanCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(162, 191);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 2;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // noneCheckBox
            // 
            this.noneCheckBox.AutoSize = true;
            this.noneCheckBox.Checked = true;
            this.noneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noneCheckBox.Enabled = false;
            this.noneCheckBox.Location = new System.Drawing.Point(276, 196);
            this.noneCheckBox.Name = "noneCheckBox";
            this.noneCheckBox.Size = new System.Drawing.Size(15, 14);
            this.noneCheckBox.TabIndex = 5;
            this.noneCheckBox.UseVisualStyleBackColor = true;
            // 
            // noneButton
            // 
            this.noneButton.Location = new System.Drawing.Point(297, 191);
            this.noneButton.Name = "noneButton";
            this.noneButton.Size = new System.Drawing.Size(75, 23);
            this.noneButton.TabIndex = 4;
            this.noneButton.Text = "None";
            this.noneButton.UseVisualStyleBackColor = true;
            this.noneButton.Click += new System.EventHandler(this.noneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Drop Song(s) Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "advisoryTaggr";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(344, 224);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(28, 28);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Developed by Rishi Masand (2016-2017)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noneCheckBox);
            this.Controls.Add(this.noneButton);
            this.Controls.Add(this.cleanCheckBox);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.explicitCheckBox);
            this.Controls.Add(this.explicitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "advisoryTaggr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button explicitButton;
        private System.Windows.Forms.CheckBox explicitCheckBox;
        private System.Windows.Forms.CheckBox cleanCheckBox;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.CheckBox noneCheckBox;
        private System.Windows.Forms.Button noneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label3;
    }
}

