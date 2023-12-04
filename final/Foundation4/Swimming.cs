public class Swimming : Activity
{
    private int _laps;
    public Swimming(int durationInMinutes, int laps) : base(durationInMinutes)
    {
        this._laps = laps;
    }

    public override void GetSummary()
    {
        double distanceKm = _laps * 50 / 1000;
        double speedKph = (distanceKm / _durationInMinutes) * 60.0;
        double paceMinPerKm = _durationInMinutes / distanceKm;
        
        Console.WriteLine($"{_currentDate} Swimming ({_durationInMinutes} min): Distance {distanceKm:F1} km, Speed {speedKph:F1} kph, Pace: {paceMinPerKm:F1} min per km");
    }
}