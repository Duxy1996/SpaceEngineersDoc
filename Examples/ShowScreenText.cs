

//GLOBAL VARS///
String[] Name_of_LCD = {};

void Main()
{
	IMyTextPanel tPanel = GridTerminalSystem.GetBlockWithName(Name_of_LCD[0]) as IMyTextPanel;  
    tPanel.WritePublicText("Hello world,by Carlos", true);    
    tPanel.ShowTextureOnScreen();      
    tPanel.ShowPublicTextOnScreen(); 
}
