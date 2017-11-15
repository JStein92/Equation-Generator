namespace EquationGenerator
{
    partial class EquationGenerator
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "*"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "+"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "-"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "/"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateProblemBtn = new System.Windows.Forms.Button();
            this.solutionBox = new System.Windows.Forms.RichTextBox();
            this.numberOfOperatorsBox = new System.Windows.Forms.NumericUpDown();
            this.difficultyBox = new System.Windows.Forms.NumericUpDown();
            this.operandsBox = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfOperatorsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Difficulty";
            // 
            // generateProblemBtn
            // 
            this.generateProblemBtn.Location = new System.Drawing.Point(12, 113);
            this.generateProblemBtn.Name = "generateProblemBtn";
            this.generateProblemBtn.Size = new System.Drawing.Size(188, 23);
            this.generateProblemBtn.TabIndex = 4;
            this.generateProblemBtn.Text = "Generate";
            this.generateProblemBtn.UseVisualStyleBackColor = true;
            this.generateProblemBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // solutionBox
            // 
            this.solutionBox.AccessibleName = "solutionBox";
            this.solutionBox.Location = new System.Drawing.Point(12, 142);
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.ReadOnly = true;
            this.solutionBox.Size = new System.Drawing.Size(193, 114);
            this.solutionBox.TabIndex = 5;
            this.solutionBox.Text = "";
            // 
            // numberOfOperatorsBox
            // 
            this.numberOfOperatorsBox.Location = new System.Drawing.Point(12, 26);
            this.numberOfOperatorsBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfOperatorsBox.Name = "numberOfOperatorsBox";
            this.numberOfOperatorsBox.Size = new System.Drawing.Size(88, 20);
            this.numberOfOperatorsBox.TabIndex = 7;
            this.numberOfOperatorsBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // difficultyBox
            // 
            this.difficultyBox.Location = new System.Drawing.Point(116, 25);
            this.difficultyBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.difficultyBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(84, 20);
            this.difficultyBox.TabIndex = 8;
            this.difficultyBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // operandsBox
            // 
            this.operandsBox.BackColor = System.Drawing.SystemColors.Window;
            this.operandsBox.HideSelection = false;
            this.operandsBox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.operandsBox.Location = new System.Drawing.Point(12, 72);
            this.operandsBox.Name = "operandsBox";
            this.operandsBox.Size = new System.Drawing.Size(188, 35);
            this.operandsBox.TabIndex = 9;
            this.operandsBox.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Operators to use (can select multiple)";
            // 
            // EquationGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(211, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operandsBox);
            this.Controls.Add(this.difficultyBox);
            this.Controls.Add(this.numberOfOperatorsBox);
            this.Controls.Add(this.solutionBox);
            this.Controls.Add(this.generateProblemBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EquationGenerator";
            this.Text = "Equation Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfOperatorsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateProblemBtn;
        private System.Windows.Forms.RichTextBox solutionBox;
        private System.Windows.Forms.NumericUpDown numberOfOperatorsBox;
        private System.Windows.Forms.NumericUpDown difficultyBox;
        private System.Windows.Forms.ListView operandsBox;
        private System.Windows.Forms.Label label3;
    }
}

