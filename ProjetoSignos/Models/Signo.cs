using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSignos.Models
{
    public class Signo
    {
        
        int dia, mes;
        
        
        public void MostrarSigno()
        {
            Console.Write("Digite o Dia do seu Nascimento: ");

            dia = int.Parse(Console.ReadLine());

            Console.Write("Digite o Mês(numérico) do seu Nascimento: ");

            mes = int.Parse(Console.ReadLine());

    
            {if((dia>=21&&mes==3)&&(dia<=31&&mes==3)||(dia>=1&&mes==4)&&(dia<=20&&mes==4))

                Console.WriteLine("Você é do Signo de: Áries");

            else if((dia>=24&&mes==9)&&(dia<=30&&mes==9)||(dia>=1&&mes==10)&&(dia<=23&&mes==10))

                Console.WriteLine("Você é do Signo de: Libra");

            else if((dia>=21&&mes==4)&&(dia<=30&&mes==4)||(dia>=1&&mes==5)&&(dia<=21&&mes==5))

                Console.WriteLine("Você é do Signo de: Touro");

            else if((dia>=24&&mes==10)&&(dia<=31&&mes==10)||(dia>=1&&mes==11)&&(dia<=22&&mes==11))

                Console.WriteLine("Você é do Signo de: Escorpião");

            else if((dia>=22&&mes==5)&&(dia<=31&&mes==5)||(dia>=1&&mes==6)&&(dia<=21&&mes==6))

                Console.WriteLine("Você é do Signo de: Gêmeos");

            else if((dia>=23&&mes==11)&&(dia<=30&&mes==11)||(dia>=1&&mes==12)&&(dia<=21&&mes==12))

                Console.WriteLine("Você é do Signo de: Sagitário");

            else if((dia>=21&&mes==6)&&(dia<=30&&mes==6)||(dia>=1&&mes==7)&&(dia<=23&&mes==7))

                Console.WriteLine("Você é do Signo de: Cãncer");

            else if((dia>=22&&mes==12)&&(dia<=31&&mes==12)||(dia>=1&&mes==1)&&(dia<=20&&mes==1))
            
                Console.WriteLine("Você é do Signo de: Capricórnio");

            else if((dia>=24&&mes==7)&&(dia<=31&&mes==7)||(dia>=1&&mes==8)&&(dia<=23&&mes==8))

                Console.WriteLine("Você é do Signo de: Leão");

            else if((dia>=21&&mes==1)&&(dia<=31&&mes==1)||(dia>=1&&mes==2)&&(dia<=19&&mes==2))

                Console.WriteLine("Você é do Signo de: Aquário");

            else if((dia>=24&&mes==8)&&(dia<=31&&mes==8)||(dia>=1&&mes==9)&&(dia<=23&&mes==9))

                Console.WriteLine("Você é do Signo de: Virgem");

            else if((dia>=20&&mes==2)&&(dia<=29&&mes==2)||(dia>=1&&mes==3)&&(dia<=20&&mes==3))

                Console.WriteLine("Você é do Signo de: Peixes");

            else
                {
                    Console.WriteLine("Dia ou mês inválidos...");
                }
            }
        }   

        public void Sobre()
        {   Signo s = new Signo();
            string opcao = string.Empty;
            bool Digite = true;

            while (Digite)
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

                switch (Console.ReadLine())
                {
                    case "1":
                        s.Sobre();
                        break;

                    case "2":
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine();
                        break;    

                    case "5":
                        Console.WriteLine();
                        break;

                    case "6":
                        Console.WriteLine();
                        break;

                    case "7":
                        Console.WriteLine();
                        break;

                    case "8":
                        Console.WriteLine();
                        break;

                    case "9":
                        Console.WriteLine();
                        break;

                    case "10":
                        Console.WriteLine();
                        break;

                    case "11":
                        Console.WriteLine();
                        break; 

                    case "12":
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadLine();
            }
            

            
        
        }
        
    }
}