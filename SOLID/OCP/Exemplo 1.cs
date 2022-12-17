namespace SOLID.OCP
{
    //Temos somente musica inicialmente
    public class Spotfy
    {
        public static void Play()
        {
            //Toca musica
        }
    }

    //E se adicionarmos agora um novo tipo, um podcast ou music video?

    //Erradissimo
    public class Spotfy
    {
        public static void PlayMusic()
        {
            //Toca musica
        }

        public static void PlayVideo()
        {
            //Toca video
        }

        public static void PlayPodcat()
        {
            //Toca podcast
        }
    }

    //O ideal seria receber uma interface como parametro pro método play

    public interface IFile
    {
        public void Play();
    }

    public class Spotfy
    {
        public static void Play(IFile file)
        {
            file.Play();
        }
    }

    //E ai os tipos de arquivos implementam a interface
    //public class VideoFile : IFile
}


