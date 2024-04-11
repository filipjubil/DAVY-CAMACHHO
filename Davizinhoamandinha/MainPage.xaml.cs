using Microsoft.Maui.Controls;

namespace Davizinhoamandinha;

public partial class MainPage : ContentPage
{
   Girafa girafa; paianimal atual;
   
   Girafa Agua;
   Girafa Carinho;
   Girafa Comida;

	public MainPage()
	{ 
      girafa= new Girafa();

      ImgDoPersonagem.Source=atual.GetArquivo();
  
	
	}
    private void ClicouBotaoComida(object sender,EventArgs args)
    {
       girafa.SetComida(girafa.GetComida()+0.1);
       ProgressComida.Progress=girafa.GetComida();

    }
    private  void ClicouBotaoAgua (object sender,EventArgs args)	
    { 
       girafa.SetAgua(girafa.GetAgua()+0.1);
       ProgressAgua.Progress=girafa.GetAgua();

    }

     private  void ClicouBotaoCarinho (object sender,EventArgs args)
     {
        girafa.SetCarinho(girafa.GetCarinho()+0.1);
        ProgressCarinho.Progress=girafa.GetCarinho();

     }
   

        


}

