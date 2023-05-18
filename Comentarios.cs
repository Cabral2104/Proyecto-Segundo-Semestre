using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Segundo_Semestre
{
    internal class Comentarios
    {
        public interface IComentarios
        {
            void AggComentario(string comentario);
            List<string> TomarComentarios();
        }
        //The IComentarios interface provides a common structure for adding comments and
        //retrieving a list of stored comments. Classes that implement this interface will
        //need to provide specific logic for adding and retrieving comments based on their
        //needs.
        public class ComentarioTienda : IComentarios
        {
            private List<string> comentarios = new List<string>();
            public void AggComentario(string comentario)
            {
                comentarios.Add(comentario);

            }
            public List<string> TomarComentarios()
            {
                return comentarios;
            }
        }
        //ComentarioTienda implements the functionality of adding comments to a list and
        //retrieving the complete list of comments. This allows the class to act as a comment
        //storage for a store or similar entity.
    }
}
