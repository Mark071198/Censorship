namespace WindowsFormsApp11
{
    partial class Form4
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
            this.CorrectText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCensorship = new System.Windows.Forms.TextBox();
            this.Censorship = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textAfterCensorshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notCorrectWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutOfYourAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCensor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CorrectText
            // 
            this.CorrectText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CorrectText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CorrectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectText.Location = new System.Drawing.Point(402, 137);
            this.CorrectText.MinimumSize = new System.Drawing.Size(215, 252);
            this.CorrectText.Multiline = true;
            this.CorrectText.Name = "CorrectText";
            this.CorrectText.ReadOnly = true;
            this.CorrectText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CorrectText.Size = new System.Drawing.Size(290, 349);
            this.CorrectText.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(302, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Not correct words:";
            // 
            // textCensorship
            // 
            this.textCensorship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCensorship.BackColor = System.Drawing.Color.LightCoral;
            this.textCensorship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCensorship.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textCensorship.Location = new System.Drawing.Point(1110, 264);
            this.textCensorship.MinimumSize = new System.Drawing.Size(229, 51);
            this.textCensorship.Multiline = true;
            this.textCensorship.Name = "textCensorship";
            this.textCensorship.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCensorship.Size = new System.Drawing.Size(416, 51);
            this.textCensorship.TabIndex = 14;
            // 
            // Censorship
            // 
            this.Censorship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Censorship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Censorship.Location = new System.Drawing.Point(306, 658);
            this.Censorship.MaximumSize = new System.Drawing.Size(150, 60);
            this.Censorship.MinimumSize = new System.Drawing.Size(122, 29);
            this.Censorship.Name = "Censorship";
            this.Censorship.Size = new System.Drawing.Size(122, 29);
            this.Censorship.TabIndex = 13;
            this.Censorship.Text = "Censorship";
            this.Censorship.UseVisualStyleBackColor = true;
            this.Censorship.Click += new System.EventHandler(this.Censorship_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(473, 112);
            this.label3.MinimumSize = new System.Drawing.Size(161, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Text after censorship:";
            // 
            // textBase
            // 
            this.textBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBase.Location = new System.Drawing.Point(52, 135);
            this.textBase.MaximumSize = new System.Drawing.Size(600, 400);
            this.textBase.MinimumSize = new System.Drawing.Size(193, 252);
            this.textBase.Multiline = true;
            this.textBase.Name = "textBase";
            this.textBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBase.Size = new System.Drawing.Size(281, 351);
            this.textBase.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(153, 112);
            this.label1.MinimumSize = new System.Drawing.Size(84, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Base text:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importForToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.adminMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importForToolStripMenuItem
            // 
            this.importForToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseTextToolStripMenuItem,
            this.notToolStripMenuItem});
            this.importForToolStripMenuItem.Name = "importForToolStripMenuItem";
            this.importForToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.importForToolStripMenuItem.Text = "Import for ...";
            // 
            // baseTextToolStripMenuItem
            // 
            this.baseTextToolStripMenuItem.Name = "baseTextToolStripMenuItem";
            this.baseTextToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.baseTextToolStripMenuItem.Text = "Base text";
            this.baseTextToolStripMenuItem.Click += new System.EventHandler(this.baseTextToolStripMenuItem_Click);
            // 
            // notToolStripMenuItem
            // 
            this.notToolStripMenuItem.Name = "notToolStripMenuItem";
            this.notToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notToolStripMenuItem.Text = "Not correct words";
            this.notToolStripMenuItem.Click += new System.EventHandler(this.notToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseTextToolStripMenuItem1,
            this.textAfterCensorshipToolStripMenuItem,
            this.notCorrectWordsToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.saveToolStripMenuItem.Text = "Save ...";
            // 
            // baseTextToolStripMenuItem1
            // 
            this.baseTextToolStripMenuItem1.Name = "baseTextToolStripMenuItem1";
            this.baseTextToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.baseTextToolStripMenuItem1.Text = "Base text";
            this.baseTextToolStripMenuItem1.Click += new System.EventHandler(this.baseTextToolStripMenuItem1_Click);
            // 
            // textAfterCensorshipToolStripMenuItem
            // 
            this.textAfterCensorshipToolStripMenuItem.Name = "textAfterCensorshipToolStripMenuItem";
            this.textAfterCensorshipToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.textAfterCensorshipToolStripMenuItem.Text = "Text after censorship";
            this.textAfterCensorshipToolStripMenuItem.Click += new System.EventHandler(this.textAfterCensorshipToolStripMenuItem_Click);
            // 
            // notCorrectWordsToolStripMenuItem
            // 
            this.notCorrectWordsToolStripMenuItem.Name = "notCorrectWordsToolStripMenuItem";
            this.notCorrectWordsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.notCorrectWordsToolStripMenuItem.Text = "Not correct words";
            this.notCorrectWordsToolStripMenuItem.Click += new System.EventHandler(this.notCorrectWordsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCloseToolStripMenuItem,
            this.signOutOfYourAccountToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.exitToolStripMenuItem.Text = "Exit ...";
            // 
            // allCloseToolStripMenuItem
            // 
            this.allCloseToolStripMenuItem.Name = "allCloseToolStripMenuItem";
            this.allCloseToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.allCloseToolStripMenuItem.Text = "All close";
            this.allCloseToolStripMenuItem.Click += new System.EventHandler(this.allCloseToolStripMenuItem_Click);
            // 
            // signOutOfYourAccountToolStripMenuItem
            // 
            this.signOutOfYourAccountToolStripMenuItem.Name = "signOutOfYourAccountToolStripMenuItem";
            this.signOutOfYourAccountToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.signOutOfYourAccountToolStripMenuItem.Text = "Sign out of your account ";
            this.signOutOfYourAccountToolStripMenuItem.Click += new System.EventHandler(this.signOutOfYourAccountToolStripMenuItem_Click);
            // 
            // adminMenuToolStripMenuItem
            // 
            this.adminMenuToolStripMenuItem.Name = "adminMenuToolStripMenuItem";
            this.adminMenuToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.adminMenuToolStripMenuItem.Text = "Admin Menu";
            this.adminMenuToolStripMenuItem.Click += new System.EventHandler(this.adminMenuToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(644, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(698, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "User";
            // 
            // textCensor
            // 
            this.textCensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCensor.BackColor = System.Drawing.Color.LightCoral;
            this.textCensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCensor.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textCensor.Location = new System.Drawing.Point(157, 568);
            this.textCensor.MinimumSize = new System.Drawing.Size(229, 51);
            this.textCensor.Multiline = true;
            this.textCensor.Name = "textCensor";
            this.textCensor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCensor.Size = new System.Drawing.Size(416, 51);
            this.textCensor.TabIndex = 20;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(745, 699);
            this.Controls.Add(this.textCensor);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Censorship (admin versia)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CorrectText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCensorship;
        private System.Windows.Forms.Button Censorship;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textAfterCensorshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notCorrectWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutOfYourAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCensor;
    }
}