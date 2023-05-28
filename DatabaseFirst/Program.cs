// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore.Metadata.Internal;

Console.WriteLine("Hello, World!");



//Step to Add data base migrations

//1)install Microsoft.entityframework Core, SqlServer, Tools

//2)Use following Commands to generate model  of database in project

//Scaffold-DbContext "Data Source=AXBLR-751\SQLEXPRESS;Initial Catalog=DevDB;Trusted_Connection=True;TrustServerCertificate=True;"
// Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
 
//3)if database column is added or some table add need to update schema we can use following Commands

//Scaffold-DbContext "Data Source=AXBLR-751\SQLEXPRESS;Initial Catalog=DevDB;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -DataAnnotation -force