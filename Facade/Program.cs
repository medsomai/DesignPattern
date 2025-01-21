namespace FacadePatternExample
{
    // Sous-système : Module de lecture de fichiers
    public class FileReader
    {
        public void OpenFile(string fileName)
        {
            Console.WriteLine($"Opening file: {fileName}");
        }
    }

    // Sous-système : Module de décodage vidéo
    public class VideoDecoder
    {
        public void DecodeVideo()
        {
            Console.WriteLine("Decoding video stream...");
        }
    }

    // Sous-système : Module de décodage audio
    public class AudioDecoder
    {
        public void DecodeAudio()
        {
            Console.WriteLine("Decoding audio stream...");
        }
    }

    // Sous-système : Module de synchronisation
    public class Synchronizer
    {
        public void Synchronize()
        {
            Console.WriteLine("Synchronizing audio and video...");
        }
    }

    // Classe Façade
    public class MediaPlayerFacade
    {
        private readonly FileReader _fileReader = new();
        private readonly VideoDecoder _videoDecoder = new();
        private readonly AudioDecoder _audioDecoder = new();
        private readonly Synchronizer _synchronizer = new();

        public void Play(string fileName)
        {
            Console.WriteLine("Starting media playback...");
            _fileReader.OpenFile(fileName);
            _videoDecoder.DecodeVideo();
            _audioDecoder.DecodeAudio();
            _synchronizer.Synchronize();
            Console.WriteLine("Playback started successfully!");
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Utilisation de la Façade
            MediaPlayerFacade mediaPlayer = new();
            mediaPlayer.Play("example.mp4");
        }
    }
}
