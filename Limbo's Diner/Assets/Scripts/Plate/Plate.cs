using UnityEngine;

public class Plate : MonoBehaviour
{
    //SLOT POSITIONS
    public GameObject[] slotpos;
    //FOOD COLLECTIONS

    //SINGLES
    public GameObject cooked_meat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void add_cooked_meat() 
    {
        cooked_meat.SetActive(true);
        for (int i = 0; i < slotpos.Length; i ++)
        {
            if (slotpos[i].activeSelf == true) 
            {
                cooked_meat.transform.position = slotpos[i].transform.position;
                slotpos[i].SetActive(false);
                print(slotpos[i]);
                break;
            }
        }
    }
}
