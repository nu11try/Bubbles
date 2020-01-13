using UnityEngine;

public class MoveUp : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2f;
    
    void Update()
    {
        if (transform.position.y > 6.5f)
            Destroy (gameObject);
            
        transform.position += new Vector3 (0, moveSpeed * Time.deltaTime, 0);
    }
}
