namespace Sync;

public static class RaceCondition
{
    public static void Run()
    {
        int contador = 0;

        Thread t1 = new Thread(Incrementar);
        Thread t2 = new Thread(Incrementar);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        // Caminho completo (garante criação)
        string caminhoArquivo = Path.Combine(Environment.CurrentDirectory, "../../../resultado-race-condition.txt");

        // File.AppendAllText já cria o arquivo se ele não existir
        File.AppendAllText(caminhoArquivo, $"{contador}{Environment.NewLine}");

        Console.WriteLine($"Valor final do contador que sofreu race condition: {contador}");


        void Incrementar()
        {
            for (int i = 0; i < 100000; i++)
            {
                contador++; // operação sem sincronização atômica
            }
        }
    }
}