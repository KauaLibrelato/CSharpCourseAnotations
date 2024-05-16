using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            /*
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é $ {preco2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("");
            Console.WriteLine($"Medida com outo casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado(três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F2", CultureInfo.InvariantCulture)}");
             */

            /*
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade e altura (mesma linha):");
            string[] infos = Console.ReadLine().Split(' ');

            int idade = int.Parse(infos[0]);
            double altura = double.Parse(infos[1], CultureInfo.InvariantCulture);

            Console.WriteLine($"Seu nome completo é {nome}, você tem {idade} anos de idade, sua altura é de {altura}m.");
            */

            /*
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Área maior é do triangulo X");
            }
            else if (areaX == areaY){
                Console.WriteLine("Áreas iguais");
            }
            else {
                Console.WriteLine("Área maior é do triangulo Y");
            }
            */

            /*
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            a.Nome = Console.ReadLine();
            Console.Write("Idade:");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            b.Nome = Console.ReadLine();
            Console.Write("Idade:");
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade) {
                Console.WriteLine($"Pessoa mais velha: {a.Nome}");
            }
            else if (a.Idade == b.Idade) {
                Console.WriteLine("Ambos tem a mesma idade");
            }
            else {
                Console.WriteLine($"Pessoa mais velha: {b.Nome}");
            }
            */

            /*
            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome:");
            a.Nome = Console.ReadLine();
            Console.Write("Salário:");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome:");
            b.Nome = Console.ReadLine();
            Console.Write("Salário:");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.Salario + b.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome:");
            p.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque:");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine("");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine("");

            Console.Write("Digite o número de produtos a ser removido do estoque:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine($"Dados atualizados: {p}");
            */

            /*
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine($"AREA = {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /*
            Funcionario2 funcionario = new Funcionario2();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {funcionario}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine($"Dados atualizados: {funcionario}");
            */

            /*
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (aluno.Aprovado()) {
                Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
            */

            /*
            Console.Write("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor = ConversorDeMoeda.ValorEmReais(cotacao, quantidade);
            Console.WriteLine($"Valor a ser pago em reais = {valor.ToString("F2", CultureInfo.InvariantCulture)}");
            */

        }
    }
}