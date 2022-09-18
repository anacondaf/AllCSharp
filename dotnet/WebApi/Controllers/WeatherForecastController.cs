using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    //Immutable object
    public record Teacher(string Name, int Age);
    // {
    //     public string Name { get; init; }
    //     public int Age { get; init; }
    //
    //     public Teacher()
    //     {
    //         
    //     }
    // }
    
    
    public class Student
    {
        private string Name;
        private int Age;
        
        public int Grade { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public void GetStudent()
    {
        //Target-typed new expression
        Student student = new("John", 10) { Grade = 1};

        Teacher teacher = new("Bob", 40);
        // We cannot mutate (change) Age of record value: teacher.Age = 10;
    }
}
