using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            score ++;
            scoreText.text = "Score: " + score;
            Destroy(other.gameObject);
        }
    }
}
