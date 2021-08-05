using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_UI_Controller : MonoBehaviour
{
    private TEST_UI_TAB uiState;

    public GameObject createWorldTab;
    public GameObject createCharacterTab;
    public GameObject takeTurnTab;

    public GameObject display;

    public IOverWorld overWorld;
    public CharacterData cd;
    public TimeLine timeLine;

    List<WorldEvent> events;
    public bool canToggle = true;
    

    public int eventIndex = 0;
    public string currentActionToggle = "";

    private void Awake()
    {
        Debug.Log("Starting Test UI menu");
        setTabState(TEST_UI_TAB.CREATE_WORLD);

    }

    public void setTabState(TEST_UI_TAB value)
    {
        this.uiState = value;
        toggleMenus();
    }

    private void toggleMenus()
    {
        takeTurnTab.SetActive(uiState == TEST_UI_TAB.TAKE_TURN);
        createCharacterTab.SetActive(uiState == TEST_UI_TAB.CREATE_CHARACTER);
        createWorldTab.SetActive(uiState == TEST_UI_TAB.CREATE_WORLD);
    }

    public void initWorld(int choice)
    {
        overWorld = OWS_Factory.createOverWorld();
        setTabState(TEST_UI_TAB.CREATE_CHARACTER);
    }

    public void initCharacter()
    {
        cd = CDS_Factory.generateTestCD();
        setTabState(TEST_UI_TAB.TAKE_TURN);
        
    }

    public void initTL()
    {
        timeLine = new TimeLine(new OriginEvent());
        PresentEvents present = (PresentEvents)timeLine.present.worldEvent;
        events = present.retrieveEvents();
        displayActionEvent();
    }

    public void displayTimeLine()
    {
        Moment index = timeLine.beginning;

        Debug.Log(index.worldEvent.eventType);

        while (index.future != null)
        {
            index = index.future;
            Debug.Log(index.worldEvent.eventType);
        }
    }


    public void displayActionEvent()
    {
        currentActionToggle = events[eventIndex].eventType.ToString();
        //Debug.Log(display.GetComponent<TMPro.TextMeshProUGUI>().text);
        display.GetComponent<TMPro.TextMeshProUGUI>().text = currentActionToggle;
    }

    public void incrementIndex()
    {
        eventIndex++;
        if ((events.Count - 1) < eventIndex)
        {
            eventIndex = 0;
        }
        displayActionEvent();
        
    }

    public void deincrementIndex()
    {
        eventIndex--;

        if(eventIndex < 0)
        {
            eventIndex = (events.Count -1);
        }
        displayActionEvent();
    }

    public void takeTurn()
    {
        timeLine.InsertMomentAtPresent(new Moment(events[eventIndex]));
        displayTimeLine();
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && canToggle)
        {
            canToggle = false;
            deincrementIndex();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && canToggle)
        {
            canToggle = false;
            incrementIndex();
        }

        if (!Input.anyKey)
        {
            canToggle = true;
        }

    }


}

public enum TEST_UI_TAB
{
    CREATE_WORLD,
    CREATE_CHARACTER,
    TAKE_TURN,
    PROCESS_TURN,
    EXIT
}
