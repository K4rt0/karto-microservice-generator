Console.WriteLine("=====================================");
Console.WriteLine(" .NET Microservice Project Generator");
Console.WriteLine("=====================================");
Console.WriteLine();

Console.Write("Project name: ");
var projectName = Console.ReadLine();

Console.Write("First service name: ");
var serviceName = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Project: {projectName}");
Console.WriteLine($"Service: {serviceName}");
Console.WriteLine();
Console.WriteLine("Generator is running...");