using UnityEngine;
using UnityEngine.AI;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] bool speed;

    public void Chase(Transform player)
    {
        target = player;
    }


}
