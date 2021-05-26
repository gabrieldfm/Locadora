### Comandos ef

`dotnet tool install --global dotnet-ef`

### Add migration: na pasta projeto infra

######Criação da migration
`dotnet ef --startup-project ../Locadora.Apresentacao.Api migrations add InitialCreate`

######Atualizando a base
`dotnet ef --startup-project ../Locadora.Apresentacao.Api database update`
