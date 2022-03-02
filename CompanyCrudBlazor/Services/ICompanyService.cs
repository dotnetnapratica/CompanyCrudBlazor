using CompanyCrudBlazor.Models;

namespace CompanyCrudBlazor.Services
{
    public interface ICompanyService
    {
        Task Add(Company company);

        Task Update(Company company);

        Task Delete(Company company);

        Task<Company> GetBy(Guid id);

        Task<List<Company>> FindAll();
    }
}
