using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroEvaluaciones.UI.Registros
{
    public partial class rEvaluaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                LlenaCombo();
            }
        }

        private void LlenaCombo()
        {
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            RepositorioBase<Categoria> repositoriy = new RepositorioBase<Categoria>();

            EstudianteDropDownList.DataSource = repositorio.GetList(t => true);
            EstudianteDropDownList.DataValueField = "IdEstudiante";
            EstudianteDropDownList.DataTextField = "NombreEstudiante";
            EstudianteDropDownList.DataBind();

            CategoriaDropDownList.DataSource = repositoriy.GetList(t => true);
            CategoriaDropDownList.DataValueField = "IdCategoria";
            CategoriaDropDownList.DataTextField = "NombreCategoria";
            CategoriaDropDownList.DataBind();
        }
    }
}