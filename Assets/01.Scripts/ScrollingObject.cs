using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; //�̵��ӵ�
    

    
  private void Update()
    {
        //�ʴ� Speed�� �ӵ��� �������� �����̵�
        transform.Translate(Vector3.left*speed * Time.deltaTime);
    }
}
