using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour
{
    public int hp = 5;
    public bool isBeingAttacked = false;
    public float catSpeed = 0.02f;

    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        float x = Random.Range(-2.25f, 2.25f);
        float y = 5.5f;
        transform.position = new Vector3(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, catSpeed);
        if (transform.position.y < - 4f)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            hp -= 1;
            catSpeed = 0.005f;
            if (!isBeingAttacked)
            {
                isBeingAttacked = true;
                StartCoroutine(ChangeColor());
            }
            if (hp <= 0)
            {
                GameManager.Instance.kill += 1;
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        catSpeed = 0.02f;
    }

    public IEnumerator ChangeColor()
    {
        sprite.color = new Color(255, 0, 0);
        yield return new WaitForSeconds(0.1f);
        sprite.color = new Color(255, 255, 255);
        yield return new WaitForSeconds(0.1f);
        isBeingAttacked = false;
    }
}
