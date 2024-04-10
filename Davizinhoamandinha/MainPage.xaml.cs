using Microsoft.Maui.Controls;

namespace Davizinhoamandinha;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
  
	
	}
    private void ClicouBotaoComida(object sender,EventArgs args)
    {
       girafa.SetComida(girafa.GetComida()+0.1);
       prgressBarComida.Progress=girafa.GetComida();

    }
    private  void ClicouBotaoAgua (object sender,EventArgs args)	
    { 
       girafa.SetAgua(girafa.GetAgua()+0.1);
       prgressBarAgua.Progress=girafa.GetAgua();

    }

     private  void ClicouBotaoCarinho (object sender,EventArgs args)
     {
        girafa.SetCarinho(girafa.GetCarinho()+0.1);
        PrgressBarCarinho.Progress=girafa.GetCarinho();

     }
   

        


}

