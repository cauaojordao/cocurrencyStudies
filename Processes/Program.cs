using System.Diagnostics;

Console.WriteLine("=== Processos Ativos ===");
foreach (var proc in Process.GetProcesses())
{
    Console.WriteLine($"{proc.Id} - {proc.ProcessName}, {proc.Threads.Count} threads");
}