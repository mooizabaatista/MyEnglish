using MyEnglish.Application.DTOs;
using MyEnglish.Domain;

namespace MyEnglish.Application.Interfaces;

public interface IPalavraService
{
    public Task<IEnumerable<PalavraDto>> GetAll();
    public Task<PalavraDto> GetById(Guid id);
    public Task<PalavraDtoFlat> Create(PalavraDtoFlat palavra);
    public Task<PalavraDtoFlat> Update(PalavraDtoFlat palavra);
    public Task<bool> Delete(Guid id);
}
