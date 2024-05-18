using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent enemyAgent;
    public Animator enemyAnimator;
    public AudioSource panicSound;
    public GameObject GunShootButton;
    public GameObject VictoryUI;
    public int bulletHit = 0;

    void OnCollisionEnter(Collision collision){
	   //Si la colision viene de la bala, entonces se aumenta el contador de impactos de bala.
        //Si el jugador le da 100 balazos al zombie, el zombie muere
        if (collision.gameObject.CompareTag("Bulet")){
            bulletHit++;
            if (bulletHit == 50){
                enemyAnimator.SetInteger("defeat", 1);
            }
        } 
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica si la animación del estado actual ha terminado
        AnimatorStateInfo stateInfo = enemyAnimator.GetCurrentAnimatorStateInfo(0); 
        bool zombieDefeated = enemyAnimator.GetInteger("defeat") == 1;
        
        if (!stateInfo.IsName("WakeUp") && !zombieDefeated)
        {
            enemyAgent.destination = Player.position;
            //panicSound.Pause();
        } else if (stateInfo.IsName("WakeUp") && !zombieDefeated){
            panicSound.Play(0);
        } else if (zombieDefeated){
            GunShootButton.SetActive(false);
            VictoryUI.SetActive(true);
        }
    }
}
