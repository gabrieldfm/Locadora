--comandos ef

dotnet tool install --global dotnet-ef

--add migration: na pasta projeto infra

dotnet ef --startup-project ../Locadora.Apresentacao.Api migrations add InitialCreate


dotnet ef --startup-project ../Locadora.Apresentacao.Api database update
 