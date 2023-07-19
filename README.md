<img src="/E-banking banner.png" alt="Blue banner for e-banking system">

## Description
The C# e-banking system is a secure and user-friendly application developed using Windows Forms and web services. It provides customers with convenient access to their accounts, allowing them perform fund transfers, deposit funds into their associated bank cards or accounts directly, view transaction history, and pay bills electronically. The system ensures robust authentication and encryption mechanisms to safeguard user data. With its intuitive interface and seamless integration with web services, this e-banking system offers a comprehensive and efficient solution for users to conduct their banking activities online.
 
<br>

## Project Structure
```
E-Banking
├── Core       # Core layer
│   ├── Core.sln
│   ├── Core                       # Source code files
│   │   └── wsCore.asmx            # Core layer WebServices with main functionalities
│   │   └── ...             
│   ├── Packages                   # Dependencies file
│   ├── .vs/Core                   # Configuration file
│   └── ...
│   
├── Int        # Integration layer
│   ├── Int.sln                    # Integration layer solution
│   ├── Int                        # Source code files
│   ├── WebServices                # Integration layer WebService with main functionalities
│   ├── Packages                   # Dependencies file
│   ├── .vs/Int                    # Configuration file
│   └── ...
│
├── Caja       # Cash Management layer
│   ├── Caja.sln                   # Cash Management layer solution
│   ├── .vs/Caja                   # Configuration file
│   ├── Caja                       # Source code files
│   │   └── Pantalla               # Main interfaces file
│   │   └── ...             
│   └── Packages                   # Dependencies file
│
├── Scripts de Datos de prueba.sql                    # Unit tests
├── Scripts de Eliminacion de Datos de prueba.sql     # Unit tests
├── Scripts de Procedimientos.sql                     # Unit tests
├── Scripts de Tablas CAJA.sql                        # Unit tests
├── Scripts de Tablas CORE.sql                        # Unit tests
├── Scripts de Tablas.sql                             # Unit tests
└── README.md                                         # Project documentation and instructions
```
 
<br>

## System Requirements
- Only compatible with Windows operating system
- Must have installed the .Net Framework 4.7.2 or later versions.
- Visual Studio: Version 2017 or above (for development)
- Microsoft SQL Server: Version 2012 or above (for data storage)
- Before running the project it is necessary to rebuild the references by clicking on the Build option in Visual Studio.
- Must install the following dependencies:
  - Log4Net
  - WindowsForms
  - WebServices
  - ReportViewer
  - MVC
 
<br>

## Contributing
Contributions to enhance the tribute page and its content are welcome. If you have any suggestions, bug reports, or feature requests, please submit them as issues in this repository. Alternatively, you can fork this repository, make your changes, and submit a pull request.
