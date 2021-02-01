using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;

    private GameObject pointText;
    int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.pointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {
        this.pointText.GetComponent<Text>().text = this.point.ToString() + " pt";
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string ObjectTag = collision.gameObject.tag;
        if (ObjectTag == "SmallStarTag")
        {
            this.point += 10;
        }
        else if (ObjectTag == "LargeStarTag")
        {
            this.point += 20;
        }
        else if (ObjectTag == "SmallCloudTag")
        {
            this.point += 15;
        }
        else if(ObjectTag == "LargeCloudTag")
        {
            this.point += 50;
        }
    }
}
