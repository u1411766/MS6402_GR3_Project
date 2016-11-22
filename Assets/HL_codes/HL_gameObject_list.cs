using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HL_gameObject_list : MonoBehaviour {
    public List<GameObject> ballons_blue = new List<GameObject>();
    public List<GameObject> ballons_red = new List<GameObject>();
    public List<GameObject> ballons_yellow = new List<GameObject>();
    public List<GameObject> ballons_black = new List<GameObject>();
    


 public bool test;
	// Use this for initialization
	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        ballons_blue = new List<GameObject>(GameObject.FindGameObjectsWithTag("balloon_blue"));
        ballons_red = new List<GameObject>(GameObject.FindGameObjectsWithTag("balloon_red"));
        ballons_yellow = new List<GameObject>(GameObject.FindGameObjectsWithTag("balloon_yellow"));
        ballons_black = new List<GameObject>(GameObject.FindGameObjectsWithTag("balloon_black"));
        if (ballons_blue.Contains(GameObject.FindGameObjectWithTag("balloon_blue")))
        {
            
        }
        if (ballons_blue.Count == 0)
        {
            test = true;
        }
        else test = false;

    }
}
