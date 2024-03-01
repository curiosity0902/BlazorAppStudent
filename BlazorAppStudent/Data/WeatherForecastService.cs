namespace BlazorAppStudent.Data
{
    public class WeatherForecastService
    {
     
        private static readonly string[] Surname = new[]
       {
        "��������", "��������", "���������", "����������", "���������"
    };
        private static readonly string[] Name = new[]
       {
        "����", "�������", "�������", "�������", "����"
    };
        private static readonly string[] Patronymic = new[]
      {
        "������������", "���������", "����������", "����������", "����������"
    };

   private static readonly string[] Groupp = new[]
        {
        "320 �", "321 �", "322 �", "327 ���", "328 ���"
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