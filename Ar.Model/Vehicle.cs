namespace Ar.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int ApplicantId { get; set; }
        public double Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public string PrimaryUse { get; set; }
        public string OwnLease { get; set; }
        
        public virtual Applicant Applicant { get; set; }
    }
}