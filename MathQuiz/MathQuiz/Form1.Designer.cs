namespace MathQuiz
{
    partial class MainForm
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.diffNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.productNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.quotientNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotientNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.Location = new System.Drawing.Point(233, 31);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLeftLabel.Location = new System.Drawing.Point(134, 35);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(92, 21);
            this.timeLeftLabel.TabIndex = 1;
            this.timeLeftLabel.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 70);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 0;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(110, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusRightLabel.Location = new System.Drawing.Point(170, 70);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(230, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumNumericUpDown
            // 
            this.sumNumericUpDown.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sumNumericUpDown.Location = new System.Drawing.Point(308, 79);
            this.sumNumericUpDown.Name = "sumNumericUpDown";
            this.sumNumericUpDown.Size = new System.Drawing.Size(100, 35);
            this.sumNumericUpDown.TabIndex = 2;
            this.sumNumericUpDown.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // diffNumericUpDown
            // 
            this.diffNumericUpDown.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.diffNumericUpDown.Location = new System.Drawing.Point(308, 134);
            this.diffNumericUpDown.Name = "diffNumericUpDown";
            this.diffNumericUpDown.Size = new System.Drawing.Size(100, 35);
            this.diffNumericUpDown.TabIndex = 3;
            this.diffNumericUpDown.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(230, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusRightLabel.Location = new System.Drawing.Point(170, 125);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 9;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(110, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 125);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productNumericUpDown
            // 
            this.productNumericUpDown.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productNumericUpDown.Location = new System.Drawing.Point(308, 189);
            this.productNumericUpDown.Name = "productNumericUpDown";
            this.productNumericUpDown.Size = new System.Drawing.Size(100, 35);
            this.productNumericUpDown.TabIndex = 4;
            this.productNumericUpDown.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(230, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 15;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timesRightLabel.Location = new System.Drawing.Point(170, 180);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 14;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(110, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 13;
            this.label9.Text = "×";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 180);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotientNumericUpDown
            // 
            this.quotientNumericUpDown.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quotientNumericUpDown.Location = new System.Drawing.Point(308, 244);
            this.quotientNumericUpDown.Name = "quotientNumericUpDown";
            this.quotientNumericUpDown.Size = new System.Drawing.Size(100, 35);
            this.quotientNumericUpDown.TabIndex = 5;
            this.quotientNumericUpDown.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(230, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 20;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dividedRightLabel.Location = new System.Drawing.Point(170, 235);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 19;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(110, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 18;
            this.label13.Text = "÷";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(50, 235);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startButton.Location = new System.Drawing.Point(178, 306);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(125, 29);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotientNumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.productNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.diffNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sumNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotientNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sumNumericUpDown;
        private System.Windows.Forms.NumericUpDown diffNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown productNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown quotientNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

