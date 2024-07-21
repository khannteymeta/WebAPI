using AttendenceManagementSystem.Domain.Entity;
using AttendenceManagementSystem.Application;
using AttendenceManagementSystem.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Google.Protobuf.WellKnownTypes;

var builder = WebApplication.CreateBuilder(args);
// add DbTimeSheet and ITimeSheet to dependencies
builder.Services.AddSingleton<TimeSheetDbContext>();
builder.Services.AddSingleton<ITimeSheet, DBTimeSheet>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//for age render
app.UseDefaultFiles();
app.UseStaticFiles();






app.UseHttpsRedirection();
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};
app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();







/*Employee API for read, create, update, delete  */
// Read all Emp

app.MapGet("api/employee", (ITimeSheet ts) =>
    TypedResults.Ok(ts.GetAllEmployee())
);

//Create new Employee with user Acc
app.MapPost("api/employee", ([FromBody] Employee inputEmp, ITimeSheet ts) =>
{
    if (string.IsNullOrEmpty(inputEmp.FullName) || string.IsNullOrEmpty(inputEmp.CardNo))
    {
        TypedResults.BadRequest("Please provider all data");
    }
    ts.AddEmployee(inputEmp);
    TypedResults.Created($"api/employees/{inputEmp.EmployeeId}", inputEmp);
});

//Update employee fullname and position by EmpId
app.MapPut("api/employee", (string EmployeeId, string FullName, string Position, ITimeSheet ts) =>
{
    ts.UpdateEmployee(EmployeeId, FullName, Position);
    return TypedResults.Created($"api/employees/{EmployeeId}", FullName);
});

// Delete an employee by EmployeeId
app.MapDelete("api/employee/{employeeId}", (string employeeId, ITimeSheet ts) =>
{
    ts.DeleteEmployee(employeeId);
    return TypedResults.NoContent();
});


// Time in Time out
// create new log for time in time out
app.MapPost("api/log", ([FromBody] LogEmp logInfo, ITimeSheet ts) =>
{
    ts.LogEmployee(logInfo.CardNo, new Log()
    {
        TimeStamp = DateTime.Now,
        TimeShift = logInfo.TimeShift
    });
    return TypedResults.Created($"api/logs/{logInfo.CardNo}", logInfo);
});


// Read all logs using unampping type with SQL statement
app.MapGet("api/log", (TimeSheetDbContext db) =>
{
    var result = db.Database.SqlQuery<EmployeeLog>($""""
        SELECT e.Fullname, I.TimeStamp, I.TimeShift
        FROM Employee e
        JOIN Logs I ON e.employeeId = I.CurrentEmployeeId;
        """").ToList();

    return TypedResults.Ok(result);
});


// Run the rest API sever
app.Run();

class LogEmp
{
    public string CardNo { get; set; }
    public DateTime? TimeStamp { get; set; }
    public uint TimeShift { get; set; }
}
public record EmployeeLog(string FullName, DateTime TimeStamp, uint TimeShift);

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
