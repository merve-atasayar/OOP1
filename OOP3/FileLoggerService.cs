using System;

class FileLoggerService : ILoggerService
{
    public void Log()
    {
        Console.WriteLine("dosyaya loglandı");
    }
}