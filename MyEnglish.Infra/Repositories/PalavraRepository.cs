using Microsoft.EntityFrameworkCore;
using MyEnglish.Domain;
using MyEnglish.Infra.Context;
using MyEnglish.Infra.Interfaces;

namespace MyEnglish.Infra.Repositories;

public class PalavraRepository : IPalavraRepository
{
    private readonly MyEnglishContext _context;

    public PalavraRepository(MyEnglishContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Palavra>> GetAll()
    {
        return await _context.Palavras.ToListAsync();
    }

    public async Task<Palavra> GetById(Guid id)
    {
        return await _context.Palavras.FirstOrDefaultAsync(x => x.Id.Equals(id));
    }

    public async Task<Palavra> Create(Palavra palavra)
    {
        _context.Palavras.Add(palavra);
        await _context.SaveChangesAsync();
        return palavra;

    }

    public async Task<Palavra> Update(Palavra palavra)
    {
        var oldEntity = await GetById(palavra.Id);

        if (oldEntity == null)
            return null;

        _context.Entry(oldEntity).CurrentValues.SetValues(palavra);
        await _context.SaveChangesAsync();

        return palavra;
    }

    public async Task<bool> Delete(Guid id)
    {
        var entity = await GetById(id);

        if (entity == null)
            return false;

        _context.Remove(entity);
        await _context.SaveChangesAsync();

        return true;
    }
}