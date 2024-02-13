namespace TestScoreCalculator_Array
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtScore = new TextBox();
            txtScoreTotal = new TextBox();
            txtScoreCount = new TextBox();
            txtAverage = new TextBox();
            btnAdd = new Button();
            btnDisplayScores = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblScore = new Label();
            lblScoreTotal = new Label();
            lblScoreCount = new Label();
            lblAverage = new Label();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.Location = new Point(165, 42);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 0;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Location = new Point(165, 95);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(100, 23);
            txtScoreTotal.TabIndex = 1;
            // 
            // txtScoreCount
            // 
            txtScoreCount.Location = new Point(165, 151);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            txtScoreCount.Size = new Size(100, 23);
            txtScoreCount.TabIndex = 2;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(165, 201);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(100, 23);
            txtAverage.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(296, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDisplayScores
            // 
            btnDisplayScores.Location = new Point(46, 262);
            btnDisplayScores.Name = "btnDisplayScores";
            btnDisplayScores.Size = new Size(106, 23);
            btnDisplayScores.TabIndex = 5;
            btnDisplayScores.Text = "Display Scores";
            btnDisplayScores.UseVisualStyleBackColor = true;
            btnDisplayScores.Click += btnDisplayScores_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(190, 262);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(190, 305);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(54, 46);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(39, 15);
            lblScore.TabIndex = 8;
            lblScore.Text = "Score:";
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.AutoSize = true;
            lblScoreTotal.Location = new Point(54, 98);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new Size(67, 15);
            lblScoreTotal.TabIndex = 9;
            lblScoreTotal.Text = "Score Total:";
            // 
            // lblScoreCount
            // 
            lblScoreCount.AutoSize = true;
            lblScoreCount.Location = new Point(54, 154);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(75, 15);
            lblScoreCount.TabIndex = 10;
            lblScoreCount.Text = "Score Count:";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(54, 204);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(53, 15);
            lblAverage.TabIndex = 11;
            lblAverage.Text = "Average:";
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(385, 351);
            Controls.Add(lblAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoreTotal);
            Controls.Add(lblScore);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplayScores);
            Controls.Add(btnAdd);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Controls.Add(txtScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScore;
        private TextBox txtScoreTotal;
        private TextBox txtScoreCount;
        private TextBox txtAverage;
        private Button btnAdd;
        private Button btnDisplayScores;
        private Button btnClear;
        private Button btnExit;
        private Label lblScore;
        private Label lblScoreTotal;
        private Label lblScoreCount;
        private Label lblAverage;
    }
}