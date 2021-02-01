using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    private GameObject pointText;
    int point = 0;

    public void GetSmallStar()
    {
        this.point += 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {
        this.pointText.GetComponent<Text>().text = this.point.ToString() + " pt";
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
