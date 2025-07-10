using Domain.MenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MenuMaster;
public class GetMenuMasterRequest : IRequest<MenuMasterDto>
{
    public int Id { get; set; }
    public GetMenuMasterRequest(int id) => Id = id;
}
public class MenuMasterByIdSpec : Specification<MenuMasterModel, MenuMasterDto>, ISingleResultSpecification
{
    public MenuMasterByIdSpec(int id) =>
        Query.Where(p => p.Id == id);
}

public class GetMenuMasterRequestHandler : IRequestHandler<GetMenuMasterRequest, MenuMasterDto>
{
    private readonly IRepository<MenuMasterModel> _repository;
    private readonly IStringLocalizer<GetMenuMasterRequestHandler> _localizer;

    public GetMenuMasterRequestHandler(IRepository<MenuMasterModel> repository, IStringLocalizer<GetMenuMasterRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<MenuMasterDto> Handle(GetMenuMasterRequest request, CancellationToken cancellationToken) =>
        await _repository.GetBySpecAsync(
            (ISpecification<MenuMasterModel, MenuMasterDto>)new MenuMasterByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["MenuMaster notfound"], request.Id));
}

