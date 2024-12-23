using MOEN_ERP.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using DNTCaptcha.Core;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Services.Repository;
using AspNetCore.Unobtrusive.Ajax;
using OfficeOpenXml;
using Microsoft.AspNetCore.Http.Features;
using MOEN_ERP.Components;
using DevExpress.XtraCharts;
using DevExpress.Office.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<SettingsModel>(builder.Configuration.GetSection("Settings"));

builder.Services.AddUnobtrusiveAjax();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
//builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

// Add service Controller
builder.Services.AddScoped<IAccount, Account>();
//--Repository

builder.Services.AddHttpClient<ITokenService, TokenService>();
builder.Services.AddScoped<IMasterService, MasterService>();
builder.Services.AddScoped<IDropdowns, Dropdowns>();
builder.Services.AddScoped<IDataService, DataService>();
builder.Services.AddScoped<IRawDataService, RawDataService>();
builder.Services.AddScoped<IAttachFileService, AttachFileService>();
builder.Services.AddScoped<IAuthenService, AuthenService>();
builder.Services.AddScoped<IBudgetService, BudgetService>();

builder.Services.AddScoped<IMeetingDisplayService, MeetingDisplayService>();
builder.Services.AddScoped<IVehicleDisplayService, VehicleDisplayService>();
builder.Services.AddScoped<IVehicleNotificationsService, VehicleNotificationsService>();
builder.Services.AddScoped<IMeetingNotificationsService, MeetingNotificationsService>();
builder.Services.AddScoped<ISystemService, SystemService>();

//--Repository End.

builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.Configure<FormOptions>(options =>
{
    // Set the limit to 50 MB
    options.MultipartBodyLengthLimit = 52428800;
});



builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
    option =>
    {
        option.Cookie.Name = "DTNBOOKINGCookieAuth";
        option.Cookie.IsEssential = true;
        option.LoginPath = "/Authen/SignIn";
        option.LogoutPath = "/Authen/SignOut";
        option.Cookie.HttpOnly = true;
        option.ExpireTimeSpan = TimeSpan.FromHours(12); // Cookie expiration time
        option.SlidingExpiration = true;
    }
    );


builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(12);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddDNTCaptcha(option =>
{

    option.UseCookieStorageProvider(SameSiteMode.Strict)
    .AbsoluteExpiration(minutes: 7)
    .ShowThousandsSeparators(false)
    .WithNoise(pixelsDensity: 25, linesCount: 3)
    .WithEncryptionKey("DTN-BOOKIGN!@#$%^&*()_+")
    .InputNames(
          //new DNTCaptchaComponent
          //{
          //    CaptchaHiddenInputName = "DNTCaptchaText",
          //    CaptchaHiddenTokenName = "DNTCaptchaToken",
          //    CaptchaInputName = "DNTCaptchaInputText"
          //})
          new DNTCaptchaComponent
          {
              CaptchaHiddenInputName = "DNT_CaptchaText",
              CaptchaHiddenTokenName = "DNT_CaptchaToken",
              CaptchaInputName = "DNT_CaptchaInputText"
          })
    .Identifier("dnt_Captcha");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseStatusCodePagesWithReExecute("/Error/{0}");
    //app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseStatusCodePagesWithReExecute("/Error/{0}");
}


////-- Set Format Date --//
var culture = CultureInfo.CreateSpecificCulture("th-TH");
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;


ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Or LicenseContext.Commercial if you have a commercial license



//var dateformat = new DateTimeFormatInfo
//{
//    ShortDatePattern = "dd/MM/yyyy",
//    LongDatePattern = "dd/MM/yyyy hh:mm:ss tt"
//};
//culture.DateTimeFormat = dateformat;

//var supportedCultures = new[]
//{
//    culture
//};

//app.UseRequestLocalization(new RequestLocalizationOptions
//{
//    DefaultRequestCulture = new RequestCulture(culture),
//    SupportedCultures = supportedCultures,
//    SupportedUICultures = supportedCultures
//});
//-- Set Format Date End. --//



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();
app.UseHttpContext();

app.UseUnobtrusiveAjax();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Authen}/{action=SignIn}/{id?}");

//Logz.AddLog("Run Application");
app.Run();
