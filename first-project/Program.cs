using first_project;

class Program
{
    static void Main()
    {
        // 01 --

        Console.WriteLine("Qual o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");

        // 02 --

        Console.WriteLine("Qual seria seu sobrenome?");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Anotado {nome} {sobrenome}!");


        // 03 --

        Console.WriteLine("A proxima função deste programa é fazer uma serie de operações matematicas!");

        OperaõesMatematicas matematica = new OperaõesMatematicas();

        Console.WriteLine("Digite 2 numeros!");
        string var1 = Console.ReadLine();
        double numb1 = int.Parse(var1);

        string var2 = Console.ReadLine();
        double numb2 = int.Parse(var2);

        double soma = matematica.Somar(numb1, numb2);
        Console.WriteLine($"A soma de {numb1} com {numb2} tem como resultado {soma}");

        double subtracao = matematica.Subtrair(numb1, numb2);
        Console.WriteLine($"A subtração de {numb1} com {numb2} tem como resultado {subtracao}");


        double multiplicacao = matematica.Multiplicar(numb1, numb2);
        Console.WriteLine($"A multiplicação de {numb1} com {numb2} tem como resultado {multiplicacao}");


        double divisao = matematica.Dividir(numb1, numb2);
        Console.WriteLine($"A divisão de {numb1} com {numb2} tem como resultado {divisao}");

        double media = matematica.Media(numb1, numb2);
        Console.WriteLine($"A media de {numb1} e {numb2} tem como resultado {media}");

        // 04 --

        Console.WriteLine("A proxima função deste programa é calcular a quantidade de caracteres escritos a seguir");

        string var3 = Console.ReadLine();
        int caracteres = var3.Length;
        Console.WriteLine($"A quantidade de caracteres digitados é {caracteres}");

        // 05 --

        Console.WriteLine("A proxima função deste programa é verificar se uma placa é valida de acordo com os padrões de 2018");
        string var4 = Console.ReadLine();

        // A --

        bool req1;
        if (var4.Length == 7)
            req1 = true;
        else
            req1 = false;

        Console.WriteLine(req1);

        // B --


        string primeiros3Caracteres = var4.Substring(0, 3);
        bool req2 = primeiros3Caracteres.All(char.IsLetter);

        // C --

        string ultimos4Caracteres = var4.Substring(var4.Length - 4);
        bool req3 = ultimos4Caracteres.All(char.IsDigit);

        // Result

        if(req1 && req2 && req3) { Console.WriteLine("Essa placa é valida"); } else { Console.WriteLine("Placa Invalida"); }
    }
}