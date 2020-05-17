using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class vbn2 : MonoBehaviour, IVirtualButtonEventHandler , ITrackableEventHandler
{
public GameObject vbObj1, vbObj2, vbObj3, vbObj4, quad1, quad2, quad3, quad4, q1, q2, q3, q4;
	string vbName;
	
	private TrackableBehaviour mTrackableBehaviour;

    // Start is called before the first frame update
    
	void Start()
    	{

        	vbObj1= GameObject.Find("vbn1");
		vbObj1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		
		vbObj2= GameObject.Find("vbn2");
		vbObj2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        	vbObj3= GameObject.Find("vbn3");
		vbObj3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        	vbObj4= GameObject.Find("vbn4");
		vbObj4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

		
		quad1.SetActive(false);
		quad2.SetActive(false);
		quad3.SetActive(false);	
		quad4.SetActive(false);	
		q1.SetActive(false);
		q2.SetActive(false);
		q3.SetActive(false);
		q4.SetActive(false);
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        	if (mTrackableBehaviour)
        	{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
        	}
 	}
	
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
	vbName =  vb.VirtualButtonName;
	if(vbName == "vbn1")
	{
		if(quad1.activeInHierarchy && q1.activeInHierarchy)
		{
		quad1.SetActive(false);
		q1.SetActive(false);
		}
		else
		{
		quad1.SetActive(true);
		quad2.SetActive(false);
		quad3.SetActive(false);	
		quad4.SetActive(false);
		q1.SetActive(true);
 	
		}
	Debug.Log("Button Pressed");
	}
	if(vbName == "vbn2")
	{
		if(quad2.activeInHierarchy && q2.activeInHierarchy)
		{
		q2.SetActive(false);
		quad2.SetActive(false);
		}
		else
		{
		quad1.SetActive(false);
		quad3.SetActive(false);	
		quad4.SetActive(false);	
		
 		q2.SetActive(true);
		quad2.SetActive(true);
		
		}
	Debug.Log("Button Pressed");
	}
	if(vbName == "vbn3")
	{
		if(quad3.activeInHierarchy && q3.activeInHierarchy)
		{
		q3.SetActive(false);
		quad3.SetActive(false);
		}
		else
		{
		quad2.SetActive(false);
		quad1.SetActive(false);	
		quad4.SetActive(false);	
		
 		q3.SetActive(true);
		quad3.SetActive(true);
		
		}
	Debug.Log("Button Pressed");
	}

	if(vbName == "vbn4")
	{
		if(quad4.activeInHierarchy && q4.activeInHierarchy)
		{
		q4.SetActive(false);
		quad4.SetActive(false);
		}
		else
		{
		quad2.SetActive(false);
		quad3.SetActive(false);	
		quad1.SetActive(false);	
		
		quad4.SetActive(true);
		q4.SetActive(true);
		}
	Debug.Log("Button Pressed");
	}
	
	}
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
	//quad1.SetActive(false);
	Debug.Log("Button Released");
	}

    // Update is called once per frame
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,TrackableBehaviour.Status newStatus)
	{
        	if (newStatus == TrackableBehaviour.Status.DETECTED ||newStatus == TrackableBehaviour.Status.TRACKED ||newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        	{
			// Play audio when target is found
			//audio.Play();
        	}
        	else
        	{
			quad1.SetActive(false);
			quad2.SetActive(false);
			quad3.SetActive(false);
			quad4.SetActive(false);
			q1.SetActive(false);
			q2.SetActive(false);
			q3.SetActive(false);
			q4.SetActive(false);
        	}
    	}	
	void Update()
    	{
       
    	}
}