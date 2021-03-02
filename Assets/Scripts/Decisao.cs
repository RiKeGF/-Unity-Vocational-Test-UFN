using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Decisao : MonoBehaviour
{
   public Escolhas escolha;
   public Cursos cursos;
   public RectTransform[] imgCursos;

   public RectTransform content_Geral;
   public RectTransform content_Principal;

   public CanvasControl canvas;

   public void finalizou()
   {
      if (escolha.qntCursosEscolhidos >= 8)
      {
         escolha.resposta();

         Application.ExternalEval("window.open(\"https://ingresso.ufn.edu.br/vestibular/presencial\",\"_blank\")");

         canvas.canvasGame.enabled = false;
         canvas.canvasDecision.enabled = true;

         for (int i = 0; i < cursos.cursos.Length; i++)
         {
            if (cursos.cursos[i] == 1)
            {
               RectTransform cursos = Instantiate(imgCursos[i], this.content_Principal.position, Quaternion.identity) as RectTransform;

               cursos.transform.SetParent(this.content_Principal.transform);
               cursos.localScale = new Vector3(1, 1, 1);
            }
            else if (cursos.cursos[i] == 2)
            {
               print("BLA2");
               RectTransform cursos = Instantiate(imgCursos[i], this.content_Geral.position, Quaternion.identity) as RectTransform;

               cursos.transform.SetParent(this.content_Geral.transform);
               cursos.localScale = new Vector3(1, 1, 1);
            }



         }
      }
      else
      {
         print("Coloque mais imagens");
      }
      

      
   }
   

   public void reset()
   {
      SceneManager.LoadScene("Menu");
   }
}
