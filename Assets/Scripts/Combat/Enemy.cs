using Control;
using Core;
using UnityEngine;

namespace Combat
{
    [RequireComponent(typeof(Health))]
    public class Enemy : MonoBehaviour, IRaycastable
    {
        private Health _health;

        private void Awake()
        {
            _health = GetComponent<Health>();
        }

        public void HandleRaycast(PlayerController controller)
        {
            controller.StartAttackAction(_health);
        }
    }
}