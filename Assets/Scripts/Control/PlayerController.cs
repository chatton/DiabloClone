using Combat;
using Core;
using Movement;
using UnityEngine;

namespace Control
{
    [RequireComponent(typeof(Mover))]
    [RequireComponent(typeof(Attacker))]
    public class PlayerController : MonoBehaviour
    {
        private ActionScheduler _actionScheduler;

        private Camera _camera;
        private Mover _mover;
        private Attacker _attacker;

        private void Awake()
        {
            _actionScheduler = new ActionScheduler();
            _camera = Camera.main;
            _mover = GetComponent<Mover>();
            _attacker = GetComponent<Attacker>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(GetMouseRay(), out RaycastHit hit))
                {
                    _actionScheduler.ExecuteAction(GetActionFor(hit));
                }
            }
        }

        public void StartAttackAction(Health health)
        {
            _actionScheduler.ExecuteAction(new AttackAction(_attacker, health));
        }

        private IAction GetActionFor(RaycastHit hit)
        {
            // the thing we hit has health, let's attack it!
            Health health = hit.collider.GetComponent<Health>();

            if (health != null)
            {
                return new AttackAction(_attacker, health);
            }

            return new MoveAction(_mover, hit.point);
        }

        private Ray GetMouseRay()
        {
            return _camera.ScreenPointToRay(Input.mousePosition);
        }
    }
}