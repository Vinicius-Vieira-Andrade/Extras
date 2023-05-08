namespace elevador
{
    public class Elevador
    {
        //ATRIBUTOS
        public int andarAtual { get; private set; } = 0;

        public int totalAndares { get; private set; } = 10;

        public int capacidadeElevador { get; private set; } = 5;

        public int pessoasElevador { get; private set; } = 0;

        //METODOS
        public void Inicializa(int capacidadeElevador, int totalAndares)
        {
            Console.WriteLine($"O elevador está vazio e no térreo");
        }

        public void Entrar()
        {
            bool validarEntrarElevador = true;
            if (this.pessoasElevador < this.capacidadeElevador)
            {
                do
                {
                    Console.WriteLine($"Quantas pessoas entrarão no elevador?");
                    int i = int.Parse(Console.ReadLine()!);

                    if (i <= 5 && i >= 0)
                    {
                        validarEntrarElevador = false;
                        this.pessoasElevador += i;
                        Console.WriteLine($"{i} pessoas entraram no elevador");
                        Console.WriteLine($"Total de pessoas no elevador {this.pessoasElevador}");
                    }
                    else if (i > 5)
                    {
                        validarEntrarElevador = true;
                        Console.WriteLine($"Não é possível adicionar {i} pessoas, pois irá sobrecarregar o elevador ");

                    }
                    else
                    {
                        validarEntrarElevador = true;
                        Console.WriteLine($"Nâo foi possível identificar quantas pessoas vão entrar");
                    }
                } while (validarEntrarElevador);
            }
            else
            {
                Console.WriteLine($"O elevador está lotado, tire uma pessoa para ser possível adicionar outra pessoa");
            }
        }

        public void Sair()
        {
            bool validarSairElevador = true;
            if (this.pessoasElevador <= this.capacidadeElevador && this.pessoasElevador > 0)
            {
                do
                {
                    Console.WriteLine($"Quantas pessoas vão sair do elevador?");
                    int quantSair = int.Parse(Console.ReadLine()!);

                    if (quantSair <= 5 && quantSair > 0)
                    {
                        validarSairElevador = false;
                        this.pessoasElevador -= quantSair;
                        Console.WriteLine($"{quantSair} pessoas saíram do elevador");
                        Console.WriteLine($"total de pessoas no elevador {this.pessoasElevador}");
                    }
                    else if (quantSair > 5)
                    {
                        validarSairElevador = true;
                        Console.WriteLine($"Valor inválido insira um valor dentro do limite estipulado *MÁXIMA CARGA DO ELEVADOR É 5 PESSOAS E QUE SEJA COMPATIVEL COM O NÚMERO DE PESSOAS NO ELEVADOR!!!");
                    }
                    else
                    {
                        validarSairElevador = true;
                        Console.WriteLine($"Nâo foi possível identificar quantas pessoas vão sair");
                    }
                } while (validarSairElevador);

            }
        }

        public void Subir()
        {
            if (this.andarAtual < this.totalAndares && this.andarAtual >= 0)
            {

            voltaEleva:
                Console.WriteLine($"<=== SUBIR ELEVADOR ===>");
                Console.WriteLine($"");
                Console.WriteLine($"Qual andar deseja ir?");
                Console.WriteLine($"");

                for (int i = 0; i <= totalAndares; i++)
                {
                    if (i == andarAtual && i == 0)
                    {
                        Console.WriteLine($"[{i}] Térreo");
                    }
                    else if (i > andarAtual)
                    {
                        Console.WriteLine($"{i}º Andar");

                    }
                }
                Console.WriteLine($"Aperte o andar desejado");
                int opcao = int.Parse(Console.ReadLine()!);
                if (opcao > this.andarAtual && opcao <= totalAndares)
                {
                    Console.WriteLine($"O elevador subiu para o {opcao}º andar");
                }
                else
                {
                    Console.WriteLine($"Opção inválida, insira um andar válido");
                    goto voltaEleva;
                }
                this.andarAtual = opcao;
            }
            else
            {
                Console.WriteLine($"O elevador está no último andar, só resta descer");
            }
        }

        public void Descer()
        {
            if (andarAtual > 0)
            {
                voltarDescer:
                Console.WriteLine($"<=== DESCER ELEVADOR ===>");
                Console.WriteLine($"");
                Console.WriteLine($"Qual andar deseja ir?");
                Console.WriteLine($"");

                for (int i = this.andarAtual; i >= 0; i--)
                {
                    if (i > this.totalAndares && i >= 0)
                    {
                        Console.WriteLine($"[{i}] Térreo");
                    }
                    else if (i > this.andarAtual)
                    {
                        Console.WriteLine($"{i}º Andar");
                    }
                }

                Console.WriteLine($"Digite o andar que deseja ir");
                int resposta = int.Parse(Console.ReadLine()!);
                if (resposta <= this.andarAtual && resposta == 0)
                {
                    Console.WriteLine($"O elevador desceu para o {resposta}º andar");
                }
                else
                {
                    Console.WriteLine($"Opção inválida, insira um andar válido");
                    goto voltarDescer;
                }
                this.andarAtual = resposta;
            }
            else
            {
                Console.WriteLine($"O elevador está no térreo, só resta subir");
            }
        }
    }
}
