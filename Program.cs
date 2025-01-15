using ParkingProjectClient.Services.Interfaces;
using ParkingProjectClient.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowSpecificOrigin", policy =>
//     {
//         policy.WithOrigins("https://localhost:5002") 
//               .AllowAnyHeader()
//               .AllowAnyMethod();
//     });
// });

builder.Services.AddTransient<IParkingAPIService, ParkingAPIService>();
builder.Services.AddTransient<IParkingService, ParkingService>();
builder.Services.AddTransient<IHttpService, HttpService>();
builder.Services.AddHttpClient();

var app = builder.Build();


// app.UseCors("AllowSpecificOrigin");

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=ParkingPermits}/{id?}");

app.Run();
