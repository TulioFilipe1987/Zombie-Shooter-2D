using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWeaponController :WeaponController{

    public Transform spawnPoint;
    public GameObject bulletPrefab;
    public ParticleSystem fx_Shot;
    public GameObject fx_BulletFall;

    private Collider2D fireCollider;

    private WaitForSeconds wait_Time = new WaitForSeconds(0.02f);
    private WaitForSeconds fire_ColliderWait = new WaitForSeconds(0.02f);
   
    void Start(){
        //create bullets
        
    }

    public override void ProcessAttack(){
        //base.ProcessAttack();

        switch (nameWp){
           

            case NameWeapon.PISTOL:
                print("Fired From Pistol");
                break;

            case NameWeapon.MP5:
                print("Fired From MP5");
                break;

            case NameWeapon.M3:
                print("Fired From M3");
                break;

            case NameWeapon.AK:
                print("Fired From AK47");
                break;

            case NameWeapon.AWP:
                print("Fired From Sniper");
                break;

            case NameWeapon.FIRE:
                print("Fired From fire");
                break;

            case NameWeapon.ROCKET:
                print("Fired From Rocket Launcher");
                break;

        }//Swicth and case 

        // SPAWN ATTACK

    }//PROCESS ATTACK

    IEnumerator WaitForShootEffect(){

        yield return wait_Time;
        fx_Shot.Play();
    }
     

    IEnumerator ActiveFireColllider(){
        fireCollider.enabled = true;

        yield return fire_ColliderWait;

        fireCollider.enabled = false;

    
    }

}//class
