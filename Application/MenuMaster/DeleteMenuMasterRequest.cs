using Domain.MenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MenuMaster;
public class DeleteMenuMasterRequest : IRequest<MenuMasterModel>
{
    public int Id { get; set; }

    public DeleteMenuMasterRequest(int id) => Id = id;
}
public class DeleteMenuMasterRequestHandler : IRequestHandler<DeleteMenuMasterRequest, MenuMasterModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<MenuMasterModel> _MenuMasterRepo;

    private readonly IStringLocalizer<DeleteMenuMasterRequestHandler> _localizer;

    public DeleteMenuMasterRequestHandler(IRepositoryWithEvents<MenuMasterModel> MenuMasterRepo, IStringLocalizer<DeleteMenuMasterRequestHandler> localizer) =>
        (_MenuMasterRepo, _localizer) = (MenuMasterRepo, localizer);

    public async Task<MenuMasterModel> Handle(DeleteMenuMasterRequest request, CancellationToken cancellationToken)
    {

        var MenuMaster = await _MenuMasterRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = MenuMaster ?? throw new NotFoundException(_localizer["MenuMaster notfound"]);

        await _MenuMasterRepo.DeleteAsync(MenuMaster, cancellationToken);

        return MenuMaster;
    }
}
