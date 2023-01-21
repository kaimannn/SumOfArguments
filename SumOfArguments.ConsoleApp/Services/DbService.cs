using Microsoft.EntityFrameworkCore;
using SumOfArguments.ConsoleApp.DB;
using SumOfArguments.ConsoleApp.Models;

namespace SumOfArguments.ConsoleApp.Services
{
    public interface IDbService
    {
        Task<List<SumModel>> GetAllSumsAsync();
        Task<bool> SaveAsync(SumModel sumModel);
    }

    public class DbService : IDbService, IDisposable
    {
        private bool disposed = false;
        private readonly SumOfArgumentsContext _db = null;

        public DbService()
        {
            _db = new SumOfArgumentsContext();
            _db.Database.EnsureCreated();
        }

        public async Task<List<SumModel>> GetAllSumsAsync() =>
            _ = await _db.Sums.Select(s => new SumModel { A = s.A, B = s.B, Result = s.Result, Type = s.Type }).ToListAsync();

        public async Task<bool> SaveAsync(SumModel sumModel)
        {
            _db.Sums.Add(new Sums() { A = sumModel.A, B = sumModel.B, Result = sumModel.Result, Type = sumModel.Type, CreatedOn = DateTime.Now });

            return (await _db.SaveChangesAsync()) > 0;
        }

        public void Dispose()
        {
            if (disposed)
                return;

            _db?.Dispose();

            disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
