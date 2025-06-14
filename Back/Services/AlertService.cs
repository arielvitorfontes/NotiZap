using Back.Data;

namespace Back.Service
{
    public class AlertService
    {
        private readonly AppDbContext _context;
        public AlertService(AppDbContext context)
        {
            _context = context;
        }
    }
}