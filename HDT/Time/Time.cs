public class Time
{
    // fields
    private int _hour;
    private int _minute;
    private int _second;

    // properties
    public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (_hour < 0 || _hour > 23)
                {
                    throw new Exception("No input validation needed.");  
                }
                _hour = value;
            }
        }
    public int minute
    {
        get
        {
            return _minute;
        }
        set
        {
            if (_minute < 0 || _minute > 59)
            {
                throw new Exception("Nhap lai phut tu 0..59!!");
            }
            _minute = value;
        }
    }
    public int second 
    {
        get 
        {
            return _second;
        }
        set 
        {
            if (_second < 0 || _second > 59)
            {
                throw new Exception("Nhap lai giay tu 0..59!!");
            }
            _second = value;
        }
    }
    public Time(int hour, int minute, int second)
    {
        // hour
        if (hour < 0 || hour > 23)
        {
            throw new Exception("Gio bat dau tu 0..23");
        }
        else
        {
            this._hour = hour;   
        }
        // minute
        if (minute < 0 || minute > 59)
        {
            throw new Exception("Phut bat dau tu 0..59");
        }
        else
        {
            this._minute = minute;   
        }
        // seconds
        if (second < 0 || second > 59)
        {
            throw new Exception("Giay bat dau tu 0..59");
        }
        else
        {
            this._second = second;   
        }
        
    }
    public Time()
    {
        this._hour = 0;
        this._minute = 0;
        this._second = 0;
    }
    // Method
    public string toString()
    {
        return ($"{this._hour:00}:{this._minute:00}:{this._second:00}");
    }
    // NextSecond() :Time
    public Time nextSecond()
    {
        Time nextSecond = new Time(this._hour,this._minute, this._second);
        nextSecond._second += 1;
        if (nextSecond._second > 59)
        {
            nextSecond._second = 0;
            nextSecond._minute += 1;
            if (nextSecond._minute > 59)
            {
                nextSecond._minute = 0;
                nextSecond._hour += 1;
                if (nextSecond._hour > 23)
                {
                    nextSecond._hour = 0;
                }
            }
        }
        return nextSecond;
    }
    // PreviousSecond() :Time
    public Time previousSecond()
    {
        Time previousSecond = new Time(this._hour, this._minute, this._second);
        previousSecond._second -= 1;
        if (previousSecond._second < 0)
        {
            previousSecond._second = 59;
            previousSecond._minute -= 1;
            if (previousSecond._minute < 0)
            {
                previousSecond._minute = 59;
                previousSecond._hour -= 1;
                if (previousSecond._hour < 0)
                {
                    previousSecond._hour = 23;
                }
            }
        }
        return previousSecond;
    }
    // AddSecond() :Time
    public Time addSecond()
    {
        int giayThem = 0;
        int tongGiay = 0;
        System.Console.Write("Nhap so giay can them: ");
        int.TryParse(Console.ReadLine(), out giayThem);

        Time addSecond = new Time(this._hour, this._minute, this._second);
        tongGiay =( this._hour * 3600 + this._minute * 60 + this._second) + giayThem;
        
        addSecond._hour = tongGiay / 3600;
        addSecond._minute = tongGiay % 3600 / 60;
        addSecond._second = tongGiay % 60;
        return addSecond;
        
    }
    // LessSecond() :Time
    public Time lessSecond()
    {
        int giayGiam = 0;
        int tongGiay = 0;       
        System.Console.Write("Nhap so giay muon giam: ");
        int.TryParse(Console.ReadLine(), out giayGiam);

        Time lessSecond = new Time(this._hour, this._minute, this._second);
        if (this._hour == 0)
        {
            this._hour = 24;
        }
        tongGiay = (this._hour * 3600 + this._minute * 60 + this._second) - giayGiam;

        lessSecond._hour = tongGiay / 3600;
        lessSecond._minute = (tongGiay % 3600) / 60;
        lessSecond._second = tongGiay % 3600 % 60;
        return lessSecond;
    }
}