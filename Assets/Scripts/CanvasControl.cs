using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControl : MonoBehaviour
{
   public Canvas canvasGame;
   public Canvas canvasDecision;

   private void Start()
   {
      canvasGame.enabled = true;
      canvasDecision.enabled = false;
   }
}
