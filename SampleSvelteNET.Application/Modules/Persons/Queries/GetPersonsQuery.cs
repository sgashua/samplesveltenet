using MediatR;
using SampleSvelteNET.Domain.Entities;

namespace SampleSvelteNET.Application.Modules.Users.Queries
{
    public record GetPersonsQuery() : IRequest<List<Person>?>;
    public class GetPersonsQueryHandler : IRequestHandler<GetPersonsQuery, List<Person>?>
    {
        //private readonly YourDBContext _context;
        //public GetPersonsQueryHandler(YourDBContext context)
        //{
        //    _context = context;
        //}
        public async Task<List<Person>?> Handle(GetPersonsQuery request, CancellationToken cancellation)
        {
            //var result = _context.YourTable();
            return new List<Person>()
            {
                new Person() { PersonID = 1, Name = "Tester A", Age = 20 },
                new Person() { PersonID = 2, Name = "Tester B", Age = 76 },
                new Person() { PersonID = 3, Name = "Tester C", Age = 12 },
                new Person() { PersonID = 4, Name = "Tester D", Age = 38 },
                new Person() { PersonID = 5, Name = "Tester E", Age = 30 }
            };
        }
    }
}
