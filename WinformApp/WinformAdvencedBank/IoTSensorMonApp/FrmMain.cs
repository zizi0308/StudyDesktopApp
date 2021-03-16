﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IoTSensorMonApp
{
    public partial class FrmMain : Form
    {

        private double xCount = 200;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // ComdoBox 초기화
            foreach (var port in SerialPort.GetPortNames())
            {
                CboSerialPort.Items.Add(port);
            }
            CboSerialPort.Text = "Select Port";

            // IoT 장비에서 받을 값의 범위
            PrbPhotoResistor.Minimum = 0;
            PrbPhotoResistor.Maximum = 1023;
            PrbPhotoResistor.Value = 0;

            // 차트모양 초기화
            InitChartStyle();

            //BtnDisplay 초기화
            BtnDisplay.BackColor = Color.BlueViolet;
            BtnDisplay.ForeColor = Color.WhiteSmoke;
            BtnDisplay.Text = "NONE";
            BtnDisplay.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            // 나머지 초기화
            LblConnectTime.Text = "Connection Time :";
            TxtSensorNumber.TextAlign = HorizontalAlignment.Right;
            TxtSensorNumber.Text = "0";
            BtnConnect.Enabled = BtnDisconnect.Enabled = false;
        }
        /// <summary>
        /// Chart 초기설정
        /// </summary>
        private void InitChartStyle()
        {
            ChtPhotoResister.ChartAreas[0].BackColor = Color.Blue;
            ChtPhotoResister.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResister.ChartAreas[0].AxisX.Maximum = xCount;
            ChtPhotoResister.ChartAreas[0].AxisX.Interval = xCount / 4;
            ChtPhotoResister.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResister.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResister.ChartAreas[0].AxisY.Minimum = 0;
            ChtPhotoResister.ChartAreas[0].AxisY.Maximum = 1024;
            ChtPhotoResister.ChartAreas[0].AxisY.Interval = xCount;
            ChtPhotoResister.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResister.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResister.ChartAreas[0].CursorX.AutoScroll = true;
            ChtPhotoResister.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChtPhotoResister.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtPhotoResister.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            ChtPhotoResister.Series.Clear(); // Series 값 지움
            ChtPhotoResister.Series.Add("PhotoValue");
            ChtPhotoResister.Series[0].ChartType = SeriesChartType.Line;
            ChtPhotoResister.Series[0].Color = Color.LightCoral;
            ChtPhotoResister.Series[0].BorderWidth = 3;

            // 범례삭제
            if (ChtPhotoResister.Legends.Count > 0)
            {
                for (int i = 0; i < ChtPhotoResister.Legends.Count; i++)
                {
                    ChtPhotoResister.Legends.RemoveAt(i);
                }
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            // TODO 나중에 실제작업시 작성
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            // TODO 나중에 실제작업시 작성
        }
        private Timer timerSimul = new Timer();
        private Random randPhoto = new Random();
        private bool IsSimulation = false;
        private List<SensorData> sensors = new List<SensorData>(); // 차트, 리스트박스에 출력될 데이터

        /// <summary>
        /// 시뮬레이션 시작
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuBeginSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000; // 1sec
            timerSimul.Tick += TimerSimul_Tick;
            timerSimul.Start();
        }

        private void TimerSimul_Tick(object sender, EventArgs e)
        {
            int value = randPhoto.Next(1, 1023); // 1부터 1023까지 사이의 값
            ShowSensorValue(value.ToString());
        }

        /// <summary>
        /// 센서값 화면 출력메서드
        /// </summary>
        /// <param name="value"></param>
        private void ShowSensorValue(string value)
        {
            int.TryParse(value, out int v);

            var currentTime = DateTime.Now;
            SensorData data = new SensorData(currentTime, v, IsSimulation);
            sensors.Add(data);

            // 센서값 갯수 출력
            TxtSensorNumber.Text = $"{sensors.Count}";
            // ProgressBar 현재값 출력
            PrbPhotoResistor.Value = v;
            // ListBox에 데이터 출력
            var item = $"{currentTime.ToString("yyyy-MM-dd HH:mm:ss")}\t{v}";
            LsbPhotoResistors.Items.Add(item);
            LsbPhotoResistors.SelectedIndex = LsbPhotoResistors.Items.Count - 1; // 스크롤 처리

            // 차트에 데이터 출력
            ChtPhotoResister.Series[0].Points.Add(v);
        }

        /// <summary>
        /// 시뮬레이션 끝
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuEndSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = false;
            timerSimul.Stop();
        }
        /// <summary>
        /// 종료버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (IsSimulation)
            {
                MessageBox.Show("시뮬레이션을 멈춘 후 프로그램을 종료하세요", "종료",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Environment.Exit(0);
        }
    }
}
