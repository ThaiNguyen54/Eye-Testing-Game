
namespace Game_Kiem_Tra_Mat
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playButton = new System.Windows.Forms.Button();
            this.Panel_Infor = new System.Windows.Forms.Panel();
            this.textBox_Error = new System.Windows.Forms.TextBox();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.timer_GameOver = new System.Windows.Forms.Timer(this.components);
            this.label_Time = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar_level = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.12886F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.87114F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(320, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.1548F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.8452F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 397);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(774, 120);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(200, 41);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Panel_Infor
            // 
            this.Panel_Infor.Controls.Add(this.textBox_Error);
            this.Panel_Infor.Controls.Add(this.textBox_Score);
            this.Panel_Infor.Controls.Add(this.label_Error);
            this.Panel_Infor.Controls.Add(this.label_Score);
            this.Panel_Infor.Location = new System.Drawing.Point(774, 180);
            this.Panel_Infor.Name = "Panel_Infor";
            this.Panel_Infor.Size = new System.Drawing.Size(200, 337);
            this.Panel_Infor.TabIndex = 2;
            // 
            // textBox_Error
            // 
            this.textBox_Error.BackColor = System.Drawing.Color.Red;
            this.textBox_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Error.Location = new System.Drawing.Point(16, 230);
            this.textBox_Error.Multiline = true;
            this.textBox_Error.Name = "textBox_Error";
            this.textBox_Error.Size = new System.Drawing.Size(171, 55);
            this.textBox_Error.TabIndex = 3;
            this.textBox_Error.Text = "0";
            this.textBox_Error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Score
            // 
            this.textBox_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Score.Location = new System.Drawing.Point(16, 80);
            this.textBox_Score.Multiline = true;
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(171, 57);
            this.textBox_Score.TabIndex = 2;
            this.textBox_Score.Text = "0";
            this.textBox_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Score.TextChanged += new System.EventHandler(this.textBox_Score_TextChanged);
            // 
            // label_Error
            // 
            this.label_Error.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.Location = new System.Drawing.Point(66, 168);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(94, 33);
            this.label_Error.TabIndex = 1;
            this.label_Error.Text = "ERROR";
            this.label_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Score
            // 
            this.label_Score.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.Location = new System.Drawing.Point(51, 22);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(109, 44);
            this.label_Score.TabIndex = 0;
            this.label_Score.Text = "SCORE";
            this.label_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_GameOver
            // 
            this.timer_GameOver.Interval = 1000;
            this.timer_GameOver.Tick += new System.EventHandler(this.timer_GameOver_Tick);
            // 
            // label_Time
            // 
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(315, 52);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(297, 51);
            this.label_Time.TabIndex = 3;
            this.label_Time.Text = "Time: 20";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_level.Location = new System.Drawing.Point(208, 525);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(84, 31);
            this.label_level.TabIndex = 6;
            this.label_level.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(732, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "5";
            // 
            // progressBar_level
            // 
            this.progressBar_level.Location = new System.Drawing.Point(322, 523);
            this.progressBar_level.Name = "progressBar_level";
            this.progressBar_level.Size = new System.Drawing.Size(430, 33);
            this.progressBar_level.Step = 25;
            this.progressBar_level.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_Kiem_Tra_Mat.Properties.Resources._950_9504201_cartoon_physician_icon_head_transprent_png_free_;
            this.pictureBox1.Location = new System.Drawing.Point(38, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1013, 606);
            this.Controls.Add(this.progressBar_level);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Panel_Infor);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Eye-Test";
            this.Panel_Infor.ResumeLayout(false);
            this.Panel_Infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel Panel_Infor;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.TextBox textBox_Error;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.Timer timer_GameOver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar_level;
    }
}

