
namespace AlarmClockApp
{
    partial class FrmAlarm
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
            this.components = new System.ComponentModel.Container();
            this.TabClock = new System.Windows.Forms.TabControl();
            this.TapSetAlarm = new System.Windows.Forms.TabPage();
            this.BtnRelaese = new System.Windows.Forms.Button();
            this.BtnSet = new System.Windows.Forms.Button();
            this.DtpAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.dtpAlarmDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TapDigitalClock = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblAlarm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.TabClock.SuspendLayout();
            this.TapSetAlarm.SuspendLayout();
            this.TapDigitalClock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabClock
            // 
            this.TabClock.Controls.Add(this.TapSetAlarm);
            this.TabClock.Controls.Add(this.TapDigitalClock);
            this.TabClock.Location = new System.Drawing.Point(25, 12);
            this.TabClock.Name = "TabClock";
            this.TabClock.SelectedIndex = 0;
            this.TabClock.Size = new System.Drawing.Size(375, 278);
            this.TabClock.TabIndex = 0;
            // 
            // TapSetAlarm
            // 
            this.TapSetAlarm.Controls.Add(this.BtnRelaese);
            this.TapSetAlarm.Controls.Add(this.BtnSet);
            this.TapSetAlarm.Controls.Add(this.DtpAlarmTime);
            this.TapSetAlarm.Controls.Add(this.dtpAlarmDate);
            this.TapSetAlarm.Controls.Add(this.label2);
            this.TapSetAlarm.Controls.Add(this.label1);
            this.TapSetAlarm.Location = new System.Drawing.Point(4, 22);
            this.TapSetAlarm.Name = "TapSetAlarm";
            this.TapSetAlarm.Padding = new System.Windows.Forms.Padding(3);
            this.TapSetAlarm.Size = new System.Drawing.Size(367, 252);
            this.TapSetAlarm.TabIndex = 0;
            this.TapSetAlarm.Text = "알람 설정";
            this.TapSetAlarm.UseVisualStyleBackColor = true;
            // 
            // BtnRelaese
            // 
            this.BtnRelaese.Location = new System.Drawing.Point(290, 221);
            this.BtnRelaese.Name = "BtnRelaese";
            this.BtnRelaese.Size = new System.Drawing.Size(71, 25);
            this.BtnRelaese.TabIndex = 5;
            this.BtnRelaese.Text = "해제";
            this.BtnRelaese.UseVisualStyleBackColor = true;
            this.BtnRelaese.Click += new System.EventHandler(this.BtnRelaese_Click);
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(213, 221);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(71, 25);
            this.BtnSet.TabIndex = 4;
            this.BtnSet.Text = "설정";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // DtpAlarmTime
            // 
            this.DtpAlarmTime.CustomFormat = "hh:mm:ss";
            this.DtpAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpAlarmTime.Location = new System.Drawing.Point(21, 128);
            this.DtpAlarmTime.Name = "DtpAlarmTime";
            this.DtpAlarmTime.Size = new System.Drawing.Size(171, 21);
            this.DtpAlarmTime.TabIndex = 3;
            // 
            // dtpAlarmDate
            // 
            this.dtpAlarmDate.Location = new System.Drawing.Point(21, 42);
            this.dtpAlarmDate.Name = "dtpAlarmDate";
            this.dtpAlarmDate.Size = new System.Drawing.Size(171, 21);
            this.dtpAlarmDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "시간 설정";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜 설정";
            // 
            // TapDigitalClock
            // 
            this.TapDigitalClock.AllowDrop = true;
            this.TapDigitalClock.Controls.Add(this.groupBox1);
            this.TapDigitalClock.Controls.Add(this.LblAlarm);
            this.TapDigitalClock.Controls.Add(this.label3);
            this.TapDigitalClock.Location = new System.Drawing.Point(4, 22);
            this.TapDigitalClock.Name = "TapDigitalClock";
            this.TapDigitalClock.Padding = new System.Windows.Forms.Padding(3);
            this.TapDigitalClock.Size = new System.Drawing.Size(367, 252);
            this.TapDigitalClock.TabIndex = 1;
            this.TapDigitalClock.Text = "디지털시계";
            this.TapDigitalClock.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTime);
            this.groupBox1.Controls.Add(this.LblDate);
            this.groupBox1.Location = new System.Drawing.Point(32, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재시간";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblTime.Location = new System.Drawing.Point(13, 55);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(96, 45);
            this.LblTime.TabIndex = 3;
            this.LblTime.Text = "Time";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(19, 27);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(30, 12);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Date";
            // 
            // LblAlarm
            // 
            this.LblAlarm.AutoSize = true;
            this.LblAlarm.Location = new System.Drawing.Point(29, 60);
            this.LblAlarm.Name = "LblAlarm";
            this.LblAlarm.Size = new System.Drawing.Size(50, 12);
            this.LblAlarm.TabIndex = 1;
            this.LblAlarm.Text = "Alarm : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "알람 설정";
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 302);
            this.Controls.Add(this.TabClock);
            this.MaximizeBox = false;
            this.Name = "FrmAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "알람시계";
            this.Load += new System.EventHandler(this.FrmAlarm_Load);
            this.TabClock.ResumeLayout(false);
            this.TapSetAlarm.ResumeLayout(false);
            this.TapSetAlarm.PerformLayout();
            this.TapDigitalClock.ResumeLayout(false);
            this.TapDigitalClock.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabClock;
        private System.Windows.Forms.TabPage TapSetAlarm;
        private System.Windows.Forms.Button BtnRelaese;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.DateTimePicker DtpAlarmTime;
        private System.Windows.Forms.DateTimePicker dtpAlarmDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TapDigitalClock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblAlarm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer MyTimer;
    }
}

