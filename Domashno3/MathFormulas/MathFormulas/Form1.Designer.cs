namespace MathFormulas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.математическиФормулиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгебраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.класToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.класToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.класToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.математическиФормулиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // математическиФормулиToolStripMenuItem
            // 
            this.математическиФормулиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алгебраToolStripMenuItem});
            this.математическиФормулиToolStripMenuItem.Name = "математическиФормулиToolStripMenuItem";
            this.математическиФормулиToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.математическиФормулиToolStripMenuItem.Text = "Математически формули";
            this.математическиФормулиToolStripMenuItem.Click += new System.EventHandler(this.математическиФормулиToolStripMenuItem_Click);
            // 
            // алгебраToolStripMenuItem
            // 
            this.алгебраToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.класToolStripMenuItem,
            this.класToolStripMenuItem1,
            this.класToolStripMenuItem2,
            this.изходToolStripMenuItem});
            this.алгебраToolStripMenuItem.Name = "алгебраToolStripMenuItem";
            this.алгебраToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.алгебраToolStripMenuItem.Text = "Алгебра";
            // 
            // класToolStripMenuItem
            // 
            this.класToolStripMenuItem.Name = "класToolStripMenuItem";
            this.класToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.класToolStripMenuItem.Text = "6 клас";
            this.класToolStripMenuItem.Click += new System.EventHandler(this.класToolStripMenuItem_Click);
            // 
            // класToolStripMenuItem1
            // 
            this.класToolStripMenuItem1.Name = "класToolStripMenuItem1";
            this.класToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.класToolStripMenuItem1.Text = "7 клас";
            this.класToolStripMenuItem1.Click += new System.EventHandler(this.класToolStripMenuItem1_Click);
            // 
            // класToolStripMenuItem2
            // 
            this.класToolStripMenuItem2.Name = "класToolStripMenuItem2";
            this.класToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.класToolStripMenuItem2.Text = "8 клас";
            this.класToolStripMenuItem2.Click += new System.EventHandler(this.класToolStripMenuItem2_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.изходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem математическиФормулиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгебраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem класToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem класToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem класToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
    }
}

