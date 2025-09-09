using System.ComponentModel;
using MCPSharp;
using Microsoft.AspNetCore.Http;

namespace Demo.McpServer;

internal class Program
{
    static async Task Main(string[] args)
    {
        MCPServer.Register<CalculatorTool>();
        await MCPServer.StartAsync("Demo.McpServer", "1.0.0");
        await Task.Delay(Timeout.Infinite);
    }
}

public class CalculatorTool
{
    [McpTool("addition", "This tool adds two numbers.")]
    public static int Add([McpParameter(required: true, description: "The first number.")] int a,
                          [McpParameter(required: true, description: "The second number.")] int b)
    {
        return a + b;
    }
}
