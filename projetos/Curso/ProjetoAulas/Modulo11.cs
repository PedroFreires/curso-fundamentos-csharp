namespace Modulo11;
public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2012, 12, 02, 19, 22, 23);
        var date2 = DateTime.Parse("2022/12/22 19:25:23");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        System.Console.WriteLine(date1);
        System.Console.WriteLine(date2);
        System.Console.WriteLine(date3);
        System.Console.WriteLine(date4);

        System.Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        System.Console.WriteLine(dateOffset1.LocalDateTime);
        System.Console.WriteLine(dateOffset1.UtcDateTime);

        //DateTimeOffset.UtcNow
    }

    public void AulaSubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2022/01/01");

        //var diff = date1 - date2;
        var diff = date1.Subtract(date2);
        System.Console.WriteLine((int)diff.TotalDays);
        System.Console.WriteLine((int)diff.TotalHours);

    }

    public void AulaAdicionandoDiasMesAno()
    {
        var date1 = DateTime.Now;

        System.Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
        System.Console.WriteLine(date1.AddMonths(1).ToString("dd-MM-yyyy HH:mm:ss"));
        System.Console.WriteLine(date1.AddYears(2).ToString("dd-MM-yyyy HH:mm:ss"));
    }

    public void AulaHoraMinutoSegundos()
    {
        var date1 = DateTime.Now;

        System.Console.WriteLine(date1.AddHours(1).ToString("HH:mm:ss"));
        System.Console.WriteLine(date1.AddMinutes(10).ToString("HH:mm:ss"));
        System.Console.WriteLine(date1.AddSeconds(10).ToString("HH:mm:ss"));
    }

    public void AulaDiaDaSemana()
    {
        var date1 = DateTime.Now;

        System.Console.WriteLine(date1.DayOfWeek);
    }

    public void AulaDateOnly()
    {
        var somenteData = DateOnly.Parse("2022-02-01");
        
        System.Console.WriteLine(somenteData.ToString("dd/MM/yyyy"));
    }

    public void AulaTimeOnly()
    {
        //var outraVariavel = new TimeOnly(12,23,25,0);
        var somenteHora = TimeOnly.Parse("12:12:55");
        
        System.Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
    }
}