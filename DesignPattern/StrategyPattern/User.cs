namespace StrategyPattern
{
    class User
    {
        private IAttacker _attacker = null;

        public User(IAttacker attacker)
        {
            this._attacker = attacker;
        }

        public void SetAttack(IAttacker iAttacker)
        {
            _attacker = iAttacker;
        }

        public void Attack()
        {
            _attacker.Attack();
        }
    }
}