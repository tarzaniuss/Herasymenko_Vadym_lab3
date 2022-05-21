namespace ClassLibrary1
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }

        public static void ShowUser(User user)
        {
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Email);
        }
    }
}