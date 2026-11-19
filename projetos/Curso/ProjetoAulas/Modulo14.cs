namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        /*string nomeCompleto = "PEDRO HENRIQUE";

        Func<char, bool> filtro = c => c == 'E';

        //var resultado = nomeCompleto.Where(filtro);
        //var resultado = nomeCompleto.Where(p => p == 'E');

        var resultado = from c in nomeCompleto where c == 'R' select c;

        foreach(var letra in resultado)
        {
            System.Console.WriteLine(letra);
        }*/

        var numeros = new int[] {10, 5, 5, 50, 15, 2};
        var resultado = numeros.Where(p => p >= 10);
        foreach(var numero in resultado)
        {
            System.Console.WriteLine(numero);
        }
    }

    public void AulaOrdenacao()
    {
        var numeros = new int[] {10, 5, 5, 50, 15, 2};
        var nomes = new string[] {"Pedro", "Henrique", "Freires"};
        //var resultado = numeros.OrderByDescending(p => p);
        var resultado = nomes.OrderBy(p => p);
        foreach(var numero in resultado)
        {
            System.Console.WriteLine(numero);
        }
    }

    public void AulaTake()
    {
        var numeros = new int[] {10, 5, 5, 50, 15, 2};
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);
        foreach(var numero in resultado)
        {
            System.Console.WriteLine(numero);
        }
    }

    public void AulaCount()
    {
        var numeros = new int[] {10, 5, 5, 50, 15, 2};
        
        var resultado = numeros.Count(p => p > 10);

        System.Console.WriteLine(resultado);
    }

    public void AulaFirstEFirstOrDefault()
    {
        var numeros = new int[] {10, 5, 5, 50, 15, 2};
        
        //var resultado = numeros.First();
        //var resultado = numeros.First(p => p > 105);
        var resultado = numeros.FirstOrDefault(p => p > 105, -99);

        System.Console.WriteLine(resultado);
    }

    public void ExercicioAverage()
    {
        var numeros = new int[] {10, 5, 5, 50, 15, 2};
        
        var resultado = numeros.Average();

        System.Console.WriteLine(resultado);
    }

    public void ExercicioSingleOrDefault()
    {
        var numeros = new int[] {10, 6, 5, 50, 15, 2};
        
        var resultado = numeros.SingleOrDefault(p => p == 5);

        System.Console.WriteLine(resultado);
    }

    public void ExercicioMinEMax()
    {
        var numeros = new int[] {10, 6, 5, 50, 15, 2};
        
        var resultadoMin = numeros.Min();
        var resultadoMax = numeros.Max();

        System.Console.WriteLine(resultadoMin);
        System.Console.WriteLine(resultadoMax);
    }


}