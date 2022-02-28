using System.Text;
using Microsoft.OpenApi.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
   options=>
   {
      options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
      {
        ValidateIssuer = true,
        //ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer   = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
      };
   }
);

//builder.Services.AddSwaggerGen( swagger => 
//    swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "EMS", Version="v1"}) 
//);
builder.Services.AddSwaggerGen(swagger =>
            {
                swagger.IgnoreObsoleteActions();
                swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "EMS", Version = "v1" });
                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Add Bearer Token in Header"
                });
                swagger.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                    new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference  {
                                  Type = ReferenceType.SecurityScheme,
                                  Id =  "Bearer"
                              }
                          },
                    new string[] { }
                    }
                  }
                      );
            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(swagger => swagger.SwaggerEndpoint("/swagger/v1/swagger.json","NS.EMS.API v1"));
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
