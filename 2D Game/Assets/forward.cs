using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forward : MonoBehaviour
{
    public GameObject player;
    private Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(player.transform.position);
        offset = transform.position - player.transform.position;
        //Debug.Log(transform.position);
        //Debug.Log("offset: " + offset);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float transformX = offset[0];
        float transformY = offset[1];
        Vector2 current_player = player.transform.position;
        if (((current_player[1]+transformY) < 0.4f) && ((current_player[1] + transformY) > -0.8f))
            transform.position = new Vector3(current_player[0]+transformX, current_player[1]+transformY, -10);
        else if ((current_player[1] + transformY) < -0.8f)
            transform.position = new Vector3(current_player[0] + transformX, -0.8f, -10);
        else transform.position = new Vector3(current_player[0] + transformX, 0.4f, -10);

    }
}
