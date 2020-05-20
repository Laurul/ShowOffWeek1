using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpManager : MonoBehaviour
{


    [SerializeField] Button upgradeFuelButtons;
    [SerializeField] Button upgradeOxygenButtons;
    [SerializeField] EventHandler fuelBar;
    [SerializeField] EventHandler oxygenBar;
    [SerializeField] AcceptJunk plasticContainer;
    [SerializeField] AcceptJunk bioContainer;
    [SerializeField] AcceptJunk metalContainer;
    int bioNeeded = 1;
    int plasticNeeded = 1;

    int metalNeeded = 1;
    int random1;
    int random2;
    // Start is called before the first frame update
    void Start()
    {
        random1 = Random.Range(0, 3);
        random2 = Random.Range(0, 3);


    }

    // Update is called once per frame
    void Update()
    {
        ChoosePair();

    }

    public void Recycle()
    {
        if ((random1 == 0 && random2 == 1) || (random2 == 0 && random1 == 1))
        {
            plasticContainer.RecycleJunk(plasticNeeded);
            bioContainer.RecycleJunk(bioNeeded);
            bioNeeded++;
            plasticNeeded++;
            RandomRoll();
        }
        else if ((random1 == 0 && random2 == 2) || (random2 == 0 && random1 == 2))
        {
            bioContainer.RecycleJunk(bioNeeded);
            metalContainer.RecycleJunk(metalNeeded);
            bioNeeded++;
            metalNeeded++;
            RandomRoll();
        }
        else if ((random1 == 1 && random2 == 2) || (random2 == 1 && random1 == 2))
        {
            plasticContainer.RecycleJunk(plasticNeeded);
            metalContainer.RecycleJunk(metalNeeded);
            plasticNeeded++;
            metalNeeded++;
            RandomRoll();
        }
        //plasticContainer.RecycleJunk(plasticNeeded);
        //bioContainer.RecycleJunk(bioNeeded);
        //metalContainer.RecycleJunk(metalNeeded);
    }

    public void RandomRoll()
    {

        random1 = Random.Range(0, 3);
        random2 = Random.Range(0, 3);
    }

    private void ChoosePair()
    {
        if ((random1 == 0 && random2 == 1) || (random2 == 0 && random1 == 1))
        {
            upgradeFuelButtons.GetComponentInChildren<TextMeshProUGUI>().text = "Synthetize fuel with " + bioNeeded + " biomass and " + plasticNeeded + " plastic";
            upgradeOxygenButtons.GetComponentInChildren<TextMeshProUGUI>().text = "Synthetize oxygen with " + bioNeeded + " biomass and " + plasticNeeded + " plastic";
            if (plasticContainer.returnCount() >= plasticNeeded && bioContainer.returnCount() >= bioNeeded)
            {
                upgradeFuelButtons.interactable = true;
                upgradeOxygenButtons.interactable = true;
            }
            else
            {
                upgradeFuelButtons.interactable = false;
                upgradeOxygenButtons.interactable = false;
            }

        }

        else if ((random1 == 0 && random2 == 2) || (random2 == 0 && random1 == 2))
        {
            upgradeFuelButtons.GetComponentInChildren<TextMeshProUGUI>().text = "Synthetize fuel with " + bioNeeded + " biomass and " + metalNeeded + " metal";
            upgradeOxygenButtons.GetComponentInChildren<TextMeshProUGUI>().text = "Synthetize oxygen with " + bioNeeded + " biomass and " + metalNeeded + " metal";

            if (metalContainer.returnCount() >= metalNeeded && bioContainer.returnCount() >= bioNeeded)
            {
                upgradeFuelButtons.interactable = true;
                upgradeOxygenButtons.interactable = true;
            }
            else
            {
                upgradeFuelButtons.interactable = false;
                upgradeOxygenButtons.interactable = false;
            }
        }

        else if ((random1 == 1 && random2 == 2) || (random2 == 1 && random1 == 2))
        {
            upgradeFuelButtons.GetComponentInChildren<TextMeshProUGUI>().text = "Synthetize fuel with " + metalNeeded + " metal and " + plasticNeeded + " plastic";
            upgradeOxygenButtons.GetComponentInChildren<TextMeshProUGUI>().text = "Synthetize oxygen with " + metalNeeded + " metal and " + plasticNeeded + " plastic";

            if (plasticContainer.returnCount() >= plasticNeeded && metalContainer.returnCount() >= metalNeeded)
            {
                upgradeFuelButtons.interactable = true;
                upgradeOxygenButtons.interactable = true;
            }
            else
            {
                upgradeFuelButtons.interactable = false;
                upgradeOxygenButtons.interactable = false;
            }
        }
        else
        {
            RandomRoll();
        }
    }


}
