using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
   static public bool musicaAtiva;
   public AudioSource musica;
   // Start is called before the first frame update
   void Start()
   {
      ativarMusica();
      DontDestroyOnLoad(this.gameObject);
   }
  

   public void ativarMusica()
   {
      if (!musicaAtiva)
      {
         musicaAtiva = true;
         musica.Play();
      }

      if (!musica.isPlaying)
      {
         Destroy(this.gameObject);
      }
   }
}
