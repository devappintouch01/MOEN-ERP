using MOEN_ERP.API.Services;
using MOEN_ERP.API.Services.Repository;
using MOEN_ERP.DAL.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MOENDBContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MOENDBContext")));
builder.Services.AddDbContext<MOENDOCSContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MOENDOCSContext")));


// Add services to the container.
builder.Services.AddScoped<IMasterService, MOEN_ERP.API.Services.Repository.MasterService>();
builder.Services.AddScoped<IDataService, MOEN_ERP.API.Services.Repository.DataService>();
builder.Services.AddScoped<IRawDataService, MOEN_ERP.API.Services.Repository.RawDataService>();
builder.Services.AddScoped<IManagementData, MOEN_ERP.API.Services.Repository.ManagementData>();
builder.Services.AddScoped<IAuthenService, MOEN_ERP.API.Services.Repository.AuthenService>();
builder.Services.AddScoped<IBudgetService, MOEN_ERP.API.Services.Repository.BudgetService>();

builder.Services.AddScoped<IUtilityServices, MOEN_ERP.API.Services.Repository.UtilityServices>();
builder.Services.AddScoped<IMeetingDisplayService, MOEN_ERP.API.Services.Repository.MeetingDisplayService>();
builder.Services.AddScoped<IVehicleDisplayService, MOEN_ERP.API.Services.Repository.VehicleDisplayService>();
builder.Services.AddScoped<IVehicleNotificationsService, MOEN_ERP.API.Services.Repository.VehicleNotificationsService>();
builder.Services.AddScoped<IMeetingNotificationsService, MOEN_ERP.API.Services.Repository.MeetingNotificationsService>();
builder.Services.AddScoped<IExpensesConsiderService, MOEN_ERP.API.Services.Repository.ExpensesConsiderService>();
builder.Services.AddScoped<IExpensesRequestService, MOEN_ERP.API.Services.Repository.ExpensesRequestService>();
builder.Services.AddScoped<IMailService, MOEN_ERP.API.Services.Repository.MailService>();
builder.Services.AddScoped<IMobileNotificationService, MOEN_ERP.API.Services.Repository.MobileNotificationService>();
builder.Services.AddScoped<ILineNotifyService, MOEN_ERP.API.Services.Repository.LineNotifyService>();
// Register FlowService
//builder.Services.AddScoped<FlowService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddAuthentication(authOptions =>
{
    authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(jwtOptions =>
{
    var key = builder.Configuration.GetValue<string>("JwtConfig:Key");
    var keyBytes = Encoding.ASCII.GetBytes(key);
    //jwtOptions.SaveToken = true;
    jwtOptions.SaveToken = false;
    jwtOptions.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
        ValidateLifetime= true,
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew= TimeSpan.Zero,
    };
});

builder.Services.AddSingleton(typeof(IJwtTokenManager), typeof(JwtTokenManager));
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.Configure<LineNotifyMeetingRoomGroup>(builder.Configuration.GetSection("LineNotifyMeetingRoomGroup"));
builder.Services.Configure<LineNotifyCateringGroup>(builder.Configuration.GetSection("LineNotifyCateringGroup"));
builder.Services.Configure<LineNotifyAudioVisualGroup>(builder.Configuration.GetSection("LineNotifyAudioVisualGroup"));
builder.Services.Configure<LineNotifyConferenceGroup>(builder.Configuration.GetSection("LineNotifyConferenceGroup"));
builder.Services.Configure<LineNotifyVehicleGroup>(builder.Configuration.GetSection("LineNotifyVehicleGroup"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else {
    app.UseSwagger();
    app.UseSwaggerUI();
}


////-- Set Format Date --//
var culture = CultureInfo.CreateSpecificCulture("th-TH");
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
