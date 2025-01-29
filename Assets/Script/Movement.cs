using TreeEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 3f;
    public void Move(Vector3 move)
    {
        transform.position += move.normalized * Time.deltaTime * speed;
    }
}
