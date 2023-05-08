// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).

using elevador;
Elevador e1 = new Elevador();
bool validarMenu = true;
bool validarMenu2 = true;

do
{
    Console.WriteLine(@$"
                Painel Elevador
----------------------------------------------------
[1] Inicializa (ANTES DE RODAR O PROGRAMA, POR FAVOR INICIALIZE, CASO CONTRÁRIO NÃO FUNCIONARÁ!!!)
[2] Entrar (ENTRADA DE PESSOAS NO ELEVADOR, MÁXIMO 5)
[3] Sair (SAIDA DE PESSOAS NO ELEVADOR)
[4] Subir (SUBIDA DE ANDARES)
[5] Descer (DESCIDA DE ANDARES)
[6] Finalizar programa
");
    string respostaMenu = Console.ReadLine()!;


    switch (respostaMenu)
    {
        case "1":
            validarMenu = false;
            e1.Inicializa(e1.capacidadeElevador, e1.totalAndares);
            Console.WriteLine($"Pressione ENTER para prosseguir!");
            string enter = Console.ReadLine()!;

            do
            {
                Console.WriteLine(@$"
                Painel Elevador
----------------------------------------------------
[1] Inicializa (ANTES DE RODAR O PROGRAMA, POR FAVOR INICIALIZE, CASO CONTRÁRIO NÃO FUNCIONARÁ!!!)
[2] Entrar (ENTRADA DE PESSOAS NO ELEVADOR, MÁXIMO 5)
[3] Sair (SAIDA DE PESSOAS NO ELEVADOR)
[4] Subir (SUBIDA DE ANDARES)
[5] Descer (DESCIDA DE ANDARES)
[6] Finalizar programa
");

                string respMennu = Console.ReadLine()!;
                switch (respMennu)
                {
                    case "1":
                        validarMenu2 = true;
                        Console.WriteLine($"O programa já está inicializado");
                        break;
                    case "2":
                        validarMenu2 = true;
                        e1.Entrar();
                        break;
                    case "3":
                        validarMenu2 = true;
                        e1.Sair();
                        break;
                    case "4":
                        validarMenu2 = true;
                        e1.Subir();
                        break;
                    case "5":
                        validarMenu2 = false;
                        e1.Descer();
                        break;
                    case "6":
                        validarMenu2 = false;
                        Console.WriteLine($"Saindo programa..");
                        Environment.Exit(1);
                        break;
                    default:
                        validarMenu2 = true;
                        Console.WriteLine($"Resposta inválida, insira uma alternativa correta!!!");
                        break;
                }

            } while (validarMenu2);
            break;
        case "2":
            validarMenu = true;
            Console.WriteLine($"Deve-se inicializar o programa do elevador, por favor inicialize antes!!!");
            break;
        case "3":
            validarMenu = true;
            Console.WriteLine($"Deve-se inicializar o programa do elevador, por favor inicialize antes!!!");
            break;
        case "4":
            validarMenu = true;
            Console.WriteLine($"Deve-se inicializar o programa do elevador, por favor inicialize antes!!!");
            break;
        case "5":
            validarMenu = true;
            Console.WriteLine($"Deve-se inicializar o programa do elevador, por favor inicialize antes!!!");
            break;
        case "6":
            validarMenu = false;
            Console.WriteLine($"Saindo programa..");
            Environment.Exit(1);
            break;
        default:
            validarMenu = true;
            Console.WriteLine($"Resposta inválida, por favor inicialize o programa antes de continuar");
            break;
    }
} while (validarMenu);




