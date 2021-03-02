using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descricao : MonoBehaviour
{
   public string ID;

   public RectTransform descricao;
   public GameObject spawn;
   public RectTransform buttonClose;
   public GameObject spawnButton;
   public void Start()
   {

      spawn = GameObject.FindGameObjectWithTag("Spawn");
      spawnButton = GameObject.FindGameObjectWithTag("SpawnButton");
    
      
   }
   public void spawnDescricao()
   {
     
      GameObject buscaDescr = GameObject.FindGameObjectWithTag("Descricao");
      if (buscaDescr != null)
      {
         Destroy(buscaDescr.gameObject);
      }

      Vector2 position = new Vector2(spawn.transform.position.x, spawn.transform.position.y);
      RectTransform descr = Instantiate(descricao, position, Quaternion.identity) as RectTransform;
      descr.transform.SetParent(spawn.transform);
      descr.localScale = new Vector3(1.5f, 0.5f, 0.5f);
      
      Vector2 positionClose = new Vector2(spawnButton.transform.position.x , spawnButton.transform.position.y);
      RectTransform button = Instantiate(buttonClose, positionClose, Quaternion.identity) as RectTransform;
      button.transform.SetParent(descr.transform);
      button.transform.localScale = new Vector3(0.1f, 0.6f, 1);
      
   }

   public void fecharDescricao()
   {
    

      GameObject buscaDescr = GameObject.FindGameObjectWithTag("Descricao");
      if (buscaDescr != null)
      {
         Destroy(buscaDescr.gameObject);
      }
      
   }
}
