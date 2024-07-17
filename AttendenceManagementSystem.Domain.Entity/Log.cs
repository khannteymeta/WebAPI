
namespace AttendenceManagementSystem.Domain.Entity;
    public class Log
    {
        public Guid Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public uint TimeShift { get; set; }

        // set up foreign key...
        public Guid CurrentEmployeeId { get; set; }


        //Navigation property
        public Employee? Employee { get; set; }
        public Log() { }
        public Log(DateTime TimeStamp, uint TimeShift)
        {
            this.Id = Guid.NewGuid();
            this.TimeStamp = TimeStamp;
            this.TimeShift = TimeShift;
        }
}
