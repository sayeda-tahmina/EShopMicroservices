var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Discount_Grpc>("discount-grpc");

builder.AddProject<Projects.Ordering_API>("ordering-api");

builder.Build().Run();
