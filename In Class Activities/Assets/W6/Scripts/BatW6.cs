using UnityEngine;
using UnityEngine.AI;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform _playerTransform;
    

    void Start()
    {
        enabled = false;
    }
    
    public void chaseEnable(Transform player)
    {
        enabled = true;
        _playerTransform = player;
    }

    public void stopChase()
    {
        enabled = false;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, speed * Time.deltaTime);
    }


}
