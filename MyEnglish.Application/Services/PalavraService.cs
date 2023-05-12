using AutoMapper;
using MyEnglish.Application.DTOs;
using MyEnglish.Application.Interfaces;
using MyEnglish.Domain;
using MyEnglish.Infra.Interfaces;

namespace MyEnglish.Application.Services;

public class PalavraService : IPalavraService
{
    private readonly IPalavraRepository _palavraRepository;
    private readonly IMapper _mapper;

    public PalavraService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public PalavraService(IPalavraRepository palavraRepository)
    {
        _palavraRepository = palavraRepository;
    }

    public async Task<IEnumerable<PalavraDto>> GetAll()
    {
        var palavrasEntity = await _palavraRepository.GetAll();
        var palavrasDto = _mapper.Map<IEnumerable<PalavraDto>>(palavrasEntity);

        return palavrasDto;
    }

    public async Task<PalavraDto> GetById(Guid id)
    {
        var palavraEntity = await _palavraRepository.GetById(id);
        var palavraDto = _mapper.Map<PalavraDto>(palavraEntity);

        return palavraDto;
    }

    public async Task<PalavraDtoFlat> Create(PalavraDtoFlat palavra)
    {
        var palavraEntity = _mapper.Map<Palavra>(palavra);
        await _palavraRepository.Create(palavraEntity);

        return palavra;
    }

    public async Task<PalavraDtoFlat> Update(PalavraDtoFlat palavra)
    {
        var palavraEntity = _mapper.Map<Palavra>(palavra);
        await _palavraRepository.Update(palavraEntity);

        return palavra;
    }

    public async Task<bool> Delete(Guid id)
    {
        return await _palavraRepository.Delete(id);
    }
}