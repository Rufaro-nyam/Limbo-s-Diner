using UnityEngine;
using UnityEngine.UI;

public class Pan : MonoBehaviour
{
    //PROGRESS BAR STUFF
    [SerializeField] private Image progressbar;
    [SerializeField] private float max_prog = 10f;

    private float current_prog;


    //COOKING CONDITIONS
    public bool cooking_meat;

    //GFX
    public GameObject meat_gfx;
    public GameObject cooked_meat_gfx;

    //OCCUPATION
    public bool occupied = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        current_prog = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (cooking_meat) 
        {
            current_prog += 0.5f * Time.deltaTime;
            progressbar.fillAmount = current_prog / max_prog;
            if(current_prog >= max_prog) 
            {
                cooking_meat = false;
                current_prog = 0f;
                meat_gfx.SetActive(false);
                cooked_meat_gfx.SetActive(true);
            }
        }
    }



    public void cook_meat() 
    {
        meat_gfx.SetActive(true);
        cooking_meat = true;
        occupied = false;
    }

    public void food_collect() 
    {
        cooked_meat_gfx.SetActive(false);
        current_prog = 0.0f;
        cooking_meat = false;
        current_prog = 0.0f;
    }
}
