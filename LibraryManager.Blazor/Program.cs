using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LibraryManager.Data;
using LibraryManager.Services;
using LibraryManager.Interfaces;
using Microsoft.EntityFrameworkCore;
using LibraryManager.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<BookRepository>();
builder.Services.AddScoped<MemberRepository>();
builder.Services.AddScoped<BorrowRepository>();
builder.Services.AddScoped<BookHistoryRepository>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddScoped<IBorrowService, BorrowService>();
builder.Services.AddScoped<IBookHistoryService, BookHistoryService>();

await builder.Build().RunAsync();
