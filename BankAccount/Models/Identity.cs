namespace BankAccount
{
    abstract class Identity
    {
        public Guid ID { get; }
        public Identity () 
        {
            ID = Guid.NewGuid ();
        }
    }  
}