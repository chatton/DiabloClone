using Movement;
using UnityEngine;

namespace Combat
{
    [RequireComponent(typeof(Mover))]
    public class Attacker : MonoBehaviour
    {
        private Mover _mover;

        private Health _targetHealth;

        private void Awake()
        {
            _mover = GetComponent<Mover>();
        }

        private void Update()
        {
            if (_targetHealth == null)
            {
                return;
            }
        }


        public void Attack(Health targetHealth)
        {
            _targetHealth = targetHealth;
        }

        public void StopAttacking()
        {
            _targetHealth = null;
        }
    }
}