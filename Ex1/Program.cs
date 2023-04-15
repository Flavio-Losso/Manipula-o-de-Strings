namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] letras = frase.Split(' ');

            for (int i = 0; i < letras.Length; i++)
            {
                letras[i] = char.ToUpper(letras[i][0]) + letras[i].Substring(1);
            }

            frase = string.Join(" ", letras);

            Console.WriteLine($"Frase em Title Case: {frase}");
        }
    }
}