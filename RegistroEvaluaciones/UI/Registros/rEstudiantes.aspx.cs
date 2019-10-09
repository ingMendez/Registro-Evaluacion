using BLL;
using Entities;
using RegistroEvaluaciones.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroEvaluaciones.UI.Registros
{
    public partial class rEstudiante : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");


        }
        public Estudiante LlenarClase()
        {
            Estudiante _estudiante = new Estudiante();

            _estudiante.IdEstudiante = Utils.ToInt(EstudianteId.Text);
            bool resultado = DateTime.TryParse(FechaTextBox.Text, out DateTime fecha);
            _estudiante.Fecha = fecha;
            _estudiante.NombreEstudiante = NombreTextBox.Text;
            _estudiante.Matricula = MatriculaTextBox.Text;

            return _estudiante;
        }
        public void LlenarCampos(Estudiante _estudiante)
        {
            FechaTextBox.Text = _estudiante.Fecha.ToString("yyyy-MM-dd");
            NombreTextBox.Text = _estudiante.NombreEstudiante;
            MatriculaTextBox.Text = _estudiante.Matricula;
        }

        protected void Limpiar()
        {
            EstudianteId.Text = "0";
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            NombreTextBox.Text = "";
            MatriculaTextBox.Text = "";
        }

        private bool Validar()
        {
            bool estado = false;
            if (String.IsNullOrWhiteSpace(EstudianteId.Text))
            {
                Utils.ShowToastr(this, "Debe tener un id válido.", "Error", "error");
                estado = true;
            }
            if (String.IsNullOrWhiteSpace(FechaTextBox.Text))
            {
                Utils.ShowToastr(this, "Debe tener una Fecha", "Error", "error");
                estado = true;
            }
            if (String.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                Utils.ShowToastr(this, "Debe tener una Nombre.", "Error", "error");
                estado = true;
            }
            if (String.IsNullOrWhiteSpace(MatriculaTextBox.Text))
            {
                Utils.ShowToastr(this, "Debe tener una Matricula.", "Error", "error");
                estado = true;
            }
            return estado;
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();

            var _estudiante = repositorio.Buscar(Utils.ToInt(EstudianteId.Text));
            if (_estudiante != null)
            {
                Utils.ShowToastr(this, "Busqueda exitosa", "Exito", "success");
                LlenarCampos(_estudiante);
            }
            else
            {
                Limpiar();
                Utils.ShowToastr(this, "No existe la Factura especificada", "Error", "error");
            }
        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void guadarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            Estudiante _estudiante = new Estudiante();

            if (Validar())
            {
                return;
            }
            else
            {
                _estudiante = LlenarClase();

                if (Utils.ToInt(EstudianteId.Text) == 0)
                {
                    paso = repositorio.Guardar(_estudiante);
                    Utils.ShowToastr(this, "Guardado", "Exito", "success");
                    Limpiar();
                }
                else
                {
                    RepositorioBase<Estudiante> repository = new RepositorioBase<Estudiante>();
                    int id = Utils.ToInt(EstudianteId.Text);
                    _estudiante = repository.Buscar(id);

                    if (_estudiante != null)
                    {
                        paso = repositorio.Modificar(LlenarClase());
                        Utils.ShowToastr(this, "Modificado", "Exito", "success");
                        Limpiar();
                    }
                    else
                        Utils.ShowToastr(this, "Id no existe", "Error", "error");
                }

                if (paso)
                {
                    Limpiar();
                }
                else
                    Utils.ShowToastr(this, "No se pudo guardar", "Error", "error");
            }
        }

        protected void eliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            int id = Utils.ToInt(EstudianteId.Text);

            var sugerencia = repositorio.Buscar(id);

            if (sugerencia != null)
            {
                if (repositorio.Eliminar(id))
                {
                    Utils.ShowToastr(this, "Eliminado", "Exito", "success");
                    Limpiar();
                }
                else
                    Utils.ShowToastr(this, "No se pudo eliminar", "Error", "error");
            }
            else
                Utils.ShowToastr(this, "No existe", "Error", "error");
        }
    }
}