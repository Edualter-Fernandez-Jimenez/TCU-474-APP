using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carga_Microempresarios_1.Logic
{
    public class Logica
    {
        public Logica()
        {

        }

        public string revisardatos(String dato)
        {
            if (dato == null)
            {
                return " ";
            }
            return dato;
        }




    }
}