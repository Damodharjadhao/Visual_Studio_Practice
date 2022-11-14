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

app.MapPost("/calculator", (Calculator calc) =>
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
            return Results.Json(calc.N1 / calc.N2);
    }
    return Results.Json("Opration not supported");
});


app.Run();

class Calculator
    {
    int n1;
    int n2;
    string? op;

    public int N1
    {
        get { return n1; }
        set { n1 = value; }
    }
    public int N2 { 
        get { return n2; } 
        set { n2 = value; }
        }

    public string? OP
    {
        get { return op; }
        set { op = value; }
    }
    }
