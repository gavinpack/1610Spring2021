using UnityEngine;

public class AxisRawExample : MonoBehaviour
{
    //GUIText is obsolete and breaks Unity.
    
    public float range;
    //public GUIText textOutput;
    
    
    void Update () 
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;
        
        transform.position = new Vector3(xPos, 2f, 0);
        //textOutput.text = "Value Returned: "+h.ToString("F2");  
    }
}
