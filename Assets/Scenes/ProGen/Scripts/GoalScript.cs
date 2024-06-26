using UnityEngine;


public class GoalScript : MonoBehaviour
{
   private DungeonCreator dungeonGenerator;
   public GameObject dungeonGeneratorObj;
   

   private void Start()
   {
       // Find the GameObject with the tag "Generator"
       dungeonGeneratorObj = GameObject.FindWithTag("Generator");


       // Check if the GameObject was found
       if (dungeonGeneratorObj == null)
       {
           Debug.LogError("DungeonGenerator GameObject not found with tag 'Generator'");
       }


   }


   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
            dungeonGenerator = dungeonGeneratorObj.GetComponent<DungeonCreator>();
            dungeonGenerator.regenerate = true;
            
            
       }
   }



}
