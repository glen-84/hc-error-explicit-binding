using hc_error_explicit_binding.Misc;
using hc_error_explicit_binding.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .InitializeOnStartup()
    //.ModifyOptions(options => options.DefaultBindingBehavior = BindingBehavior.Explicit)
    .ModifyOptions(options => options.StripLeadingIFromInterface = true)
    .ModifyRequestOptions(
        options => options.IncludeExceptionDetails = builder.Environment.IsDevelopment())
    .AddErrorInterfaceType<IDomainError>()
    .AddMutationConventions()
    .AddMutationErrorConfiguration<CustomMutationErrorConfiguration>()
    .AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
