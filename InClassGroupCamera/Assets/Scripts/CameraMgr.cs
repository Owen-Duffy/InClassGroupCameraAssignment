using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMgr : MonoBehaviour
{

    /// <summary>    
    /// /// STEP 1. Define the public fields.    
    /// /// Save the file return to Unity     
    /// /// and assign the cameras to these fields in the    
    /// /// inspector.    /// Return to Github Desktop, Commit and Push.    
    /// /// Everyone then pulls the updated repo.    
    /// /// </summary>    
    public Camera mainCamera;    
    public Camera pictureInPictureCam;    
    public Camera SideViewCamera;    
    public Camera SplitScreenUpper;    
    public Camera SplitScreenLower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>    
    /// /// Person 1:     
    /// /// Fills in the code within the Update.    
    /// /// Commits their changes but then waits    
    /// /// for person 2 to complete their changes.    
    /// /// </summary>

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y != 0) 
        { 
            Vector3 diff = Vector3.forward * Input.mouseScrollDelta.y; 
            if (mainCamera.enabled) mainCamera.transform.Translate(diff);
         else if (SideViewCamera.enabled) SideViewCamera.transform.Translate(diff);
         else if (SplitScreenLower.enabled) SplitScreenLower.transform.Translate(diff);
        }
    }

    public void OnSliderValueChanged(float value)
    {
        Debug.LogFormat("Slider:{0}", value);
        // Code will go here
    }

    public void SwitchViews(Dropdown change)
    {
        Debug.LogFormat("{0}:{1}", change.itemText.text,
            change.value);
        // Code will go here

    }


}
