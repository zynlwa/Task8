namespace Task8
{
    internal class Account
    {
        public string Username;
        public string Password;
         public void Login(string username, string password)
        {
            if (username == "lorem123" && password == "123456*")
            {
                Console.WriteLine("Girish ugurludur");
            }else
                Console.WriteLine("Email ve ya password sehvdir ");
        }
    }
}
