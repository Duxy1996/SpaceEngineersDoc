void Main()       
{       
    IMyTextPanel tPanel2 = GridTerminalSystem.GetBlockWithName("lcdCabOne") as IMyTextPanel;

    List<IMyReactor> spanels = new List<IMyReactor>();   
    List<IMyTerminalBlock> allBlocks = new List<IMyTerminalBlock>();   
    GridTerminalSystem.GetBlocks(allBlocks); // Where allBlocks is a list type.    
    for (int i = 0; i < allBlocks.Count; i++)   {
       if (allBlocks[i] is IMyReactor)   
           spanels.Add((IMyReactor)allBlocks[i]); 
    }
    tPanel2.WritePublicText("\n", false);  
    tPanel2.ShowTextureOnScreen();             
    tPanel2.ShowPublicTextOnScreen();
    String formatZero = "0";
    for(int i = 0; i < spanels.Count;i++){
         if(i>9){formatZero = "";}
         spanels[i].GetActionWithName("OnOff").Apply(spanels[i]);
         tPanel2.WritePublicText(" Reactor"+formatZero+i+": "+spanels[i].Enabled, true);
         tPanel2.ShowTextureOnScreen();           
         tPanel2.ShowPublicTextOnScreen();
        if(i%5 == 0){
            tPanel2.WritePublicText("\n", true); 
            tPanel2.ShowTextureOnScreen();            
            tPanel2.ShowPublicTextOnScreen();
        }
    }        
} 
   
  
     
