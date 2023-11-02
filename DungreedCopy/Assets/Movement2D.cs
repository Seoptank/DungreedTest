using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{

    [Header("��/�� �̵�, ���� ����")]
    [SerializeField]
    private float               moveSpeed = 1.0f;
    [SerializeField]
    private float               jumpForce = 3.0f;
    [SerializeField]
    private float               lowGravity = 2.0f;  // ����Ű�� ���� ������ ������ ����Ǵ� ���� �߷�
    [SerializeField]
    private float               highGravity = 5.0f; // �Ϲ������� ����Ǵ� ���� 

    [Header("���� ����")]
    public bool                 haveDoubleJump;
    [SerializeField]
    private int                 haveDoubleJump_MaxJumpCount = 2;
    [SerializeField]
    private int                 normalState_MaxJumpCount = 1;
    [SerializeField]
    private int                 curJumpCount;
    
    [Header(" �� äũ")]
    [SerializeField]
    private LayerMask       collisionLayer;
    private bool            isGrounded;
    private Vector3         footPos;

    public bool isLongJump { set; get; } = false;

    private Rigidbody2D         rigidbody;
    private BoxCollider2D       boxCollider2D;    

    private void Awake()
    {
        rigidbody       = GetComponent<Rigidbody2D>();
        boxCollider2D   = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        Bounds bounds = boxCollider2D.bounds;

        footPos = new Vector3(bounds.center.x, bounds.min.y);

        isGrounded = Physics2D.OverlapCircle(footPos, 0.02f, collisionLayer);
        
        if(isGrounded == true && rigidbody.velocity.y <= 0)
        {
           if(haveDoubleJump == true)
            {
                curJumpCount = haveDoubleJump_MaxJumpCount;
            }
           else if(haveDoubleJump == false)
            {
                curJumpCount = normalState_MaxJumpCount;
            }
        }

        if(isLongJump && rigidbody.velocity.y > 0)
        {
            rigidbody.gravityScale = lowGravity;
        }
        else
        {
            rigidbody.gravityScale = highGravity;
        }
    }

    public void MoveTo(float x)
    {
        rigidbody.velocity = new Vector2(x * moveSpeed, rigidbody.velocity.y);
    }

    public bool JumpTo()
    {
        if( curJumpCount > 0 )
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpForce);
            curJumpCount--;
            return true;
        }
        return false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(footPos, 0.02f);
    }
}
