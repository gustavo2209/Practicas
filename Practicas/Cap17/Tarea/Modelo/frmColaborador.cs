using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap17.Tarea.Modelo
{
    public partial class frmColaborador : Form
    {

        IColaborador colaborador = null;

        public frmColaborador()
        {
            InitializeComponent();
            InitValues();
        }

        private void InitValues()
        {
            cbNivel.Items.Add(InstructorNivelEnum.Estable.ToString());
            cbNivel.Items.Add(InstructorNivelEnum.Invitado.ToString());

            cbEstado.Items.Add(EmpleadoEstadoEnum.Administrativo.ToString());
            cbEstado.Items.Add(EmpleadoEstadoEnum.Asistente.ToString());
            cbEstado.Items.Add(EmpleadoEstadoEnum.Directivo.ToString());
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            try
            {
                if (colaborador is Instructor)
                {
                    ((Instructor)colaborador).Nivel = (InstructorNivelEnum)Enum.Parse(typeof(InstructorNivelEnum), cbNivel.SelectedItem.ToString());
                }
                else
                {
                    ((Empleado)colaborador).Estado = (EmpleadoEstadoEnum)Enum.Parse(typeof(EmpleadoEstadoEnum), cbEstado.SelectedItem.ToString());
                }

                colaborador.Nombres = txtNombres.Text;
                colaborador.ApePaterno = txtApePaterno.Text;
                colaborador.ApeMaterno = txtApeMaterno.Text;
                colaborador.FecIngreso = dtpFechaIngreso.Value;
                colaborador.FecNacimiento = dtpFechaNacimiento.Value;

                lblMontoBonificacion.Text = colaborador.CalcularBonificacion().ToString();
                lblTiempoServicio.Text = colaborador.CalcularTiempoServicio().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void rbInstructor_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionarColaborador();
        }

        private void SeleccionarColaborador()
        {
            if (rbEmpleado.Checked)
                colaborador = new Empleado();
            else
                colaborador = new Instructor();
        }
    }
}
