# E-Banking System
The C# e-banking system is a secure and user-friendly application developed using Windows Forms and web services. It provides customers with convenient access to their accounts, allowing them perform fund transfers, deposit funds into their associated bank cards or accounts directly, view transaction history, and pay bills electronically. The system ensures robust authentication and encryption mechanisms to safeguard user data. With its intuitive interface and seamless integration with web services, this e-banking system offers a comprehensive and efficient solution for users to conduct their banking activities online.

## Project Structure
``
`bash
├── EBankingSystem.sln             # Solution file
├── EBankingSystem.DataAccess      # Data access layer
│   ├── EBankingSystem.DataAccess.csproj
│   ├── Repositories                # Data repositories
│   ├── Entities                    # Data entity classes
│   └── ...
├── EBankingSystem.BusinessLogic    # Business logic layer
│   ├── EBankingSystem.BusinessLogic.csproj
│   ├── Services                    # Business services
│   ├── Validators                  # Input validation logic
│   └── ...
├── EBankingSystem.WebApp           # Web application layer
│   ├── EBankingSystem.WebApp.csproj
│   ├── Controllers                 # MVC controllers
│   ├── Views                       # MVC views
│   ├── wwwroot                     # Static files (CSS, JS, etc.)
│   └── ...
├── EBankingSystem.Tests            # Unit tests
│   ├── EBankingSystem.Tests.csproj
│   ├── DataAccessTests             # Data access layer tests
│   ├── BusinessLogicTests          # Business logic layer tests
│   └── ...
└── README.md                       # Project documentation and instructions
`
``


## External Dependencies
- Log4Net
- WindowsForms
- WebServices
- ReportViewer
