using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace joc_de_preguntes
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSeleccio();
        }

        static void MostrarMenu()
        {
            // MENU PRINCIPAL
            //color de fons
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            //color de la lletra
            Console.ForegroundColor = ConsoleColor.Black;
            //resolucio de la finestra
            Console.SetWindowSize(120, 50);
            // Menu del programa
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("\t\t\t\t\t::\t\t\t\t\t::");
            Console.WriteLine("\t\t\t\t\t::\t1- Preguntes d'història\t\t::");
            Console.WriteLine("\t\t\t\t\t::\t2- Preguntes d'art i literatura\t::");
            Console.WriteLine("\t\t\t\t\t::\t3- Preguntes d'esports\t\t::");
            Console.WriteLine("\t\t\t\t\t::\t\t\t\t\t::");
            Console.WriteLine("\t\t\t\t\t::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t::\tSeleccionar opcio:\t\t::");
        }
        static void MenuSeleccio()
        {
            char c;

            do
            {
                //SELECCIONAR OPCIÓ DES DEL MENÚ
                MostrarMenu();

                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Clear();


                switch (c)
                {
                    case '1':
                        historia();
                        break;
                    case '2':
                        artLiteratura();
                        break;
                    case '3':
                        esports();
                        break;
                   
                    default:
                        MostrarMenu();

                        break;

                }


                Console.Clear();



            } while (c != 'q' && c != 'Q');
        }
        static void historia()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("\t\t\t\t\t::\t1- Preguntes d'història\t\t::");
            Console.WriteLine("\t\t\t\t\t::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("");

            pregunta1H();
            pregunta2H();
            pregunta3H();
            pregunta4H();
            pregunta5H();

            TempsEspera(3000);
        }

        static void pregunta1H()
        {
            //PRIMERA PREGUNTA D'HISTORIA
            Console.WriteLine("Qui va ser el primer president de la democràcia espanyola després del franquisme?");
            Console.WriteLine("1- Adolfo Suárez.");
            Console.WriteLine("2- Pedro Sánchez");
            Console.WriteLine("3- Carles Puigdemont");
            Console.WriteLine("presiona qualsevol tecla per a passar a la SEGUENT PREGUNTA: ");


            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        correcte();
                        break;
                    case '2':
                        incorrecte();
                        break;
                    case '3':
                        incorrecte();
                        break;

                    default:
                        pregunta2H();
                        break;

                }
            } while (c != 'q' && c != 'Q');
        }

        static void pregunta2H()
        {
            //SEGONA PREGUNTA D'HISTORIA
            Console.WriteLine("presiona qualsevol tecla per a passar a la SEGUENT PREGUNTA: ");
            Console.WriteLine("Qui va ser el primer president dels Estats Units?");
            Console.WriteLine("1- Donald Trump");
            Console.WriteLine("2- George Washington");
            Console.WriteLine("3- Barack Obama");
           

            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        incorrecte();
                        break;
                    case '2':
                        correcte();
                        break;
                    case '3':
                        incorrecte();
                        break;

                    default:
                        pregunta3H();
                        break;
                }

            } while (c != 'q' && c != 'Q');
        }

        static void pregunta3H()
        {
            //TERCERA PREGUNTA D'HISTORIA'
            Console.WriteLine("presiona qualsevol tecla per a passar a la SEGUENT PREGUNTA: ");
            Console.WriteLine("Com es deien els dos exploradors que van donar la primera volta a el món?");
            Console.WriteLine("1- Magallanes-Elcano");
            Console.WriteLine("2- Roberto-Rodríguez");
            Console.WriteLine("3- Sánchez-Pérez");


            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        correcte();
                        break;
                    case '2':
                        incorrecte();
                        break;
                    case '3':
                        incorrecte();
                        break;

                    default:
                        pregunta4H();
                        break;
                }

            } while (c != 'q' && c != 'Q');
        }

        static void pregunta4H()
        {
            //QUARTA PREGUNTA D'HISTORIA
            Console.WriteLine("presiona qualsevol tecla per a passar a la SEGUENT PREGUNTA: ");
            Console.WriteLine("Què illa va servir de presó per Napoleó després de la seva derrota a la batalla de Waterloo?");
            Console.WriteLine("1- Illes de Hawaii");
            Console.WriteLine("2- Illes Canàries");
            Console.WriteLine("3- Illa de Santa Elena");


            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        incorrecte();
                        break;
                    case '2':
                        incorrecte();
                        break;
                    case '3':
                        correcte();
                        break;

                    default:
                        pregunta5H();
                        break;
                }

            } while (c != 'q' && c != 'Q');
        }

        static void pregunta5H()
        {
            //CINQUENA PREGUNTA D'HISTORIA
            Console.WriteLine("presiona qualsevol tecla per a tornar al MENU PRINCIPAL ");
            Console.WriteLine("Per quina religió és especialment important el rei Haile Selassie I?");
            Console.WriteLine("1- cristianisme");
            Console.WriteLine("2- rastafari");
            Console.WriteLine("3- budisme");


            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        incorrecte();
                        break;
                    case '2':
                        correcte();
                        break;
                    case '3':
                        incorrecte();
                        break;

                    default:
                        MostrarMenu();
                        break;
                }

            } while (c != 'q' && c != 'Q');
        }






        static void artLiteratura()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("\t\t\t\t\t::\t2- Preguntes d'art i literatura\t::");
            Console.WriteLine("\t\t\t\t\t::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("");

            pregunta1AL();
            pregunta2AL();
            pregunta3AL();
            pregunta4AL();
            pregunta5AL();
            

            TempsEspera(5000);
        }

        static void pregunta1AL()
        {
            //PRIMERA PREGUNTA D'HISTORIA
            Console.WriteLine("Quina novel·la va escriure Miguel de Cervantes i és considerada com una dels màxims exponents de la literatura espanyola i universal?");
            Console.WriteLine("1- El ingenioso hidalgo Don Quijote de la Mancha");
            Console.WriteLine("2- Mortadelo y Filemón");
            Console.WriteLine("3- El Hobbit");
            Console.WriteLine("presiona qualsevol tecla per a passar a la SEGUENT PREGUNTA: ");


            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        correcte();
                        break;
                    case '2':
                        incorrecte();
                        break;
                    case '3':
                        incorrecte();
                        break;

                    default:
                        pregunta2AL();
                        break;

                }
            } while (c != 'q' && c != 'Q');
        }

        static void pregunta2AL()
        {
            //SEGONA PREGUNTA D'HISTORIA
            Console.WriteLine("presiona qualsevol tecla per a passar a la SEGUENT PREGUNTA: ");
            Console.WriteLine("Quin gran artista és conegut per haver pintat la Capella Sixtina?");
            Console.WriteLine("1- Homer Simpson");
            Console.WriteLine("2- Joan Dausà");
            Console.WriteLine("3- Miguel Angel");


            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        incorrecte();
                        break;
                    case '2':
                        incorrecte();
                        break;
                    case '3':
                        correcte();
                        break;

                    default:
                        pregunta3AL();
                        break;
                }

            } while (c != 'q' && c != 'Q');
        }

        static void pregunta3AL()
        {
            //TERCERA PREGUNTA D'HISTORIA'
            Console.WriteLine("presiona qualsevol tecla per a passar a la SEGUENT PREGUNTA: ");
            Console.WriteLine("Qui va escriure la colmena?");
            Console.WriteLine("1- Steve Jobs");
            Console.WriteLine("2- Roberto-Rodríguez");
            Console.WriteLine("3- Camilo José Cela");


            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        incorrecte();
                        break;
                    case '2':
                        incorrecte();
                        break;
                    case '3':
                        correcte();
                        break;

                    default:
                        pregunta4AL();
                        break;
                }

            } while (c != 'q' && c != 'Q');
        }

        static void pregunta4AL()
        {
            //TERCERA PREGUNTA D'HISTORIA'
            Console.WriteLine("presiona qualsevol tecla per a passar a la SEGUENT PREGUNTA: ");
            Console.WriteLine("Qui va escriure la colmena?");
            Console.WriteLine("1- Steve Jobs");
            Console.WriteLine("2- Roberto Rodríguez");
            Console.WriteLine("3- Camilo José Cela");


            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        incorrecte();
                        break;
                    case '2':
                        incorrecte();
                        break;
                    case '3':
                        correcte();
                        break;

                    default:
                        pregunta5AL();
                        break;
                }

            } while (c != 'q' && c != 'Q');
        }

        static void pregunta5AL()
        {
            //TERCERA PREGUNTA D'HISTORIA'
            Console.WriteLine("presiona qualsevol tecla per a passar a la SEGUENT PREGUNTA: ");
            Console.WriteLine("Com es diu el pintor noruec autor de l'obra El Grito");
            Console.WriteLine("1- Camilo José Cela");
            Console.WriteLine("2- Edvard Munch");
            Console.WriteLine("3- Miguel de Cervantes");


            char c;

            do
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        incorrecte();
                        break;
                    case '2':
                        correcte();
                        break;
                    case '3':
                        incorrecte();
                        break;

                    default:
                        MostrarMenu();
                        break;
                }

            } while (c != 'q' && c != 'Q');
        }



        static void esports()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("\t\t\t\t\t::\t3- Preguntes d'esports\t\t::");
            Console.WriteLine("\t\t\t\t\t::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("");

            TempsEspera(2000);

        }

      

 
        static void TempsEspera(int Segons)
        {
            // temps espera de x segons

            Console.WriteLine("Espera" + Segons / 1000 + "segons");
            Thread.Sleep(Segons);

        }

        static void correcte()
        {
            Console.WriteLine("Resposta correcta!!!");
        }

        static void incorrecte()
        {
            Console.WriteLine("Resposta incorrecta!!!");
        }
    }

}