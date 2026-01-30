# SQLite-Database-Tool

This is a simple C# with .NET Framework based WinForms App that manages SQLite Databases

## Features

### Legacy Mode
The application provides dedicated interfaces for managing specific databases:
- **Users Database**: Manage user records (ID, Username, Password)
- **Manuals Database**: Store and manage document files (PDFs, images) with metadata
- **Tasks Database**: Track tasks with due dates and assignments
- **Updates Database**: Manage update records

### Universal Database Mode (NEW!)
The application now includes a universal database interface that can:
- **Open any SQLite database file**: Browse and select any `.db` file on your system
- **Dynamic table discovery**: Automatically detects all tables in the selected database
- **Dynamic schema detection**: Reads table structure and generates appropriate input fields
- **Full CRUD operations**: 
  - **Add**: Insert new records with all table columns
  - **Update**: Modify existing records by selecting from the data grid
  - **Delete**: Remove records with confirmation
  - **View**: Display all records in a sortable data grid
- **Handle any database structure**: Works with any SQLite database regardless of schema

## How to Use Universal Database Mode

1. Launch the application
2. Click on **"Universal Database"** from the top menu
3. Click **"Browse..."** to select a SQLite database file (`.db`)
4. Select a table from the dropdown list
5. Use the dynamically generated fields to:
   - **Add**: Fill in the fields and click "Add"
   - **Update**: Select a row in the grid (fields auto-populate), modify values, and click "Update"
   - **Delete**: Select a row in the grid and click "Delete"
   - **Refresh**: Click "Refresh" to reload the table data

## Requirements
- .NET 8.0 or higher
- Windows OS (WinForms application)
- System.Data.SQLite package
