using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverIcone : MonoBehaviour
{
   public string ID;
   public int numberID;
   public bool click;
   public Vector2 position;
   public bool start;
   public GameObject objMove;
   public GameObject content;
   public GameObject content2;
   public bool estaMochila;
   public GameObject limite;

   public Escolhas escolhas;

   public AudioSource pegou;
   public AudioSource largou;

   public bool ativouSom;
   private float countSom = 0.2f;
  
   void Start()
   {

   }

   void Update()
   {
      if (ativouSom)
      {
         countSom -= Time.deltaTime;

         if (countSom < 0)
         {
            ativouSom = false;
         }
      }



      escolhas.qntCursosEscolhidos = content2.transform.childCount;

      if (start)
      {
         if (click)
         {
            this.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            this.transform.SetParent(objMove.transform);
         }
         else
         {
            if (checkMochila())
            {
               this.transform.SetParent(content2.transform);
            }
            else
            {
               this.transform.SetParent(content.transform);
            }
            
         }
      }


      if ((this.transform.position.x > limite.transform.position.x) && (this.transform.position.y < limite.transform.position.y)) {
         estaMochila = true;
      }
      else
      {
         estaMochila = false;
      }


   }

   public void clicou()
   {

      if (!ativouSom)
      {
         ativouSom = true;

         if (click)
         {
            pegou.Play();
         }
         else
         {
            largou.Play();
            
         }
      }
      
      if (checkMochila())
      {
         checkBotao(ID);

         this.transform.SetParent(content2.transform);
         click = !click;
         return;
      }
      click = !click;
      start = true;
      
   }

   public void checkBotao(string id)
   {
      escolhas.qntCurso[numberID]++;
   }


   public bool checkMochila()
   {
      if (estaMochila)
      {          
         return true;
      }
      else
      {
         return false;
      }
   }

}
