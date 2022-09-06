using System;
using ProjetoSignos.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Signo s = new Signo();

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Descobrir qual é o meu Signo!");
    Console.WriteLine("2 - Sobre meu Signo!");
    Console.WriteLine("3 - Encerrar Programa");

    switch (Console.ReadLine())
    {
        case "1":
            s.MostrarSigno();
            break;

        case "2":
            
            while(exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Meu Signo é: Capricórnio"); 
                Console.WriteLine("2 - Meu Signo é: Aquário");
                Console.WriteLine("3 - Meu Signo é: Peixes");
                Console.WriteLine("4 - Meu Signo é: Touro");
                Console.WriteLine("5 - Meu Signo é: Gemêos");
                Console.WriteLine("6 - Meu Signo é: Câncer");
                Console.WriteLine("7 - Meu Signo é: Libra");
                Console.WriteLine("8 - Meu Signo é: Leão");
                Console.WriteLine("9 - Meu Signo é: Escorpião");
                Console.WriteLine("10 - Meu Signo é: Áries");
                Console.WriteLine("11 - Meu Signo é: Virgem");
                Console.WriteLine("12 - Meu Signo é: Sagitário");
                Console.WriteLine("13 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Capricórnio é um dos signos mais julgados do zodíaco. Sem querer inserir trocadilhos, mas, por coincidência, Capricórnio é o próprio signo ligado ao julgamento. Frequentemente rotulado como chato, inflexível e workaholic, você verá que Capricórnio tem muito mais a oferecer e também entenderá o motivo de ser como é. Depois do fanfarrão Sagitário, que vive como se não houvesse amanhã, aparece Capricórnio para colocar ordem na casa. Ele pensa no longo prazo e não tem problema nenhum em deixar os pequenos prazeres para depois do trabalho importante. Capricórnio pensa muito sobre tudo o que é necessário para a estabilidade durar para sempre. Para isso, ele usa regras, hierarquia, tradições que deram certo e foco no propósito maior.");
                        break;

                    case "2":
                        Console.WriteLine("Aquário é o signo ligado ao novo, ao futuro, à tecnologia, à liberdade e a tudo que é diferente. Ele veio para questionar e renovar tudo o que veio antes dele – muitas vezes, pensando em como essas mudanças afetariam a sociedade. Inovador, racional, rápido e imprevisível, ele ri da cara das regras e detesta a sensação de estar preso a algo, seja um lugar, um ideal ou uma situação.");
                        break;

                    case "3":
                        Console.WriteLine("O último signo do zodíaco é profundo como um oceano e consegue navegar em dimensões aonde os mais racionais não chegam. Peixes está ligado a assuntos que envolvem introspecção, como espiritualidade, empatia, a conexão universal e o inconsciente. Esse signo vem para nos lembrar das coisas que dão um sentido maior para a vida.");
                        break;

                    case "4":
                        Console.WriteLine("Por prezar a qualidade, Touro é um signo paciente. Pode não ser assim desde criança, mas, ao longo da vida, esse signo se torna muito amigo do tempo. Quanto mais você aprender a se relacionar bem com o tempo das coisas, mais desfrutará da vida. Outra coisa: taurina não gosta de gente apressando sua vida. Você, taurina, já sabe disso, mas é bom deixar isso BEM CLARO, caso uma pessoa de outro signo esteja lendo aqui. Taurina também não gosta de gente se metendo em assuntos que não deve, pois é um signo extremamente ligado em limites. Esses limites servem, obviamente, também para suas posses. Gente, Touro pode ser muito generoso, mas odeia quando pegam as suas coisas sem avisar.");
                        break;    

                    case "5":
                        Console.WriteLine("Gêmeos é um dos signos mais engraçados do zodíaco, graças ao seu raciocínio rápido e sua habilidade de enxergar as coisas de um ponto de vista mais leve. Essas qualidades fazem com que as geminianas possuam uma criatividade muito grande, no sentido de conseguirem pensar em soluções inusitadas para qualquer problema. E bota pensar nisso!");
                        break;

                    case "6":
                        Console.WriteLine("Câncer, o signo das emoções. Se existe um signo que veio para aprender a fluir nas oscilações e na beleza dos feelings todos é esse. Sendo o primeiro signo do zodíaco que entra em contato com as águas, seria como se ele ainda estivesse aprendendo a lidar com os sentimentos, tipo uma criança. E é o que se vê em seu jeito fofo, carinhoso e, às vezes, manhoso, infantil ou birrentinho.");
                        break;

                    case "7":
                        Console.WriteLine("Libra é um signo ligado ao elemento Ar e regido pelo planeta Vênus e, por isso, usa suas habilidades para trazer harmonia a tudo que a cerca através de seu talento de enxergar a mesma coisa através de muitos pontos de vista. Num conflito, a libriana sabe olhar para a situação e ver os pontos que as partes têm em comum, mostrando caminhos para o entendimento. Na casa, ela sabe quais toques dar para tudo ficar mais lindo. No look, ela consegue pensar em mil maneiras para combinar acessórios e ficar chic na festa, linda, mas sem chocar.");
                        break;

                    case "8":
                        Console.WriteLine("Se você pensa que isso se traduziria em um desejo de ser famoso, pode ter razão. Mas, no caso de Leão, vamos rever esses parâmetros de sucesso. Sucesso para Leão não é aonde você chega, pois esse signo já é um sucesso só por nascer. E é aí que rola o pulo do gato, ou melhor, da leonina: por confiarem em si mesmas, as leoninas acabam arriscando mais, ousando enfrentar desafios que exigem autoconfiança e que, claro, resultam em reconhecimento e, quem sabe, fama. “A fama é óbvia, não uma busca.”");
                        break;

                    case "9":
                        Console.WriteLine("Escorpião é o mais indecifrável de todos os signos, e ele prefere manter as coisas assim, do jeito que estão, sob seu controle, pois seu enigmatismo lhe confere bastante poder. Escorpião tem a habilidade de ser invisível e incapturável.");
                        break;    

                    case "10":
                        Console.WriteLine("Áries é um signo que respeita a individualidade de cada um e espera uma atitude recíproca do próximo. Não que seja um problema liderar, pelo contrário, você sabe mandar, mas é que para você é muito óbvio que cada um pode fazer o que quiser, na hora que quiser. Portanto, se ficam te cobrando e exigindo, é quase como se estivessem pedindo para você ficar nervosa. Afinal, você precisa se sentir livre para se movimentar e também para curtir uma boa pausa quando quer.");
                        break;

                    case "11":
                        Console.WriteLine("A maioria dos virginianos se orgulha das qualidades de seu signo, pois ele é sinônimo de pragmatismo, trabalho, funcionalidade, organização e saúde, coisas que são muito bem vindas por todos nós nos dias de hoje.");
                        break; 

                    case "12":
                        Console.WriteLine("Sagitário está ligado ao elemento Fogo e é o primeiro do grupo dos signos sociais. É o Fogo sem limites, e isso se reflete no seu jeito de olhar para o mundo. Fronteiras são apenas conceitos, vagas de estacionamento são mera marcação e objetos não têm dono, eles existem para serem compartilhados. Um misto de folgado, generoso e engraçado por natureza define.");
                        break;

                    case "13":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                    Console.WriteLine("PRECIONE QUALQUER TECLA PARA CONTINUAR");
                    Console.ReadLine();

            }
                    break;

        case "3":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para Encerrar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");

