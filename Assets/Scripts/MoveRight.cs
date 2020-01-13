using UnityEngine;

public class MoveRight : MonoBehaviour
{
    [SerializeField]
    
    void Update()
    {
        if (transform.position.y > 7.1f)
            Destroy (gameObject);
            
        transform.position += new Vector3 (0, Random.Range (1f, 3f) * Time.deltaTime, 0);
    }
}
