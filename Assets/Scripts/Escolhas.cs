using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escolhas : MonoBehaviour
{
   public int[] qntCurso;

   public Cursos cursos;

   public int primario = 0;
   public int[] secundarios = { 0, 0, 0 };
   public int index;
   public int index2 = 0;
   public bool primarioMT = true;
   public int qntCursosEscolhidos = 0;
   public int count = 0;
   public GameObject objPrimario;
   public GameObject tituloPrimario;

   public void resposta()
   {
      for (int i = 0; i < qntCurso.Length; i++)
      {
         if (qntCurso[i] > primario)
         {
            primario = qntCurso[i];
            index = i;
         }
      }

      for (int i = 0; i < qntCurso.Length; i++)
      {
         if (qntCurso[i] > 0 && qntCurso[i] <= primario)
         {
            if (index2 < 3)
            {
               secundarios[index2] = i;
               index2++;
            }

         }
      }
      cursos.cursos[secundarios[0]] = 2;
      cursos.cursos[secundarios[1]] = 2;
      cursos.cursos[secundarios[2]] = 2;

      if (primario > 1)
      {
         objPrimario.active = true;
         tituloPrimario.active = true;
         cursos.cursos[index] = 1;
      }
      else
      {
         objPrimario.active = false;
         tituloPrimario.active = false;
         cursos.cursos[index] = 2;
      }
      
   }
}

