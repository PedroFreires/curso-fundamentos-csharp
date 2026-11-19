namespace Conversores;

public class Conversor
{
    public void ConvertAndParse()
    {
        //int numero = int.Parse("1");
        //int numero = Convert.ToInt32(null);
        //int numero = int.Parse(null);
        bool verdadeiro = bool.Parse("true");
        System.Console.WriteLine(verdadeiro);
    }

    public void AulaTryParse()
    {
        var numero = "abc";
        int numeroConvertido;

        if(int.TryParse(numero, out numeroConvertido))
        {
            System.Console.WriteLine("Numero foi convertido com sucesso!");
        }

        System.Console.WriteLine(numeroConvertido);
    }
}