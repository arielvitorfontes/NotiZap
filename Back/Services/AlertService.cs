using Back.Data;
using Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Back.Service
{
    public class AlertService
    {
        private readonly AppDbContext _context;
        public AlertService(AppDbContext context)
        {
            _context = context;
        }
        
        public List<Alert> GetAlerts() => _context.Alerts.AsNoTracking().ToList();

        public Alert GetAlert(int idAlert)
        {
            var alert = _context.Alerts.AsNoTracking().FirstOrDefault(c => c.Id.Equals(idAlert));

            if (alert == null)
                throw new("Alerta não encontrado");

            return alert;
        }

        public void CreateAlert(Alert alertData)
        {
            _context.Alerts.Add(alertData);
            _context.SaveChanges();
        }

        public Alert UpdateAlert(int idAlert)
        {
            var alert = _context.Alerts.AsNoTracking().FirstOrDefault(c => c.Id.Equals(idAlert));

            if (alert == null)
                throw new("Usuário não encontrado");

            _context.Update(alert);
            _context.SaveChanges();

            return alert;
        }

        public void DeleteAlert(int idAlert)
        {
            var alert = _context.Alerts.AsNoTracking().FirstOrDefault(c => c.Id.Equals(idAlert));

            if (alert == null)
                throw new("Usuário não encontrado");

            _context.Update(alert);
            _context.SaveChanges();
        }
    }
}