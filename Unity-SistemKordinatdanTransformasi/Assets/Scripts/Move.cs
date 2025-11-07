using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Camera.main.transform.forward * speed * Time.deltaTime);

    }
}
