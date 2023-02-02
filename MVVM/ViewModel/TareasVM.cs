using P8_Administrador_de_tareas.MVVM.Modelo;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Administrador_de_tareas.MVVM.ViewModel
{
    class TareasVM
    {
        public TareasVM()
        {
            this.ListaCategorias= new ObservableCollection<Categoria>() {
                new Categoria("Categoria 1", new ObservableCollection<Tarea>() { new Tarea("Tarea 1")}) ,
                new Categoria("Categoria 2", new ObservableCollection<Tarea>() { new Tarea("Tarea 2")}) ,

            };
        }
        [AlsoNotifyFor("ListaTareas")]
        public ObservableCollection<Categoria> ListaCategorias { get; set; }


        public ObservableCollection<Tarea> ListaTareas { get {
                ObservableCollection<Tarea> listaTarea = new ObservableCollection<Tarea>();
                foreach (var cat in ListaCategorias)
                {
                    foreach (var item in cat.ListaTareas)
                    {
                        listaTarea.Add(item);
                    }
                }

                return listaTarea; 
            } set {
                ObservableCollection<Tarea> listaTarea = new ObservableCollection<Tarea>();
                foreach (var cat in ListaCategorias)
                {
                    foreach (var item in cat.ListaTareas)
                    {
                        listaTarea.Add(item);
                    }
                }
                this.ListaTareas = listaTarea;
            } }

        
    }
}
