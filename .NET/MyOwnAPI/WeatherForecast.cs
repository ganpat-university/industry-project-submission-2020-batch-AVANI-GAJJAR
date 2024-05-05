namespace MyOwnAPI
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Add other properties as needed
    }
    public class WeatherForecast : Item
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
