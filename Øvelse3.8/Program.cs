// See https://aka.ms/new-console-template for more information

Time t1, t2;
t1 = new Time("08:30:00");
t2 = t1;
t2.Hour = t2.Hour + 2;
Console.WriteLine(t1.ToString());
Console.WriteLine(t2.ToString());


public struct Time
{
    private int _secondsSinceMidnight;
    private int _maxSeconds = 86400;

    public Time(int h, int m, int s)
    {
        Hour = h;
        Minut = m;
        Sek = s;
    }
    public Time(string time) : this(Int32.Parse(time.Substring(0,2)),
                                    Int32.Parse(time.Substring(3,2)),
                                    Int32.Parse(time.Substring(6)))
    {
      
    }

    public int Hour
    {
        set
        {
            int hour = value;
            int temp = _secondsSinceMidnight % 3600;
            _secondsSinceMidnight = (temp + hour * 3600) % _maxSeconds;

        }
        get { return _secondsSinceMidnight / 3600; }
    }
    
    public int Minut
    {
        set
        {
            int min = value;
            int hours = (_secondsSinceMidnight / 3600) * 3600;
            int seconds = _secondsSinceMidnight % 60;
            _secondsSinceMidnight = (hours + min * 60 + seconds) % _maxSeconds;

        }
        get { return (_secondsSinceMidnight % 3600) / 60; }
    }
    
    public int Sek
    {
        set
        {
            int withoutSeconds = _secondsSinceMidnight - (_secondsSinceMidnight % 60);
            _secondsSinceMidnight = (withoutSeconds + value) % _maxSeconds;
        }
        get { return _secondsSinceMidnight % 60 ; }
    }

    public override string ToString()
    {
        return Hour + ":" + Minut + ":" + Sek;
    }
}