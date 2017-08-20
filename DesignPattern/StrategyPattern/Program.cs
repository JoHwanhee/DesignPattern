
namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(new Knife());
            user1.Attack();
            user1.SetAttack(new Sword());
            user1.Attack();


        }
    }
}
