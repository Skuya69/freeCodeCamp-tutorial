using System;

namespace Giraffe
{

    class Program
    {
        static void Main(string[] args)
        {
            //typ zmiennej / nazwa / wartość

            string zdanie = "Akademia Giraffe" + " is cool";
            char grade = '4';
            int twojStary = 4;
            double kasa = 100.60;
            bool amIsexy = true;

            //tekst i metody

            Console.WriteLine("Akademia\n\"Giraffe\"");
            Console.WriteLine(zdanie.GetHashCode());
            Console.WriteLine(zdanie.ToUpper());
            Console.WriteLine("that's " + zdanie.Contains("Akademia") + " " + (zdanie[9]));
            Console.WriteLine(twojStary + "" + zdanie.IndexOf("cool"));
            Console.WriteLine(zdanie.Substring(zdanie.IndexOf("Giraffe")));


            //liczby i metody

            Console.WriteLine(Math.Sin(twojStary));
            Console.WriteLine(Math.Cos(twojStary));
            Console.WriteLine(Math.Max(Math.Sin(twojStary), Math.Cos(twojStary)));


            //getting user input

            Console.Write("Wprowadz swoje imie: ");
            string name = Console.ReadLine();

            Console.Write("Podaj liczbe: ");

            int liczba0 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Witaj " + name + ", Twoja liczba dnia to " + liczba0 * 69);

            Console.Write("Podaj liczbe: ");
            int liczba3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masz " + liczba3 + " nowe wiadomosci");


            //kalkulator

            Console.Write("Wprowadz liczbe: ");
            int liczba1 = Convert.ToInt32(Console.ReadLine()); // jesli chce decimal to double liczba1 i Convert.ToDouble()
            Console.Write("Wprowadz inna liczbe: ");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Suma podanych liczb " + (liczba1 + liczba2));
            Console.WriteLine("Roznica podanych liczb " + (liczba1 - liczba2));
            Console.WriteLine("Iloczyn podanych liczb " + liczba1 * liczba2);
            Console.WriteLine("Iloraz podanych liczb " + liczba1 / liczba2);

            //mad libs

            string wiek, postac, zawod;

            Console.Write("Podaj wiek: ");
            wiek = Console.ReadLine();  //dlaczego nie Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj nazwe postaci: ");
            postac = Console.ReadLine();
            Console.Write("Podaj zawod: ");
            zawod = Console.ReadLine();

            Console.WriteLine("Moj dziadek ma " + wiek + " lat");
            Console.WriteLine("Moj superbohater nazywa sie " + postac);
            Console.WriteLine("Twoj stary to " + zawod);

            //arrays / tablice - container ktory moze przetrzymywac wiele informacji o zmiennych

            int[] luckyNumbers = { 1, 7, 17, 27, 36, 44, 52, 69, 77, 80, 99 };
            //  0  1  2   3   4   5   6   7   8   9   10

            luckyNumbers[2] = 900;
            Console.WriteLine(luckyNumbers[2]); //<-- w [] podaje sie numer wartości z kolei w tablicy

          
            string[] office = new string[5];

            office[0] = "Jim";
            office[1] = "Pam";
            office[2] = "Dwight"; 
            office[3] = "Stanley";
            office[4] = "Michael";

            Console.Write("Wybierz numer od 0 do 4: ");

            int numer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Twoj bohater z the Office na dzis to " + office[numer]);

            //methods / metody - containter, w którym napisany kod wykona konkretną czynność


            SayHi("Milosz", 24);
            SayHi("Martyna", 25);       // na dole jest metoda SayHi
            SayHi("Dziczek", 69);

            int cubedNumber = cube(19);  // na dole jest metoda cube
            
            Console.WriteLine(cubedNumber);

            //instrukcje warunkowe:
            //
            //if

            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall) // && oznacza i, czyli oba warunki muszą być spełnione do egzekucji kodu
            {
                Console.WriteLine("You are tall male");
            } else
            {
                Console.WriteLine("You are either not tall or not male or both");
            }


            if (isMale || isTall) // || oznacza lub, czyli wystarczy ze jeden z warunkow bedzie prawdziwy do egzekucji kodu
            {
                Console.WriteLine("You are either tall or male or both");
            }
            else
            {
                Console.WriteLine("You are either not tall or not male or both");
            }
            //
            // else if
            //
            if (isMale && isTall) 
            {
                Console.WriteLine("You are tall male");
            }
            else if (isMale && !isTall) // ! oznacza negacje, czyli czy NIE jest wysoki
            {
                Console.WriteLine("You are short male");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are not a male, but you are tall");
            }
            else
            {
                Console.WriteLine("You are either not tall or not male or both");
            }

            //wiecej instrukcji warunkowych:


            Console.WriteLine(GetMax(39, 93));          
            Console.WriteLine(GetMaxMax(25,69,13));

            //rozbudowany kalkulator / 2 zmienne / mozliwość wyboru działania 

            Console.Write("Wprowadz liczbe: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wybierz działanie: \n" + "+\n" + "-\n" + "*\n" + "/\n");
            string op = Console.ReadLine();

            Console.Write("Wprowadz drugą liczbe: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("ziomek ale wez wpisz jakis symbol jak wyzej");
            }

            //instrukcje przypadkowe - switch / case


            Console.Write("Wybierz swoj ulubiony numer od 1-7:");
            int numDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twoj dzien tygodnia to " + GetDay(numDay));

            
            //pętle while

            int index = 1;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 10);


            //guess game

            string secretWord = "sword";
            string guess = "";
            int guessCount = 0;
            const int guessLimit = 4;
            bool outOfGuesses = false;


            Console.WriteLine("Welcome to guess game!\nSecret word is \"king's weapon\"");

            do
            {
                Console.Write("Guess the secret word: ");
                guess = Console.ReadLine();
                guessCount++;

                if (guess == secretWord)
                {
                    Console.Write("You are the best!!! ");
                }
                else if (guessCount < guessLimit)
                {
                    Console.WriteLine("You got " + (guessLimit - guessCount) + " tries remaining");
                }
                else if (guessCount < guessLimit && guessCount == 3)
                {
                    Console.WriteLine("You got only " + (guessLimit - guessCount)+ " try remaining");
                }
                else
                {
                    outOfGuesses = true;
                }

            } while (guess != secretWord && !outOfGuesses);

            if (outOfGuesses)
            {
                Console.WriteLine ("You lose!");
            }

            //for - loop, bardziej kompaktowy niz while, latwiejszy do zarządzania


            int[] luckyNumbers2 = { 4, 8, 15, 16, 23, 42 };

            for (int i = 1; i < luckyNumbers2.Length; i++)
            {
                Console.WriteLine(luckyNumbers2[i]);
            }

            // getPow

            Console.WriteLine(GetPow(2, 3));

            //2d arrays

            int[,] numberGrid = {  //<-- im wiecej przecinków w [], tym więcej wymiarów tablicy
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
            };

            int[,] myArray = new int[2, 3];


            Console.WriteLine(numberGrid[1, 1]);





            Console.ReadLine();

           
        }

        /////////////metoda

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old.");
        }

        //return - metoda ze zwroceniem inta

        static int cube(int num)
        {
            int wynik = num * num * num;
            return wynik;
        }

        //getMax - metoda do intrukcji warunkowej

        static int GetMax(int num1, int num2)
        {
            int wynik;

            if (num1 > num2)   // warunek przez porownanie zmiennych
            {
                wynik = num1;
                
            }else
            {
                wynik = num2;
            }
            return wynik;
        }

        //coraz trudniej hihi 3 zmienne if else if

        static int GetMaxMax(int num1, int num2, int num3)
        {
            int wynik;

            if (num1 >= num2 && num1 >= num3)   // warunek przez porownanie zmiennych
            {
                wynik = num1;

            }
            else if (num2 >= num1 && num2 >= num3)
            {
                wynik = num2;
            }
            else
            {
                wynik = num3;
            }
            return wynik;
        }


        //metoda do instrukcji przypadkowych - switch / case 

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;

        }

        // for / metoda getPow(liczba bazowa, liczba przez ktorą podnieść do potęgi)

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i <powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }


    }
}
