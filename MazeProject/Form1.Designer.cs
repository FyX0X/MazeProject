namespace MazeProject
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
            this.generateMaze = new System.Windows.Forms.Button();
            this.mazeSize = new System.Windows.Forms.Label();
            this.mazeWidth = new System.Windows.Forms.NumericUpDown();
            this.mazeHeight = new System.Windows.Forms.NumericUpDown();
            this.multiSolutionCB = new System.Windows.Forms.CheckBox();
            this.showStartEndCB = new System.Windows.Forms.CheckBox();
            this.saveMazeB = new System.Windows.Forms.Button();
            this.showSolutionCB = new System.Windows.Forms.CheckBox();
            this.loadMazeB = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.changeFileDirB = new System.Windows.Forms.Button();
            this.rngStartEndCB = new System.Windows.Forms.CheckBox();
            this.changeSEModeCB = new System.Windows.Forms.CheckBox();
            this.resetSEPosB = new System.Windows.Forms.Button();
            this.startPosL = new System.Windows.Forms.Label();
            this.startMoveUpB = new System.Windows.Forms.Button();
            this.startMoveDownB = new System.Windows.Forms.Button();
            this.startMoveLeftB = new System.Windows.Forms.Button();
            this.startMoveRightB = new System.Windows.Forms.Button();
            this.endMoveRightB = new System.Windows.Forms.Button();
            this.endMoveLeftB = new System.Windows.Forms.Button();
            this.endMoveDownB = new System.Windows.Forms.Button();
            this.endMoveUpB = new System.Windows.Forms.Button();
            this.endPosL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mazeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // generateMaze
            // 
            this.generateMaze.Location = new System.Drawing.Point(13, 13);
            this.generateMaze.Name = "generateMaze";
            this.generateMaze.Size = new System.Drawing.Size(85, 23);
            this.generateMaze.TabIndex = 0;
            this.generateMaze.Text = "Generate";
            this.generateMaze.UseVisualStyleBackColor = true;
            this.generateMaze.Click += new System.EventHandler(this.generateMaze_Click);
            // 
            // mazeSize
            // 
            this.mazeSize.AutoSize = true;
            this.mazeSize.Location = new System.Drawing.Point(10, 41);
            this.mazeSize.Name = "mazeSize";
            this.mazeSize.Size = new System.Drawing.Size(46, 48);
            this.mazeSize.TabIndex = 2;
            this.mazeSize.Text = "width:\r\n\r\nheight:";
            // 
            // mazeWidth
            // 
            this.mazeWidth.Location = new System.Drawing.Point(65, 39);
            this.mazeWidth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.mazeWidth.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.mazeWidth.Name = "mazeWidth";
            this.mazeWidth.Size = new System.Drawing.Size(42, 22);
            this.mazeWidth.TabIndex = 3;
            this.mazeWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.mazeWidth.ValueChanged += new System.EventHandler(this.mazeWidth_ValueChanged);
            // 
            // mazeHeight
            // 
            this.mazeHeight.Location = new System.Drawing.Point(65, 67);
            this.mazeHeight.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.mazeHeight.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.mazeHeight.Name = "mazeHeight";
            this.mazeHeight.Size = new System.Drawing.Size(42, 22);
            this.mazeHeight.TabIndex = 4;
            this.mazeHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.mazeHeight.ValueChanged += new System.EventHandler(this.mazeHeight_ValueChanged);
            // 
            // multiSolutionCB
            // 
            this.multiSolutionCB.AutoSize = true;
            this.multiSolutionCB.Location = new System.Drawing.Point(13, 95);
            this.multiSolutionCB.Name = "multiSolutionCB";
            this.multiSolutionCB.Size = new System.Drawing.Size(124, 20);
            this.multiSolutionCB.TabIndex = 5;
            this.multiSolutionCB.Text = "Multiple solution";
            this.multiSolutionCB.UseVisualStyleBackColor = true;
            // 
            // showStartEndCB
            // 
            this.showStartEndCB.AutoSize = true;
            this.showStartEndCB.Checked = true;
            this.showStartEndCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStartEndCB.Location = new System.Drawing.Point(13, 121);
            this.showStartEndCB.Name = "showStartEndCB";
            this.showStartEndCB.Size = new System.Drawing.Size(115, 20);
            this.showStartEndCB.TabIndex = 6;
            this.showStartEndCB.Text = "show start/end";
            this.showStartEndCB.UseVisualStyleBackColor = true;
            this.showStartEndCB.CheckedChanged += new System.EventHandler(this.showStartEndCB_CheckedChanged);
            // 
            // saveMazeB
            // 
            this.saveMazeB.Enabled = false;
            this.saveMazeB.Location = new System.Drawing.Point(13, 225);
            this.saveMazeB.Name = "saveMazeB";
            this.saveMazeB.Size = new System.Drawing.Size(86, 23);
            this.saveMazeB.TabIndex = 8;
            this.saveMazeB.Text = "Save maze";
            this.saveMazeB.UseVisualStyleBackColor = true;
            this.saveMazeB.Click += new System.EventHandler(this.saveMazeB_Click);
            // 
            // showSolutionCB
            // 
            this.showSolutionCB.AutoSize = true;
            this.showSolutionCB.Location = new System.Drawing.Point(13, 147);
            this.showSolutionCB.Name = "showSolutionCB";
            this.showSolutionCB.Size = new System.Drawing.Size(111, 20);
            this.showSolutionCB.TabIndex = 7;
            this.showSolutionCB.Text = "Show solution";
            this.showSolutionCB.UseVisualStyleBackColor = true;
            this.showSolutionCB.CheckedChanged += new System.EventHandler(this.showSolutionCB_CheckedChanged);
            // 
            // loadMazeB
            // 
            this.loadMazeB.Location = new System.Drawing.Point(13, 254);
            this.loadMazeB.Name = "loadMazeB";
            this.loadMazeB.Size = new System.Drawing.Size(86, 23);
            this.loadMazeB.TabIndex = 9;
            this.loadMazeB.Text = "Load maze";
            this.loadMazeB.UseVisualStyleBackColor = true;
            this.loadMazeB.Click += new System.EventHandler(this.loadMazeB_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "maze";
            this.openFileDialog.Filter = "Maze file (*.maze)|*.maze";
            this.openFileDialog.InitialDirectory = "mazeData\\";
            this.openFileDialog.Title = "Load Maze";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // changeFileDirB
            // 
            this.changeFileDirB.Location = new System.Drawing.Point(13, 283);
            this.changeFileDirB.Name = "changeFileDirB";
            this.changeFileDirB.Size = new System.Drawing.Size(86, 44);
            this.changeFileDirB.TabIndex = 10;
            this.changeFileDirB.Text = "Change file directory";
            this.changeFileDirB.UseVisualStyleBackColor = true;
            this.changeFileDirB.Click += new System.EventHandler(this.changeFileDirB_Click);
            // 
            // rngStartEndCB
            // 
            this.rngStartEndCB.AutoSize = true;
            this.rngStartEndCB.Location = new System.Drawing.Point(13, 173);
            this.rngStartEndCB.Name = "rngStartEndCB";
            this.rngStartEndCB.Size = new System.Drawing.Size(136, 20);
            this.rngStartEndCB.TabIndex = 11;
            this.rngStartEndCB.Text = "Random start/end\r\n";
            this.rngStartEndCB.UseVisualStyleBackColor = true;
            this.rngStartEndCB.CheckedChanged += new System.EventHandler(this.rngStartEndCB_CheckedChanged);
            // 
            // changeSEModeCB
            // 
            this.changeSEModeCB.AutoSize = true;
            this.changeSEModeCB.Location = new System.Drawing.Point(13, 199);
            this.changeSEModeCB.Name = "changeSEModeCB";
            this.changeSEModeCB.Size = new System.Drawing.Size(131, 20);
            this.changeSEModeCB.TabIndex = 12;
            this.changeSEModeCB.Text = "Change start/end";
            this.changeSEModeCB.UseVisualStyleBackColor = true;
            this.changeSEModeCB.CheckedChanged += new System.EventHandler(this.changeSEModeCB_CheckedChanged);
            // 
            // resetSEPosB
            // 
            this.resetSEPosB.Location = new System.Drawing.Point(13, 349);
            this.resetSEPosB.Name = "resetSEPosB";
            this.resetSEPosB.Size = new System.Drawing.Size(106, 23);
            this.resetSEPosB.TabIndex = 13;
            this.resetSEPosB.Text = "Reset start/end";
            this.resetSEPosB.UseVisualStyleBackColor = true;
            this.resetSEPosB.Visible = false;
            this.resetSEPosB.Click += new System.EventHandler(this.resetSEPosB_Click);
            // 
            // startPosL
            // 
            this.startPosL.AutoSize = true;
            this.startPosL.Location = new System.Drawing.Point(10, 375);
            this.startPosL.Name = "startPosL";
            this.startPosL.Size = new System.Drawing.Size(64, 16);
            this.startPosL.TabIndex = 14;
            this.startPosL.Text = "Start Pos:";
            this.startPosL.Visible = false;
            // 
            // startMoveUpB
            // 
            this.startMoveUpB.Location = new System.Drawing.Point(36, 394);
            this.startMoveUpB.Name = "startMoveUpB";
            this.startMoveUpB.Size = new System.Drawing.Size(20, 23);
            this.startMoveUpB.TabIndex = 15;
            this.startMoveUpB.Text = "U";
            this.startMoveUpB.UseVisualStyleBackColor = true;
            this.startMoveUpB.Visible = false;
            this.startMoveUpB.Click += new System.EventHandler(this.startMoveUpB_Click);
            // 
            // startMoveDownB
            // 
            this.startMoveDownB.Location = new System.Drawing.Point(36, 423);
            this.startMoveDownB.Name = "startMoveDownB";
            this.startMoveDownB.Size = new System.Drawing.Size(20, 23);
            this.startMoveDownB.TabIndex = 16;
            this.startMoveDownB.Text = "D";
            this.startMoveDownB.UseVisualStyleBackColor = true;
            this.startMoveDownB.Visible = false;
            this.startMoveDownB.Click += new System.EventHandler(this.startMoveDownB_Click);
            // 
            // startMoveLeftB
            // 
            this.startMoveLeftB.Location = new System.Drawing.Point(10, 423);
            this.startMoveLeftB.Name = "startMoveLeftB";
            this.startMoveLeftB.Size = new System.Drawing.Size(20, 23);
            this.startMoveLeftB.TabIndex = 17;
            this.startMoveLeftB.Text = "L";
            this.startMoveLeftB.UseVisualStyleBackColor = true;
            this.startMoveLeftB.Visible = false;
            this.startMoveLeftB.Click += new System.EventHandler(this.startMoveLeftB_Click);
            // 
            // startMoveRightB
            // 
            this.startMoveRightB.Location = new System.Drawing.Point(62, 423);
            this.startMoveRightB.Name = "startMoveRightB";
            this.startMoveRightB.Size = new System.Drawing.Size(20, 23);
            this.startMoveRightB.TabIndex = 18;
            this.startMoveRightB.Text = "R";
            this.startMoveRightB.UseVisualStyleBackColor = true;
            this.startMoveRightB.Visible = false;
            this.startMoveRightB.Click += new System.EventHandler(this.startMoveRightB_Click);
            // 
            // endMoveRightB
            // 
            this.endMoveRightB.Location = new System.Drawing.Point(62, 504);
            this.endMoveRightB.Name = "endMoveRightB";
            this.endMoveRightB.Size = new System.Drawing.Size(20, 23);
            this.endMoveRightB.TabIndex = 23;
            this.endMoveRightB.Text = "R";
            this.endMoveRightB.UseVisualStyleBackColor = true;
            this.endMoveRightB.Visible = false;
            this.endMoveRightB.Click += new System.EventHandler(this.endMoveRightB_Click);
            // 
            // endMoveLeftB
            // 
            this.endMoveLeftB.Location = new System.Drawing.Point(10, 504);
            this.endMoveLeftB.Name = "endMoveLeftB";
            this.endMoveLeftB.Size = new System.Drawing.Size(20, 23);
            this.endMoveLeftB.TabIndex = 22;
            this.endMoveLeftB.Text = "L";
            this.endMoveLeftB.UseVisualStyleBackColor = true;
            this.endMoveLeftB.Visible = false;
            this.endMoveLeftB.Click += new System.EventHandler(this.endMoveLeftB_Click);
            // 
            // endMoveDownB
            // 
            this.endMoveDownB.Location = new System.Drawing.Point(36, 504);
            this.endMoveDownB.Name = "endMoveDownB";
            this.endMoveDownB.Size = new System.Drawing.Size(20, 23);
            this.endMoveDownB.TabIndex = 21;
            this.endMoveDownB.Text = "D";
            this.endMoveDownB.UseVisualStyleBackColor = true;
            this.endMoveDownB.Visible = false;
            this.endMoveDownB.Click += new System.EventHandler(this.endMoveDownB_Click);
            // 
            // endMoveUpB
            // 
            this.endMoveUpB.Location = new System.Drawing.Point(36, 475);
            this.endMoveUpB.Name = "endMoveUpB";
            this.endMoveUpB.Size = new System.Drawing.Size(20, 23);
            this.endMoveUpB.TabIndex = 20;
            this.endMoveUpB.Text = "U";
            this.endMoveUpB.UseVisualStyleBackColor = true;
            this.endMoveUpB.Visible = false;
            this.endMoveUpB.Click += new System.EventHandler(this.endMoveUpB_Click);
            // 
            // endPosL
            // 
            this.endPosL.AutoSize = true;
            this.endPosL.Location = new System.Drawing.Point(10, 456);
            this.endPosL.Name = "endPosL";
            this.endPosL.Size = new System.Drawing.Size(61, 16);
            this.endPosL.TabIndex = 19;
            this.endPosL.Text = "End Pos:";
            this.endPosL.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 675);
            this.Controls.Add(this.endMoveRightB);
            this.Controls.Add(this.endMoveLeftB);
            this.Controls.Add(this.endMoveDownB);
            this.Controls.Add(this.endMoveUpB);
            this.Controls.Add(this.endPosL);
            this.Controls.Add(this.startMoveRightB);
            this.Controls.Add(this.startMoveLeftB);
            this.Controls.Add(this.startMoveDownB);
            this.Controls.Add(this.startMoveUpB);
            this.Controls.Add(this.startPosL);
            this.Controls.Add(this.resetSEPosB);
            this.Controls.Add(this.changeSEModeCB);
            this.Controls.Add(this.rngStartEndCB);
            this.Controls.Add(this.changeFileDirB);
            this.Controls.Add(this.loadMazeB);
            this.Controls.Add(this.showSolutionCB);
            this.Controls.Add(this.saveMazeB);
            this.Controls.Add(this.showStartEndCB);
            this.Controls.Add(this.multiSolutionCB);
            this.Controls.Add(this.mazeHeight);
            this.Controls.Add(this.mazeWidth);
            this.Controls.Add(this.mazeSize);
            this.Controls.Add(this.generateMaze);
            this.Name = "Form1";
            this.Text = "Maze Project";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.mazeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateMaze;
        private System.Windows.Forms.Label mazeSize;
        private System.Windows.Forms.NumericUpDown mazeWidth;
        private System.Windows.Forms.NumericUpDown mazeHeight;
        private System.Windows.Forms.CheckBox multiSolutionCB;
        private System.Windows.Forms.CheckBox showStartEndCB;
        private System.Windows.Forms.Button saveMazeB;
        private System.Windows.Forms.CheckBox showSolutionCB;
        private System.Windows.Forms.Button loadMazeB;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button changeFileDirB;
        private System.Windows.Forms.CheckBox rngStartEndCB;
        private System.Windows.Forms.CheckBox changeSEModeCB;
        private System.Windows.Forms.Button resetSEPosB;
        private System.Windows.Forms.Label startPosL;
        private System.Windows.Forms.Button startMoveUpB;
        private System.Windows.Forms.Button startMoveDownB;
        private System.Windows.Forms.Button startMoveLeftB;
        private System.Windows.Forms.Button startMoveRightB;
        private System.Windows.Forms.Button endMoveRightB;
        private System.Windows.Forms.Button endMoveLeftB;
        private System.Windows.Forms.Button endMoveDownB;
        private System.Windows.Forms.Button endMoveUpB;
        private System.Windows.Forms.Label endPosL;
    }
}

