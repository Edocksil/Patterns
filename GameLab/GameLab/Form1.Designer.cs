namespace GameLab
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
            this.toolStripNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFor2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFor3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFor4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRules = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMoves = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewGame,
            this.toolStripRules});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripNewGame
            // 
            this.toolStripNewGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFor2,
            this.toolStripFor3,
            this.toolStripFor4});
            this.toolStripNewGame.Name = "toolStripNewGame";
            this.toolStripNewGame.Size = new System.Drawing.Size(84, 24);
            this.toolStripNewGame.Text = "Нова гра";
            // 
            // toolStripFor2
            // 
            this.toolStripFor2.Name = "toolStripFor2";
            this.toolStripFor2.Size = new System.Drawing.Size(140, 26);
            this.toolStripFor2.Text = "2 гравці";
            this.toolStripFor2.Click += new System.EventHandler(this.toolStripFor2_Click);
            // 
            // toolStripFor3
            // 
            this.toolStripFor3.Name = "toolStripFor3";
            this.toolStripFor3.Size = new System.Drawing.Size(140, 26);
            this.toolStripFor3.Text = "3 гравці";
            this.toolStripFor3.Click += new System.EventHandler(this.toolStripFor3_Click);
            // 
            // toolStripFor4
            // 
            this.toolStripFor4.Name = "toolStripFor4";
            this.toolStripFor4.Size = new System.Drawing.Size(140, 26);
            this.toolStripFor4.Text = "4 гравці";
            this.toolStripFor4.Click += new System.EventHandler(this.toolStripFor4_Click);
            // 
            // toolStripRules
            // 
            this.toolStripRules.Name = "toolStripRules";
            this.toolStripRules.Size = new System.Drawing.Size(82, 24);
            this.toolStripRules.Text = "Правила";
            this.toolStripRules.Click += new System.EventHandler(this.toolStripRules_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMove.Location = new System.Drawing.Point(798, 446);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(452, 95);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Зробити крок";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMoves);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(798, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 375);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Гравці";
            // 
            // textBoxMoves
            // 
            this.textBoxMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoves.Location = new System.Drawing.Point(394, 334);
            this.textBoxMoves.Name = "textBoxMoves";
            this.textBoxMoves.ReadOnly = true;
            this.textBoxMoves.Size = new System.Drawing.Size(47, 28);
            this.textBoxMoves.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "До завалу печери у вас лишилося кроків: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(289, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 300);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поточні скарби";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(180, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 300);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поточне здоров\'я";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Гравець-4: ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Гравець-3: ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Гравець-2: ім\'я";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Гравець-1: ім\'я";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(798, 413);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(452, 27);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Розпочати гру";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // LogText
            // 
            this.LogText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogText.Location = new System.Drawing.Point(13, 32);
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LogText.Size = new System.Drawing.Size(779, 509);
            this.LogText.TabIndex = 6;
            this.LogText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1262, 553);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1280, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Втеча з підземелля";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripNewGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripFor2;
        private System.Windows.Forms.ToolStripMenuItem toolStripFor3;
        private System.Windows.Forms.ToolStripMenuItem toolStripFor4;
        private System.Windows.Forms.ToolStripMenuItem toolStripRules;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMoves;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox LogText;
    }
}

