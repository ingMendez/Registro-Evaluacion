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
    public partial class rCategorias : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");


        }
        public Categoria LlenarClase()
        {
            Categoria _categoria = new Categoria();

            _categoria.IdCategoria = Utils.ToInt(CategoriaId.Text);
            bool resultado = DateTime.TryParse(FechaTextBox.Text, out DateTime fecha);
            _categoria.Fecha = fecha;
            _categoria.NombreCategoria = NombreTextBox.Text;

            return _categoria;
        }
        public void LlenarCampos(Categoria _categoria)
        {
            FechaTextBox.Text = _categoria.Fecha.ToString("yyyy-MM-dd");
            NombreTextBox.Text = _categoria.NombreCategoria;
        }

        protected void Limpiar()
        {
            CategoriaId.Text = "0";
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            NombreTextBox.Text = "";
        }

        private bool Validar()
        {
            bool estado = false;
            if (String.IsNullOrWhiteSpace(CategoriaId.Text))
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
                Utils.ShowToastr(this, "Debe tener una Descripcion.", "Error", "error");
                estado = true;
            }
            return estado;
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categoria> repositorio = new RepositorioBase<Categoria>();

            var _Categoria = repositorio.Buscar(Utils.ToInt(CategoriaId.Text));
            if (_Categoria != null)
            {
                Utils.ShowToastr(this, "Busqueda exitosa", "Exito", "success");
                LlenarCampos(_Categoria);
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
            RepositorioBase<Categoria> repositorio = new RepositorioBase<Categoria>();
            Categoria _categoria = new Categoria();

            if (Validar())
            {
                return;
            }
            else
            {
                _categoria = LlenarClase();

                if (Utils.ToInt(CategoriaId.Text) == 0)
                {
                    paso = repositorio.Guardar(_categoria);
                    Utils.ShowToastr(this, "Guardado", "Exito", "success");
                    Limpiar();
                }
                else
                {
                    RepositorioBase<Categoria> repository = new RepositorioBase<Categoria>();
                    int id = Utils.ToInt(CategoriaId.Text);
                    _categoria = repository.Buscar(id);

                    if (_categoria != null)
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
            RepositorioBase<Categoria> repositorio = new RepositorioBase<Categoria>();
            int id = Utils.ToInt(CategoriaId.Text);

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