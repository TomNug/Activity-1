using System.ComponentModel;

namespace Activity_1.Models
{
    public class AppointmentModel
    {
        [DisplayName("Patient's Full Name")]
        public string PatientName { get; set; }
        [DisplayName("Appointment Request Date")] 
        public DateTime AppointmentDate { get; set; }
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }
        [DisplayName("Doctor's Last Name")]
        public string DoctorName { get; set; }
        [DisplayName("Patient's Perceived Level of Pain (1-10)")]
        public int PainLevel { get; set; }
    }
}
