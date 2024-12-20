
namespace @while
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button1_Rock = new System.Windows.Forms.Button();
            this.button2_Scissors = new System.Windows.Forms.Button();
            this.button3_Paper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(12, 51);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(776, 387);
            this.textBox_result.TabIndex = 0;
            // 
            // button1_Rock
            // 
            this.button1_Rock.Location = new System.Drawing.Point(12, 7);
            this.button1_Rock.Name = "button1_Rock";
            this.button1_Rock.Size = new System.Drawing.Size(248, 38);
            this.button1_Rock.TabIndex = 1;
            this.button1_Rock.Text = "Rock";
            this.button1_Rock.UseVisualStyleBackColor = true;
            this.button1_Rock.Click += new System.EventHandler(this.button1_Rock_Click);
            // 
            // button2_Scissors
            // 
            this.button2_Scissors.Location = new System.Drawing.Point(275, 7);
            this.button2_Scissors.Name = "button2_Scissors";
            this.button2_Scissors.Size = new System.Drawing.Size(248, 38);
            this.button2_Scissors.TabIndex = 2;
            this.button2_Scissors.Text = "Scissors";
            this.button2_Scissors.UseVisualStyleBackColor = true;
            this.button2_Scissors.Click += new System.EventHandler(this.button2_Scissors_Click);
            // 
            // button3_Paper
            // 
            this.button3_Paper.Location = new System.Drawing.Point(540, 7);
            this.button3_Paper.Name = "button3_Paper";
            this.button3_Paper.Size = new System.Drawing.Size(248, 38);
            this.button3_Paper.TabIndex = 3;
            this.button3_Paper.Text = "Paper";
            this.button3_Paper.UseVisualStyleBackColor = true;
            this.button3_Paper.Click += new System.EventHandler(this.button3_Paper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3_Paper);
            this.Controls.Add(this.button2_Scissors);
            this.Controls.Add(this.button1_Rock);
            this.Controls.Add(this.textBox_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button1_Rock;
        private System.Windows.Forms.Button button2_Scissors;
        private System.Windows.Forms.Button button3_Paper;
    }
}

