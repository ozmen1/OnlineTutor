using OnlineTutor.Business.Abstract;
using OnlineTutor.Business.Concrete;
using OnlineTutor.Data.Abstract;
using OnlineTutor.Data.Concrete;
using OnlineTutor.Data.Concrete.EfCore.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<OnlineTutorContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IShowCardService, ShowCardManager>();
builder.Services.AddScoped<ISubjectService, SubjectManager>();

var app = builder.Build();

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
    name: "showCardDetails",
    pattern: "ilanlar/{showCardUrl}",
    defaults: new { controller = "ShowCard", action = "ShowCardDetails" }
    );

app.MapControllerRoute(
    name: "ListShowCardsBySubject",
    pattern: "ilanlar/{subjectName}",
    defaults: new { controller = "ShowCard", action = "ListShowCardsBySubject" }
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
