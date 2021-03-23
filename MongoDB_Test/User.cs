using System;

namespace MongoDB_Test
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool State { get; set; }
        public TypeEnum Type { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Owner { get; set; }
    }

    public enum TypeEnum
    {
        None = 0,
        Employee = 1,
        Manager = 2,
        Administrator = 3
    }
}
