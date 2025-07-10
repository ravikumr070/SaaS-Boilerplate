using Application.Auditing;
using Application.LoginAttempt;
using Infrastructure.Persistence.Context;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.LoginAttempt;

public class LoginAttemptService : ILoginAttemptService
{
    private readonly ApplicationDbContext _context;

    public LoginAttemptService(ApplicationDbContext context) => _context = context;

    public async Task<List<LoginAttemptDto>> GetLoginAttemptAsync(string userId)
    {
        var trails = await _context.LoginAttempts
            .Where(a => a.UserId == userId)
            .OrderByDescending(a => a.DateTime)
            .Take(5000)
            .ToListAsync();

        return trails.Adapt<List<LoginAttemptDto>>();
    }
    public async Task<List<LoginAttemptDto>> GetLoginAttemptAsync()
    {
        var trails = await _context.LoginAttempts
            .OrderByDescending(a => a.DateTime)
            .ToListAsync();

        return trails.Adapt<List<LoginAttemptDto>>();
    }
    public async Task<string> AddLoginAttemptAsync(LoginAttemptDto request)
    {
        var dataModel = request.Adapt<LoginAttempt>();
        _ = await _context.LoginAttempts
            .AddAsync(dataModel);
        return _context.SaveChanges() > 0 ? "Success" : "Failed";

    }
}