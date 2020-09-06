using UnityEngine;
using UnityEngine.AI;

namespace Movement
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Mover : MonoBehaviour
    {
        private NavMeshAgent _agent;

        private void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        public void MoveTo(Vector3 destination)
        {
            if (destination != Vector3.zero)
            {
                _agent.isStopped = false;
                _agent.SetDestination(destination);
            }
        }

        public void Stop()
        {
            _agent.isStopped = true;
        }
    }
}