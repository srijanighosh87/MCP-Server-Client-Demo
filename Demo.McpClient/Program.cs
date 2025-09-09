using MCPSharp;

namespace Demo.McpClient;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to the MCP Client demo!");

        var client = new MCPClient(
                name: "DemoMcpClient",
                version: "v1.0.0",
                server: "D:\\Git Repos\\MCP-Server-Client-Demo\\Demo.McpServer\\bin\\Debug\\net9.0\\Demo.McpServer.exe"
            );
        var tools = await client.GetToolsAsync();
        Console.WriteLine($"Available tool count: {tools.Count}");
        Console.WriteLine("First Available tool:");
        Console.WriteLine($"- Name: {tools[0].Name}");
        Console.WriteLine($"- Description: {tools[0].Description}");

        var result = await client.CallToolAsync(name: tools[0].Name, parameters: new Dictionary<string, object?>
        {
            { "a", 10 },
            { "b", 20 }
        });
        Console.WriteLine($"Tool call result: {result.Content[0].Text}");

        Console.Read();
    }
}