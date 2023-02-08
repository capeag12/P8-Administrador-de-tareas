using P8_Administrador_de_tareas.MVVM.Modelo;
using P8_Administrador_de_tareas.MVVM.ViewModel;
using System.Collections.ObjectModel;

namespace P8_Administrador_de_tareas.MVVM.View;

public partial class ViewAdd : ContentPage
{
	AddVM añadirVM;

    public ViewAdd(ObservableCollection<Categoria> listaCategorias, ObservableCollection<Tarea> listaTareas)
    {
        InitializeComponent();
        this.añadirVM = new AddVM(listaCategorias,listaTareas);
        BindingContext = añadirVM;
    }
}