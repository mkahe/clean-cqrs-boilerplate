using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

public class LeaveRequest : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set;}
    public DateTime DateRequest { get; set; }
    public string? RequestComments { get; set; }
    public bool? Approved { get; set; }
    public bool Canceled { get;}
    public string RequestingEmployeeId { get; set; } = string.Empty;
}