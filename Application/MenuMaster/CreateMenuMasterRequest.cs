using Domain.MenuMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MenuMaster;
public class CreateMenuMasterRequest : IRequest<MenuMasterModel>
{
    public int Id { get;  set; }
    public int? ParentId { get;  set; }
    public int Sequence { get;  set; }
    public string MenuText { get;  set; }
    public string IconClass { get;  set; }
    public string PageUrl { get;  set; }
    public bool IsActive { get;  set; }
    public bool IsDeleted { get;  set; }
    public string PageType { get; set; }


}
public class CreateTblMenuMasterRequestValidator : CustomValidator<CreateMenuMasterRequest>
{
    public CreateTblMenuMasterRequestValidator(IReadRepository<MenuMasterModel> repository, IStringLocalizer<CreateTblMenuMasterRequestValidator> localizer) { }
}
public class CreateMenuMasterRequestHandler : IRequestHandler<CreateMenuMasterRequest, MenuMasterModel>
{
    private readonly IRepositoryWithEvents<MenuMasterModel> _repository;

    public CreateMenuMasterRequestHandler(IRepositoryWithEvents<MenuMasterModel> repository) => _repository = repository;
    public async Task<MenuMasterModel> Handle(CreateMenuMasterRequest request, CancellationToken cancellationToken)
    {
        var MenuMaster = new MenuMasterModel(
        request.Id,
        request.ParentId,
        request.Sequence,
        request.MenuText,
        request.IconClass,
        request.PageUrl,
        request.IsActive,
        request.IsDeleted,
        request.PageType
        );
        var ouptput = await _repository.AddAsync(MenuMaster, cancellationToken);
        return ouptput;

    }

}

