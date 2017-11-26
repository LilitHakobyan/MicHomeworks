namespace Tic_Tac_Toe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.XPoint = new System.Windows.Forms.Label();
            this.DPoint = new System.Windows.Forms.Label();
            this.OPoint = new System.Windows.Forms.Label();
            this.playeWithCompToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.playeWithCompToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.resetToolStripMenuItem.Text = "Reset Win Counts";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn11.Location = new System.Drawing.Point(0, 27);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(115, 102);
            this.btn11.TabIndex = 1;
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.button_Click);
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn12.Location = new System.Drawing.Point(121, 27);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(115, 102);
            this.btn12.TabIndex = 2;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.button_Click);
            // 
            // btn13
            // 
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn13.Location = new System.Drawing.Point(242, 27);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(115, 102);
            this.btn13.TabIndex = 3;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.button_Click);
            // 
            // btn21
            // 
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn21.Location = new System.Drawing.Point(0, 135);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(115, 102);
            this.btn21.TabIndex = 4;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.button_Click);
            // 
            // btn22
            // 
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn22.Location = new System.Drawing.Point(121, 135);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(115, 102);
            this.btn22.TabIndex = 5;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.button_Click);
            // 
            // btn23
            // 
            this.btn23.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn23.Location = new System.Drawing.Point(242, 135);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(115, 102);
            this.btn23.TabIndex = 6;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Click += new System.EventHandler(this.button_Click);
            // 
            // btn31
            // 
            this.btn31.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn31.Location = new System.Drawing.Point(0, 243);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(115, 102);
            this.btn31.TabIndex = 7;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Click += new System.EventHandler(this.button_Click);
            // 
            // btn32
            // 
            this.btn32.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn32.Location = new System.Drawing.Point(121, 243);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(115, 102);
            this.btn32.TabIndex = 8;
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.Click += new System.EventHandler(this.button_Click);
            // 
            // btn33
            // 
            this.btn33.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn33.Location = new System.Drawing.Point(242, 243);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(115, 102);
            this.btn33.TabIndex = 9;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.Click += new System.EventHandler(this.button_Click);
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(0, 348);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(115, 30);
            this.X.TabIndex = 10;
            this.X.Text = "Player1 Win Count";
            // 
            // Player2
            // 
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2.Location = new System.Drawing.Point(242, 348);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(115, 30);
            this.Player2.TabIndex = 11;
            this.Player2.Text = "Player2 Win Count";
            // 
            // D
            // 
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D.Location = new System.Drawing.Point(118, 348);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(115, 30);
            this.D.TabIndex = 12;
            this.D.Text = "Draw Count";
            // 
            // XPoint
            // 
            this.XPoint.AutoSize = true;
            this.XPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XPoint.Location = new System.Drawing.Point(80, 378);
            this.XPoint.Name = "XPoint";
            this.XPoint.Size = new System.Drawing.Size(15, 15);
            this.XPoint.TabIndex = 13;
            this.XPoint.Text = "0";
            // 
            // DPoint
            // 
            this.DPoint.AutoSize = true;
            this.DPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DPoint.Location = new System.Drawing.Point(197, 378);
            this.DPoint.Name = "DPoint";
            this.DPoint.Size = new System.Drawing.Size(15, 15);
            this.DPoint.TabIndex = 14;
            this.DPoint.Text = "0";
            // 
            // OPoint
            // 
            this.OPoint.AutoSize = true;
            this.OPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPoint.Location = new System.Drawing.Point(321, 377);
            this.OPoint.Name = "OPoint";
            this.OPoint.Size = new System.Drawing.Size(15, 15);
            this.OPoint.TabIndex = 15;
            this.OPoint.Text = "0";
            // 
            // playeWithCompToolStripMenuItem
            // 
            this.playeWithCompToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerToolStripMenuItem,
            this.player2ToolStripMenuItem});
            this.playeWithCompToolStripMenuItem.Name = "playeWithCompToolStripMenuItem";
            this.playeWithCompToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.playeWithCompToolStripMenuItem.Text = "Play With ";
            // 
            // computerToolStripMenuItem
            // 
            this.computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            this.computerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.computerToolStripMenuItem.Text = "Computer";
            this.computerToolStripMenuItem.Click += new System.EventHandler(this.computerToolStripMenuItem_Click);
            // 
            // player2ToolStripMenuItem
            // 
            this.player2ToolStripMenuItem.Name = "player2ToolStripMenuItem";
            this.player2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.player2ToolStripMenuItem.Text = "Player2";
            this.player2ToolStripMenuItem.Click += new System.EventHandler(this.player2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(360, 416);
            this.Controls.Add(this.OPoint);
            this.Controls.Add(this.DPoint);
            this.Controls.Add(this.XPoint);
            this.Controls.Add(this.D);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.X);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 455);
            this.MinimumSize = new System.Drawing.Size(376, 455);
            this.Name = "Form1";
            this.Text = "Xs and Os";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label XPoint;
        private System.Windows.Forms.Label DPoint;
        private System.Windows.Forms.Label OPoint;
        private System.Windows.Forms.ToolStripMenuItem playeWithCompToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player2ToolStripMenuItem;
    }
}

