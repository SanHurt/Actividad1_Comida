using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Actividad1_Comida
{
    class Plato: INotifyPropertyChanged
    {
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if(_nombre != value)
                {
                    _nombre = value;
                    NotifyPropertyChanged("Nombre");
                }
            }
        }
        private string _imagen;
        public string Imagen
        {
            get => _imagen;
            set
            {
                if (_imagen != value)
                {
                    _imagen = value;
                    NotifyPropertyChanged("Imagen");
                }
            }
        }

        private string _tipo;
        public string Tipo
        {
            get => _tipo;
            set
            {
                if (_tipo != value)
                {
                    _tipo = value;
                    NotifyPropertyChanged("Tipo");
                }
            }
        }
        private bool _gluten;
        public bool Gluten
        {
            get => _gluten;
            set
            {
                if (_gluten != value)
                {
                    _gluten = value;
                    NotifyPropertyChanged("Gluten");
                }
            }
        }
        private bool _soja;
        public bool Soja
        {
            get => _soja;
            set
            {
                if (_soja != value)
                {
                    _soja = value;
                    NotifyPropertyChanged("Soja");
                }
            }
        }
        private bool _leche;
        public bool Leche
        {
            get => _leche;
            set
            {
                if (_leche != value)
                {
                    _leche = value;
                    NotifyPropertyChanged("Leche");
                }
            }
        }
        private bool _sulfitos;
        public bool Sulfitos
        {
            get => _sulfitos;
            set
            {
                if (_sulfitos != value)
                {
                    _sulfitos = value;
                    NotifyPropertyChanged("Sulfitos");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
        }

        internal static ObservableCollection<Plato> GetSamples(string rutaImagenes)
        {
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }
    }
}
