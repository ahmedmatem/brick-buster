namespace BrickGameGuiApp
{
    partial class GameForm
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
            panelGameInfo = new Panel();
            labelPlayerScore = new Label();
            label2 = new Label();
            label1 = new Label();
            panelGameInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelGameInfo
            // 
            panelGameInfo.BackColor = Color.Gold;
            panelGameInfo.Controls.Add(labelPlayerScore);
            panelGameInfo.Controls.Add(label2);
            panelGameInfo.Controls.Add(label1);
            panelGameInfo.Location = new Point(343, 155);
            panelGameInfo.Name = "panelGameInfo";
            panelGameInfo.Size = new Size(326, 154);
            panelGameInfo.TabIndex = 0;
            panelGameInfo.Visible = false;
            // 
            // labelPlayerScore
            // 
            labelPlayerScore.AutoSize = true;
            labelPlayerScore.Font = new Font("Viner Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerScore.Location = new Point(204, 73);
            labelPlayerScore.Name = "labelPlayerScore";
            labelPlayerScore.Size = new Size(78, 60);
            labelPlayerScore.TabIndex = 2;
            labelPlayerScore.Text = "120";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 83);
            label2.Name = "label2";
            label2.Size = new Size(149, 44);
            label2.TabIndex = 1;
            label2.Text = "Your score:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 12);
            label1.Name = "label1";
            label1.Size = new Size(234, 49);
            label1.TabIndex = 0;
            label1.Text = "GAME OVER";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 450);
            Controls.Add(panelGameInfo);
            Name = "GameForm";
            Text = "Brick Destroyer";
            panelGameInfo.ResumeLayout(false);
            panelGameInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGameInfo;
        private Label label2;
        private Label label1;
        private Label labelPlayerScore;
    }
}