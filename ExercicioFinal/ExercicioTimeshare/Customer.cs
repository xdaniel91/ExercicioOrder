namespace ExercicioTimeshare
{
    public class Customer
    {
        private string CPF { get; }
        public string Name { get; set; }
        private string Email { get; }
        private string Birth { get; }

        public Customer(string cpf, string name, string email, string birth)
        {
            CPF = cpf;
            Name = name;
            Email = email;
            Birth = birth;          
        }
    }
}