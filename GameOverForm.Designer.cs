
namespace Game_Kiem_Tra_Mat
{
    partial class GameOverForm
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
            this.label_GameOver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_GameOver
            // 
            this.label_GameOver.AutoSize = true;
            this.label_GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GameOver.Location = new System.Drawing.Point(189, 175);
            this.label_GameOver.Name = "label_GameOver";
            this.label_GameOver.Size = new System.Drawing.Size(412, 73);
            this.label_GameOver.TabIndex = 0;
            this.label_GameOver.Text = "TIME\'S UP!!!";
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_GameOver);
            this.Name = "GameOverForm";
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_GameOver;
    }
}