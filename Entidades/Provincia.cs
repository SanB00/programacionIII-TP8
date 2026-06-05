namespace Entidades {
    public class Provincia {
        private string id;
        private string nombre;

        public Provincia() {

        }

        public void setId(string id) {
            this.id = id;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public string getId() {
            return id;
        }

        public string getNombre() {
            return nombre;
        }
    }
}
