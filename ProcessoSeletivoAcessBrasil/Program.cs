namespace ProcessoSeletivoAcessBrasil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] amostra = { 100, 90, 40, 70 };
            int alunoAcimaMedia = 0;
            int mediaAmostra = (amostra.Sum()) / 4;

            for (int indice=0; indice<amostra.Length; indice++)
            {
                if (amostra[indice] > mediaAmostra)
                {
                    alunoAcimaMedia++;
                }
            }

            double eficiencia = (alunoAcimaMedia * 100 / amostra.Length);

            Console.WriteLine($"A eficiência de alunos equivale a {eficiencia}%");
            
        }
    }
}