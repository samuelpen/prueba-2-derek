using APPEXAMEN.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPEXAMEN.ViewModel
{
    public class SQLViewModel
    {
        private SQLiteConnection conec;
        private static SQLViewModel instance;
        public static SQLViewModel Instance
        {
            get
            {
                if (instance == null) { throw new Exception("Falta inicializar"); }
                return instance;
            }
        }

        public static void Inicializador(String filename)
        {
            if (filename == null) { throw new ArgumentException(); }
            if (instance != null) { instance.conec.Close(); }
            instance = new SQLViewModel(filename);
        }

        private SQLViewModel(String DbPath)
        {
            conec = new SQLiteConnection(DbPath);
            conec.CreateTable<Notes>();
        }
        public String EstadoMensaje;

        public int AddNew(string contents)
        {
            int result = 0;

            try
            {
                result = conec.Insert(new Notes()
                {
                    Contents = contents
                });
                EstadoMensaje = string.Format("Lo hicite bien");
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }

            return result;
        }

        public IEnumerable<Notes> GetAll()
        {
            try
            {
                return conec.Table<Notes>();
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return Enumerable.Empty<Notes>();
        }
    }
}
