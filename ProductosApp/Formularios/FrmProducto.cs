using AppCore.Interfaces;
using Domain.Entities.Inventories;
using Domain.Enums;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios
{    
    public partial class FrmProducto : Form
    {
        public IProductService PModel { get; set; }
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(MeasureUnit))
                                              .Cast<object>()
                                              .ToArray()
                                          );
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = PModel.GetLastId() + 1,
                Nombre = txtNombre.Text,
                Descripcion = txtDesc.Text,
                //Existencia = (int)nudExist.Value,
                //Precio = nudPrice.Value,
                //FechaVencimiento = dtpCaducity.Value,
                UnidadMedida = (MeasureUnit)cmbMeasureUnit.SelectedIndex
            };

            PModel.Create(p);

            Dispose();
        }
    }
}
