namespace MotorcycleService.Base
{
    public class User
    {
        private int userID;
        private string userLogin;

        internal User(int _userID, string _userLogin)
        {
            userID = _userID;
            userLogin = _userLogin;
        }
        public int UserID
        {
            get
            {
                return userID;
            }
        }
        public string UserLogin
        {
            get
            {
                return userLogin;
            }
        }
    }
}