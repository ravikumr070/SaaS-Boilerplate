using Domain.MenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MenuMaster;
public class UpdateMenuMasterRequest : IRequest<MenuMasterModel>
{
    public int Id { get; set; }
    public UpdateMenuMasterRequest(int id) => Id = id;
    public int? ParentId { get; set; }
    public int Sequence { get; set; }
    public string MenuText { get; set; }
    public string IconClass { get; set; }
    public string PageUrl { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public string PageType { get; set; }
}
public class UpdateMenuMasterRequestValidator : CustomValidator<UpdateMenuMasterRequest>
{
    public UpdateMenuMasterRequestValidator(IRepository<MenuMasterModel> repository, IStringLocalizer<UpdateMenuMasterRequestValidator> localizer) { }

}
public class UpdateMenuMasterRequestHandler : IRequestHandler<UpdateMenuMasterRequest, MenuMasterModel>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<MenuMasterModel> _repository;
    private readonly IStringLocalizer<UpdateMenuMasterRequestHandler> _localizer;


    public UpdateMenuMasterRequestHandler(IRepositoryWithEvents<MenuMasterModel> repository, IStringLocalizer<UpdateMenuMasterRequestHandler> localizer) =>
        (_repository, _localizer) = (repository, localizer);
    public async Task<MenuMasterModel> Handle(UpdateMenuMasterRequest request, CancellationToken cancellationToken)
    {
        var MenuMaster = await _repository.GetByIdAsync(request.Id, cancellationToken);
        _ = MenuMaster ?? throw new NotFoundException(string.Format(_localizer["MenuMaster notfound"], request.Id));
        MenuMaster.Update(
            request.ParentId,
        request.Sequence,
        request.MenuText,
        request.IconClass,
        request.PageUrl,
         request.IsActive,
        request.IsDeleted,
        request.PageType
        
            );
        await _repository.UpdateAsync(MenuMaster, cancellationToken);
        return MenuMaster;
    }
}

