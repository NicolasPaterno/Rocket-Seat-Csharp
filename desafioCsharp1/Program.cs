using System;
using System.Text;
using System.Text.RegularExpressions;

class DesafioCsharp1
{
    public void BoasVindas()
    {
        Console.WriteLine("Qual seu nome? ");
        string nome = Console.ReadLine().Trim();
        Console.WriteLine($"Olá {nome}, seja muito bem-vindo!");
    }

    public void ConcatName()
    {
        Console.WriteLine("Digite seu nome:");
        var name = Console.ReadLine().Trim();
        Console.WriteLine("Digite seu sobrenome:");
        var subName = Console.ReadLine().Trim();

        StringBuilder fullName = new StringBuilder();
        fullName.Append(name);
        fullName.Append(" ");
        fullName.Append(subName);

        Console.WriteLine($"Nome completo: {fullName}");
    }

    public void BasicOperations()
    {
        Console.WriteLine("Insira 2 valores quaisquer: ");
        var num1 = Convert.ToDouble(Console.ReadLine());
        var num2 = Convert.ToDouble(Console.ReadLine());

        void Sum()
        {
            var sum = num1 + num2;
            Console.WriteLine($"Soma: {sum}");
        }

        void Subtraction()
        {
            var sub = num1 - num2;
            Console.WriteLine($"Subtração: {sub}");
        }

        void Multi()
        {
            var mult = num1 * num2;
            Console.WriteLine($"Multiplicação: {mult}");
        }

        void Division()
        {
            if (num2 != 0)
            {
                var div = num1 / num2;
                Console.WriteLine($"Divisão: {div}");
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida!");
            }
        }

        void Average()
        {
            var average = (num1 + num2) / 2;
            Console.WriteLine($"Média: {average}");
        }

        Sum();
        Subtraction();
        Multi();
        Division();
        Average();
    }

    public void NumbOfLetters()
    {
        Console.WriteLine("Digite uma ou mais palavras: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        Console.WriteLine("\nQuantidade de caracteres em cada palavra:");

        foreach (string word in words)
        {
            Console.WriteLine($"{word}: {word.Length} caracteres");
        }
    }

    public void BrPlates()
    {
        Console.WriteLine("Digite sua placa:");

        string plate = Console.ReadLine();
        string standardPlate = @"^[A-Za-z]{3}[0-9]{4}$";

        var check = Regex.IsMatch(plate, standardPlate);

        Console.WriteLine(check ? "Verdadeiro" : "Falso");
    }

    public void Date()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Escolha um formato para exibir a data atual:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\"");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Formato completo: " + date.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
                break;
            case 2:
                Console.WriteLine("Data no formato \"dd/MM/yyyy\": " + date.ToString("dd/MM/yyyy"));
                break;
            case 3:
                Console.WriteLine("Hora no formato 24 horas: " + date.ToString("HH:mm"));
                break;
            case 4:
                Console.WriteLine("Data com mês por extenso: " + date.ToString("dd 'de' MMMM 'de' yyyy"));
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    public static void Main()
    {
        DesafioCsharp1 desafio = new DesafioCsharp1();

        Console.WriteLine("Escolha o que deseja fazer:");
        Console.WriteLine("1 - Boas vindas");
        Console.WriteLine("2 - Junção de nome e sobrenome");
        Console.WriteLine("3 - Operações básicas entre 2 números");
        Console.WriteLine("4 - Número de caracteres inseridos em uma ou mais palavras");
        Console.WriteLine("5 - Validação da placa do carro válida até 2018");
        Console.WriteLine("6 - Exibição personalizada de data e hora");
        Console.WriteLine("7 - Sair");
        var escolha = Convert.ToInt32(Console.ReadLine());
        while(escolha>0 && escolha<8)
        switch (escolha)
        {
            case 1:
                desafio.BoasVindas();
                break;
            case 2:
                desafio.ConcatName();
                break;
            case 3:
                desafio.BasicOperations();
                break;
            case 4:
                desafio.NumbOfLetters();
                break;
            case 5:
                desafio.BrPlates();
                break;
            case 6:
                desafio.Date();
                break;
            case 7:
            return;
                break;
            default:
                Console.WriteLine("Valor incorreto");
                break;
        }
    }
}
