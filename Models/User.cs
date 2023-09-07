namespace BankWebApi.Models {
    public class User: Base {
        public string Username {get;set;}   
        public string Password {get;set;}

        public string Mail  {get;set;}
        public string Mobile {get;set;}
    }
}
