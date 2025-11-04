using UnityEngine;
using UnityEngine.AI;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;

    public void chaseEnable(Transform player)
    {
        enabled = true;
        target = player;
    }

    public void stopChase()
    {
        enabled = false;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }


}
