using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.UnitQMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class UnitService : BaseService, IUnitService
    {
        public UnitService(IUnitOfWork unitOfWork,IMapper mapper)
            :base(unitOfWork,mapper)
        {

        }
        public async Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync(UnitQM query)
        {
            var spec = new UnitSpecification(query);

            var list = await _unitOfWork.Repository<Unit>().GetListWithSpecAsync(spec);

            return _mapper.Map<IReadOnlyList<BaseSelectListModel>>(list);
        }

        public async Task<IReadOnlyList<UnitDto>> GetListAsync()
        {
            var list = await _unitOfWork.Repository<Unit>().GetListAsync();
            return _mapper.Map<IReadOnlyList<UnitDto>>(list);
        }
    }
}
