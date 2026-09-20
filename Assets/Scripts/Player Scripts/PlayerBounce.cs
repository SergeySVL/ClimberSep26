using UnityEngine;

public class PlayerBounce : MonoBehaviour
{

    public float min_X = -2.6f, max_X = 2.6f, min_Y = -5.6f;

    void Update()
    {
        CheckBounds();        
    }

    void CheckBounds()
    {
        Vector2 temp = transform.position;

        if (temp.x > max_X) {
            temp.x = max_X;
        }

        if (temp.x < min_X) {
            temp.x = min_X;
        }

        if (temp.y <= min_Y) {
            temp.y = min_Y;
        }


    }

}
