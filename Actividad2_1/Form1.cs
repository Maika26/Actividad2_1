using Actividad2_1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Todo lo que se escriba aqui se ejecutara cuando se inicie el form
            DBColegio bd = new DBColegio();

            CBoxCurso.DataSource = bd.Cursos.ToList();
            CBoxCurso.DisplayMember = "Nombre";

        }

        private void CBoxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar los alumnos en la grilla del curso seleccionado
            DBColegio bd = new DBColegio();
            Curso cursoSeleccionado = (Curso)CBoxCurso.SelectedItem;
            List<Alumno> alumnosCurso = bd.Alumnos.Where
                (Alumno => Alumno.idCurso == cursoSeleccionado.idCurso).ToList();
            GridAlumnos.DataSource = alumnosCurso;

            GridAlumnos.Columns[0].Visible = false;
            GridAlumnos.Columns[3].Visible = false;
            GridAlumnos.Columns[4].Visible = false;

            // Cargar el nombre del profesor encargado del curso seleccionado
            txtProfesor.Text = cursoSeleccionado.Profesore.Nombre;

        }
    }
}
