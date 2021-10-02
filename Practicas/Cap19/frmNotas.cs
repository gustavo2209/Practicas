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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void Registrar()
        {
            var nombreAlumno = txtNombre.Name;
            var practica = cbPracticas.SelectedText;
            var nota = Convert.ToDouble(txtNota.Text);

            var alumnosServices = new AlumnoServices(_alumnoRepository);

            var resultado = alumnosServices.AgregarNota(nombreAlumno, practica, nota);

            if(resultado == true)
            {
                MessageBox.Show("NOTA INGRESADA CORRECTAMENTE");
            }
        }
    }
}
