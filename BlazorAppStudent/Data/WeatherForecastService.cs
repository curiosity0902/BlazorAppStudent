namespace BlazorAppStudent.Data
{
    public class WeatherForecastService
    {
     
        private static readonly string[] Surname = new[]
       {
        "Кудашова", "Сагдиева", "Корнилова", "Файзуллина", "Ахметшина"
    };
        private static readonly string[] Name = new[]
       {
        "Анна", "Камилла", "Варвара", "Эльвина", "Кира"
    };
        private static readonly string[] Patronymic = new[]
      {
        "Вячеславовна", "Рамилевна", "Дмитриевна", "Рафаэлевна", "Рустемовна"
    };

   private static readonly string[] Groupp = new[]
        {
        "320 п", "321 п", "322 п", "327 веб", "328 веб"
    };
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(0, 5).Select(index => new WeatherForecast
            {
                Surname = Surname[index],
                Name = Name[index],
                Patronymic = Patronymic[index],
                DateOfBirth = startDate.AddDays(index),
                Groupp = Groupp[index]
            }).ToArray());
        }
    }
}