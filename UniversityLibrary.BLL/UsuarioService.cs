using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.ENTITIES;

namespace LibreriaUniversitaria.BLL
{
    public class UsuarioService
    {
        private FirebaseHelper firebase = new FirebaseHelper();

        public async Task<bool> CorreoExisteAsync(string correo)
        {
            var usuarios = await firebase.ReadAsync<Dictionary<string, Usuario>>("Usuarios");

            if (usuarios == null || usuarios.Count == 0)
                return false;

            return usuarios.Any(u => u.Value.correo.Equals(correo, StringComparison.OrdinalIgnoreCase));
        }


        public async Task<Usuario> ObtenerOCrearUsuario(string correo)
        {
            var usuarios = await firebase.ReadAsync<Dictionary<string, Usuario>>("Usuarios");

            if (usuarios == null || usuarios.Count == 0)
            {
                // La colección está vacía, crear el primer usuario
                var nuevoUsuario = CrearNuevoUsuario(correo);
                await firebase.CreateAsync("Usuarios", nuevoUsuario);
                return nuevoUsuario;
            }

            var item = usuarios.FirstOrDefault(u => u.Value.correo.Equals(correo, StringComparison.OrdinalIgnoreCase));

            if (item.Value != null)
            {
                return item.Value.tipo_usuario_id == 1 ? item.Value : null;
            }

            // Usuario no existe, crearlo
            var usuarioNuevo = CrearNuevoUsuario(correo);
            await firebase.CreateAsync("Usuarios", usuarioNuevo);
            return usuarioNuevo;
        }

        private Usuario CrearNuevoUsuario(string correo)
        {
            return new Usuario
            {
                correo = correo,
                nombre = GenerarNombreDesdeCorreo(correo),
                tipo_usuario_id = 1,
                prestamosActivos = 0,
                historialPrestamos = Array.Empty<string>(),
                multas = Array.Empty<string>()
            };
        }

        private string GenerarNombreDesdeCorreo(string correo)
        {
            try
            {
                string usuario = correo.Split('@')[0];
                usuario = new string(usuario.TakeWhile(c => !char.IsDigit(c)).ToArray());

                string[] partes = usuario.Split('.');
                if (partes.Length == 2)
                {
                    string nombre = char.ToUpper(partes[0][0]) + partes[0].Substring(1);
                    string apellido = char.ToUpper(partes[1][0]) + partes[1].Substring(1);
                    return $"{nombre} {apellido}";
                }

                return usuario;
            }
            catch
            {
                return correo;
            }
        }
    }
}
