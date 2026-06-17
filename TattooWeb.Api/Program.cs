using Microsoft.EntityFrameworkCore;
using TattooWeb.Application.UseCases.Artists.CreateArtist;
using TattooWeb.Application.UseCases.Artists.DeleteArtist;
using TattooWeb.Application.UseCases.Artists.GetAllArtists;
using TattooWeb.Application.UseCases.Artists.GetArtistById;
using TattooWeb.Application.UseCases.Artists.UpdateArtist;
using TattooWeb.Domain.Repositories;
using TattooWeb.Infrastructure.Data;
using TattooWeb.Infrastructure.Repositories;
using TattooWeb.Api.GraphQL.Queries;
using TattooWeb.Api.GraphQL.Mutations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddDbContext<TattooWebDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<ArtistQuery>()
    .AddMutationType<ArtistMutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

builder.Services.AddScoped<IArtistRepository, ArtistRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();

builder.Services.AddScoped<CreateArtistUseCase>();
builder.Services.AddScoped<GetAllArtistsUseCase>();
builder.Services.AddScoped<GetArtistByIdUseCase>();
builder.Services.AddScoped<UpdateArtistUseCase>();
builder.Services.AddScoped<DeleteArtistUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.MapGraphQL();

app.Run();
