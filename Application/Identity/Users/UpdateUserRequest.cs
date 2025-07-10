namespace Application.Identity.Users;

public class UpdateUserRequest //: AuditableEntity, IAggregateRoot
{
    public string Id { get; set; } = default!;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public FileUploadRequest? Image { get; set; }
    public bool DeleteCurrentImage { get; set; } = false;
}

//public class UpdateUserRequestRequestHandler : IRequestHandler<UpdateUserRequest>
//{
//    // Add Domain Events automatically by using IRepositoryWithEvents
//    private readonly IRepositoryWithEvents<UpdateUserRequest> _repository;
  




//    public UpdateUserRequestRequestHandler(IRepositoryWithEvents<UpdateUserRequest> repository, IRepositoryWithEvents<UpdateUserRequest> repos) => (_repository) = (repository);



//    public async Task<UpdateUserRequest> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
//    {
//        var tblUpdateProfile = new UpdateUserRequest(

//    request.Id,

//    request.FirstName,
//    request.LastName,
//        request.PhoneNumber,
//    request.Email,
//    request.Image,
//    request.DeleteCurrentImage
//);


//        var output = await _repository.UpdateAsync(tblUpdateProfile, cancellationToken);
        
//        return output;


//    }

//}
