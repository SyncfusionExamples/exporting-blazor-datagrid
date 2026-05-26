# Blazor DataGrid Export Examples

A comprehensive collection of [Blazor DataGrid]() export samples demonstrating various export scenarios including memory streams, PDF generation, Excel conversion, and file handling techniques.

## Overview

This repository contains multiple sample projects showcasing different approaches to exporting data from Blazor DataGrid components. Whether you need to export to Excel, PDF, or handle advanced scenarios like merging multiple exports or rotating headers, you'll find practical examples here.

The samples cover:

- **Excel Exports** — Export DataGrid data as Excel files using memory streams
- **PDF Exports** — Generate PDF documents from DataGrid content with customization
- **Memory Stream Handling** — Work with binary data programmatically
- **Stream Merging** — Combine multiple export streams into single files
- **File Management** — Save exports with proper headers and encoding
- **PDF Advanced Features** — Rotate headers, handle horizontal overflow

## Features

- **Progress Tracking** — Real-time export progress indicators for large datasets
- **Custom Formatting** — Apply custom styles and formatting to exported files
- **Batch Processing** — Export multiple files simultaneously in batch mode
- **Error Handling** — Comprehensive error management and recovery mechanisms
- **File Compression** — Compress exported files and create ZIP archives
- **Schedule Exports** — Automated scheduling for periodic exports

## Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/SyncfusionExamples/exporting-blazor-datagrid.git
cd exporting-blazor-datagrid
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## Resources

- [Blazor Exporting Documentation](https://blazor.syncfusion.com/documentation/datagrid/excel-exporting)
- [Online Export Demo](https://blazor.syncfusion.com/demos/datagrid/exporting?theme=fluent2)
