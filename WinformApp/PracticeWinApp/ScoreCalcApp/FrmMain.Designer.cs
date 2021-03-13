
namespace ScoreCalcApp
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt경제학원론 = new System.Windows.Forms.TextBox();
            this.Txt시사경제론 = new System.Windows.Forms.TextBox();
            this.Txt국제경제학 = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtAvg = new System.Windows.Forms.TextBox();
            this.BtnResult = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt국제경제학);
            this.groupBox1.Controls.Add(this.Txt시사경제론);
            this.groupBox1.Controls.Add(this.Txt경제학원론);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtAvg);
            this.groupBox2.Controls.Add(this.TxtTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(257, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "경제학원론";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "시사경제론";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "국제경제학";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "총점";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "평균";
            // 
            // Txt경제학원론
            // 
            this.Txt경제학원론.Location = new System.Drawing.Point(83, 28);
            this.Txt경제학원론.Name = "Txt경제학원론";
            this.Txt경제학원론.Size = new System.Drawing.Size(95, 21);
            this.Txt경제학원론.TabIndex = 3;
            this.Txt경제학원론.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt시사경제론
            // 
            this.Txt시사경제론.Location = new System.Drawing.Point(83, 87);
            this.Txt시사경제론.Name = "Txt시사경제론";
            this.Txt시사경제론.Size = new System.Drawing.Size(95, 21);
            this.Txt시사경제론.TabIndex = 4;
            this.Txt시사경제론.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt국제경제학
            // 
            this.Txt국제경제학.Location = new System.Drawing.Point(83, 146);
            this.Txt국제경제학.Name = "Txt국제경제학";
            this.Txt국제경제학.Size = new System.Drawing.Size(95, 21);
            this.Txt국제경제학.TabIndex = 5;
            this.Txt국제경제학.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(49, 28);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(84, 21);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtAvg
            // 
            this.TxtAvg.Location = new System.Drawing.Point(49, 87);
            this.TxtAvg.Name = "TxtAvg";
            this.TxtAvg.ReadOnly = true;
            this.TxtAvg.Size = new System.Drawing.Size(84, 21);
            this.TxtAvg.TabIndex = 4;
            this.TxtAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(306, 193);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(126, 29);
            this.BtnResult.TabIndex = 2;
            this.BtnResult.Text = "계산";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 236);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "성적계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt국제경제학;
        private System.Windows.Forms.TextBox Txt시사경제론;
        private System.Windows.Forms.TextBox Txt경제학원론;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtAvg;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnResult;
    }
}

