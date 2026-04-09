namespace ConsoleApp1.Entities
{
    public static class Calculadora
    {
        public static int Somar(int a, int b)
        {
            // valicação caso fosse implementar. mas o número é randomico...
            //if(a <= 0 || b <= 0)
            //{
            //    Console.WriteLine("Os números tem que ser MAIOR que 0");
            //    return 0;
            //}

            return a + b;
        }

        public static int Subtrait(int a, int b)
        {
            // valicação caso fosse implementar. mas o número é randomico..
            //if (a <= 0 || b <= 0)
            //{
            //    Console.WriteLine("Os números tem que ser MAIOR que 0");
            //    return 0;
            //}

            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            // valicação caso fosse implementar. mas o número é randomico..
            //if (a <= 0 || b <= 0)
            //{
            //    Console.WriteLine("Os números tem que ser MAIOR que 0");
            //    return 0;
            //}
            return a * b;
        }
         
        public static int Dividir(int a, int b)
        {
            // valicação caso fosse implementar. mas o número é randomico..
            //if (a <= 0 || b <= 0)
            //{
            //    Console.WriteLine("Os números tem que ser MAIOR que 0");
            //    return 0;
            //}
            return a / b;
        }
        //por exemplo, quero que a função de soma seja com número aleatório. mas questão é que ela vai de fato somar, mas preciso desse valor retornado..
        //como posso pegar dois números aletórios e somar eles e depois retornar o resultado?
    }

}
