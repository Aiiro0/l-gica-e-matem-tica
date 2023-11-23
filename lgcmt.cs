        static void Main()
        {
            int soma = 0;
            int p = 1;
            int valor = 2;
   
            Console.WriteLine("Numeros Impares");
                for (int n = 0; n < 40; n++)
                {

                    if (n % 2 != 0)
                    {
                    Console.WriteLine(n);
                    }
                }
            Console.WriteLine("Soma dos numeros inteiros");
            while (p <= 100)
            {
                soma = soma + p;
                p = p + 1;
            }

            Console.WriteLine(soma);

            Console.WriteLine("Divisiveis por 4");
            for (int u = 1; u < 40; u++)
            {
            if (u % 4 == 0)
                {
                    Console.WriteLine(u);
                }
            }

            Console.WriteLine("Quadrado dos numeros");
            for (int q = 15; q < 201; q++)
            {
                Console.WriteLine($"{q}^{valor} = {(long)Math.Pow(q, valor):N0} ");
            }

            Console.WriteLine("Soma dos pares");
            for (int m = 1; m < 50; m++)
            {

                if (m % 2 == 0)
                {
                    Console.WriteLine($"{m} + {m} = {m + m}");
                }
            }
        }
    }
}
