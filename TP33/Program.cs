using System.Data;
using System.Data.SQLite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

SQLiteConnection sqlite_conn = new SQLiteConnection("DataSource=database.db"); ;
sqlite_conn.Open(); 
SQLiteCommand sqlite_cmd;
string query = "SELECT * FROM personal_info";
sqlite_cmd = sqlite_conn.CreateCommand();
sqlite_cmd.CommandText = query;
sqlite_cmd.ExecuteNonQuery();
SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
while (sqlite_datareader.Read())
{
    int id = sqlite_datareader.GetInt16(0);
    string first_name = sqlite_datareader.GetString(1);
    string last_name = sqlite_datareader.GetString(2);
    string email = sqlite_datareader.GetString(3);
    string date = sqlite_datareader.GetString(4);

    Console.WriteLine(id+first_name+last_name+email+date);
}

sqlite_conn.Close();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
