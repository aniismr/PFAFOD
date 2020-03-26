

###  Angular
create new Angular project to download the missing folder node_modules
```
npm install -g @angular/cli 
```
clone  
```View ```  
to your new angular project folder 

add those libraries
```
npm install --save @ng-bootstrap/ng-bootstrap
ng add @angular/localize.
npm install bootstrap
npm install @angular/flex-layout --save
ng add @angular/material
```
then run it 
```
ng serve
```

## BackEnd Dotnet core 3.1 
install Entity framework
```
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
```
change your connection string in :
```		
connection string :BackEnd/appsettings.json 

```
create a migration of database and update it / create it :
```	
dotnet ef migrations add "yourSnapshot"
dotnet ef database update
```
run dotnet
```
dotnet run
```
		

