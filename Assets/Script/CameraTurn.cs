using UnityEngine;
using System.Collections;

public class CameraTurn : MonoBehaviour
{
    //추적할 대상
    public Transform target;
    //카메라와의 거리   
    public float dist = 7f;
    //카메라의 높이 
    public float height = 1f;
    public float smoothRotate = 5.0f;
    private Transform tr;
    // Use this for initialization

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    //Update is called once per frame
    void Update()
    {
        float currYAngle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, smoothRotate * Time.deltaTime);
        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);
        //카메라 위치 설정
        tr.position = target.position - (rot * Vector3.forward * dist) + (Vector3.up * height);
        tr.LookAt(target);
    }
}
