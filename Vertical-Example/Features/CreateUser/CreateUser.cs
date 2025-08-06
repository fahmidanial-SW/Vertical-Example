using MediatR;
using Vertical_Example.Data;

namespace Vertical_Example.Features.CreateUser
{
    public class CreateUser
    {
        public record Command(string Name, string Email, int age) : IRequest<Response>;

        public record Response(string Name, string Email, string Age, DateTime CreatedAt, DateTime UpdateAt) : IRequest<int>;

        public class Handler : IRequestHandler<Command, Response>
        {
            private readonly UserDBContext _context;
            public Handler(UserDBContext context)
            {
                _context = context;
            }
            public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = new Entity.User
                {
                    Name = request.Name,
                    Email = request.Email,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync(cancellationToken);
                return new Response(user.Name, user.Email, request.age.ToString(), user.CreatedAt, user.UpdatedAt);
            }
        }
    }
}
