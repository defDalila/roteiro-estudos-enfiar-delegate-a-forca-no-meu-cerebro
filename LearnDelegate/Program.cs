using System.Globalization;
using Delegates;
using LearnDelegate.Models;

Console.Clear();

Alarme alarme = new Alarme();

// Inscrevendo dois métodos no evento
alarme.AoDisparar += AvisoConsole;
alarme.AoDisparar += RegistrarLog;

// Disparando o alarme
alarme.Disparar();
    

    static void AvisoConsole(string msg)
{
    Console.WriteLine($"[Aviso] {msg}");
}

static void RegistrarLog(string msg)
{
    Console.WriteLine($"[Log] {DateTime.Now}: {msg}");
}

Console.Write("Tecle enter para fechar...");
Console.ReadKey();



static void Exercício01()
{
    Mensagem m = Exibir;

    m("Hello World");


    static void Exibir(string msg)
    {
        Console.WriteLine(msg);

    }
}

static void Exercicio02()
{
    Mensagem saudacao = Ola;
    saudacao("Dalila");
    Console.WriteLine();


    saudacao += Tchau;
    saudacao("Lady Gauss");
    Console.WriteLine();


    static void Ola(string nome)
    {
        Console.WriteLine($"Olá, {nome}! Seja bem-vindo(a)!");

    }

    static void Tchau(string nome)
    {
        Console.WriteLine($"Tchau {nome}! Até a próxima");

    }
}

static void Exercicio02_Desafio()
{
    Mensagem cases = Minusculo;
    cases += PrimeiraMaiuscula;
    cases += Capitalize;
    cases += Maiusculo;

    string pangrama = "The quick brown fox jumps over the lazy dog";

    cases(pangrama);

    static void Maiusculo(string frase)
    {
        Console.WriteLine(frase.ToUpper());
        Console.WriteLine();
    }

    static void Minusculo(string frase)
    {
        Console.WriteLine(frase.ToLower());
        Console.WriteLine();
    }

    static void Capitalize(string frase)
    {
        string capitalizado = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(frase.ToLower());

        Console.WriteLine(capitalizado);
        Console.WriteLine();
    }

    static void PrimeiraMaiuscula(string frase)
    {
        string inicioMaiusculo = char.ToUpper(frase[0]) + frase.Substring(1).ToLower();
        Console.WriteLine(inicioMaiusculo);
        Console.WriteLine();
    }
}

static void Exercicio03()
{
    Operacao op = Somar;
    Executar(5, 3, op);

    op = Subtrair;
    Executar(5, 3, op);

    op = Multiplicar;
    Executar(5, 3, op);

    op = Dividir;
    Executar(5, 3, op);

    Console.WriteLine();

    Executar(5, 3, Somar);
    Executar(5, 3, Subtrair);
    Executar(5, 3, Multiplicar);
    Executar(5, 3, Dividir);



    static int Somar(int a, int b) => a + b;
    static int Subtrair(int a, int b) => a - b;
    static int Multiplicar(int a, int b) => a * b;
    static int Dividir(int a, int b) => Convert.ToInt32((double)a / b);

    static void Executar(int x, int y, Operacao op)
    {
        Console.WriteLine($" {op(x, y)}");
        Console.WriteLine();


    }
}

static void Exercicio04()
{
    static int Somar(int a, int b) => a + b;
    static int Subtrair(int a, int b) => a - b;
    static int Multiplicar(int a, int b) => a * b;
    static int Dividir(int a, int b) => Convert.ToInt32((double)a / b);



    static void Executar(int x, int y, Func<int, int, int> operacao)
    {
        Console.WriteLine($" {operacao(x, y)}");
        Console.WriteLine();
    }

    Func<int, int, int> operacao = Somar;
    Executar(5, 3, operacao);
}

static void Exercicio04_Desafio()
{
    void ExibirMaiuscula(string texto, Action<string> action)
    {
        var upper = texto.ToUpper();

        action(upper);
    }


    ExibirMaiuscula("Dalila", msg => Console.WriteLine(msg));

    void Mostrar(string s) => Console.WriteLine($"Texto recebido: {s}");
    ExibirMaiuscula("Lady Gauss", Mostrar);
}