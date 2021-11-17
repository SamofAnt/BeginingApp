using System.Globalization;
using BeginingApp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var duty = new Duty();

// app.MapGet("/customs_duty",  (double price) =>   $"Пошлина: {duty.GetDuty(price)}");

app.MapGet("/customs_duty",  (double price) =>  duty.AddDuty( $"Пошлина: {Duty.GetDuty(price)}"));
app.MapGet("/all_duties", duty.GetAllDuties);
app.MapGet("/current_date", (string language) => DateTime.Now.ToString("dd MMMM yyyy, dddd, HH:mm:ss", new CultureInfo(language)));


app.Run();