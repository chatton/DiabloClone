using Core;

namespace Combat
{
    public class AttackAction : IAction
    {
        private Attacker _attacker;
        private Health _targetHealth;

        public AttackAction(Attacker attacker, Health targetHealth)
        {
            _attacker = attacker;
            _targetHealth = targetHealth;
        }

        public void Execute()
        {
            _attacker.Attack(_targetHealth);
        }

        public void Cancel()
        {
            _attacker.StopAttacking();
        }
    }
}