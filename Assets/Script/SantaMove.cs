using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SantaMove : MonoBehaviour {
    public float speed = 6f;

    private Animator anim;
    private GameObject instance1;
    private GameObject instance2;
    public GameObject snowball;
    public GameObject present;
    public AudioSource audio1;
    public AudioSource audio2;
    private Vector3[] presentPosition = {new Vector3(12f,1f,18f), new Vector3(27f,1f,10f), new Vector3(-34f,1f,-18),
        new Vector3(-13f,1f,-18f), new Vector3(34f,1f,-33f), new Vector3(-24f, 1f, -33f), new Vector3(-8f, 1f, 27f) };
    private int i;
    public ParticleSystem santaParticle;
    public ParticleSystem snowmanParticle;

    void Start()
    {
        anim = GetComponent<Animator>();
        i = Random.Range(0, 7);
        santaParticle.Stop();
        snowmanParticle.Stop();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || PhoneButton.run)
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            anim.SetBool("isRun", true);
        }
        else anim.SetBool("isRun", false);
        if (Input.GetKeyDown(KeyCode.LeftArrow) || PhoneButton.left)
        {
            this.transform.Rotate(new Vector3(0, -90, 0), Space.Self);
            PhoneButton.left = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || PhoneButton.right)
        {
            this.transform.Rotate(new Vector3(0, 90, 0), Space.Self);
            PhoneButton.right = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) || PhoneButton.ball)
        {
            Vector3 pos = transform.position; // 위치
            pos.y += 1;
            instance1 = Instantiate(snowball, pos, Quaternion.identity) as GameObject;
            instance1.GetComponent<Rigidbody>().AddForce(transform.forward * 700);
            audio1.Play();
            PhoneButton.ball = false;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("snowman"))
        {
            if (CollisionItem.score == 0)
            {
                Destroy(other.gameObject); // destroy snowman
                Destroy(gameObject); // destroy santa
                audio2.Play();
                SceneManager.LoadScene("scene3");
            }
            else
            {
                snowmanParticle.Play();
                CollisionItem.score--;
                santaParticle.Play();
                instance2 = Instantiate(present, presentPosition[i], Quaternion.identity) as GameObject; // make new present
                if (i < 6) i++;
                else i = 0;
                audio2.Play();
                for (int i = 0; i < 3; i++)
                {
                    if (other.gameObject == Snowman.snowmanArray[i])
                    {
                        Snowman.snowmanArray[i].SetActive(false);
                        Snowman.snowmanArray[i].transform.position = Snowman.snowmanPosition[Random.Range(0, 3)];
                        Snowman.snowmanArray[i].SetActive(true);
                    }
                }
            }
        }
    }
}
