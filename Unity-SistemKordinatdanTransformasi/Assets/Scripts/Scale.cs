using UnityEngine;

public class Scale : MonoBehaviour
{
    public float scaleSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        float s = Mathf.PingPong(Time.time * scaleSpeed, 1f) + 1f;
        transform.localScale = new Vector3(s, s, s);
    }
}
