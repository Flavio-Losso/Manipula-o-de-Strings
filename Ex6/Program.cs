namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Definicao();
            string[] cidadeEstado, Estados;
            char[] letras;
            Manipulacao(line, out cidadeEstado, out Estados, out letras);
            Exibir(cidadeEstado, Estados, letras);
        }

        static string[] Definicao()
        {
            String caminhoArquivo = "../../../Cidades.csv";
            String arquivoCSV = File.ReadAllText(caminhoArquivo);
            String[] line = arquivoCSV.Split("\r\n");
            return line;
        }

        static void Manipulacao(string[] line, out string[] cidadeEstado, out string[] Estados, out char[] letras)
        {
            cidadeEstado = new string[(line.Length)];
            for (int i = 0; i < cidadeEstado.Length; i++)
            {
                int cidade = 2;
                int estado = 3;
                String[] coluna = line[i].Split(";");
                cidadeEstado[i] = coluna[cidade] + ";" + coluna[estado];
            }
            Estados = new String[27];
            int nEstados = 0;
            for (int i = 1; i < cidadeEstado.Length; i++)
            {
                int indexSeparador = cidadeEstado[i].IndexOf(";");
                string estado = cidadeEstado[i].Substring(indexSeparador + 1).Trim();

                bool estadoJaAdicionado = false;
                for (int j = 0; j < nEstados; j++)
                {
                    if (Estados[j] == estado)
                    {
                        estadoJaAdicionado = true;
                        break;
                    }
                }

                if (!estadoJaAdicionado)
                {
                    Estados[nEstados] = estado;
                    nEstados++;
                }

            }
            Array.Sort(Estados);

            letras = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z' };
        }

        static void Exibir(string[] cidadeEstado, string[] Estados, char[] letras)
        {
            for (int i = 0; i < letras.Length; i++)
            {
                char primeiraLetra = letras[i];
                Console.WriteLine($"Cidades com a letra do alfabeto {primeiraLetra}");
                Console.WriteLine();
                for (int j = 0; j < cidadeEstado.Length; j++)
                {
                    if (cidadeEstado[j].StartsWith(primeiraLetra))
                    {
                        int ax = cidadeEstado[j].IndexOf(";");
                        string cidade = cidadeEstado[j].Remove(ax);
                        Console.WriteLine(cidade);
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < Estados.Length; i++)
            {
                Console.WriteLine($"Cidades do estado {Estados[i]}");
                Console.WriteLine();
                for (int j = 0; j < cidadeEstado.Length; j++)
                {
                    if (cidadeEstado[j].Contains(Estados[i]))
                    {
                        int removeEstado = cidadeEstado[j].IndexOf(";");
                        string cidade = cidadeEstado[j].Remove(removeEstado);
                        Console.WriteLine(cidade);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}