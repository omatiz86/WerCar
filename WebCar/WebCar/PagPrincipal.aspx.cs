using System;
using Entities;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCar
{
    public partial class PagPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();
            }

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            if (TxtPlacaVehiculo.Text != null)
            {


                Vehiculo v = new Vehiculo{                
                    MATRICULA  = TxtPlacaVehiculo.Text,
                    MARCA = txtMarcaVehiculo.Text,
                    MODELO = System.Convert.ToInt16(txtModelo.Text),
                    ESTADO = txtEstado.Text,
                };
            
                Vehiculo_BD.InsertaVehiculo(v);
                LimpiaCampos();
                CargarGrilla();
            }

        }

        protected void CargarGrilla()
        {
            List<Vehiculo> lst = new List<Vehiculo>();
            lst = Vehiculo_BD.ConsultarVehiculoCliente().ToList();
            
            gvResult.DataSource = lst;
            gvResult.DataBind();
        }


        protected void LimpiaCampos()
        {            
            txtEstado.Text = string.Empty;
            txtMarcaVehiculo.Text = string.Empty;            
            txtModelo.Text = string.Empty;
            TxtPlacaVehiculo.Text = string.Empty;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Vehiculo v = new Vehiculo
            {
                MATRICULA = TxtPlacaVehiculo.Text
            };

            Vehiculo_BD.EliminarVehiculo(v);
            LimpiaCampos();
            CargarGrilla();


        }
    }
}