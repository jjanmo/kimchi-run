using UnityEngine;

public class Destoryer : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x < -13)
        {
            Destroy(gameObject);
        }

    }
}
