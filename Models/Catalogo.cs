namespace TP03_MusicStore.Models;

public static class Catalogo
{
    public static Dictionary<int, Disco> Discos { get; private set; }

    public static void InicializarCatalogo()
    {
        
    Discos =  new Dictionary<int, Disco>();

        // Disco 1 - León Gieco
        var temas1 = new List<string> { "Sólo le pido a Dios", "La memoria", "El ángel de la bicicleta" };
        Discos.Add(1, new Disco(1, "Sólo le pido a Dios", "León Gieco", "Gustavo Santaolalla", "Folk Rock", "soloLePidoADios.jpg", temas1));

        // Disco 2 - Los Gatos
        var temas2 = new List<string> { "La balsa", "Ayer nomás", "Seremos amigos" };
        Discos.Add(2, new Disco(2, "Los Gatos", "Los Gatos", "Jorge Álvarez", "Rock", "losGatos.jpg", temas2));

        // Disco 3 - Soda Stereo
        var temas3 = new List<string> { "De música ligera", "Un millón de años luz", "Cuando pase el temblor" };
        Discos.Add(3, new Disco(3, "Canción Animal", "Soda Stereo", "Gustavo Cerati", "Rock", "cancionAnimal.jpg", temas3));

        // Disco 4 - Pescado Rabioso
        var temas4 = new List<string> { "Muchacha (Ojos de papel)", "Rasguña las piedras", "Noche de amigos" };
        Discos.Add(4, new Disco(4, "Artaud", "Pescado Rabioso", "Luis Alberto Spinetta", "Rock", "aratud.png", temas4));

        // Disco 5 - Vox Dei
        var temas5 = new List<string> { "La muralla verde", "El extraño de pelo largo", "La bengala perdida" };
        Discos.Add(5, new Disco(5, "La Biblia", "Vox Dei", "Ricardo Soulé", "Rock", "laBiblia.jpg", temas5));

        // Disco 6 - Fito Páez
        var temas6 = new List<string> { "El amor después del amor", "La balada de Donna Helena", "Tango del pecado" };
        Discos.Add(6, new Disco(6, "El amor después del amor", "Fito Páez", "Fito Páez", "Rock", "elAmor.jpg", temas6));

        // Disco 7 - Los Redondos
        var temas7 = new List<string> { "La rubia tarada", "Vete de mí", "El final" };
        Discos.Add(7, new Disco(7, "La rubia tarada", "Patricio Rey y sus Redonditos de Ricota", "Indio Solari", "Rock", "laRubia.jpg", temas7));

        // Disco 8 - Serú Girán
        var temas8 = new List<string> { "Seminare", "Cuando ya me empiece a quedar solo", "La mamá de Jimmy" };
        Discos.Add(8, new Disco(8, "Seminare", "Serú Girán", "Charly García", "Rock", "seminare.jpg", temas8));
    }
} 