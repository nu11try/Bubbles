using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed = 10f;

    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
            mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
            mousePos.y = mousePos.y > 5.7f ? 5.7f : mousePos.y;
            mousePos.y = mousePos.y < -3.7f ? -3.7f : mousePos.y;
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, mousePos.y), speed * Time.deltaTime);
        }
    }
}
