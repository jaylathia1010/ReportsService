using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.Configure<ForwardedHeadersOptions>(options =>
//           {
//               options.ForwardedHeaders =
//                   ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
//           });
// builder.Services.AddHttpsRedirection(options =>
// {
//     options.HttpsPort = 7180;
// });
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AnyOrigin", builder =>
//     {
//         builder
//             .AllowAnyOrigin()
//             .AllowAnyMethod();
//     });
// });

var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseForwardedHeaders();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
// else
// {
//     app.UseHsts();
// }

//app.UseCors("AnyOrigin");
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
