# E-Banking
The C# e-banking system is a secure and user-friendly application developed using Windows Forms and web services. It provides customers with convenient access to their accounts, allowing them perform fund transfers, deposit funds into their associated bank cards or accounts directly, view transaction history, and pay bills electronically. The system ensures robust authentication and encryption mechanisms to safeguard user data. With its intuitive interface and seamless integration with web services, this e-banking system offers a comprehensive and efficient solution for users to conduct their banking activities online.

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

## External Dependencies
- Log4Net
- WindowsForms
- WebServices
- ReportViewer
- MVC
