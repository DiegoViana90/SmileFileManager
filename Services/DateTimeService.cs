using System;
using System.Threading;

public class DateTimeService
{
    public event Action? OnTimeUpdated;

    private Timer? _timer;

    public string CurrentDateTime { get; private set; } = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

    public void Start()
    {
        _timer = new Timer(UpdateDateTime, null, 0, 1000);
    }

    private void UpdateDateTime(object? state)
    {
        CurrentDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        OnTimeUpdated?.Invoke();
    }

}
