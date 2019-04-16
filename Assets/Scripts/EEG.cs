using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EEG : MonoBehaviour
{

    public OSC osc;
	private float speed = 0.5f;


    // Use this for initialization
    void Start()
    {
        osc.SetAddressHandler("/eeg", OnReceiveXYZ);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnReceiveXYZ(OscMessage message)
    {
        Debug.Log("EEG! " + message.GetFloat(0));

		if (message.GetFloat(0) < 0.20)
		{
			transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
		}
        //float x = message.GetFloat(0);
        //float y = message.GetFloat(1);
        //float z = message.GetFloat(2);

        //transform.position = new Vector3(x, y, z);
    }

    //void OnReceiveX(OscMessage message)
    //{
    //    float x = message.GetFloat(0);

    //    Vector3 position = transform.position;

    //    position.x = x;

    //    transform.position = position;
    //}

    //void OnReceiveY(OscMessage message)
    //{
    //    float y = message.GetFloat(0);

    //    Vector3 position = transform.position;

    //    position.y = y;

    //    transform.position = position;
    //}

    //void OnReceiveZ(OscMessage message)
    //{
    //    float z = message.GetFloat(0);

    //    Vector3 position = transform.position;

    //    position.z = z;

    //    transform.position = position;
    //}


}
