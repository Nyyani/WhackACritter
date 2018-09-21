using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : MonoBehaviour {

    public Vector2 lowerRange;
    public Vector2 upperRange;
    public Score scoreDisplay;
    public Timer timer;
    public int pointValue = 1; //how much is critter worth


    // Use this for initialization
    void Start () {
        transform.position = new Vector3(Random.Range(lowerRange.x, upperRange.x),
            Random.Range(lowerRange.y, upperRange.y),
            0);
	}
	
	// Update is called once per frame
	void Update () {
		if (timer.IsTimerRunning() == false)
        {
            Destroy(gameObject);
        }
	}

    void OnMouseDown()
    {
        scoreDisplay.ChangeValue(pointValue);
        Destroy(gameObject);
    }

}
