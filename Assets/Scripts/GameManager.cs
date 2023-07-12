using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int kill = 0;
    public Text killText;

    public GameObject food;
    public GameObject dog;
    public GameObject cat;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        InvokeRepeating("MakeFood", 0f, 0.1f);
        InvokeRepeating("MakeCat", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        killText.text = kill.ToString();
    }

    private void MakeFood()
    {
        float x = dog.transform.position.x;
        float y = dog.transform.position.y + 0.2f;
        Instantiate(food, new Vector3(x, y), Quaternion.identity);
    }

    private void MakeCat()
    {
        Instantiate(cat);
    }
}
