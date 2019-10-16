using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    

        public float speed = 10f;
        public float fireRate = 0.3f;
       

        void Update()
        {
            //Move();
        }
/*
        public virtual void Move()
        {
            Vector3 tempPos = pos;
            tempPos.y -= speed * Time.deltaTime;
            pos = tempPos;
        }
        */
        void OnCollisionEnter(Collision col)
        {
            GameObject other = col.gameObject;
            switch (other.tag)
            {
                case "Hero":
                break;
                case "HeroLaser":
                Destroy(this.gameObject);
                gameManager.count = gameManager.count + 1;
                break;
                default:
                break;
            }
        }

        public Vector3 pos
        {
            get
            {
                return (this.transform.position);
            }
            set
            {
                this.transform.position = value;
            }
        }


}
