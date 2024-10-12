using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo
{
    class Empleado
    {
        private int CodEmp;
        private string NomEmp;
        private string ApeEmp;
        private string DniEmp;
        private int EdadEmp;
        private char SexEmp;
        private int CodCar;

        public Empleado()
        {
            CodEmp = 0;
            NomEmp = "";
            ApeEmp = "";
            DniEmp = "";
            EdadEmp = 0;
            SexEmp = ' ';
            CodCar = 0;
        }

        public Empleado(int codEmp, string nomEmp, string apeEmp, string dniEmp, int edadEmp, char sexEmp, int codCar)
        {
            CodEmp = codEmp;
            NomEmp = nomEmp;
            ApeEmp = apeEmp;
            DniEmp = dniEmp;
            EdadEmp = edadEmp;
            SexEmp = sexEmp;
            CodCar = codCar;
        }

        public int gsCodEmp
        {
            get { return CodEmp; }
            set { CodEmp = value; }
        }
        
        public string gsNomEmp
        {
            get { return NomEmp; }
            set { NomEmp = value; }
        }
        
        public string gsApeEmp
        {
            get { return ApeEmp; }
            set { ApeEmp = value; }
        }
        
        public string gsDniEmp
        {
            get { return DniEmp; }
            set { DniEmp = value; }
        }
        
        public int gsEdadEmp
        {
            get { return EdadEmp; }
            set { EdadEmp = value; }

        }
        
        public char gsSexEmp
        {
            get { return SexEmp; }
            set { SexEmp = value; }
        }
        
        public int gsCodCar
        {
            get { return CodCar; }
            set { CodCar = value; }
        }


    }
}
