using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class CountryService :BaseService, ICountryService
    {
        public CountryService(IUnitOfWork unitOfWork, IMapper mapper):
            base(unitOfWork,mapper)
        {
        
        }

        public async Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync()
        {
            var list = await _unitOfWork.Repository<Country>().GetListAsync();
            return _mapper.Map<IReadOnlyList<BaseSelectListModel>>(list);
        }
        
        public async Task<CountryDto> GetAsync(Guid id)
        {
            var entity = await _unitOfWork.Repository<Country>().GetByIdAsync(id);
            return _mapper.Map<CountryDto>(entity);
        }
    }
}