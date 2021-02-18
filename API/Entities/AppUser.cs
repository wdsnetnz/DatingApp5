namespace API.Entities
{
    public class AppUser
    {
        /// <summary>
        /// Make the Id, because EntityFrame form will then treat as primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Make as UserName, dotnet authrization map to UserName.
        /// </summary>
        public string UserName { get; set; }

        /**
        * ? ffff
        * !!!
        * TODO: write something here.
        **/
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}