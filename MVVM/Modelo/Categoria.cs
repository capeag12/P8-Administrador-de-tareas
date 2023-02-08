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
    public class Categoria
    {
        private int id;
        private static int idAuto=1;
        public string NombreCategoria { get; set; }

        private double tareasTotales;
        private double tareasRestantes;
        private double tareasCompletadas;
        private double porcentajeCompletadas;


       

        public Categoria(string nombreCategoria)
        {
            id = idAuto;
            NombreCategoria = nombreCategoria;
            this.tareasTotales= 0;
            this.tareasRestantes= 0;
            this.tareasCompletadas= 0;
            this.porcentajeCompletadas= 0;
            idAuto++;

            obtenerPorcentajeCompletadas(); obtenerTareasRestantes();

        }

        public int ID { get { return id; }  }

        void obtenerPorcentajeCompletadas()
        {
            try
            {
                this.PorcentajeCompletadas = tareasCompletadas / tareasTotales;
                Console.WriteLine();
            }
            catch (Exception)
            {

                
            }
            
        }

        void obtenerTareasRestantes()
        {
            this.TareasRestantes = TareasTotales-tareasCompletadas;
        }

        public double TareasTotales { get { return tareasTotales; } set { tareasTotales =value; obtenerPorcentajeCompletadas(); obtenerTareasRestantes(); } }

        public double TareasRestantes { get { return tareasRestantes; } set { tareasRestantes= value; } }

        public double TareasCompletadas { get { return tareasCompletadas;} set { tareasCompletadas = value; obtenerPorcentajeCompletadas(); obtenerTareasRestantes(); } }

        public double PorcentajeCompletadas { get { return porcentajeCompletadas;} set { porcentajeCompletadas= value; } }


    }    
}

