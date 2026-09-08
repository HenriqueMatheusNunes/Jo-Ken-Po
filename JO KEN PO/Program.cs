namespace JO_KEN_PO
{
    internal class Program
    {
        enum Opcao
        {
            Adicionar = 1,
            Jogar = 2,
            Placar = 3,
            Sair = 4,
        }
        static void Main(string[] args)
        {
            List<Jogador> Lista = new List<Jogador>();
            bool rodarMenu = true;

            int VitoriasJogador = 0;
            int VitoriasPC = 0;
            int ganhador = 0;

            while (rodarMenu == true)
            {
                Console.WriteLine("\nSelecione uma das opções abaixo:");
                Console.WriteLine("1-Adicionar\n2-Jogar\n3-Placar\n4-Sair");

                int index = int.Parse(Console.ReadLine());
                Opcao opcaoSelecionada = (Opcao)index;

                switch (opcaoSelecionada)
                {

                    case Opcao.Adicionar:
                        Jogador jogador = new Jogador();

                        Console.WriteLine("Ola, bem vindo ao jo-ken-po. Pode dizer o seu nome?");
                        string nome = Console.ReadLine();
                        jogador.Nome = nome;

                        Lista.Add(jogador);


                        break;

                    case Opcao.Jogar:

                        string jogada;
                        string placar;



                        int vitorias;


                        if (Lista.Count == 0)
                        {
                            Console.WriteLine("Nenhum jogador foi cadastrado! Vá na opcao 1 para realizar o cadastro");
                        }

                        else
                        {
                            Console.WriteLine($"Bem {Lista[0].Nome}, preparado para jogar? digite Sim para confirmação e Não para não");
                            string ler = Console.ReadLine();

                            if (ler == "Sim" || ler == "sim")
                            {
                                Console.WriteLine(" 1 partida, faca sua primeira jogada " + Lista[0].Nome);
                                jogada = Console.ReadLine();
                                if (jogada == "Tesoura" || jogada == "tesoura")
                                {
                                    Console.WriteLine(" Voce escolheu Tesoura ");
                                }



                                else if (jogada == "Pedra" || jogada == "pedra")
                                {
                                    Console.WriteLine(" Voce escolheu Pedra ");
                                }



                                else if (jogada == "Papel" || jogada == "papel")
                                {
                                    Console.WriteLine(" Voce escolheu Papel");
                                }



                                Console.WriteLine(" Agora o computador fara sua jogada ");




                                Random r = new Random();
                                int jogadaPc = r.Next(1, 4);
                                string escolhaPc = "";


                                if (jogadaPc == 1) escolhaPc = "Pedra";
                                if (jogadaPc == 2) escolhaPc = "Papel";
                                if (jogadaPc == 3) escolhaPc = "Tesoura";

                                Console.WriteLine("O computador jogou " + escolhaPc);



                                if ((jogada == "Tesoura" || jogada == "tesoura") && escolhaPc == "Tesoura")
                                {
                                    Console.WriteLine("Nessa partida voce " + Lista[0].Nome + " Escolheu Tesoura e o computador também, empate");
                                }
                                else if ((jogada == "Tesoura" || jogada == "tesoura") && escolhaPc == "Pedra")
                                {
                                    Console.WriteLine("Nessa partida voce " + Lista[0].Nome + " Escolheu Tesoura e o computador escolheu Pedra. Portanto computador ganhou");
                                    VitoriasPC++;
                                }
                                else if ((jogada == "Tesoura" || jogada == "tesoura") && escolhaPc == "Papel")
                                {
                                    Console.WriteLine("Nessa partida voce " + Lista[0].Nome + " Escolheu Tesoura e o computador escolheu Papel. Portanto " + Lista[0].Nome + " ganhou");
                                    VitoriasJogador++;
                                }

                                else if ((jogada == "Papel" || jogada == "papel") && escolhaPc == "Papel")
                                {
                                    Console.WriteLine("Nessa partida voce " + Lista[0].Nome + " Escolheu Papel e o computador também, empate");
                                }
                                else if ((jogada == "Papel" || jogada == "papel") && escolhaPc == "Pedra")
                                {
                                    Console.WriteLine("Nessa partida voce " + Lista[0].Nome + " Escolheu Papel e o computador escolheu Pedra. Portanto " + Lista[0].Nome + " ganhou");
                                    VitoriasJogador++;
                                }
                                else if ((jogada == "Papel" || jogada == "papel") && escolhaPc == "Tesoura")
                                {
                                    Console.WriteLine("Nessa partida voce " + Lista[0].Nome + " Escolheu Papel e o computador escolheu Tesoura. Portanto computador ganhou");
                                    VitoriasPC++;
                                }

                                else if ((jogada == "Pedra" || jogada == "pedra") && escolhaPc == "Pedra")
                                {
                                    Console.WriteLine("Nessa partida voce " + Lista[0].Nome + " Escolheu Pedra e o computador também, empate");
                                }
                                else if ((jogada == "Pedra" || jogada == "pedra") && escolhaPc == "Papel")
                                {
                                    Console.WriteLine("Nessa partida voce " + Lista[0].Nome + " Escolheu Pedra e o computador escolheu Papel. Portanto computador ganhou");
                                    VitoriasPC++;
                                }
                                else if ((jogada == "Pedra" || jogada == "pedra") && escolhaPc == "Tesoura")
                                {
                                    Console.WriteLine("Nessa partida voce " + Lista[0].Nome + " Escolheu Pedra e o computador escolheu Tesoura. Portanto " + Lista[0].Nome + " ganhou");
                                    VitoriasJogador++;
                                }


                            }
                        }
                        break;

                    case Opcao.Placar:
                        Console.WriteLine("O placar  do jogador foi de " + VitoriasJogador + " E o placar do PC foi de " + VitoriasPC);
                        if (VitoriasJogador > VitoriasPC)
                        {
                            Console.WriteLine("O jogador ganhou essa partida com um total de pontos de " + VitoriasJogador);
                        }
                        else if (VitoriasJogador < VitoriasPC)
                        {
                            Console.WriteLine(" O PC foi o vencedor com um total de pontos de " + VitoriasPC);
                        }
                        else
                        {
                            Console.WriteLine("EMPATE");
                        }


                        break;





                    case Opcao.Sair:
                        rodarMenu = false;
                        break;



                }

                }
            }
        }
    }