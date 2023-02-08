using P8_Administrador_de_tareas.MVVM.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Administrador_de_tareas.MVVM.ViewModel
{
    public class AddVM
    {
        public ObservableCollection<Categoria> ListaCategorias { get; set; }
        public ObservableCollection<Tarea> ListaTareas { get; set; }

        public AddVM(ObservableCollection<Categoria> listaCategorias, ObservableCollection<Tarea> listaTareas)
        {
            
            ListaCategorias = listaCategorias;
            ListaTareas = listaTareas;
        }
    }
}
