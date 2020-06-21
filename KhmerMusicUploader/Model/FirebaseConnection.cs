using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhmerMusicUploader.Model
{
    class FirebaseConnection
    {
        public static IFirebaseClient client;
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "hF7kuYo94d7bFG0V1hQGUafLEV95T2NbOTOCn8Vn",
            BasePath = "https://khmer-music-library.firebaseio.com/"
        };
    }
}
