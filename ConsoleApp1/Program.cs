using System;

namespace ConosleApp1
{
    class Program
    {
        /// <summary>
        /// Funkcja Sum zwraza sumę liczb całkowitych
        /// Wykonuje dodawanie liczb całkowitych
        /// </summary>
        /// <param name="parameter_a">Liczba a</param>
        /// <param name="parameter_a">Liczba b</param>
        /// <returns>Suma</returns>
        public static int Sum(int parameter_a, int parameter_b)
        {
            return parameter_a + parameter_b;
        }
        /// <summary>
         /// Funkcja Sum zwraza sumę liczb całkowitych
         /// Wykonuje dodawanie liczb całkowitych
         /// </summary>
         /// <param name="parameter_a">Liczba a</param>
         /// <param name="parameter_a">Liczba b</param>
         /// <returns>Suma</returns>
        public static int Subtraction(int parameter_a, int parameter_b)
        {
            return parameter_a - parameter_b; //TODO: Piotr w miejsce -1 wstaw odpowiednie działanie, tak aby wynik był zgodny
        }
        /// <summary>
        /// Funkcja Product zwara iloczyn liczb całkowitych
        /// Wykonuje mnożenie liczb całkowitych
        /// </summary>
        /// <param name="a">Liczba a</param>
        /// <param name="b">Liczba b</param>
        /// <returns>Iloczyn - wynik działania mnożenia</returns>
        public static int Product(int parameter_a, int parameter_b)
        {
            return parameter_a * parameter_b;
        }

        /// <summary>
        /// Funkcja Product zwara iloraz liczb całkowitych
        /// Wykonuje dzielenie liczb całkowitych
        /// </summary>
        /// <param name="a">Liczba a</param>
        /// <param name="b">Liczba b</param>
        /// <returns>Iloraz - wynik działania dzielenia</returns>
        public static int Quotient(int parameter_a, int parameter_b)
        {
            return parameter_a / parameter_b; //TODO: Piotr w miejsce -1 wstaw odpowiednie działanie, tak żeby wynik był zgodny
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dodawanie liczb całkowitych");
            
            int a = 10;
            int b = 99;
            int suma_a_b = Sum(a, b);
            Console.WriteLine($"Wynik dodawania liczb: {a} i {b} jest równy {suma_a_b}"); //TODO: Piotr co to jest ten znaczek $? W jaki inny sposób można przekazać do konsoli wynik dodawania?
            //TODO: Piotr przetestuj działanie funkcji sum na innych liczbach, po swojemu

            int c = 15;
            int d = 3;
            int product_c_d = Product(c, d);
            Console.WriteLine($"Wynik mnożenia liczb: {c} i {d} jest równy {product_c_d}");
            //TODO: Piotr przetestuj działanie funkcji Product na innych liczbach, po swojemu

            //TODO: Piotr przetestuj działanie funkcji Subtraction oraz Quotient

            // Odejmowanie
            int e = 81;
            int f = 9;

            int Subtraction_e_f = Subtraction(e, f);
            Console.WriteLine($"Wynik odejmowania liczb: {e} i {f} jest równy {Subtraction_e_f}");


            // Dzielenie 
            int g = 10;
            int h = 5;

            int Quotient_g_h = Quotient(g, h);
            Console.WriteLine($"Wynik dzielenia liczb: {g} i {h} jest równe {Quotient_g_h}");
        }
    }
}
