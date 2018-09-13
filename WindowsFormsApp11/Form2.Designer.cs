namespace WindowsFormsApp11
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.textBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Censorship = new System.Windows.Forms.Button();
            this.textCensorship = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CorrectText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.baseTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textAfterCensorshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notCorrectWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textAfterCensorshipToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutOfYourAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(175, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(112, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base text:";
            // 
            // textBase
            // 
            this.textBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBase.Location = new System.Drawing.Point(53, 135);
            this.textBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBase.MaximumSize = new System.Drawing.Size(799, 491);
            this.textBase.MinimumSize = new System.Drawing.Size(256, 309);
            this.textBase.Multiline = true;
            this.textBase.Name = "textBase";
            this.textBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBase.Size = new System.Drawing.Size(373, 431);
            this.textBase.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(607, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MinimumSize = new System.Drawing.Size(215, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text after censorship:";
            // 
            // Censorship
            // 
            this.Censorship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Censorship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Censorship.Location = new System.Drawing.Point(373, 794);
            this.Censorship.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Censorship.MaximumSize = new System.Drawing.Size(200, 74);
            this.Censorship.MinimumSize = new System.Drawing.Size(163, 36);
            this.Censorship.Name = "Censorship";
            this.Censorship.Size = new System.Drawing.Size(163, 36);
            this.Censorship.TabIndex = 4;
            this.Censorship.Text = "Censorship";
            this.Censorship.UseVisualStyleBackColor = true;
            this.Censorship.Click += new System.EventHandler(this.Censorship_Click);
            // 
            // textCensorship
            // 
            this.textCensorship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCensorship.BackColor = System.Drawing.Color.LightCoral;
            this.textCensorship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCensorship.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textCensorship.Location = new System.Drawing.Point(180, 662);
            this.textCensorship.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCensorship.MinimumSize = new System.Drawing.Size(304, 62);
            this.textCensorship.Multiline = true;
            this.textCensorship.Name = "textCensorship";
            this.textCensorship.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCensorship.Size = new System.Drawing.Size(553, 62);
            this.textCensorship.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(353, 634);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Not correct words:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CorrectText
            // 
            this.CorrectText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CorrectText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CorrectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectText.Location = new System.Drawing.Point(519, 138);
            this.CorrectText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CorrectText.MinimumSize = new System.Drawing.Size(285, 309);
            this.CorrectText.Multiline = true;
            this.CorrectText.Name = "CorrectText";
            this.CorrectText.ReadOnly = true;
            this.CorrectText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CorrectText.Size = new System.Drawing.Size(385, 429);
            this.CorrectText.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(897, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "User";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(988, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseTextToolStripMenuItem,
            this.textAfterCensorshipToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 24);
            this.toolStripMenuItem1.Text = "Import for...";
            // 
            // baseTextToolStripMenuItem
            // 
            this.baseTextToolStripMenuItem.Name = "baseTextToolStripMenuItem";
            this.baseTextToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.baseTextToolStripMenuItem.Text = "Base Text";
            this.baseTextToolStripMenuItem.Click += new System.EventHandler(this.baseTextToolStripMenuItem_Click);
            // 
            // textAfterCensorshipToolStripMenuItem
            // 
            this.textAfterCensorshipToolStripMenuItem.Name = "textAfterCensorshipToolStripMenuItem";
            this.textAfterCensorshipToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.textAfterCensorshipToolStripMenuItem.Text = "Not correct words";
            this.textAfterCensorshipToolStripMenuItem.Click += new System.EventHandler(this.textAfterCensorshipToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseTextToolStripMenuItem1,
            this.notCorrectWordsToolStripMenuItem,
            this.textAfterCensorshipToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.saveToolStripMenuItem.Text = "Save ...";
            // 
            // baseTextToolStripMenuItem1
            // 
            this.baseTextToolStripMenuItem1.Name = "baseTextToolStripMenuItem1";
            this.baseTextToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.baseTextToolStripMenuItem1.Text = "Base Text";
            this.baseTextToolStripMenuItem1.Click += new System.EventHandler(this.baseTextToolStripMenuItem1_Click);
            // 
            // notCorrectWordsToolStripMenuItem
            // 
            this.notCorrectWordsToolStripMenuItem.Name = "notCorrectWordsToolStripMenuItem";
            this.notCorrectWordsToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.notCorrectWordsToolStripMenuItem.Text = "Not correct words";
            this.notCorrectWordsToolStripMenuItem.Click += new System.EventHandler(this.notCorrectWordsToolStripMenuItem_Click);
            // 
            // textAfterCensorshipToolStripMenuItem1
            // 
            this.textAfterCensorshipToolStripMenuItem1.Name = "textAfterCensorshipToolStripMenuItem1";
            this.textAfterCensorshipToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.textAfterCensorshipToolStripMenuItem1.Text = "Text after censorship";
            this.textAfterCensorshipToolStripMenuItem1.Click += new System.EventHandler(this.textAfterCensorshipToolStripMenuItem1_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCloseToolStripMenuItem,
            this.signOutOfYourAccountToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.exitToolStripMenuItem.Text = "Exit...";
            // 
            // allCloseToolStripMenuItem
            // 
            this.allCloseToolStripMenuItem.Name = "allCloseToolStripMenuItem";
            this.allCloseToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.allCloseToolStripMenuItem.Text = "All close";
            this.allCloseToolStripMenuItem.Click += new System.EventHandler(this.allCloseToolStripMenuItem_Click);
            // 
            // signOutOfYourAccountToolStripMenuItem
            // 
            this.signOutOfYourAccountToolStripMenuItem.Name = "signOutOfYourAccountToolStripMenuItem";
            this.signOutOfYourAccountToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.signOutOfYourAccountToolStripMenuItem.Text = "Sign out of your account";
            this.signOutOfYourAccountToolStripMenuItem.Click += new System.EventHandler(this.signOutOfYourAccountToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(825, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 855);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CorrectText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCensorship);
            this.Controls.Add(this.Censorship);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2633, 1317);
            this.MinimumSize = new System.Drawing.Size(719, 644);
            this.Name = "Form2";
            this.Text = "Censorship";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Censorship;
        private System.Windows.Forms.TextBox textCensorship;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox CorrectText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem baseTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textAfterCensorshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notCorrectWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textAfterCensorshipToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutOfYourAccountToolStripMenuItem;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
    }
}