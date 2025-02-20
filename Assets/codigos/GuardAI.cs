using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    public Transform[] patrolPoints;
    public Transform player;
    private NavMeshAgent agent;
    private int currentPoint = 0;
    private bool chasing = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GoToNextPatrolPoint();
    }

    void Update()
    {
        if (chasing)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                GoToNextPatrolPoint();
            }
        }
    }

    void GoToNextPatrolPoint()
    {
        if (patrolPoints.Length == 0) return;
        agent.SetDestination(patrolPoints[currentPoint].position);
        currentPoint = (currentPoint + 1) % patrolPoints.Length;
    }

    // Usamos OnTriggerStay para asegurarnos de que el NPC detecta al jugador
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            chasing = true;
            agent.SetDestination(player.position);
        }
    }

    // Si el jugador sale del rango, el NPC deja de perseguirlo y vuelve a patrullar
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            chasing = false;
            GoToNextPatrolPoint();
        }
    }
}
