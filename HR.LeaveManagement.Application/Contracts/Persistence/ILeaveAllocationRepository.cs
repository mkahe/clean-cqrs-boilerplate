using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    Task<LeaveAllocation> GetLeaveAllocationWithDetailsAsync(int id);
    Task<IReadOnlyList<LeaveAllocation>> GetLeaveAllocationsWithDetailsAsync();
    Task<IReadOnlyList<LeaveAllocation>> GetLeaveAllocationsWithDetailsAsync(string userId);
    Task<bool> AllocationExists(string userId, int leaveTypeId, int period);
    Task AddAllocations(List<LeaveAllocation> allocations);
    Task<LeaveAllocation> GetUserAllAllocations(string userId, int leaveTypeId);
}
