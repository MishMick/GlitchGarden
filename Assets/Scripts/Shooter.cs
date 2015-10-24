using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour 
{
    public GameObject projectile,gun;
    public GameObject projectileParent;
    private Animator anim;
    private Spawner myLaneSpawnerObj;
    void Start()
    {
     anim = GetComponent<Animator>();
     projectileParent = GameObject.Find("Projectiles");
     if(!projectileParent)
     {
      projectile = new GameObject("Projectiles");
     }
     FindMyLaneSpawner();
     print (myLaneSpawnerObj);
    }
    void Update()
    {
     if(isAttackerVisible())
     {
      anim.SetBool("isAttacking",true);
     }
     else
     {
      anim.SetBool("isAttacking",false);
     }
    }
    void FindMyLaneSpawner()
    {
     Spawner[] mySpawnerArray = GameObject.FindObjectsOfType<Spawner>();
     foreach(Spawner spawn in mySpawnerArray)
     {
      if(spawn.transform.position.y == transform.position.y)
      {
       myLaneSpawnerObj = spawn;
       return;
      }
      Debug.LogError("Can't find spawner in my lane");
     }
    }
    bool isAttackerVisible()
    {
     return true;
    }
	private void FireGun()
	{
	 GameObject shoot = Instantiate(projectile) as GameObject;
	 shoot.transform.parent = projectileParent.transform;
	 shoot.transform.position = gun.transform.position;
	}
}
