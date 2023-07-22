using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetailsAsync(int id);
        Task<IReadOnlyList<LeaveRequest>> GetLeaveRequestsWithDetailsAsync();
        Task<IReadOnlyList<LeaveRequest>> GetLeaveRequestsWithDetailsAsync(string userId);
    }
}
