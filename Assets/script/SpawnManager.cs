using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    //public int animalIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float starDelay = 1;
    private float spawnInterval = 1.5f;
    void Start()
    {
        
    InvokeRepeating("SpawnRandomAnimal", starDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
          // if (Input.GetKeyDown(KeyCode.S))
        //{
        //   Vector3 spawnPos = new Vector3 (Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        //    int animalIndex = Random.Range(0, animalPrefabs.Length);
           // Instantiate(animalPrefabs[animalIndex], spawnPos, 
           // animalPrefabs[animalIndex].transform.rotation);
        //}
        

       //if (Input.GetKeyDown(KeyCode.S))
        //{
         //    SpawnRandomAnimal();
             
             //Vector3 spawnPos = new Vector3 (Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            //int animalIndex = Random.Range(0, animalPrefabs.Length);
            //Instantiate(animalPrefabs[animalIndex], spawnPos, 
            //animalPrefabs[animalIndex].transform.rotation);
       // }
    }
        void SpawnRandomAnimal()
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnpos = new Vector3 (Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
            Instantiate(animalPrefabs[animalIndex], spawnpos,
            animalPrefabs[animalIndex].transform.rotation);
        }
}
