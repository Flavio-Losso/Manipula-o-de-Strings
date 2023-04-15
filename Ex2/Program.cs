namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            frase = frase.Trim();


            string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int numerodepalavras = palavras.Length;

            Console.WriteLine("A frase tem " + numerodepalavras + " palavras.");
        }
    }
}