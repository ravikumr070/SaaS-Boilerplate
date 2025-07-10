using Application.Common.Caching;
using Application.Common.Exceptions;
using Application.LoginAttempt;
using Application.MenuMaster;
using Domain.MenuMaster;
using Shared.Authorization;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Identity;

internal partial class UserService
{
    public async Task<List<LoginAttemptDto>> GetBuyIdLoginAttempt(string userId, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(userId);

        _ = user ?? throw new UnauthorizedException("Authentication Failed.");

        var loginAttempt = new List<LoginAttemptDto>();
        var data = await _db.LoginAttempts.Where(x => x.UserId == userId).OrderByDescending(x => x.DateTime).ToListAsync();
        loginAttempt = data.Adapt<List<LoginAttemptDto>>();
        return loginAttempt.Distinct().ToList();
    }

}