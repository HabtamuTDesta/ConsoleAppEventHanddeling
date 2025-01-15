using System;

public class TemperatureMonitor
{
    public delegate void TemperatureExceededEventHandler(object sender, TemperatureEventArgs e);

    public event TemperatureExceededEventHandler TemperatureExceeded;
    private int _currentTemperature;

    public void UpdateTemperature(int newTemperature)
    {
        _currentTemperature = newTemperature;
        Console.WriteLine($"Temperature updated to: {_currentTemperature}°C");

        
        if (_currentTemperature > 30)
        {
            OnTemperatureExceeded(new TemperatureEventArgs(_currentTemperature));
        }
    }

    
    protected virtual void OnTemperatureExceeded(TemperatureEventArgs e)
    {
        TemperatureExceeded?.Invoke(this, e);
    }
}