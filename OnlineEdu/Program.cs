using Microsoft.EntityFrameworkCore;
using OnlineEdu.Data;
using System.Threading.Channels;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<OnlineEdu.Data.CoursePortalDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IEnrollmentRepository, Enrollmentrepository>();
builder.Services.AddScoped<ISubmissionRepo, SubmissionRepo>();
builder.Services.AddScoped<IAssessmentrepository, Assessmentrepository>();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();