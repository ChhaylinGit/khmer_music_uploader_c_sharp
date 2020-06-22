using Firebase.Database;
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
        static string AuthSecret = "hF7kuYo94d7bFG0V1hQGUafLEV95T2NbOTOCn8Vn"; // your app secret

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = AuthSecret,
            BasePath = "https://khmer-music-library.firebaseio.com/"
        };
        public static FirebaseClient firebaseClient = new FirebaseClient(
              "https://khmer-music-library.firebaseio.com/",
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(AuthSecret)
              });
    }
}
