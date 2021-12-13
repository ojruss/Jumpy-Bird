using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float ScrollSpeed = 5f;

    float offSet;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offSet += ScrollSpeed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", new Vector2(offSet, 0));
    }
}
