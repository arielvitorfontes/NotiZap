using Back.Data;

namespace Back.Service
{
    public class LoginService
    {
        private readonly AppDbContext _context;
        public LoginService(AppDbContext context)
        {
            _context = context;
        }
    }
}