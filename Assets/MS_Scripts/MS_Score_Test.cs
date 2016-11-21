using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MS_Score_Test : MonoBehaviour {

    public Text gui_score;
    public Text gui_time;
    public float fl_score;
    public int int_time;
    public int int_max_time;

	// Use this for initialization
	void Start () {

        fl_score = 0;
        UpdateScore();
        UpdateTime();
        InvokeRepeating("MinusTime", 1,1);

        
	}
	
	// Update is called once per frame
	void Update () {

        
        UpdateScore();
        UpdateTime();
        if (int_time < 1)
        {
            Application.LoadLevel(Application.loadedLevel);

        }

	}

    void UpdateScore()
    {

        gui_score.text = "Score:" + "   " + fl_score;
    }

    void UpdateTime()
    {
        gui_time.text = "Time:" + "       " + int_time;

    }

    void MinusTime()
    {

        int_time -= 1;
    }
}
