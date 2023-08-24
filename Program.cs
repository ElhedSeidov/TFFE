namespace ConsoleApp3
{











    




    public class Program
    {
        static void Main(string[] args)
        {
            EmailValidator emailValidator = new EmailValidator();

            try
            {
                bool IsValid = emailValidator.Validate("brock@mail.com");
                Console.WriteLine(IsValid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}