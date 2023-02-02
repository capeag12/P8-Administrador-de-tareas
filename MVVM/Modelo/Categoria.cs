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
        public string NombreCategoria { get; set; }

        [AlsoNotifyFor("TareasTotales", "PorcentajeCompletado", "TareasRestantes","TareasCompletadas")]
        public ObservableCollection<Tarea> ListaTareas { get; set; }

        [AlsoNotifyFor("TareasTotales", "PorcentajeCompletado")]
        public int TareasCompletadas { get { return ListaTareas.Where(t => t.Completada == true).Count(); } set { this.TareasCompletadas = ListaTareas.Where(t => t.Completada == true).Count(); } }

        public int TareasTotales { get { return this.ListaTareas.Count; } set { this.TareasTotales = ListaTareas.Count; } }

        public int TareasRestantes { get { return this.TareasTotales - this.TareasCompletadas; } set { this.TareasRestantes = this.TareasTotales - this.TareasCompletadas; } }

        public Categoria(string nombreCategoria, ObservableCollection<Tarea> listaTareas)
        {
        this.NombreCategoria = nombreCategoria;
        this.ListaTareas = listaTareas;


    }
    public double PorcentajeCompletado { get { return (TareasCompletadas / TareasTotales); } set { this.PorcentajeCompletado = (TareasCompletadas / TareasTotales); } }



}
        
    }

