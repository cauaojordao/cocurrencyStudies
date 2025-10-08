Thread t1 = new Thread(Trabalho);
Thread t2 = new Thread(Trabalho);

t1.Start("Thread 1");
t2.Start("Thread 2");

Console.WriteLine("Threads iniciadas.");

void Trabalho(object nome)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{nome} executando passo {i + 1}");
        Thread.Sleep(500);
    }
}