using System;

class Train
{ 
    public int    _number;
    public int    _countOfPas;
    public string _timeOfDeparture;
    public string _timeOfArrival;
    public Route  _theRoute;

    /// <summary>
    /// Создание объекта по номеру, кол-ву пассажиров, времени отправления и прибытия, маршруту
    /// </summary>
    /// <param name="Number">Номер поезда</param>
    /// <param name="CountOfPas">Количество пассажиров</param>
    /// <param name="TimeOfDeparture">Время отправления</param>
    /// <param name="TimeOfArrival">Время прибытия</param>
    /// <param name="TheRoute">Маршрут</param>
    public Train(int Number, int CountOfPas, string TimeOfDeparture, string TimeOfArrival, Route TheRoute)
    {
        this.Number             = Number;
        this.CountOfPas         = CountOfPas;
        this.TimeOfDeparture    = TimeOfDeparture;
        this.TimeOfArrival      = TimeOfArrival;
        this.TheRoute           = TheRoute;
    }

    /// <summary>
    /// Возвращает номер поезда
    /// </summary>
    public int Number
    {
        get { return _number; }
        set { if (value >= 0) _number = value; }
    }

    /// <summary>
    /// Возвращает количество пассажиров
    /// </summary>
    public int CountOfPas
    {
        get { return _countOfPas; }
        set { if (value >= 0) _countOfPas = value; }
    }

    /// <summary>
    /// Возвраает время отправления
    /// </summary>
    public string TimeOfDeparture
    {
        get { return _timeOfDeparture; }
        set { if (value.Length >= 0) _timeOfDeparture = value; }
    }

    /// <summary>
    /// Возврашает время прибытия
    /// </summary>
    public string TimeOfArrival
    {
        get { return _timeOfArrival; }
        set { if (value.Length >= 0) _timeOfArrival = value; }
    }

    /// <summary>
    /// Возвращает маршрут
    /// </summary>
    public Route TheRoute
    {
        get { return _theRoute; }
        set { if (value != null) _theRoute = value; }
    }
}