using UnityEngine;
//���� ������ �̵��� ����� ������ ������ ���ġ�ϴ� ��ũ��Ʈ
public class BackgroundLoop : MonoBehaviour
{
    private float widht;//����� ���� ����
   private void Awake()
    {
        //���� ���̸� �����ϴ� ó��
        //Boxcollider2D ������Ʈ�� Size �ʵ���X���� ���� ���̷� ���
        BoxCollider2D backgroundCollider= GetComponent<BoxCollider2D>();
        widht = backgroundCollider.size.x;
    }

    
 private void Update()
    {
        // ���� ��ġ�� �������� �������� width �̻� �̵����� �� ��ġ�� ���ġ
        if(transform.position.x <= -widht)  
        {
            Reposition();
        }
    }

    // ��ġ�� ���ġ�ϴ� �ż���
    private void Reposition()
    {
        //���� ��ġ���� ���������� ���α��� * 2��ŭ �̵�
        Vector2 offset = new Vector2(widht * 2f, 0);
        transform.position = (Vector2) transform.position + offset;
    }
}
