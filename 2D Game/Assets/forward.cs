using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forward : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(player.transform.position.x, 0.4f, 15),
            Mathf.Clamp(player.transform.position.y, 0.0f, 2.8f),
            transform.position.z);
    }
}
