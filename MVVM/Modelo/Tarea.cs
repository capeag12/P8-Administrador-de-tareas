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
        private int id;
        private static int idAutoInc = 1;
        public string TextTarea { get; set; }

        public bool Completada { get; set;}
        private int idCategoria;
        public Tarea(string tarea, int idCat)
        {
            id = idAutoInc;
            this.TextTarea = tarea;
            Completada = false;
            idAutoInc++;
            idCategoria = idCat;
        }

        public int Id { get { return id; } }
        public int IdCategoria { get { return idCategoria; } }



    }
}
