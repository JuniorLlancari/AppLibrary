using MongoDB.Bson.Serialization.Attributes;

namespace AppLibrary.Core.Entities
{
    [BsonCollection("Autor")]
    public class AutorEntity : Document
    {

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("apellido")]
        public string Apellido { get; set; }

        [BsonElement("gradoAcademico")]
        public string GradoAcademico { get; set; }

        [BsonElement("nombreCompleto")]
        public string NombreCompleto { get; set; }
    }
}
