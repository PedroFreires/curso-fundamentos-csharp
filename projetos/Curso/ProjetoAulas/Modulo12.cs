namespace Modulo12;

public class TrabalhandoComExcecoes
{
    public void AulaGerandoException()
    {
        while(true)
        {
            System.Console.WriteLine("Informe um numero: ");
            var numero = System.Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            System.Console.WriteLine("Resultado: " + resultado);  
        }   
    }

    public void AulaTratandoException()
    {
        while(true)
        {
            try
            {
                System.Console.WriteLine("Informe um numero: ");
                var numero = System.Console.ReadLine();
                var resultado = 500 / int.Parse(numero);
                System.Console.WriteLine("Resultado: " + resultado);
            }
            catch(DivideByZeroException exception)
            {
                System.Console.WriteLine("Ocorreu um erro de divisaoModuo: " + exception.Message);
                System.Console.WriteLine("Stack: " + exception.StackTrace);
            }
            catch(Exception exception)
            {
                System.Console.WriteLine("Ocorreu um erro: " + exception.Message);
                System.Console.WriteLine("Stack: " + exception.StackTrace);
            }
              
        }   
    }
}