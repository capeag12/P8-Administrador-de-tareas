using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P8_Administrador_de_tareas.MVVM.Modelo
{
    [AddINotifyPropertyChangedInterface]
    class Tarea
    {
        public string TextTarea { get; set; }

        public bool Completada { get; set;}
        public Tarea(string tarea)
        {
            this.TextTarea = tarea;
            Completada = false;
            
        }

        

    }
}
