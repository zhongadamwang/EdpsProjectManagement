using MetaShare.Common.Core.Daos;
using MetaShare.Common.Core.Daos.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EdpsProjectManagement.Daos;
using EdpsProjectManagement.Services;
/*add customized code between this region*/
/*add customized code between this region*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("EdpsProjectManagement");

DaoFactory.Instance.ConnectionStringBuilder = new ConnectionStringBuilder(connectionString, typeof(SqlContext)) { SqlDialectType = typeof(SqlServerDialect), SqlDialectVersionType = typeof(SqlServerDialectVersion) };

RegisterDaos.RegisterAll(DaoFactory.Instance.ConnectionStringBuilder.SqlDialectType, DaoFactory.Instance.ConnectionStringBuilder.SqlDialectVersionType);
RegisterServices.RegisterAll();

/*add customized code between this region*/
/*add customized code between this region*/

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    /*add customized code between this region*/
    /*add customized code between this region*/
}

/*add customized code between this region*/
/*add customized code between this region*/
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
