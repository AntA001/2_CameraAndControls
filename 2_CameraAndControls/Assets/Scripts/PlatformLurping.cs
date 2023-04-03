using UnityEngine;

public class PlatformLurping : MonoBehaviour
{
    [SerializeField]
    float delta;

    [SerializeField]
    float speed = 1.0f;

    [SerializeField]
    Transform starting;

    [SerializeField]
    Transform ending;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (delta > 0.9f)
            delta = 0.9f;
        if (delta < 0.1f)
            delta = 0.1f;

        transform.position = (1 - delta) * starting.position + delta * ending.position;
        delta = Mathf.Cos(Time.time * speed) * 0.5f + 0.5f;
    }
}
