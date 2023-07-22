using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.DatabaseContext.Repositories;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{
    public LeaveRequestRepository(HrDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<LeaveRequest>> GetLeaveRequestsWithDetailsAsync()
    {
        var leaveRequests = await _context.LeaveRequests
            .Include(p=>p.LeaveType)
            .ToListAsync();
        return leaveRequests;
    }

    public async Task<IReadOnlyList<LeaveRequest>> GetLeaveRequestsWithDetailsAsync(string userId)
    {
        var leaveRequests = await _context.LeaveRequests
            .Where(p=>p.RequestingEmployeeId == userId)
            .Include(p => p.LeaveType)
            .ToListAsync();
        return leaveRequests;
    }

    public async Task<LeaveRequest> GetLeaveRequestWithDetailsAsync(int id)
    {
        var leaveRequest = await _context.LeaveRequests
            .Include(p => p.LeaveType)
            .FirstOrDefaultAsync(p => p.Id == id);
        return leaveRequest;
    }
}
