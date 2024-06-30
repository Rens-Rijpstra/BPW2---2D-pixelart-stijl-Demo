using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerControl;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //zorgt dat de positie van de camera gelijk is aan die van de speler.
        transform.position = playerControl.position + offset;
    }
}
