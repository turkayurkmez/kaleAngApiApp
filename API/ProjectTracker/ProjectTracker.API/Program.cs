using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ProjectTracker.Business;
using ProjectTracker.Business.Mapping;
using ProjectTracker.DataAccess.Data;
using ProjectTracker.DataAccess.Repositories;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IProjectRepository, EFProjectRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, EFUserRepository>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, EFCategoryRepository>();


builder.Services.AddAutoMapper(typeof(MappingProfile));

var connectionString = builder.Configuration.GetConnectionString("db");

builder.Services.AddDbContext<ProjectTrackerDbContext>(option => option.UseSqlServer(connectionString));

var secret = "cok gizli ve onemli bir cumle";
var issuer = "kalegrup";
var audience = "kalegrup";

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(option => {
                    option.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = true,
                        ValidateIssuer = true,
                        ValidIssuer = issuer,
                        ValidAudience = audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret))
                    };
                });

builder.Services.AddCors(option => {
    option.AddPolicy("allow", builder => {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});
/*
 * Üç farklı origin:
 * https://www.yemeksepeti.com
 * http://www.yemeksepeti.com
 * https://mutfak.yemeksepeti.com
 *https://www.yemeksepeti.com:1000
 * 
 *  https://www.yemeksepeti.com/iller
 *  https://www.yemeksepeti.com/pizza
 *  https://www.yemeksepeti.com/restoran
 */

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("allow");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();


app.Run();
