using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; //이동속도
    

    
  private void Update()
    {
        //초당 Speed의 속도를 왼쪽으로 평행이동
        transform.Translate(Vector3.left*speed * Time.deltaTime);
    }
}
