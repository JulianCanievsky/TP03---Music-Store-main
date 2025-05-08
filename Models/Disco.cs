namespace TP03_MusicStore.Models;

public class Disco
{
    public int Id { get; private set; }
    public string Titulo { get; private set; }
    public string Artista { get; private set; }
    public string Productor { get; private set; }
    public string Genero { get; private set; }
    public string Foto { get; private set; }
    public List<string> Temas { get; private set; }

    public Disco(int Id, string titulo, string artista, string productor, string genero, string foto, List<string> temas)
    {
        Id = this.Id;
        Titulo = titulo;
        Artista = artista;
        Productor = productor;
        Genero = genero;
        Foto = foto;
        Temas = temas;
    }
} 