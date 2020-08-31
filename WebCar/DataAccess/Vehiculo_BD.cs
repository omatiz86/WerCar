using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DataAccess
{
    public class Vehiculo_BD
    {

        public static void InsertaVehiculo(Vehiculo item)
        {
            using (Conect db = new Conect())
            {
                db.SP_VEHICULO_CREAR(item.MATRICULA,item.MARCA,item.MODELO, item.ESTADO);
            }
        }

        public static void EliminarVehiculo(Vehiculo item)
        {
            using (Conect db = new Conect())
            {
                db.SP_VEHICULO_ELIMINAR(item.MATRICULA);
            }
        }


        public static Vehiculos ConsultarVehiculoCliente()
        {
            List<SP_GENERAL_CONSULTARResult> lstDB = new List<SP_GENERAL_CONSULTARResult>();
            using (Conect db = new Conect())
            {
                lstDB = db.SP_GENERAL_CONSULTAR().ToList<SP_GENERAL_CONSULTARResult>();
            }

            Vehiculos lstRes = new Vehiculos();

            foreach (SP_GENERAL_CONSULTARResult item in lstDB)
            {
                lstRes.Add(new Vehiculo
                {
                   MATRICULA  = item.MATRICULA,
                   MARCA = item.MARCA,
                   ESTADO = item.ESTADO
                    //,MODELO = convert. item.MODELO
                   ,MODELO = System.Convert.ToInt16(item.MODELO),

                });
            }

            return lstRes;
        }


        //public static DataTable ListToDataTable<T>(List<T> items)
        //{
        //    DataTable dataTable = new DataTable(typeof(T).Name);
        //    PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        //    foreach (PropertyInfo prop in Props)
        //    {
        //        dataTable.Columns.Add(prop.Name);
        //    }

        //    foreach (T item in items)
        //    {
        //        var values = new object[Props.Length];
        //        for (int i = 0; i < Props.Length; i++)
        //        {
        //            values[i] = Props[i].GetValue(item, null);
        //        }

        //        dataTable.Rows.Add(values);
        //    }
        //    return dataTable;
        //}


    }
}
