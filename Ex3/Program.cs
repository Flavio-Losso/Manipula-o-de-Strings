namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o texto a ser cifrado: ");
            string texto = Console.ReadLine();
            Console.Write("Digite a numero de posições que a letra vai se mover: ");
            int posicoes = Convert.ToInt32(Console.ReadLine());

            string textomovido = "";

            foreach (char letra in texto)
            {
                if (char.IsLetter(letra))
                {
                    char letraCifrada = (char)(((int)char.ToUpper(letra) + posicoes - 65) % 26 + 65);
                    textomovido += char.IsUpper(letra) ? letraCifrada : char.ToLower(letraCifrada);
                }
                else
                {
                    textomovido += letra;
                }
            }

            Console.WriteLine($"Texto com cifra: {textomovido}");
        }
    }
}