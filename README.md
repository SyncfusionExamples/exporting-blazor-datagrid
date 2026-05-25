# Blazor DataGrid Export Examples

A comprehensive collection of Blazor DataGrid export samples demonstrating various export scenarios including memory streams, PDF generation, Excel conversion, and file handling techniques.

## Overview

This repository contains multiple sample projects showcasing different approaches to exporting data from Blazor DataGrid components. Whether you need to export to Excel, PDF, or handle advanced scenarios like merging multiple exports or rotating headers, you'll find practical examples here.

The samples cover:

- **Excel Exports** — Export DataGrid data as Excel files using memory streams
- **PDF Exports** — Generate PDF documents from DataGrid content with customization
- **Memory Stream Handling** — Work with binary data programmatically
- **Stream Merging** — Combine multiple export streams into single files
- **File Management** — Save exports with proper headers and encoding
- **PDF Advanced Features** — Rotate headers, handle horizontal overflow

## Sample Projects

### Excel Export Examples

#### Exporting_Memory_Stream
Demonstrates how to export Syncfusion Blazor DataGrid data to Excel format using memory streams.

```bash
cd Exporting_Memory_Stream/Exporting_Stream
dotnet run
```

**Key Features:**
- Export to Excel from DataGrid toolbar
- Handle binary data as memory streams
- Download files to the client

### PDF Export Examples

#### Blazor_Memory_Stream
Basic example of exporting DataGrid to PDF using memory streams.

```bash
cd Exporting-PDF-Datagrid/Blazor_Memory_Stream
dotnet run
```

#### Merging_Two_PDF_Memory_Stream
Combine multiple DataGrid exports into a single PDF file.

```bash
cd Exporting-PDF-Datagrid/Merging_Two_PDF_Memory_Stream
dotnet run
```

#### Rotate_header
Export to PDF with rotated column headers for better readability of wide tables.

```bash
cd Exporting-PDF-Datagrid/Rotate_header
dotnet run
```

#### Horizontal_overflow
Handle DataGrids with many columns that exceed page width.

```bash
cd Exporting-PDF-Datagrid/Horizontal_overflow
dotnet run
```

### Stream Conversion Examples

#### Converting_Memory_File_Stream
Convert between memory streams and file streams for flexible data handling.

```bash
cd Converting_Memory_File_Stream/Exporting_Stream
dotnet run
```

#### Merging_Two_Excel_Memory_Streams
Merge multiple Excel exports into a single workbook.

```bash
cd Merging_Two_Excel_Memory_Streams/Exporting_Stream
dotnet run
```

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

- [Blazor DataGrid Documentation](https://www.syncfusion.com/blazor-components/blazor-datagrid)
- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core)
- [Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor)
