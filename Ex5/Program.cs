namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Em maiúsculo:");
            Console.WriteLine(frase.ToUpper());

            Console.WriteLine("Em minúsculo:");
            Console.WriteLine(frase.ToLower());

            Console.WriteLine("Tamanho da frase:");
            Console.WriteLine(frase.Length);

            Console.WriteLine("Primeira palavra:");
            Console.WriteLine(frase.Split()[0]);

            Console.WriteLine("Última palavra:");
            Console.WriteLine(frase.Split()[frase.Split().Length - 1]);
        }
    }
}