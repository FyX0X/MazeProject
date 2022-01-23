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
            this.mazeSize.Location = new System.Drawing.Point(13, 39);
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
            this.multiSolutionCB.Location = new System.Drawing.Point(13, 91);
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
            this.showStartEndCB.Location = new System.Drawing.Point(13, 118);
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
            this.saveMazeB.Location = new System.Drawing.Point(12, 170);
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
            this.showSolutionCB.Location = new System.Drawing.Point(12, 144);
            this.showSolutionCB.Name = "showSolutionCB";
            this.showSolutionCB.Size = new System.Drawing.Size(111, 20);
            this.showSolutionCB.TabIndex = 7;
            this.showSolutionCB.Text = "Show solution";
            this.showSolutionCB.UseVisualStyleBackColor = true;
            this.showSolutionCB.CheckedChanged += new System.EventHandler(this.showSolutionCB_CheckedChanged);
            // 
            // loadMazeB
            // 
            this.loadMazeB.Location = new System.Drawing.Point(12, 199);
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
            this.changeFileDirB.Location = new System.Drawing.Point(12, 229);
            this.changeFileDirB.Name = "changeFileDirB";
            this.changeFileDirB.Size = new System.Drawing.Size(86, 44);
            this.changeFileDirB.TabIndex = 10;
            this.changeFileDirB.Text = "Change file directory";
            this.changeFileDirB.UseVisualStyleBackColor = true;
            this.changeFileDirB.Click += new System.EventHandler(this.changeFileDirB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 675);
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
    }
}

