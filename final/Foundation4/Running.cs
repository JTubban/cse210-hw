public class Running : Activity
{
    private double _distanceInMiles;
    public Running(int durationInMinutes, double distanceInMiles) : base(durationInMinutes)
    {
        this._distanceInMiles = distanceInMiles;
    }

    public override void GetSummary()
    {
        double speedMph = (_distanceInMiles / _durationInMinutes) * 60;
        double paceMinPerMile = _durationInMinutes / _distanceInMiles;

        Console.WriteLine($"{_currentDate} Running ({_durationInMinutes} min): Distance {_distanceInMiles:F1} miles, Speed {speedMph:F1} mph, Pace: {paceMinPerMile:F1} min per mile");
    }
}