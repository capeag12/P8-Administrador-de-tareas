using P8_Administrador_de_tareas.MVVM.View;

namespace P8_Administrador_de_tareas;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ViewTareas();
	}
}
