using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAutoShadows : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
    }
}
