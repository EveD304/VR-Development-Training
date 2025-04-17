using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RightHandAttach : MonoBehaviour
{
    
    public GameObject ruler;
    public GameObject clipboard;
    string rulerName = "Ruler";
    string clipName = "Clipboard";
    string attached = "[RightHand Controller] Dynamic Attach";

    // Start is called before the first frame update
    void Start()
    {

        ruler = GameObject.FindGameObjectWithTag(rulerName);
        clipboard = GameObject.FindGameObjectWithTag(clipName);
    }

    // Update is called once per frame
    void Update()
    {
        if (ruler.transform.childCount > 1)
        {
            
            if (ruler.transform.GetChild(1).name == attached)
            {
                ruler.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x * 90 + 90 , gameObject.transform.rotation.y * 90, gameObject.transform.rotation.z * 90 + 90 );
            }
        }

        if (clipboard.transform.childCount > 2)
        {
            if (clipboard.transform.GetChild(2).name == attached)
            {
                clipboard.transform.localRotation = Quaternion.Euler(gameObject.transform.rotation.z * 90, gameObject.transform.rotation.y * 90 + 90, gameObject.transform.rotation.x * 90);
            }
        }
    }
}
