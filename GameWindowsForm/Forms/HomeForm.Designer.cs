namespace GameWindowsForm
{
    partial class HomeForm
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
            this.msgTelaInicial = new System.Windows.Forms.Label();
            this.msgTelainicial2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.player1TxtBox = new System.Windows.Forms.TextBox();
            this.player2TxtBox = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgTelaInicial
            // 
            this.msgTelaInicial.AutoSize = true;
            this.msgTelaInicial.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgTelaInicial.Location = new System.Drawing.Point(89, 139);
            this.msgTelaInicial.Name = "msgTelaInicial";
            this.msgTelaInicial.Size = new System.Drawing.Size(375, 32);
            this.msgTelaInicial.TabIndex = 0;
            this.msgTelaInicial.Text = "You need another one to play";
            // 
            // msgTelainicial2
            // 
            this.msgTelainicial2.AutoSize = true;
            this.msgTelainicial2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgTelainicial2.Location = new System.Drawing.Point(42, 227);
            this.msgTelainicial2.Name = "msgTelainicial2";
            this.msgTelainicial2.Size = new System.Drawing.Size(445, 29);
            this.msgTelainicial2.TabIndex = 1;
            this.msgTelainicial2.Text = "Write your name and the your partner to play";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1.Location = new System.Drawing.Point(31, 265);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(89, 28);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2.Location = new System.Drawing.Point(417, 265);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(89, 28);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player 2";
            // 
            // player1TxtBox
            // 
            this.player1TxtBox.Location = new System.Drawing.Point(31, 307);
            this.player1TxtBox.Name = "player1TxtBox";
            this.player1TxtBox.Size = new System.Drawing.Size(125, 27);
            this.player1TxtBox.TabIndex = 4;
            // 
            // player2TxtBox
            // 
            this.player2TxtBox.Location = new System.Drawing.Point(381, 307);
            this.player2TxtBox.Name = "player2TxtBox";
            this.player2TxtBox.Size = new System.Drawing.Size(125, 27);
            this.player2TxtBox.TabIndex = 5;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.Location = new System.Drawing.Point(182, 373);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(153, 60);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = "TIC-TAC-TOE";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(543, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.player2TxtBox);
            this.Controls.Add(this.player1TxtBox);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.msgTelainicial2);
            this.Controls.Add(this.msgTelaInicial);
            this.Name = "HomeForm";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgTelaInicial;
        private System.Windows.Forms.Label msgTelainicial2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox player1TxtBox;
        private System.Windows.Forms.TextBox player2TxtBox;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
    }
}
