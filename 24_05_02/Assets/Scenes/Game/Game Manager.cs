using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cricleObject;
    public Transform GenTransform;
    public float timeCheck;
    public bool isGen;

    // Start is called before the first frame update
    public void GenObject()
    {
        isGen = false;
        timeCheck = 1.0f;
    }

    void Start()
    {
        GenObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGen == false)
        {
            timeCheck -= Time.deltaTime;
            if(timeCheck < 0.0f)
            {
                GameObject Temp = Instantiate(cricleObject);
                Temp.transform.position = GenTransform.position;
                isGen = true;
            }
        
        }
    }
}
