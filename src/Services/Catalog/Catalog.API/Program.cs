var builder = WebApplication.CreateBuilder(args);

//add services to the container

var app = builder.Build();

// comgifure http request pipeline

app.Run();
