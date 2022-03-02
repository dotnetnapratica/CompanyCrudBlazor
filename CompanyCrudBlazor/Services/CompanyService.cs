using CompanyCrudBlazor.Data;
using CompanyCrudBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyCrudBlazor.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly AppDbContext dbContext;
        public CompanyService(AppDbContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task Add(Company company)
        {
            await dbContext.AddAsync(company);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(Company company)
        {
            dbContext.Update(company);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Company company)
        {
            dbContext.Remove(company);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Company> GetBy(Guid id)
        {
            var company = await dbContext.Companies.FirstOrDefaultAsync(c => c.Id == id);

            return company;
        }

        public async Task<List<Company>> FindAll()
        {
            var companies = await dbContext.Companies.ToListAsync();

            return companies;
        }
    }
}
