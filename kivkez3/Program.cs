using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivkez3
{

    class TulHosszuException : Exception
    {
        private Video video;
        private string kivetelUzenet;
        
        public Video Video
        {
            get; set;
        }
        public string KivetelUzenet
        {
            get;set;
        }

        public TulHosszuException(string message, Video video)
        {
            this.Video = video;
            this.kivetelUzenet = message;
        }

    }
    class YoutubeUser
    {
        public string Nev { get; set; }
    }

    class Video
    {
        public string Cim { get; set; }
    }

    class YoutubeManager
    {

        public void videoToUser(YoutubeUser user, Video video)
        {
            if (video.Cim.Length > 5)
            {
                //hibát dobjuk
                throw new TulHosszuException("túl hosszú videó", video);
            }
            else
            {
                //minden oké
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            YoutubeManager ytm = new YoutubeManager();
            try
            {
                ytm.videoToUser(new YoutubeUser() { Nev = "Laci" }, new Video() { Cim = "ASD" });
            }
            catch(TulHosszuException e)
            {
                Console.WriteLine(e.KivetelUzenet+" "+e.Video.Cim);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba van! >> " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
