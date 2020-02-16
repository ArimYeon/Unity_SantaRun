using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Snowman : MonoBehaviour {

    private Transform _transform;
    private Transform playerTransform;
    private NavMeshAgent nvAgent;
    public AudioSource audio1;
    public static Vector3[] snowmanPosition = { new Vector3(28f, 0f, 27f), new Vector3(0f, 0f, 10f), new Vector3(-33f, 0f, -32f), new Vector3(0f, 0f, -18f), new Vector3(-10f, 0f, -25f), new Vector3(-10f, 0f, -33f) };
    public static GameObject[] snowmanArray = new GameObject[4];
    public ParticleSystem snowmanParticle;

    void Start()
    {
        snowmanArray[0] = GameObject.Find("snowman1");
        snowmanArray[1] = GameObject.Find("snowman2");
        snowmanArray[2] = GameObject.Find("snowman3");
        snowmanArray[3] = GameObject.Find("snowman4");
        _transform = this.gameObject.GetComponent<Transform>();
        nvAgent = this.gameObject.GetComponent<NavMeshAgent>();
        snowmanParticle.Stop();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || PhoneButton.run)
        {
            playerTransform = GameObject.FindWithTag("santa").GetComponent<Transform>();
            nvAgent.destination = playerTransform.position;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("snowball"))
        {
            snowmanParticle.Play();
            audio1.Play();
            for (int i = 0; i < 4; i++)
            {
                if (gameObject == snowmanArray[i])
                {
                    snowmanArray[i].SetActive(false);
                    snowmanArray[i].transform.position = snowmanPosition[Random.Range(0, 6)];
                    snowmanArray[i].SetActive(true);
                }
            }
            Destroy(other.gameObject); // delete snowball
        }
       
    }
 }
