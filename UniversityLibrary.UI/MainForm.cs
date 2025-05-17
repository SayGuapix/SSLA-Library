using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.ENTITIES;
using LibreriaUniversitaria.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibrary.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            {
                Usuario usuario = Datos.UsuarioActual;

                if (usuario != null)
                {
                    lblNombre.Text = usuario.nombre;
                    lblTipo.Text = "Estudiante";
                    lblPrestamos.Text = $"Préstamos activos:  {usuario.prestamosActivos}";

                    await CargarMultasPendientes();
                }
                else
                {
                    MessageBox.Show("Usuario no identificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }
        private async Task CargarMultasPendientes()
        {
            var firebase = new FirebaseHelper(); // Tu clase de ayuda para Firebase
            var usuario = Datos.UsuarioActual;

            // Verificar si el usuario tiene alguna multa registrada
            if (usuario.multas == null || usuario.multas.Length == 0)
            {
                lblMultas.Text = "Multas pendientes:  0";
                return;
            }

            // Leer todas las multas
            var todasMultas = await firebase.ReadAsync<Dictionary<string, Multa>>("Multas");

            if (todasMultas != null)
            {
                var multasPendientes = todasMultas
                    .Where(m => usuario.multas.Contains(m.Key) && m.Value.estado_pago == false)
                    .Select(m => m.Value)
                    .ToList();

                if (multasPendientes.Any())
                {
                    decimal total = multasPendientes.Sum(m => m.monto);
                    lblMultas.Text = $"Multas pendientes:  {multasPendientes.Count} | Total:  ${total:F2}";
                }
            }
            else
            {
                lblMultas.Text = "No se pudieron cargar las multas.";
            }
        }

    }
}
