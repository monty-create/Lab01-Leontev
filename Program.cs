
Console.WriteLine("=== 1. ИНФОРМАЦИЯ О КОМПЬЮТЕРЕ ===");
Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");
Console.WriteLine();

Console.WriteLine("=== 2. ИССЛЕДОВАНИЕ ОС ===");
Console.WriteLine($"ОС: {Environment.OSVersion}");
Console.WriteLine($"64-битная ОС: {Environment.Is64BitOperatingSystem}");
Console.WriteLine();

Console.WriteLine("=== 3. ЛОГИЧЕСКИЕ ПРОЦЕССОРЫ ===");
Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
Console.WriteLine();

Console.WriteLine("=== 4. ПАМЯТЬ ПРОЦЕССА ===");
Console.WriteLine($"PID процесса: {Environment.ProcessId}");
long memoryEnv = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса (через Environment): {memoryEnv} МБ");
Console.WriteLine();

Console.WriteLine("=== 5. МИНИ-МОНИТОР СИСТЕМЫ (ДОП. ЗАДАНИЕ) ===");
Process currentProcess = Process.GetCurrentProcess();
Console.WriteLine($"PID процесса (через Process): {currentProcess.Id}\n");
Console.WriteLine("Память процесса:");

for (int i = 1; i <= 3; i++)
{
    currentProcess.Refresh();
    long memoryProc = currentProcess.WorkingSet64 / 1024 / 1024;
    Console.WriteLine($"{i} измерение: {memoryProc} МБ");
    if (i < 3)
    {
        Console.WriteLine("Обновите окно через несколько секунд (нажмите Enter)...");
        Console.ReadLine();
    }
}

Console.WriteLine("\nИсследование завершено.");
Console.ReadLine();
