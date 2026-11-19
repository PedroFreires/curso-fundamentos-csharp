/*Console.WriteLine("Primeiro programa!");

int idade = 22;
Console.WriteLine(idade);
String nomePessoa = "Pedro Henrique";
Console.WriteLine(nomePessoa);
decimal valor = 200.99M;
double valorDouble = 200.99;
float valorFloat = 200.99f;
Console.WriteLine(valor);
Console.WriteLine(valorDouble);
Console.WriteLine(valorFloat);
var idadeNova = 34;
char flag = 'Y';
Console.WriteLine(flag);
bool ativo = true;
Console.WriteLine(ativo);

//Constantes
const string descricao = "Curso CSHARP";
descricao = "Cruso";
Console.WriteLine(descricao);
*/

/*
var numero1 = 1;
var numero2 = 2;


int soma = numero1 + numero2;
Console.WriteLine(soma);

int subtracao = numero2 - numero1;
Console.WriteLine(subtracao);

int multiplicacao = (numero2 * numero1) * 10;
Console.WriteLine(multiplicacao);

int divisao = numero2 / numero1;
Console.WriteLine(divisao);
*/


/*
var igual = numero1 == numero2;
Console.WriteLine(igual);

bool maior = numero2 > numero1;
Console.WriteLine(maior);

bool menor = numero2 < numero1;
Console.WriteLine(menor);

bool menorOuIgual = numero2 <= numero1;
Console.WriteLine(menorOuIgual);

bool maiorOuIgual = numero2 >= numero1;
Console.WriteLine(maiorOuIgual);

bool diferente = numero2 != numero1;
Console.WriteLine(diferente);
*/

/*
int numero1 = 1;
var numero2 = 2;


bool valido = numero2 > numero1 && 6 > 7;
Console.WriteLine(valido);

bool valido2 = numero2 > 10 || 6 > 7;
Console.WriteLine(valido2);

bool valido3 = !(numero2 > numero1);
Console.WriteLine(valido3);
*/
/*
bool ativo = false;
string status = ativo ? "Cadastro Ativo" : "Cadastro Inativo";
Console.WriteLine(status);
*/

/*
EscreverNome();

void EscreverNome()
{
    var nome = NomeCompleto();
    var soma = SomaValores();
    Console.WriteLine(nome);
    Console.WriteLine(soma);
}

string NomeCompleto()
{
    string primeiroNome = "Pedro";
    string segundoNome = "Henrique";
    return primeiroNome + " " + segundoNome;
}

int SomaValores()
{
    return 8 + 2;
}
*/

/*
var soma = SomaValores(3, 5);
Console.WriteLine(soma);

var nome = NomeEIdade("Pedro", 22);
Console.WriteLine(nome);

int SomaValores(int a, int b)
{
    return a + b;    
}

string NomeEIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e tenho " + idade + " anos";
}
*/

using System.Collections;

/*
var arrayList = new ArrayList();
arrayList.Add(1); //0
arrayList.Add("Pedro"); //1
arrayList.Add(true); //2

//Console.WriteLine(arrayList[1]); // acesso por indice

arrayList.RemoveAt(1);

// Limpar arrayList
//arrayList = new ArrayList();
arrayList.Clear();

foreach(var item in arrayList)
{
    Console.WriteLine(item);
}
*/

/*
//var arrayTipadoNumero = new int[3] {1, 2, 3};

var arrayTipadoNumero = new int[3];
arrayTipadoNumero[0] = 5;
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10;

//Array.Resize(ref arrayTipadoNumero, 100);
//arrayTipadoNumero[10] = 100;

foreach(var item in arrayTipadoNumero)
{
    Console.WriteLine(item);
}

//var arrayTipadoString = new string[2] {"Pedro", "Henrique"};
var arrayTipadoString = new string[2];

arrayTipadoString[0] = "Pedro";
arrayTipadoString[1] = "Henrique";

foreach(var item in arrayTipadoString)
{
    Console.WriteLine(item);
}
*/

/*
var list = new List<String>(10)
{
    "Pedro",
    "Henrique",
};
//list.Add("Pedro");
//list.Add("Henrique");
//list.Add("Curso");

var nome = list[0];
Console.WriteLine(nome);

list.RemoveAt(1);

foreach(var item in list)
{
    Console.WriteLine(item);
}
*/

/*
var dicionario = new Dictionary<int, string>()
{
    {5, "Teste"},
    {6, "Teste 6"},
};

dicionario.Add(100, "Pedro");

dicionario[50] = "Curso";

var nome = dicionario[50];
//Console.WriteLine(nome);

foreach(var item in dicionario)
{
    Console.WriteLine(item.Value);
}
*/

/*
var queue = new Queue<string>();
queue.Enqueue("Pedro");
queue.Enqueue("Henrique");

//var nome = queue.Peek();
//var nome1 = queue.Peek();

var nome = queue.Dequeue();
var nome1 = queue.Dequeue();


Console.WriteLine(nome);
Console.WriteLine(nome1);

/*
foreach(var item in queue)
{
    Console.WriteLine(item);
}
*/

/*
var stack = new Stack<string>();
stack.Push("Pedro");
stack.Push("Henrique");

var nome = stack.Pop();
var nome1 = stack.Pop();

Console.WriteLine(nome);
Console.WriteLine(nome1);
/*foreach(var item in stack)
{
    Console.WriteLine(item);
}*/

//Modulo 7 - Aula 1
/*
var diaDaSemana = 0;
var diaDeTrabalho = false;

if(diaDaSemana == 0 && diaDeTrabalho == true)
{
    Console.WriteLine("Hoje é Domingo");
}
else if(diaDaSemana == 0 && diaDeTrabalho == false)
{
    Console.WriteLine("Hoje é Domingo, mas não é dia de trabalho");
}
else
{
    Console.WriteLine("Hoje não é Domingo");
}
*/

/*
var diaDaSemana = 1;
if(diaDaSemana == 1)
{
    System.Console.WriteLine("Hoje é Domingo");
}
else if(diaDaSemana == 2)
{
    System.Console.WriteLine("Hoje é Segunda");
}
else if(diaDaSemana == 3)
{
    System.Console.WriteLine("Hoje é Terça");
}
else if(diaDaSemana == 4)
{
    System.Console.WriteLine("Hoje é Quarta");
}
else if(diaDaSemana == 5)
{
    System.Console.WriteLine("Hoje é Quinta");
}
else if(diaDaSemana == 6)
{
    System.Console.WriteLine("Hoje é Sexta");
}
else if(diaDaSemana == 7)
{
    System.Console.WriteLine("Hoje é Sabado");
}
else
{
    System.Console.WriteLine("Dia da semana Inválido");
}
*/

//Modulo 7 - Aula 2
/*var diaDaSemana = 0;
switch (diaDaSemana)
{
    case 0:
    {
        System.Console.WriteLine("Hoje é Domingo");
        break;
    }
    case 2:
        System.Console.WriteLine("Hoje é Segunda");
        break;
    case 3:
        System.Console.WriteLine("Hoje é Terça");
        break;
    case 4:
        System.Console.WriteLine("Hoje é Quarta");
        break;
    case 5:
    System.Console.WriteLine("Hoje é Quinta");
        break;
    case 6:
        System.Console.WriteLine("Hoje é Sexta");
        break;
    case 7:
        System.Console.WriteLine("Hoje é Sábado");
        break;
    default:
        System.Console.WriteLine("Inválido");
        break;
}
*/

/*
var diaDaSemana = 0;
switch(diaDaSemana < 1) //nesses casos booleanos para switch faz mais sentido um if e else
{
    case true:
        System.Console.WriteLine("Hoje é Domingo");
        break;
    case false:
        System.Console.WriteLine("Inválido");
        break;
}
*/

//Modulo 7 - Aula 3
/*var lista = new List<string>(){"Pedro", "Curso", "CSHARP"};

for(var i=0; i < lista.Count; i++)
{
    var nome = lista[i];
    System.Console.WriteLine(nome);
}
*/
//Modulo 7 - Aula 4
/*var lista = new List<string>(){"Pedro", "Curso", "CSHARP"};

foreach(string item in lista)
{
    System.Console.WriteLine(item);
}

foreach(var letra in "Pedro Henrique")
{
    System.Console.WriteLine(letra);
}
*/

//Modulo 7 - Aula 5
/*var i = 0;
while (i < 10)
{
    System.Console.WriteLine(i);
    i++;
}

var j = 0;
do
{
    System.Console.WriteLine(j);
    j++;
} while (j < 10);
*/

//Modulo 7 - Aula 6
/*var i = 0;
while (i < 5)
{
    if(i < 2)
    {
        System.Console.WriteLine("Continuando");
        i++;
        continue;
    }

    System.Console.WriteLine("var i = " + i);
    i++;

    if(i == 2)
    {
        System.Console.WriteLine("Valor do i é igual a 2");
        break;
    }
}
*/