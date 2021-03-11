using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; // dll추가 

namespace AlarmClockApp
{
    public partial class FrmAlarm : Form
    {
        private DateTime SetDay;
        private DateTime SetTime;
        private bool IsSetAlarm;
        WindowsMediaPlayer mediaPlayer; // 전역변수에는 선언만하고 Frm에서 인스턴스 객체를 만듦(같이 만들면 오류나는 경우도 있음)

        public FrmAlarm()
        {
            InitializeComponent();

            // 초기화 작업
        }

        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            mediaPlayer = new WindowsMediaPlayer();

            LblAlarm.ForeColor = Color.Gray;

            LblDate.Text = LblTime.Text = ""; // 시작할 때 글자를 지워줌

            DtpAlarmTime.Format = DateTimePickerFormat.Custom;
            DtpAlarmTime.CustomFormat = "HH:mm:ss";
            DtpAlarmTime.ShowUpDown = true;

            MyTimer.Interval = 1000; // 1sec
            MyTimer.Tick += MyTimer_Tick;
            MyTimer.Enabled = true;
            MyTimer.Start();

            TabClock.SelectedTab = TapDigitalClock;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            LblDate.Text = curDate.ToShortDateString();
            LblTime.Text = curDate.ToString("HH:mm:ss");

            if (IsSetAlarm == true) // 알람이 설정되었다면
            {
                // 알람 시간하고 현재시간 일치하면 알람울림
                if (SetDay == curDate.Date &&
                    SetTime.Hour == curDate.Hour &&
                    SetTime.Minute == curDate.Minute &&
                    SetTime.Second == curDate.Second)
                
                {
                    // IsSetAlarm = false; // 알람설정종료
                    BtnRelaese_Click(sender, e); // 이벤트도 하나의 메소드
                    
                    mediaPlayer.URL = @".\medias\alarm.mp3"; // 알람넣기
                    mediaPlayer.controls.play();
                    
                    MessageBox.Show("알람!!!!", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            SetDay = DateTime.Parse(dtpAlarmDate.Text);
            SetTime = DateTime.Parse(DtpAlarmTime.Text);

            LblAlarm.Text = $"Alarm : {SetDay.ToShortDateString()} {SetTime.ToString("HH:mm:ss")}";
            LblAlarm.ForeColor = Color.Red;

            TabClock.SelectedTab = TapDigitalClock;
            IsSetAlarm = true;
        }

        private void BtnRelaese_Click(object sender, EventArgs e)  // 참조 2개 버튼클릭한거 하나 알람창 하나
        {
            IsSetAlarm = false;
            LblAlarm.Text = "Alarm : ";
            LblAlarm.ForeColor = Color.Gray;
            
            TabClock.SelectedTab = TapDigitalClock;

        }

        
    }
}
