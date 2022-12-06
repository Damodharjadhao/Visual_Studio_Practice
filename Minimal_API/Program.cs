using Minimal_API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

CalculatorFunctions calc= new CalculatorFunctions();

app.MapPost("/calculator", (CalculatorFunctions calc) =>
{
    switch (calc.OP)
    {
        case "+":
            return Results.Json(calc.N1 + calc.N2);
        case "-":
            return Results.Json(calc.N1 - calc.N2);
        case "*":
            return Results.Json(calc.N1 * calc.N2);
        case "/":
            return Results.Json(calc.N1 / calc.N2 );
    }
    return Results.Json("Opration not supported");
});


app.Run();


