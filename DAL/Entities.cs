using System;

namespace DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    public class Account
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
    }

    public class DevelopmentPlan
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Progress { get; set; }
    }

    public class Competence
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
