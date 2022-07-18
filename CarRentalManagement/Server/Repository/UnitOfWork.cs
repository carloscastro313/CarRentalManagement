using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make>? _makes;
        private IGenericRepository<Model>? _models;
        private IGenericRepository<Colour>? _colours;
        private IGenericRepository<Booking>? _booking;
        private IGenericRepository<Customer>? _customers;
        private IGenericRepository<Vehicle>? _vehicles;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Model> Models => _models ??= new GenericRepository<Model>(_context);
        public IGenericRepository<Colour> Colours => _colours ??= new GenericRepository<Colour>(_context);
        public IGenericRepository<Booking> Bookings => _booking ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Vehicle> Vehicles => _vehicles ??= new GenericRepository<Vehicle>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity?.Name;

            var entries = _context.ChangeTracker.Entries().Where(q => q.State == EntityState.Modified || q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModal)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModal)entry.Entity).UpdatedBy = user ?? "System";

                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModal)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModal)entry.Entity).CreatedBy = user ?? "System";
                }

            }

            await _context.SaveChangesAsync();
        }
    }
}
