using Carter;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using SampleSvelteNET.Application.Modules.Users.Queries;

namespace SampleSvelteNET.Application.Modules.Persons.Endpoints
{
    public class PersonEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/api/Person");
            group.MapGet("/", Get);
        }
        [AllowAnonymous]
        public async Task<IResult> Get(IMediator mediator)
        {
            var result = await mediator.Send(new GetPersonsQuery());
            return Results.Ok(new
            {
                success = true,
                result = result
            });
        }
    }
}
