using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfPracticeApp.BusinessLogic
{
    public class Car : Notifier
    {
        // public double Speed { get; set; } 이것과 아래가 같은것임 부가적인 처리를 할 필요가 없을 때
        private double speed;
        public double Speed // 따로 값을 받아서 처리할 때
        {
            get { return speed; }
            set {
                if (value >350)
                {
                    speed = 350;
                }
                else
                {
                    speed = value;
                }
                speed = value;
                OnPropertyChanged("Speed"); // 속성값 변경된 것을 알려줌(프로그램 안에)
                }
        }
        private Color maincolor;
        public Color MainColor 
        { 
            get { return maincolor; }
            set { maincolor = value; } 
        }
        public Human Driver { get; set; }
    }

    public class Human
    {
        public string Name { get; set; }

        public bool HasDriveLicense { get; set; }
    }
}
