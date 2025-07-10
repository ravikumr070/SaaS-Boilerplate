using Domain.MenuMaster;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MenuMaster;
public class GetAllMenuMasterRequest : IRequest<List<AllMenuMasterDto>>
{
}
public class AllMenuMasterByIdSpec : Specification<MenuMasterModel, AllMenuMasterDto>, ISingleResultSpecification
{
    public AllMenuMasterByIdSpec() =>
        Query
        .Include(x => x.Children)
        .ThenInclude(x => x.Children)
        .ThenInclude(x => x.Children)
        .ThenInclude(x => x.Children)
        .Where(p => !p.IsDeleted);
}
public class GetAllMenuMasterRequestHandler : IRequestHandler<GetAllMenuMasterRequest, List<AllMenuMasterDto>>
{
    private readonly IRepository<MenuMasterModel> _repository;
    private readonly IStringLocalizer<GetMenuMasterRequestHandler> _localizer;

    public GetAllMenuMasterRequestHandler(IRepository<MenuMasterModel> repository, IStringLocalizer<GetMenuMasterRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<List<AllMenuMasterDto>> Handle(GetAllMenuMasterRequest request, CancellationToken cancellationToken)
    {
        //await _repository.ListAsync(
        //    (ISpecification<MenuMasterModel, AllMenuMasterDto>)new AllMenuMasterByIdSpec(), cancellationToken)
        //?? throw new NotFoundException(string.Format(_localizer["MenuMaster notfound"], "Row is not found."));
        var data = await _repository.ListAsync(cancellationToken).ConfigureAwait(false);
        return data.Adapt<List<AllMenuMasterDto>>();
    }
}

