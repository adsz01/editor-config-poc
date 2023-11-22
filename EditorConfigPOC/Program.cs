var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

List<int> variable1 = null;

IEnumerable<int> numbers = new List<int>()
{
    1,
    2,
    3,
    4,
    5,
    6,
};


var stringNumbers = numbers.Where(x => x % 2 == 0).Select(x => x / 2);
var stringNumbers2 = numbers.Where(x => x % 2 == 0).Select(x => x / 2);
var stringNumbers3 = numbers.Where(x => x % 2 == 0).Select(x => x / 2);

Console.WriteLine(string.Join(",", numbers.Where(x=>x % 2 == 0)));
Console.WriteLine(string.Join(",", stringNumbers2.Where(x => x % 2 == 0)));
Console.WriteLine(string.Join(",", stringNumbers2.Where(x => x % 2 == 0)));

var odds = numbers.Where(x => x % 2 == 0);
app.UseHttpsRedirection();
MyMethod(stringNumbers2);

app.UseAuthorization();
var a = new int[0];

while (true)
{
    Console.WriteLine(".");
}





app.MapControllers();

app.Run();

return;

void MyMethod(IEnumerable<int> input)
{
    var count = input.Count();
    foreach (var i in input) { }
}

class Testclass
{
    public int var1 { get; set; }
}
