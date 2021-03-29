using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SnakeBiteGame
{
    /// <summary>
    /// GameWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GameWindow : Window
    {
        Random rand = new Random();

        Ellipse[] snake = new Ellipse[30];
        Ellipse egg = new Ellipse();
        private int size = 12; // egg, body
        private int visibleCount = 5;
        private string move = "";
        private int eaten = 0;
        DispatcherTimer playTimer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        private bool startFlag = false;


        public GameWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            InitSnake();
            InitEgg();

            playTimer.Interval = new TimeSpan(0, 0, 0, 0, 100); // 0.1sec
            playTimer.Tick += PlayTimer_Tick;
            playTimer.Start();
        }

        private void InitEgg()
        {
            
        }

        private void InitSnake()
        {
            int x = rand.Next(1, 500 / size) * size;
            int y = rand.Next(1, 400 / size) * size;

            for (int i = 0; i < 30; i++)
            {
                snake[i] = new Ellipse();
                snake[i].Width = snake[i].Height = size;
                if (i == 0)
                    snake[i].Fill = Brushes.Chocolate;
                else if (i % 5 == 0)
                    snake[i].Fill = Brushes.YellowGreen;
                else
                    snake[i].Fill = Brushes.Gold;
                snake[i].Stroke = Brushes.Black;

                CvsGame.Children.Add(snake[i]);
            }

            // 뱀길이를 5개로 하고 나머지는 화면에서 지운다
            for (int i = visibleCount; i < 30; i++)
            {
                snake[i].Visibility = Visibility.Hidden;
            }

            CreateSnake(x, y);
        }

        private void CreateSnake(int x, int y)
        {
            for (int i = 0; i < visibleCount; i++)
            {
                snake[i].Tag = new Point(x, y + i * size); // 태그에 위치값 들어있음
                Canvas.SetLeft(snake[i], x);
                Canvas.SetTop(snake[i], y + i * size);
            }
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            if (move != "")
            {
                startFlag = true;

                for (int i = visibleCount; i >= 1; i--)
                {
                    Point p = (Point)snake[i - 1].Tag; // 그 위치 값 가져옴
                    snake[i].Tag = new Point(p.X, p.Y);
                }

                // 키보드로 옮겼을 때 처리

                // 알을 먹었는지 체크
            }

            if (startFlag)
            {
                TimeSpan span = stopwatch.Elapsed;
                TxtTime.Text = $"Time = {span.Minutes}:{span.Seconds}:{span.Milliseconds / 10}";
                DrawSnake();
            }
        }

        private void DrawSnake()
        {
            for (int i = 0; i < visibleCount; i++)
            {
                Point p = (Point)snake[i].Tag;
                Canvas.SetLeft(snake[i], p.X);
                Canvas.SetTop(snake[i], p.Y);

            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (move == "") stopwatch.Start();

            // 키조작
        }
    }
}
