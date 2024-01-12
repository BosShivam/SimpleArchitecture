using SimpleArchitecture.Api.Extensions;
using SW.Bus;
using SW.PrimitiveTypes;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options => options.UseNamespaceRouteToken())
                .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));    // Add this to process Enums by default as string instead of integer

builder.Services.AddEndpointsApiExplorer();
builder.Services.SimpleArchSwaggerConf();
builder.Services.RegisterDependencyInjections();

#region SimplyWorks Configuration
builder.Services.AddBus(configure =>
{
    configure.ApplicationName = "SimpleArchitecture.API";
    configure.DefaultQueuePrefetch = 10;
    configure.DefaultRetryCount = 2;
}, builder.Environment.EnvironmentName);
builder.Services.AddBusPublish();
builder.Services.AddBusConsume();
builder.Services.AddScoped<RequestContext>();
#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
app.MapControllers();
app.Run();