using Microsoft.EntityFrameworkCore;
using TattooWeb.Application.UseCases.Services.CreateService;
using TattooWeb.Application.UseCases.Services.DeleteService;
using TattooWeb.Application.UseCases.Services.GetAllServices;
using TattooWeb.Application.UseCases.Services.UpdateService;
using TattooWeb.Application.UseCases.Artists.CreateArtist;
using TattooWeb.Application.UseCases.Artists.DeleteArtist;
using TattooWeb.Application.UseCases.Artists.GetAllArtists;
using TattooWeb.Application.UseCases.Artists.GetArtistById;
using TattooWeb.Application.UseCases.Artists.UpdateArtist;
using TattooWeb.Application.UseCases.Clients.CreateClient;
using TattooWeb.Application.UseCases.Clients.DeleteClient;
using TattooWeb.Application.UseCases.Clients.GetAllClients;
using TattooWeb.Application.UseCases.Clients.UpdateClient;
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
    .AddQueryType(d => d.Name("Query"))
    .AddTypeExtension<ArtistQuery>()
    .AddTypeExtension<ClientQuery>()
    .AddTypeExtension<ServiceQuery>()
    .AddMutationType(d => d.Name("Mutation"))
    .AddTypeExtension<ArtistMutation>()
    .AddTypeExtension<ClientMutation>()
    .AddTypeExtension<ServiceMutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

builder.Services.AddScoped<IArtistRepository, ArtistRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

builder.Services.AddScoped<CreateArtistUseCase>();
builder.Services.AddScoped<GetAllArtistsUseCase>();
builder.Services.AddScoped<GetArtistByIdUseCase>();
builder.Services.AddScoped<UpdateArtistUseCase>();
builder.Services.AddScoped<DeleteArtistUseCase>();

builder.Services.AddScoped<CreateClientUseCase>();
builder.Services.AddScoped<GetAllClientsUseCase>();
builder.Services.AddScoped<UpdateClientUseCase>();
builder.Services.AddScoped<DeleteClientUseCase>();

builder.Services.AddScoped<CreateServiceUseCase>();
builder.Services.AddScoped<GetAllServicesUseCase>();
builder.Services.AddScoped<UpdateServiceUseCase>();
builder.Services.AddScoped<DeleteServiceUseCase>();

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
