using Practicas.Cap19.AppDbContext;
using Practicas.Cap19.Domain.Model;
using Practicas.Cap19.Domain.Services;
using Practicas.Cap19.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Cap19
{
    public partial class frmNotas : Form
    {
        private NotasDbContext _context;
        private IAlumnosRepository _alumnoRepository;

        public frmNotas()
        {
            InitializeComponent();
            _context = new NotasDbContext();
            _context.Alumnos = new List<Alumno>();
            _alumnoRepository = new AlumnoRepository(_context);

            ConfigInit();
        }

        private void ConfigInit()
        {
            cbPracticas.Items.Add("Practica 1");
            cbPracticas.Items.Add("Practica 2");
            cbPracticas.Items.Add("Practica 3");
            cbPracticas.Items.Add("Practica 4");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void Registrar()
        {
            var nombreAlumno = txtNombre.Text;
            var practica = cbPracticas.SelectedItem;
            var nota = Convert.ToDouble(txtNota.Text);

            var alumnosServices = new AlumnoServices(_alumnoRepository);

            var resultado = alumnosServices.AgregarNota(nombreAlumno, practica.ToString(), nota);

            if(resultado == true)
            {
                MostrarNotas();
                MessageBox.Show("NOTA INGRESADA CORRECTAMENTE");
            }
        }

        private void MostrarNotas()
        {
            lbDatos.Items.Clear();
            foreach(var alumno in _alumnoRepository.ListadoAlumnos())
            {
                lbDatos.Items.Add("--------------------------------------------------");
                lbDatos.Items.Add($"{alumno.Nombres}");
                lbDatos.Items.Add("--------------------------------------------------");
                foreach (var nota in alumno.Notas)
                {
                    var alumnoNota = $"{nota.Practica} - {nota.Calificacion}";
                    lbDatos.Items.Add(alumnoNota);
                }
                lbDatos.Items.Add("");
            }
        }
    }
}
