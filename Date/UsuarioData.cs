using LoginApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Date
{
    public class UsuarioData
    {
        private SQLiteAsyncConnection _conexaoBD;

        public UsuarioData(SQLiteAsyncConnection conexaoBD)
        {
            _conexaoBD = conexaoBD;
        }

        public Task<List<Usuario>> ListarUsuario()
        {
            var lista = _conexaoBD
                .Table<Usuario>()
                .ToListAsync();

            return lista;
        }

        public Task<Usuario> ObtemUsuario(string email, string senha)
        {
            var usuario = _conexaoBD
                .Table<Usuario>()
                .Where(x => x.Email == email && x.Senha == senha)
                .FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<int> SalvarUsuario(Usuario usuario)
        {
            var usuarioIsSalvo = await ObtemUsuario(usuario.Id);
            
            if(usuarioIsSalvo == null)
            {
                return await _conexaoBD.InsertAsync(usuario);
            }
            else
            {
                return await _conexaoBD.UpdateAsync(usuario);
            }
        }

        public Task<Usuario> ObtemUsuario(Guid id)
        {
            var usuario = _conexaoBD
                .Table<Usuario>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<int> ExcluirUsuario(Guid id)
        {
            return await _conexaoBD.DeleteAsync(id);
        }

    }
}
