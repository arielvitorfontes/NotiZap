namespace Back.Models;

public class Alert
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Message { get; set; }
    public bool Active { get; set; }
    public int FrequencyDays { get; set; }
    public DateTime NextExecution { get; set; }
    public DateTime LastExecution { get; set; }
    public List<Recipient> Recipients { get; set; }
}