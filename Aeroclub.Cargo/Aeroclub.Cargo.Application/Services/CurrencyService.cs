using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class CurrencyService :BaseService, ICurrencyService
    {
        
        public CurrencyService(IUnitOfWork unitOfWork, IMapper imapper):
            base(unitOfWork,imapper)
        {
           
        }
        public async Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync()
        {
            var list = await _unitOfWork.Repository<Currency>().GetListAsync();
            return _mapper.Map<IReadOnlyList<BaseSelectListModel>>(list);
        }
    }
}
