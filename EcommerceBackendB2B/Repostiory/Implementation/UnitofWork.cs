using EcommerceBackendB2B.Data;
using EcommerceBackendB2B.Repostiory.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EcommerceBackendB2B.Repostiory.Implementation
{
    public class UnitofWork : IUnitofWork
    {
        private readonly DBContext _context;

        public UnitofWork(DBContext context)
        {
            _context = context;
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(_context);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
