using MyEnglish.Domain;

namespace MyEnglish.Infra.Interfaces;

public interface IPalavraRepository
{
    public Task<IEnumerable<Palavra>> GetAll();
    public Task<Palavra> GetById(Guid id);
    public Task<Palavra> Create(Palavra palavra);
    public Task<Palavra> Update(Palavra palavra);
    public Task<bool> Delete(Guid id);
}
