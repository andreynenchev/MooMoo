namespace WindowsFormsApplication1
{
    partial class FormCows
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCows));
            this.Menu = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.GroupBox();
            this.BullsForm = new System.Windows.Forms.NumericUpDown();
            this.CowsForm = new System.Windows.Forms.NumericUpDown();
            this.ButtonAnswer = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.Automatic = new System.Windows.Forms.CheckBox();
            this.Num = new System.Windows.Forms.TextBox();
            this.Exit2 = new System.Windows.Forms.Button();
            this.Guess = new System.Windows.Forms.Button();
            this.TestBox = new System.Windows.Forms.GroupBox();
            this.numberoftests = new System.Windows.Forms.NumericUpDown();
            this.Testprogress = new System.Windows.Forms.ProgressBar();
            this.TestText = new System.Windows.Forms.TextBox();
            this.process1 = new System.Diagnostics.Process();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BullsForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowsForm)).BeginInit();
            this.TestBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberoftests)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Exit);
            this.Menu.Controls.Add(this.Test);
            this.Menu.Controls.Add(this.NewGame);
            this.Menu.Location = new System.Drawing.Point(389, 37);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(264, 313);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(95, 140);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(95, 111);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 2;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(95, 82);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Game
            // 
            this.Game.Controls.Add(this.BullsForm);
            this.Game.Controls.Add(this.CowsForm);
            this.Game.Controls.Add(this.ButtonAnswer);
            this.Game.Controls.Add(this.textBox4);
            this.Game.Controls.Add(this.textBox3);
            this.Game.Controls.Add(this.Output);
            this.Game.Controls.Add(this.Automatic);
            this.Game.Controls.Add(this.Num);
            this.Game.Controls.Add(this.Exit2);
            this.Game.Controls.Add(this.Guess);
            this.Game.Location = new System.Drawing.Point(36, 37);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(298, 468);
            this.Game.TabIndex = 1;
            this.Game.TabStop = false;
            this.Game.Text = "Game";
            this.Game.Visible = false;
            // 
            // BullsForm
            // 
            this.BullsForm.Location = new System.Drawing.Point(105, 98);
            this.BullsForm.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.BullsForm.Name = "BullsForm";
            this.BullsForm.Size = new System.Drawing.Size(28, 20);
            this.BullsForm.TabIndex = 12;
            this.BullsForm.ValueChanged += new System.EventHandler(this.BullsForm_ValueChanged);
            // 
            // CowsForm
            // 
            this.CowsForm.Location = new System.Drawing.Point(30, 97);
            this.CowsForm.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CowsForm.Name = "CowsForm";
            this.CowsForm.Size = new System.Drawing.Size(28, 20);
            this.CowsForm.TabIndex = 3;
            this.CowsForm.ValueChanged += new System.EventHandler(this.CowsForm_ValueChanged);
            // 
            // ButtonAnswer
            // 
            this.ButtonAnswer.Enabled = false;
            this.ButtonAnswer.Location = new System.Drawing.Point(178, 93);
            this.ButtonAnswer.Name = "ButtonAnswer";
            this.ButtonAnswer.Size = new System.Drawing.Size(75, 23);
            this.ButtonAnswer.TabIndex = 11;
            this.ButtonAnswer.Text = "Answer";
            this.ButtonAnswer.UseVisualStyleBackColor = true;
            this.ButtonAnswer.Click += new System.EventHandler(this.ButtonAnswer_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(64, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(35, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Cows";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(34, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Bulls";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(22, 140);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(214, 269);
            this.Output.TabIndex = 6;
            // 
            // Automatic
            // 
            this.Automatic.AutoSize = true;
            this.Automatic.Checked = true;
            this.Automatic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Automatic.Location = new System.Drawing.Point(39, 16);
            this.Automatic.Name = "Automatic";
            this.Automatic.Size = new System.Drawing.Size(125, 17);
            this.Automatic.TabIndex = 5;
            this.Automatic.Text = "Automatic Answering";
            this.Automatic.UseVisualStyleBackColor = true;
            this.Automatic.CheckedChanged += new System.EventHandler(this.Automatic_CheckedChanged);
            // 
            // Num
            // 
            this.Num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Num.Location = new System.Drawing.Point(39, 39);
            this.Num.MaxLength = 4;
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(100, 20);
            this.Num.TabIndex = 0;
            this.Num.TextChanged += new System.EventHandler(this.Num_TextChanged);
            // 
            // Exit2
            // 
            this.Exit2.Location = new System.Drawing.Point(178, 68);
            this.Exit2.Name = "Exit2";
            this.Exit2.Size = new System.Drawing.Size(75, 23);
            this.Exit2.TabIndex = 4;
            this.Exit2.Text = "Exit";
            this.Exit2.UseVisualStyleBackColor = true;
            this.Exit2.Click += new System.EventHandler(this.Exit2_Click);
            // 
            // Guess
            // 
            this.Guess.Location = new System.Drawing.Point(178, 39);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(75, 23);
            this.Guess.TabIndex = 1;
            this.Guess.Text = "Guess";
            this.Guess.UseVisualStyleBackColor = true;
            this.Guess.Click += new System.EventHandler(this.Guess_Click);
            // 
            // TestBox
            // 
            this.TestBox.Controls.Add(this.numberoftests);
            this.TestBox.Controls.Add(this.Testprogress);
            this.TestBox.Controls.Add(this.TestText);
            this.TestBox.Location = new System.Drawing.Point(673, 37);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(202, 312);
            this.TestBox.TabIndex = 2;
            this.TestBox.TabStop = false;
            this.TestBox.Text = "Test";
            this.TestBox.Visible = false;
            // 
            // numberoftests
            // 
            this.numberoftests.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberoftests.Location = new System.Drawing.Point(44, 231);
            this.numberoftests.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberoftests.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberoftests.Name = "numberoftests";
            this.numberoftests.Size = new System.Drawing.Size(120, 20);
            this.numberoftests.TabIndex = 2;
            this.numberoftests.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Testprogress
            // 
            this.Testprogress.Location = new System.Drawing.Point(44, 266);
            this.Testprogress.Name = "Testprogress";
            this.Testprogress.Size = new System.Drawing.Size(119, 23);
            this.Testprogress.TabIndex = 1;
            // 
            // TestText
            // 
            this.TestText.Location = new System.Drawing.Point(6, 16);
            this.TestText.Multiline = true;
            this.TestText.Name = "TestText";
            this.TestText.ReadOnly = true;
            this.TestText.Size = new System.Drawing.Size(190, 286);
            this.TestText.TabIndex = 0;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AccessibleName = "Menu";
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 26);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.testToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newToolStripMenuItem.Text = "&New Game";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // FormCows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 514);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Game);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCows";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCows_Load);
            this.Menu.ResumeLayout(false);
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BullsForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CowsForm)).EndInit();
            this.TestBox.ResumeLayout(false);
            this.TestBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberoftests)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.GroupBox Game;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Button Guess;
        private System.Windows.Forms.Button Exit2;
        private System.Windows.Forms.CheckBox Automatic;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button ButtonAnswer;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown CowsForm;
        private System.Windows.Forms.NumericUpDown BullsForm;
        private System.Windows.Forms.GroupBox TestBox;
        private System.Windows.Forms.TextBox TestText;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ProgressBar Testprogress;
        private System.Windows.Forms.NumericUpDown numberoftests;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

