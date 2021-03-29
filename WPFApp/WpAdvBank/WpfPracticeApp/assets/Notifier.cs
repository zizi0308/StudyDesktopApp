using System.ComponentModel;

public class Notifier : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName) // 분할업무를 할 때(MVVM을 할 때) 값으 바뀌었다는 것을 알려주기 위한 이벤트
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
