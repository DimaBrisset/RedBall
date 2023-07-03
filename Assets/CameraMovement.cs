using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Character Character;
    public float MinXPos;
    public float MaxXPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector3(Mathf.Clamp(Character.transform.position.x,MinXPos,MaxXPos),transform.position.y,transform.position.z);
    }
}
