using UnityEngine;

public class Stat : MonoBehaviour
{   // vie
    [Header("Health")]

    [SerializeField]
    private float maxHealth = 100;
    private float currentHealth;
    // modification de l'image de la barre de vie
    [SerializeField]
    private ImageConversion healthBarFill;

    [SerializeField]
    private float healthDecreaseRateForHungerAndThirst;

    // faim
    [Header("Hunger")]
    [SerializeField]
    private float maxHunger = 100;
    private float currentHunger;
    private float currentThirst;
    [SerializeField]
    private Image hungerBarFill;

    [SerializeField]
    private float hungerDecreaseRate;

    // soif
    [Header("Thirst")]
    [SerializeField]
    private float maxThirst = 100;
    private float currenThirst;

    [SerializeField]
    private Image ThirstBarFill;

    [SerializeField]
    private float ThirstDecreaseRate;

    void Awake()
    {
        currentHealth = maxHealth;
        currentHunger = maxHunger;
        currentThirst = maxThirst;

    }

    void Update()
    {
        UpdateHungerAndThirstBarFill();
        // dégat infligé (tapper la touche d pour 15dmg (pour test))
        if (Input.GetKeyDown(KeyCode.D))
        {
            takeDamage(15f);
        }
    }
    // modification de la stat de vie quand dégat pris
    void takeDamage(float damage, bool overTime = false)
    {
        if (overTime)
        {
            currentHealth -= damage * Time.deltaTime;
        }
        else
            currentHealth -= damage;
        {
            UpdateHealthtBarFill();
        }
        if (currentHealth <= 0)
        {
            Debug.Log("Player died !");
        }

        void UpdateHealthtBarFill()
        {
            healthBarFill.fillAmount = currentHealth / maxHealth;
        }
    }
    void UpdateHungerAndThirstBarFill()
     {//barre de faim baisse avec le temps
       currentHunger -= hungerDecreaseRate * Time.deltaTime;
       currentThirst -= ThirstDecreaseRate * Time.deltaTime;

      //on empeche de passer dans le négatif
       currentHunger = currentHunger < 0 ? 0 : currentHunger;
       currentThirst = currentThirst < 0 ? 0 : currentThirst;


      //mettre a jour les visuels
       hungerBarFill.fillAmount = currentHunger / maxHunger;
       ThirstBarFill.fillAmount = currentThirst / maxThirst;

      // si la barre de faim et/ou soif est a 0 l'entité prend des dégats (x2 si les 2 barres a 0)
         if (currentHunger <= 0 || currentThirst <= 0)
         {
            takeDamage((currentHunger <= 0 && currenThirst <= 0 ? healthDecreaseRateForHungerAndThirst * 2 : healthDecreaseRateForHungerAndThirst), true);
         }

    }
}