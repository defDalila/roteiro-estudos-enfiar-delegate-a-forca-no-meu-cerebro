using System.Globalization;
using Delegates;

Console.Clear();

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