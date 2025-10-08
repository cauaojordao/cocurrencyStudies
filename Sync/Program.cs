using Sync;

Console.WriteLine("Escolha uma opção:");
Console.WriteLine("1 - Demonstrar condição de corrida");
Console.WriteLine("2 - Demonstrar uso de Lock");
string? opcao = Console.ReadLine();
switch (opcao)
{
    case "1":
        RaceCondition.Run();
        break;
    case "2":
        await Lock.Run();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}