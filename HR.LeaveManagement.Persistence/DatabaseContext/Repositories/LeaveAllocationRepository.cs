using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.DatabaseContext.Repositories;

public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{
    public LeaveAllocationRepository(HrDatabaseContext context) : base(context)
    {
    }

    public async Task AddAllocations(List<LeaveAllocation> allocations)
    {
        await _context.AddRangeAsync(allocations);
        await _context.SaveChangesAsync();
    }

    public Task<bool> AllocationExists(string userId, int leaveTypeId, int period)
    {
        return _context.LeaveAllocations
            .AnyAsync(p => p.EmployeeId == userId
            && p.LeaveTypeId == leaveTypeId
            && p.Period == period);
    }

    public async Task<IReadOnlyList<LeaveAllocation>> GetLeaveAllocationsWithDetailsAsync()
    {
        var leaveAllocations = await _context.LeaveAllocations
            .Include(p => p.LeaveType)
            .AsNoTracking()
            .ToListAsync();
        return leaveAllocations;
    }

    public async Task<IReadOnlyList<LeaveAllocation>> GetLeaveAllocationsWithDetailsAsync(string userId)
    {
        var leaveAllocations = await _context.LeaveAllocations
            .Where(p => p.EmployeeId == userId)
            .Include(p => p.LeaveType)
            .AsNoTracking()
            .ToListAsync();
        return leaveAllocations;
    }

    public async Task<LeaveAllocation> GetLeaveAllocationWithDetailsAsync(int id)
    {
        var leaveAllocation = await _context.LeaveAllocations
            .Include(p => p.LeaveType)
            .AsNoTracking()
            .FirstOrDefaultAsync(p=> p.Id == id);
        return leaveAllocation;
    }

    public async Task<LeaveAllocation> GetUserAllAllocations(string userId, int leaveTypeId)
    {
        var leaveAllocation = await _context.LeaveAllocations
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.EmployeeId == userId && p.LeaveTypeId == leaveTypeId);
        return leaveAllocation;
    }
}