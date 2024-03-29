using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceKind
{
    WOOD,
    SEND,
    LEAF,
    CHICKEN,
    FLINTSTONE,
    IRON,
    GOLD,
    DIAMOND,
    TREASURE_BOX,
    URANIUM,
    FISH,
}

public enum CollectionSite
{
    ISLAND,
    CAVE,
    SEA,
}

/// <summary>
/// 아마 Collection함수 실행은 RayCast로 마우스 클릭 감지하여 하지 않을까
/// </summary>
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Resource : MonoBehaviour
{
    public ResourceKind ResourceKind { get; set; }

    public CollectionSite CollectionSite { get; set; }

    //acquisition probability의 약자를 사용함 획득 확률
    public int Ap
    {
        get
        {
            return Ap;
        }
        set
        {
            Ap = Mathf.Min(101, Mathf.Max(-1, value));
            print($"Ap of {ResourceKind} is {Ap}");
        }
    }

    public void Collection()
    {
        if (GameManager.Instance.CollectionSite != CollectionSite)
        {
            print("CollectionSite is Not Equals");
            return;
        }

        int rand = Random.Range(0, 101);
        print($"rand value is [{rand}]");

        if (Ap > rand)
        {
            FindObjectOfType<Inventory>().myInventory.Add(this);
        }
    }
}
