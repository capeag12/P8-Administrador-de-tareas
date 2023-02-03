using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Administrador_de_tareas.MVVM.Modelo
{
    [AddINotifyPropertyChangedInterface]
    class Categoria
    {
        private ObservableCollection<Tarea> listaTareas;
        public string NombreCategoria { get; set; }

        private int tareasTotales;
        private int tareasRestantes;
        private int tareasCompletadas;
        private double porcentajeCompletadas;


        public ObservableCollection<Tarea> ListaTareas { get { return listaTareas; } set { this.listaTareas = value;
                obtenerTareasTotales();
                obtenerTareasRestantes();
                obtenerTareasCompletadas();
                obtenerPorcentajeCompletadas();
            } }

        public Categoria(string nombreCategoria, ObservableCollection<Tarea> listaTareas)
        {
            this.listaTareas = listaTareas;
            NombreCategoria = nombreCategoria;
            this.tareasTotales= 0;
            this.tareasRestantes= 0;
            this.tareasCompletadas= 0;
            this.porcentajeCompletadas= 0;
            obtenerTareasTotales();
            obtenerTareasRestantes();
            obtenerTareasCompletadas();
            obtenerPorcentajeCompletadas();
            
        }

        void obtenerTareasTotales()
        {
            this.TareasTotales = listaTareas.Count;
            
        }

        void obtenerTareasRestantes()
        {
            this.TareasRestantes= listaTareas.Where(l => l.Completada==false).Count();
        }

        void obtenerTareasCompletadas()
        {
            this.TareasCompletadas = listaTareas.Where(l=>l.Completada = true).Count();
        }

        void obtenerPorcentajeCompletadas()
        {
            this.PorcentajeCompletadas = tareasCompletadas / tareasTotales;
        }

        public int TareasTotales { get { return tareasTotales; } set { tareasTotales = value; } }

        public int TareasRestantes { get { return tareasRestantes; } set { tareasRestantes= value; } }

        public int TareasCompletadas { get { return tareasCompletadas;} set { tareasCompletadas = value; } }

        public double PorcentajeCompletadas { get { return porcentajeCompletadas;} set { porcentajeCompletadas= value; } }


    }    
}

