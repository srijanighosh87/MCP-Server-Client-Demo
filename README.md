# MCP-Server-Client-Demo

This repository demonstrates a simple Model Context Protocol (MCP) server and client implementation in .NET.

## Solution Structure

- **Demo.McpServer/**: The MCP server project. Handles incoming MCP requests and provides responses.
- **Demo.McpClient/**: The MCP client project. Connects to the server and sends MCP requests.

## Getting Started

### Prerequisites
- [.NET 9.0 SDK]
- Visual Studio 2022 or VS Code

### Build the Solution

From the root directory:

```powershell
dotnet build
```

### Run the Server

```powershell
cd Demo.McpServer
 dotnet run
```

### Run the Client

In a new terminal:

```powershell
cd Demo.McpClient
 dotnet run
```

## Project Details

- Both projects target .NET 9.0.
- Dependencies are managed via NuGet and restored automatically on build.
- The server and client communicate using the MCP protocol.


## Folder Structure

```
MCP-Server-Client-Demo.sln
|
|-- Demo.McpServer/
|     |-- Program.cs
|     |-- ...
|
|-- Demo.McpClient/
  |-- Program.cs
  |-- ...
```

## NuGet Packages Used

Both the server and client use the following NuGet package:

- [MCPSharp](https://www.nuget.org/packages/MCPSharp) (v1.0.11)


This package provides the core MCP protocol implementation for .NET.


## MCP Server-Client Architecture (ASCII Diagram)

```
  +-------------------+           MCP Protocol           +-------------------+
  |                   | <-----------------------------> |                   |
  |   MCP Client      |   requests / responses / tools  |   MCP Server      |
  | (Demo.McpClient)  | ==============================> | (Demo.McpServer)  |
  |                   | <============================== |                   |
  +-------------------+                                 +-------------------+
```

## Sample Output from Client

```
Welcome to the MCP Client demo!
Available tool count: 1
First Available tool:
- Name: AddNumbers
- Description: Adds two numbers and returns the sum.
Tool call result: 30
```
