using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo
{
    class CargoEmp
    {
        private int CodCar;
        private string Cargo;
        private double Sueldo;

        public CargoEmp()
        {
            CodCar = 0;
            Cargo = "";
            Sueldo = 0.0;
        }
        
        public CargoEmp(int codCar, string cargo, double sueldo)
        {
            CodCar = codCar;
            Cargo = cargo;
            Sueldo = sueldo;
        }

        public int gsCodCar
        {
            get { return CodCar; }
            set { CodCar = value; }
        }

        public string gsCargo
        {
            get { return Cargo; }
            set { Cargo = value; }
        }

        public double gsSueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }

        public void asd()
        {
            Form1 x = new Form1();
            x.ShowDialog();
        }
    }
}
