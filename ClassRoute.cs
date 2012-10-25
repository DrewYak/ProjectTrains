using System;

class Route
{
    string _pointsOfDeparture;
    string _pointsOfArrival;

    /// <summary>
    /// Создаёт маршрут по пункту отправления и прибытия.
    /// </summary>
    /// <param name="PointsOfDeparture">Пункт отправления.</param>
    /// <param name="PointsOfArrival">Пункт прибытия.</param>
    public Route(string PointsOfDeparture, string PointsOfArrival)
    {
        this.PointsOfDeparture = PointsOfDeparture;
        this.PointsOfArrival   = PointsOfArrival;
    }
   
    /// <summary>
    /// Возвращает пункт отправления.
    /// </summary>
    public string PointsOfDeparture
    {
        get { return _pointsOfDeparture; }
        set { if (value.Length >= 0) _pointsOfDeparture = value; }
    }

    /// <summary>
    /// Возвращает пункт прибытия.
    /// </summary>
    public string PointsOfArrival
    {
        get { return _pointsOfArrival; }
        set { if (value.Length >= 0) _pointsOfArrival = value; }
    }
}