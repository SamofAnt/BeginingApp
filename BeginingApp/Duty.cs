namespace BeginingApp;

public class Duty
{
    private IList<string> HistoryDuties { get; set; }= new List<string>();
    
    public static double GetDuty(double price) => price > 200 ? (price - 200) * 1.15 + 200 : price;
    
    public string GetAllDuties() => HistoryDuties.Aggregate("", (current, str) => current + (str + '\n'));

    public void AddDuty(string duty) => HistoryDuties.Add(duty);
}