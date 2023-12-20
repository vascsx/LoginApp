using LoginApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Date
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexaoBD;


        // public UsuarioData UsuarioDataTable { get; set; }[

        public SQLiteData(string path)
        {
            _conexaoBD = new SQLiteAsyncConnection(path);

            _conexaoBD.CreateTableAsync<Usuario>().Wait();


        }

    }
}
