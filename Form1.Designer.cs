namespace GameOfLife
{
    partial class GUI
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_1Instructions = new System.Windows.Forms.Label();
            this.lbl_X = new System.Windows.Forms.Label();
            this.UpDown_X = new System.Windows.Forms.NumericUpDown();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.UpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.btn_GenerateField = new System.Windows.Forms.Button();
            this.lbl_ActiveCellsPer = new System.Windows.Forms.Label();
            this.UpDown_Perc = new System.Windows.Forms.NumericUpDown();
            this.lbl_Grid = new System.Windows.Forms.Label();
            this.checkBox_Grid = new System.Windows.Forms.CheckBox();
            this.btn_MakeStep = new System.Windows.Forms.Button();
            this.lbl_Simulation = new System.Windows.Forms.Label();
            this.lbl_OR = new System.Windows.Forms.Label();
            this.lbl_Generation = new System.Windows.Forms.Label();
            this.UpDown_SimSteps = new System.Windows.Forms.NumericUpDown();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.track_Speed = new System.Windows.Forms.TrackBar();
            this.btn_Simulate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Perc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_SimSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(106, 51);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(307, 31);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Conway\'s Game of Life";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.Location = new System.Drawing.Point(388, 95);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(75, 15);
            this.lbl_Author.TabIndex = 2;
            this.lbl_Author.Text = "-by Nikita S.";
            // 
            // lbl_1Instructions
            // 
            this.lbl_1Instructions.AutoSize = true;
            this.lbl_1Instructions.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1Instructions.Location = new System.Drawing.Point(600, 51);
            this.lbl_1Instructions.Name = "lbl_1Instructions";
            this.lbl_1Instructions.Size = new System.Drawing.Size(142, 18);
            this.lbl_1Instructions.TabIndex = 3;
            this.lbl_1Instructions.Text = "1.1. Generate a Field";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.Location = new System.Drawing.Point(568, 95);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(24, 18);
            this.lbl_X.TabIndex = 4;
            this.lbl_X.Text = "X:";
            // 
            // UpDown_X
            // 
            this.UpDown_X.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_X.Location = new System.Drawing.Point(594, 91);
            this.UpDown_X.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UpDown_X.Name = "UpDown_X";
            this.UpDown_X.Size = new System.Drawing.Size(53, 29);
            this.UpDown_X.TabIndex = 5;
            this.UpDown_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDown_X.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lbl_Y.Location = new System.Drawing.Point(672, 95);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(24, 18);
            this.lbl_Y.TabIndex = 6;
            this.lbl_Y.Text = "Y:";
            // 
            // UpDown_Y
            // 
            this.UpDown_Y.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.UpDown_Y.Location = new System.Drawing.Point(696, 91);
            this.UpDown_Y.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UpDown_Y.Name = "UpDown_Y";
            this.UpDown_Y.Size = new System.Drawing.Size(53, 29);
            this.UpDown_Y.TabIndex = 7;
            this.UpDown_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDown_Y.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btn_GenerateField
            // 
            this.btn_GenerateField.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateField.Location = new System.Drawing.Point(594, 273);
            this.btn_GenerateField.Name = "btn_GenerateField";
            this.btn_GenerateField.Size = new System.Drawing.Size(155, 29);
            this.btn_GenerateField.TabIndex = 8;
            this.btn_GenerateField.Text = "Generate";
            this.btn_GenerateField.UseVisualStyleBackColor = true;
            this.btn_GenerateField.Click += new System.EventHandler(this.btn_GenerateField_Click);
            // 
            // lbl_ActiveCellsPer
            // 
            this.lbl_ActiveCellsPer.AutoSize = true;
            this.lbl_ActiveCellsPer.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lbl_ActiveCellsPer.Location = new System.Drawing.Point(583, 149);
            this.lbl_ActiveCellsPer.Name = "lbl_ActiveCellsPer";
            this.lbl_ActiveCellsPer.Size = new System.Drawing.Size(182, 18);
            this.lbl_ActiveCellsPer.TabIndex = 9;
            this.lbl_ActiveCellsPer.Text = "1.2. Select % of Active Cells";
            // 
            // UpDown_Perc
            // 
            this.UpDown_Perc.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.UpDown_Perc.Location = new System.Drawing.Point(594, 187);
            this.UpDown_Perc.Name = "UpDown_Perc";
            this.UpDown_Perc.Size = new System.Drawing.Size(155, 29);
            this.UpDown_Perc.TabIndex = 10;
            this.UpDown_Perc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Grid
            // 
            this.lbl_Grid.AutoSize = true;
            this.lbl_Grid.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lbl_Grid.Location = new System.Drawing.Point(591, 238);
            this.lbl_Grid.Name = "lbl_Grid";
            this.lbl_Grid.Size = new System.Drawing.Size(126, 18);
            this.lbl_Grid.TabIndex = 11;
            this.lbl_Grid.Text = "1.3. Generate Grid";
            // 
            // checkBox_Grid
            // 
            this.checkBox_Grid.AutoSize = true;
            this.checkBox_Grid.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.checkBox_Grid.Location = new System.Drawing.Point(727, 241);
            this.checkBox_Grid.Name = "checkBox_Grid";
            this.checkBox_Grid.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Grid.TabIndex = 12;
            this.checkBox_Grid.UseVisualStyleBackColor = true;
            // 
            // btn_MakeStep
            // 
            this.btn_MakeStep.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.btn_MakeStep.Location = new System.Drawing.Point(594, 396);
            this.btn_MakeStep.Name = "btn_MakeStep";
            this.btn_MakeStep.Size = new System.Drawing.Size(155, 29);
            this.btn_MakeStep.TabIndex = 13;
            this.btn_MakeStep.Text = "Make A Step";
            this.btn_MakeStep.UseVisualStyleBackColor = true;
            this.btn_MakeStep.Click += new System.EventHandler(this.btn_MakeStep_Click);
            // 
            // lbl_Simulation
            // 
            this.lbl_Simulation.AutoSize = true;
            this.lbl_Simulation.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lbl_Simulation.Location = new System.Drawing.Point(587, 355);
            this.lbl_Simulation.Name = "lbl_Simulation";
            this.lbl_Simulation.Size = new System.Drawing.Size(171, 18);
            this.lbl_Simulation.TabIndex = 14;
            this.lbl_Simulation.Text = "--- Simulate Next Step ---";
            // 
            // lbl_OR
            // 
            this.lbl_OR.AutoSize = true;
            this.lbl_OR.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lbl_OR.Location = new System.Drawing.Point(657, 441);
            this.lbl_OR.Name = "lbl_OR";
            this.lbl_OR.Size = new System.Drawing.Size(29, 18);
            this.lbl_OR.TabIndex = 15;
            this.lbl_OR.Text = "OR";
            // 
            // lbl_Generation
            // 
            this.lbl_Generation.AutoSize = true;
            this.lbl_Generation.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lbl_Generation.Location = new System.Drawing.Point(591, 486);
            this.lbl_Generation.Name = "lbl_Generation";
            this.lbl_Generation.Size = new System.Drawing.Size(89, 18);
            this.lbl_Generation.TabIndex = 16;
            this.lbl_Generation.Text = "Generations:";
            // 
            // UpDown_SimSteps
            // 
            this.UpDown_SimSteps.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.UpDown_SimSteps.Location = new System.Drawing.Point(686, 483);
            this.UpDown_SimSteps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_SimSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown_SimSteps.Name = "UpDown_SimSteps";
            this.UpDown_SimSteps.Size = new System.Drawing.Size(63, 29);
            this.UpDown_SimSteps.TabIndex = 17;
            this.UpDown_SimSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDown_SimSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.AutoSize = true;
            this.lbl_Speed.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lbl_Speed.Location = new System.Drawing.Point(652, 531);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(44, 18);
            this.lbl_Speed.TabIndex = 18;
            this.lbl_Speed.Text = "Speed";
            // 
            // track_Speed
            // 
            this.track_Speed.BackColor = System.Drawing.Color.LightGray;
            this.track_Speed.Cursor = System.Windows.Forms.Cursors.Default;
            this.track_Speed.Location = new System.Drawing.Point(594, 563);
            this.track_Speed.Maximum = 5;
            this.track_Speed.Minimum = 1;
            this.track_Speed.Name = "track_Speed";
            this.track_Speed.Size = new System.Drawing.Size(155, 45);
            this.track_Speed.TabIndex = 19;
            this.track_Speed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.track_Speed.Value = 1;
            // 
            // btn_Simulate
            // 
            this.btn_Simulate.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.btn_Simulate.Location = new System.Drawing.Point(594, 614);
            this.btn_Simulate.Name = "btn_Simulate";
            this.btn_Simulate.Size = new System.Drawing.Size(155, 31);
            this.btn_Simulate.TabIndex = 20;
            this.btn_Simulate.Text = "Simulate";
            this.btn_Simulate.UseVisualStyleBackColor = true;
            this.btn_Simulate.Click += new System.EventHandler(this.btn_Simulate_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 681);
            this.Controls.Add(this.btn_Simulate);
            this.Controls.Add(this.track_Speed);
            this.Controls.Add(this.lbl_Speed);
            this.Controls.Add(this.UpDown_SimSteps);
            this.Controls.Add(this.lbl_Generation);
            this.Controls.Add(this.lbl_OR);
            this.Controls.Add(this.lbl_Simulation);
            this.Controls.Add(this.btn_MakeStep);
            this.Controls.Add(this.checkBox_Grid);
            this.Controls.Add(this.lbl_Grid);
            this.Controls.Add(this.UpDown_Perc);
            this.Controls.Add(this.lbl_ActiveCellsPer);
            this.Controls.Add(this.btn_GenerateField);
            this.Controls.Add(this.UpDown_Y);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.UpDown_X);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.lbl_1Instructions);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game of Life";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GUI_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Perc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_SimSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_1Instructions;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.NumericUpDown UpDown_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.NumericUpDown UpDown_Y;
        private System.Windows.Forms.Button btn_GenerateField;
        private System.Windows.Forms.Label lbl_ActiveCellsPer;
        private System.Windows.Forms.NumericUpDown UpDown_Perc;
        private System.Windows.Forms.Label lbl_Grid;
        private System.Windows.Forms.CheckBox checkBox_Grid;
        private System.Windows.Forms.Button btn_MakeStep;
        private System.Windows.Forms.Label lbl_Simulation;
        private System.Windows.Forms.Label lbl_OR;
        private System.Windows.Forms.Label lbl_Generation;
        private System.Windows.Forms.NumericUpDown UpDown_SimSteps;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.TrackBar track_Speed;
        private System.Windows.Forms.Button btn_Simulate;
    }
}

