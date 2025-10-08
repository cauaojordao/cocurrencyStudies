namespace Sync;

public static class Lock
{
    private static int contador;
    static readonly object locker = new();

    public static async Task Run()
    {
        Thread t1 = new Thread(Incrementar);
        Thread t2 = new Thread(Incrementar);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
        
        string caminhoArquivo = Path.Combine(Environment.CurrentDirectory, "../../../resultado-lock.txt");

        File.AppendAllText(caminhoArquivo, $"{contador}{Environment.NewLine}");

        Console.WriteLine($"Valor final do contador com lock: {contador}");

        static void Incrementar()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (locker)
                {
                    contador++;
                }
            }
        }
    }
}