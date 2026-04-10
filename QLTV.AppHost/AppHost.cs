var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.QLTV_Frontend>("qltv-frontend");
builder.AddProject<Projects.QLTV_Frontend>("webfrontend");
builder.Build().Run();
