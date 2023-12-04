public class Cycling : Activity
{
    private double _speedInKph;
    public Cycling(int durationInMinutes, double speedInKph) : base(durationInMinutes)
    {
        this._speedInKph = speedInKph;
    }

    public override void GetSummary()
    {
        double speedKph = _speedInKph;
        double paceMinPerKm = 60.0 / speedKph;

        Console.WriteLine($"{_currentDate} Cycling ({_durationInMinutes} min): Speed {speedKph:F1} kph, Pace: {paceMinPerKm:F1} min per km");
    }
}